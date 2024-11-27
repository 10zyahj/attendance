
Imports System.Net.Mail

Public Class Form13

    ' Constants for email address and password
    Dim FromEmailAddress As String = "kylaescudero04@gmail.com"
    Dim EmailPassword As String = "omgs vyxe zmyn yenh"

    ' Constructor to accept email address parameter
    Public Sub New(ByVal emailAddress As String)
        InitializeComponent()
        txtTo.Text = emailAddress
    End Sub
    Private Sub buttonSend_Click(sender As Object, e As EventArgs) Handles buttonSend.Click
        Try
            Dim mail As New MailMessage
            Dim AaronServer As New SmtpClient("smtp.gmail.com")

            ' Check for empty fields
            If String.IsNullOrEmpty(FromEmailAddress) OrElse String.IsNullOrEmpty(txtTo.Text) OrElse String.IsNullOrEmpty(txtSubject.Text) OrElse String.IsNullOrEmpty(txtBody.Text) Then
                MsgBox("Please fill in all fields.", MsgBoxStyle.Critical)
                Return
            End If

            mail.From = New MailAddress(FromEmailAddress)
            mail.To.Add(txtTo.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text

            AaronServer.Port = 587
            AaronServer.Credentials = New System.Net.NetworkCredential(FromEmailAddress, EmailPassword)
            AaronServer.EnableSsl = True
            AaronServer.Send(mail)
            MsgBox("Mail has been successfully sent!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub



    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Clear?", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            txtTo.Clear()
            txtSubject.Clear()
            txtBody.Clear()
        Else

        End If


    End Sub
End Class