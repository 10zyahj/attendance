Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form5
    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        With Form10
            .TopLevel = False
            Form3.Panel4.Controls.Add(Form10)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Display(datagrid As DataGridView)
        Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
            Try
                conn.Open()
                Dim query As String = "SELECT student_id, student_name, year_level, course, section, student_image FROM students"
                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Ensure columns are defined only once
                    If datagrid.Columns.Count = 0 Then
                        datagrid.Columns.Add("student_id", "Student ID")
                        datagrid.Columns.Add("student_name", "Student Name")
                        datagrid.Columns.Add("year_level", "Year Level")
                        datagrid.Columns.Add("course", "Course")
                        datagrid.Columns.Add("section", "Section")
                        Dim imageCol As New DataGridViewImageColumn()
                        imageCol.Name = "picture"
                        imageCol.HeaderText = "Picture"
                        datagrid.Columns.Add(imageCol)
                    End If

                    ' Adjust row height for images
                    datagrid.RowTemplate.Height = 100

                    ' Clear existing rows to prevent duplication
                    datagrid.Rows.Clear()

                    ' Populate rows with data
                    For Each row As DataRow In dt.Rows
                        Dim newRow As DataGridViewRow = datagrid.Rows(datagrid.Rows.Add())
                        newRow.Cells("student_id").Value = row("student_id")
                        newRow.Cells("student_name").Value = row("student_name")
                        newRow.Cells("year_level").Value = row("year_level")
                        newRow.Cells("course").Value = row("course")
                        newRow.Cells("section").Value = row("section")

                        ' Handle image column
                        If row("student_image") IsNot DBNull.Value Then
                            Dim imageBytes As Byte() = CType(row("student_image"), Byte())
                            Using ms As New MemoryStream(imageBytes)
                                Dim img As Image = Image.FromStream(ms)
                                newRow.Cells("picture").Value = img
                            End Using
                        End If
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub






    Private Sub Form5_Load_1(sender As Object, e As EventArgs)
        Display(datagrid)
    End Sub

    Dim connectionString As String = "server=localhost;port=3306;database=attendancesystem;username=root;password=;"
    Private connection As MySqlConnection
    Private dataAdapter As MySqlDataAdapter
    Private dataTable As DataTable

    ' Capture selected date from DateTimePicker and insert attendance records

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Get the selected date from the DateTimePicker control (day)
            Dim selectedDate As DateTime = day.Value

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                For Each row As DataGridViewRow In datagrid.Rows
                    ' Check if the row is not a header
                    If Not row.IsNewRow Then
                        ' Get the student number (from the DataGridView)
                        Dim studentNumber As String = CStr(row.Cells("student_number").Value)

                        ' Find the student_id using the student_number
                        Dim studentId As Integer = 0
                        Dim findStudentIdSql As String = "SELECT student_id FROM students WHERE student_number = @student_number"
                        Using findStudentCmd As New MySqlCommand(findStudentIdSql, connection)
                            findStudentCmd.Parameters.AddWithValue("@student_number", studentNumber)
                            Dim result As Object = findStudentCmd.ExecuteScalar()

                            If result IsNot Nothing Then
                                studentId = Convert.ToInt32(result)
                            Else
                                ' Handle case where student_number does not exist
                                MessageBox.Show("Student with number " & studentNumber & " not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Continue For ' Skip this row if student is not found
                            End If
                        End Using

                        ' Get the selected status from the ComboBox column
                        Dim statusCell As DataGridViewComboBoxCell = TryCast(row.Cells("student_status"), DataGridViewComboBoxCell)
                        Dim selectedStatus As String = If(statusCell IsNot Nothing, CStr(statusCell.Value), "")

                        ' Insert into the attendance_records table
                        Dim sql As String = "INSERT INTO attendance (student_id, attendance_date, attendance_status) " &
                                    "VALUES (@student_id, @attendance_date, @attendance_status)"
                        Using command As New MySqlCommand(sql, connection)
                            command.Parameters.AddWithValue("@student_id", studentId)
                            command.Parameters.AddWithValue("@attendance_date", selectedDate) ' Use the selected date from DateTimePicker
                            command.Parameters.AddWithValue("@attendance_status", selectedStatus)
                            command.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Attendance records saved successfully.")
                Form10.RefreshAttendance()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each row As DataGridViewRow In datagrid.Rows
            If Not row.IsNewRow Then
                row.Cells("col3").Value = String.Empty
            End If
        Next
    End Sub

    ' Form Load event
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New MySqlConnection()
        con.ConnectionString = "server=localhost;port=3306;database=attendancesystem;username=root;password=;"
        LoadDataGridView()
    End Sub

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    ' Load student data into DataGridView
    Private Sub LoadDataGridView()
        ' Clear existing rows and columns to avoid duplication
        datagrid.Rows.Clear()
        If datagrid.Columns.Count = 0 Then
            datagrid.Columns.Clear()

            ' Define necessary columns
            datagrid.Columns.Add("student_number", "Student Number")
            datagrid.Columns.Add("student_name", "Student Name")
            datagrid.Columns.Add("year_level", "Year Level")
            datagrid.Columns.Add("course", "Course")
            datagrid.Columns.Add("section", "Section")

            ' Add an image column for student images
            Dim imageCol As New DataGridViewImageColumn()
            imageCol.Name = "student_image"
            imageCol.HeaderText = "Student Image"
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom ' Adjust to fit the cell
            datagrid.Columns.Add(imageCol)

            ' Add a ComboBox column for attendance status
            Dim statusCol As New DataGridViewComboBoxColumn()
            statusCol.Name = "student_status"
            statusCol.HeaderText = "Status"
            statusCol.Items.AddRange("Present", "Late", "Absent") ' Add status options
            datagrid.Columns.Add(statusCol)
        End If

        ' Adjust row height to fit the images
        datagrid.RowTemplate.Height = 100

        ' Open the database connection
        con.Open()
        cmd = New MySqlCommand("SELECT student_number, student_name, year_level, course, section, student_image FROM students", con)
        dr = cmd.ExecuteReader()

        ' Add rows to the DataGridView
        While dr.Read()
            Dim rowIndex As Integer = datagrid.Rows.Add()
            Dim row As DataGridViewRow = datagrid.Rows(rowIndex)

            ' Populate text columns
            row.Cells("student_number").Value = dr("student_number").ToString()
            row.Cells("student_name").Value = dr("student_name").ToString()
            row.Cells("year_level").Value = dr("year_level").ToString()
            row.Cells("course").Value = dr("course").ToString()
            row.Cells("section").Value = dr("section").ToString()

            ' Handle student_image column
            Try
                Dim imageBytes As Byte() = CType(dr("student_image"), Byte())
                If imageBytes.Length > 0 Then
                    Using ms As New MemoryStream(imageBytes)
                        Dim img As Image = Image.FromStream(ms)
                        row.Cells("student_image").Value = img
                    End Using
                Else
                    row.Cells("student_image").Value = Nothing
                End If
            Catch ex As Exception
                row.Cells("student_image").Value = Nothing
                Debug.WriteLine("Error loading image: " & ex.Message)
            End Try
        End While

        ' Close the reader and connection
        dr.Close()
        con.Close()
    End Sub

    ' In Form5
    Public Sub RefreshDataGrid()
        ' Call the DisplayData method that reloads the data into the DataGridView
        LoadDataGridView()
    End Sub


    ' ComboBox change events
    Private Sub comboYear_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadDataGridView()
    End Sub

    Private Sub comboCourse_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadDataGridView()
    End Sub

    Private Sub comboSection_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadDataGridView()
    End Sub

    ' DataGridView click event
    Private Sub datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid.CellContentClick

    End Sub

    ' DatePicker value change event (if needed)
    Private Sub day_ValueChanged(sender As Object, e As EventArgs) Handles day.ValueChanged

    End Sub

    Private Sub lblPresent_Click(sender As Object, e As EventArgs) Handles lblPresent.Click

    End Sub

    Private Sub lblAbsent_Click(sender As Object, e As EventArgs) Handles lblAbsent.Click

    End Sub

    Private Sub lblLate_Click(sender As Object, e As EventArgs) Handles lblLate.Click

    End Sub

    Private Sub lblNumStud_Click(sender As Object, e As EventArgs) Handles lblNumStud.Click

    End Sub
End Class
