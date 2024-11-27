Public Class Form3


    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        With Form5
            .TopLevel = False
            Panel4.Controls.Add(Form5)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        With Form4
            .TopLevel = False
            Panel4.Controls.Add(Form4)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click

        With Form6
            .TopLevel = False
            Panel4.Controls.Add(Form6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        Else

        End If

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btnRegisterClass_Click(sender As Object, e As EventArgs)
        With Form12
            .TopLevel = False
            Panel4.Controls.Add(Form12)
            .BringToFront
            .Show
        End With
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class