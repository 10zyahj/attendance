Imports MySql.Data.MySqlClient

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        With Form9
            .TopLevel = False
            Form3.Panel4.Controls.Add(Form9)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentName.Text = ""
        txtStudentNum.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        dateBirthday.Value = DateTime.Now

        comboGender.SelectedIndex = -1
        comboYear.SelectedIndex = -1
        comboCourse.SelectedIndex = -1
        comboSection.SelectedIndex = -1
        comboStatus.SelectedIndex = -1

        studpic.Image = Nothing
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim connectionString As String = "server=localhost;port=3306;database=attendancesystem;username=root;password=;"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand("INSERT INTO students (student_name, student_number, home_address, contact_number, email_address, birthday, gender, year_level, course, section, status) VALUES (@studentName, @studentNumber, @homeAddress, @contactNumber, @emailAddress, @birthday, @gender, @yearLevel, @course, @section, @status)", connection)
                    cmd.Parameters.AddWithValue("@studentName", txtStudentName.Text)
                    cmd.Parameters.AddWithValue("@studentNumber", txtStudentNum.Text)
                    cmd.Parameters.AddWithValue("@homeAddress", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@contactNumber", txtContact.Text)
                    cmd.Parameters.AddWithValue("@emailAddress", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@birthday", dateBirthday.Value)
                    cmd.Parameters.AddWithValue("@gender", comboGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@yearLevel", comboYear.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@course", comboCourse.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@section", comboSection.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data has been saved successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class