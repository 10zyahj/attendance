Imports MySql.Data.MySqlClient

Public Class Form7
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate the inputs (e.g., check for empty fields)
        If String.IsNullOrEmpty(comboClassNumber.Text) OrElse
       String.IsNullOrEmpty(comboCourse.Text) OrElse
       String.IsNullOrEmpty(comboSection.Text) OrElse
       String.IsNullOrEmpty(txtTeacherEmployeeID.Text) Then
            MessageBox.Show("Please fill in all the class details and specify the teacher.")
        Else
            ' Parse year to an integer
            Dim year As Integer
            If Int32.TryParse(comboYearLevel.SelectedItem.ToString(), year) Then
                ' Database connection setup
                Dim connectionString As String = "server=localhost;port=3306;database=attendancesystem;user=root;password=;"
                Try
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        ' Create the SQL command to insert class details into the classes table
                        Dim insertQuery As String = "INSERT INTO classes (class_number, year, course, section, teacher_id) " &
                                                "VALUES (@classNumber, @year, @course, @section, @teacherEmployeeID)"

                        Using cmd As New MySqlCommand(insertQuery, connection)
                            cmd.Parameters.AddWithValue("@classNumber", comboClassNumber.SelectedItem.ToString())
                            cmd.Parameters.AddWithValue("@year", comboYearLevel) ' Use the parsed year
                            cmd.Parameters.AddWithValue("@course", comboCourse.SelectedItem.ToString())
                            cmd.Parameters.AddWithValue("@section", comboSection.SelectedItem.ToString())
                            cmd.Parameters.AddWithValue("@teacherEmployeeID", txtTeacherEmployeeID.Text)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Class registration successful.")
                            Else
                                MessageBox.Show("Class registration failed.")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Please select a valid year.")
            End If
        End If
    End Sub





    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize your form as needed
    End Sub
End Class
