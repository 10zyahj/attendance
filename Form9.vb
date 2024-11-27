Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form9
    Dim adapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        With Form8
            .TopLevel = False
            Form3.Panel4.Controls.Add(Form8)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
    End Sub

    Private Sub txtvsSearch_TextChanged(sender As Object, e As EventArgs) Handles txtvsSearch.TextChanged
        FilterStudentData(txtvsSearch.Text)
    End Sub

    Private Sub LoadStudentData()
        Dim conn As New MySqlConnection()
        conn.ConnectionString = "server=localhost;port=3306;database=attendancesystem;user=root;password=;"

        Try
            conn.Open()
            SQL = "SELECT student_name, student_number, year_level, course, section, home_address, contact_number, email_address, birthday, gender, status FROM students"

            Dim Command As New MySqlCommand(SQL, conn)
            adapter.SelectCommand = Command
            adapter.Fill(myData)
            gridData.DataSource = myData

            MsgBox("Connected")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FilterStudentData(searchTerm As String)
        Try
            Dim filterExpression As String = ""
            If Not String.IsNullOrEmpty(searchTerm) Then
                filterExpression = $"student_name LIKE '%{searchTerm}%' OR section LIKE '%{searchTerm}%' OR course LIKE '%{searchTerm}%' OR year_level = {searchTerm} OR email_address LIKE '%{searchTerm}%' OR status LIKE '%{searchTerm}'"
            End If

            Console.WriteLine("Filter Expression: " & filterExpression) ' Debug output

            myData.DefaultView.RowFilter = filterExpression

            ' Check if any rows are found after filtering
            If myData.DefaultView.Count = 0 Then
                MsgBox("No matching records found.")
            End If
        Catch ex As Exception
            ' Handle any errors silently without showing an error message
            Console.WriteLine("Error: " & ex.Message) ' Debug output
        End Try
    End Sub


End Class
