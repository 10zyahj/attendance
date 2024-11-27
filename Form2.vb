Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim connectionString As String = "server=localhost;port=3306;database=attendancesystem;username=root;password=;"
    Dim connection As MySqlConnection

    Public Sub New()
        InitializeComponent()
        ' Initialize the database connection
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim ename, enumber, econtact, eemail, eusername, epassword, econfirm As String
        Dim edepartment, esubject As String

        ename = txtEmployeeName.Text
        enumber = txtEmployeeNumber.Text
        econtact = txtContactNumber.Text
        eemail = txtEmailAddress.Text
        eusername = txtUsername.Text
        epassword = txtPassword.Text
        econfirm = txtConfirmPassword.Text

        edepartment = comboDepartment.SelectedItem.ToString()
        esubject = comboSubjectCode.SelectedItem.ToString()

        ' Validate input
        If String.IsNullOrEmpty(ename) Or String.IsNullOrEmpty(enumber) Or String.IsNullOrEmpty(econtact) Or String.IsNullOrEmpty(eemail) Or String.IsNullOrEmpty(eusername) Or String.IsNullOrEmpty(epassword) Or String.IsNullOrEmpty(econfirm) Or String.IsNullOrEmpty(edepartment) Or String.IsNullOrEmpty(esubject) Then
            MsgBox("All fields are required.")
        ElseIf econfirm <> epassword Then
            MsgBox("Password and Confirm Password do not match. Please try again.")
            ' ElseIf String.IsNullOrEmpty(edepartment) Or String.IsNullOrEmpty(esubject) Then
            MsgBox("Department and/or Subject are empty. Please make selections.")
        Else
            ' Insert data into the database
            Try
                connection.Open()
                Dim query As String = "INSERT INTO register (EmployeeName, EmployeeNumber, ContactNumber, EmailAddress, Username, Password, Department, SubjectCode) " &
                    "VALUES (@ename, @enumber, @econtact, @eemail, @eusername, @epassword, @edepartment, @esubject)"
                Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ename", ename)
                cmd.Parameters.AddWithValue("@enumber", enumber)
                cmd.Parameters.AddWithValue("@econtact", econtact)
                cmd.Parameters.AddWithValue("@eemail", eemail)
                cmd.Parameters.AddWithValue("@eusername", eusername)
                cmd.Parameters.AddWithValue("@epassword", epassword)
                cmd.Parameters.AddWithValue("@edepartment", edepartment)
                cmd.Parameters.AddWithValue("@esubject", esubject)
                cmd.ExecuteNonQuery()
                MsgBox("Registered Successfully!")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try

            ' Clear the input fields and reset selections
            txtEmployeeName.Text = ""
            txtEmployeeNumber.Text = ""
            txtContactNumber.Text = ""
            txtEmailAddress.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
            comboDepartment.SelectedIndex = -1
            comboSubjectCode.SelectedIndex = -1

            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
