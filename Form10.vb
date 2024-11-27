Imports MySql.Data.MySqlClient

Public Class Form10
    ' Function to display all attendance records with dynamic date columns
    Private Sub DisplayAttendance()
        Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
            Try
                conn.Open()

                ' Step 1: Get all distinct attendance dates from the attendance_records table
                Dim dateQuery As String = "SELECT DISTINCT attendance_date FROM attendance ORDER BY attendance_date"
                Using dateCmd As New MySqlCommand(dateQuery, conn)
                    Using dateDa As New MySqlDataAdapter(dateCmd)
                        Dim dateDt As New DataTable()
                        dateDa.Fill(dateDt)

                        ' Step 2: Prepare the DataGridView with dynamic columns for each date
                        DataGridView2.Columns.Clear()

                        ' Add a column for student name
                        DataGridView2.Columns.Add("student_name", "Student Name")

                        ' Add a column for each attendance date
                        For Each dateRow As DataRow In dateDt.Rows
                            Dim dateColumn As String = dateRow("attendance_date").ToString()
                            ' Ensure each date column is unique
                            If Not DataGridView2.Columns.Contains(dateColumn) Then
                                DataGridView2.Columns.Add(dateColumn, dateColumn)
                            End If
                        Next

                        ' Step 3: Get all attendance records for each student (without duplicating rows)
                        Dim attendanceQuery As String = "SELECT s.student_id, s.student_name, a.attendance_date, a.attendance_status " &
                                                        "FROM attendance a " &
                                                        "JOIN students s ON a.student_id = s.student_id"
                        Using attendanceCmd As New MySqlCommand(attendanceQuery, conn)
                            Using attendanceDa As New MySqlDataAdapter(attendanceCmd)
                                Dim attendanceDt As New DataTable()
                                attendanceDa.Fill(attendanceDt)

                                ' Step 4: Add attendance data to DataGridView
                                ' Create a dictionary to keep track of rows by student name
                                Dim studentRows As New Dictionary(Of String, DataGridViewRow)()

                                For Each attendanceRow As DataRow In attendanceDt.Rows
                                    Dim studentName As String = attendanceRow("student_name").ToString()
                                    Dim attendanceDate As String = attendanceRow("attendance_date").ToString()
                                    Dim attendanceStatus As String = If(IsDBNull(attendanceRow("attendance_status")), "Absent", attendanceRow("attendance_status").ToString())

                                    ' Check if the student already has a row in the DataGridView
                                    Dim existingRow As DataGridViewRow = Nothing
                                    If studentRows.ContainsKey(studentName) Then
                                        existingRow = studentRows(studentName)
                                    End If

                                    ' If the student row doesn't exist, create a new row
                                    If existingRow Is Nothing Then
                                        existingRow = New DataGridViewRow()
                                        existingRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = studentName})
                                        studentRows.Add(studentName, existingRow)
                                        DataGridView2.Rows.Add(existingRow)
                                    End If

                                    ' Add the attendance status to the appropriate date column
                                    For Each dateRow As DataRow In dateDt.Rows
                                        Dim dateColumn As String = dateRow("attendance_date").ToString()

                                        If attendanceDate = dateColumn Then
                                            existingRow.Cells(dateColumn).Value = attendanceStatus
                                            Exit For
                                        End If
                                    Next
                                Next
                            End Using
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Form Load event to call the DisplayAttendance function
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAttendance()
    End Sub

    Public Sub RefreshAttendance()
        ' Clear existing columns and rows
        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()

        ' Re-display the updated attendance
        DisplayAttendance()
    End Sub

    Private Sub btnCheckAttendance_Click(sender As Object, e As EventArgs) Handles btnCheckAttendance.Click
        ' Show Form5 inside Panel4
        With Form5
            .TopLevel = False
            Form3.Panel4.Controls.Add(Form5)
            .BringToFront()
            .Show()
        End With

        ' Close Form10
        Me.Close()
    End Sub

End Class
