Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Define the connection string with your database information
    Dim connectionString As String = "Server=localhost;Database=attendancesystem;username=root;Password="
    Dim connection As MySqlConnection


    Public Sub New()
        InitializeComponent()
        ' Initialize the database connection
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub RegisterHere_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterHere.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username, password As String
        username = txtUsername.Text
        password = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Please input your username or password.")
        Else
            ' Verify user credentials against the database
            Try
                connection.Open()
                Dim query As String = "SELECT EmployeeName FROM register WHERE Username = @username AND Password = @password"
                Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    MsgBox("Login Successful!")
                    ' Pass the username to Form4
                    Form4.username = username

                    Form3.Show()
                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                Else
                    MsgBox("Invalid username or password. Please try again.")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub checkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowPassword.CheckedChanged
        If checkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False ' Show the password as plain text
        Else
            txtPassword.UseSystemPasswordChar = True ' Hide the password as asterisks (password mode)
        End If
    End Sub


End Class
