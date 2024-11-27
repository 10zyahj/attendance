Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO


Public Class Form11

    Dim myData As New DataTable

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData(dataGrid)
    End Sub

    Private Sub DisplayData(dataGrid As DataGridView)
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()
                Dim query As String = "SELECT student_name, student_number, home_address, contact_number, email_address, birthday, gender, year_level, course, section, status FROM students"
                Using da As New MySqlDataAdapter(query, conn)
                    myData.Clear()
                    da.Fill(myData)

                    ' Bind the DataTable to the DataGridView
                    dataGrid.DataSource = myData
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form3.Show()
        Me.Hide()
    End Sub


    Public Sub Save()
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO `students`(`student_name`, `student_number`, `home_address`, `contact_number`, `email_address`, `birthday`, `gender`, `year_level`, `course`, `section`, `status`) VALUES (@student_name, @student_number, @home_address, @contact_number, @email_address, @birthday, @gender, @year_level, @course, @section, @status)", conn)
                    ' Add parameters for the values to be inserted
                    cmd.Parameters.AddWithValue("@student_name", txtSName.Text)
                    cmd.Parameters.AddWithValue("@student_number", txtSNumber.Text)
                    cmd.Parameters.AddWithValue("@home_address", txtHomeAddress.Text)
                    cmd.Parameters.AddWithValue("@contact_number", txtConNumber.Text)
                    cmd.Parameters.AddWithValue("@email_address", txtEmailAddress.Text)

                    ' Parse the date from dateBday (assuming dateBday is a DateTimePicker control)
                    cmd.Parameters.AddWithValue("@birthday", dateBday.Value)

                    cmd.Parameters.AddWithValue("@gender", comboG.Text)
                    cmd.Parameters.AddWithValue("@year_level", comboYearLevel.Text)
                    cmd.Parameters.AddWithValue("@course", comboCourses.Text)
                    cmd.Parameters.AddWithValue("@section", comboSections.Text)
                    cmd.Parameters.AddWithValue("@status", comboStat.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' After clicking OK, refresh the DataGridView to see the latest data
                DisplayData(dataGrid)
                Form5.RefreshDataGrid()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Save()
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        txtSName.Clear()
        txtSNumber.Clear()
        txtHomeAddress.Clear()
        txtConNumber.Clear()
        txtEmailAddress.Clear()
        dateBday.Value = Date.Now
        comboG.SelectedIndex = -1
        comboYearLevel.SelectedIndex = -1
        comboCourses.SelectedIndex = -1
        comboSections.SelectedIndex = -1
        comboStat.SelectedIndex = -1
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        ' Check if a row is selected
        If dataGrid.SelectedRows.Count > 0 Then
            ' Get the selected student_number
            Dim studentNumber As String = dataGrid.SelectedRows(0).Cells("col2").Value.ToString()

            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete student with Student Number: {studentNumber}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If user confirms, proceed with deletion
                DeleteStudent(studentNumber)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        DisplayData(dataGrid)
        Form5.RefreshDataGrid()
    End Sub


    Private Sub DeleteStudent(studentNumber As String)
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()

                Using cmd As New MySqlCommand("DELETE FROM students WHERE student_number = @student_number", conn)
                    cmd.Parameters.AddWithValue("@student_number", studentNumber)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show($"Student {studentNumber} has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearForm()
        ' Clear the form controls
        txtSName.Clear()
        txtSNumber.Clear()
        txtHomeAddress.Clear()
        txtConNumber.Clear()
        txtEmailAddress.Clear()
        dateBday.Value = Date.Now
        comboG.SelectedIndex = -1
        comboYearLevel.SelectedIndex = -1
        comboCourses.SelectedIndex = -1
        comboSections.SelectedIndex = -1
        comboStat.SelectedIndex = -1


        ' Enable the Save button after deletion
        buttonSave.Enabled = True
    End Sub

    Private Sub dataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGrid.CellMouseClick
        If dataGrid.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataGrid.SelectedRows(0)

            txtSName.Text = selectedRow.Cells("col1").Value.ToString()
            txtSNumber.Text = selectedRow.Cells("col2").Value.ToString()
            txtHomeAddress.Text = selectedRow.Cells("col6").Value.ToString()
            txtConNumber.Text = selectedRow.Cells("col7").Value.ToString()
            txtEmailAddress.Text = selectedRow.Cells("col11").Value.ToString()

            ' Validate and parse the date
            Dim dateValue As String = selectedRow.Cells("col8").Value.ToString()
            If Not String.IsNullOrEmpty(dateValue) AndAlso DateTime.TryParse(dateValue, Nothing) Then
                dateBday.Value = DateTime.Parse(dateValue)
            Else
                dateBday.Value = DateTime.Now ' Or set a default date value
            End If

            comboG.Text = selectedRow.Cells("col9").Value.ToString()
            comboYearLevel.Text = selectedRow.Cells("col3").Value.ToString()
            comboCourses.Text = selectedRow.Cells("col4").Value.ToString()
            comboSections.Text = selectedRow.Cells("col5").Value.ToString()
            comboStat.Text = selectedRow.Cells("col10").Value.ToString()

        End If
    End Sub




    Private Function GetImagePathFromDatabase(studentNumber As String) As String
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()

                ' Assuming your image path is stored in a column named "student_image" in the "students" table
                Dim query As String = "SELECT student_image FROM students WHERE student_number = @student_number"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@student_number", studentNumber)

                    Dim result As Object = cmd.ExecuteScalar()

                    ' Check if the result is not DBNull.Value and not empty
                    If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                        ' Return the image path
                        Return result.ToString()
                    Else
                        ' Return an empty string if the image path is not found
                        Return String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception (e.g., log or display an error message)
            Console.WriteLine("Error: " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()

                Using cmd As New MySqlCommand("UPDATE `students` SET `student_name` = @student_name, `home_address` = @home_address, `contact_number` = @contact_number, `email_address` = @email_address, `birthday` = @birthday, `gender` = @gender, `year_level` = @year_level, `course` = @course, `section` = @section, `status` = @status, `student_image` = @student_image WHERE `student_number` = @student_number", conn)
                    ' Add parameters for the values to be updated
                    cmd.Parameters.AddWithValue("@student_name", txtSName.Text)
                    cmd.Parameters.AddWithValue("@home_address", txtHomeAddress.Text)
                    cmd.Parameters.AddWithValue("@contact_number", txtConNumber.Text)
                    cmd.Parameters.AddWithValue("@email_address", txtEmailAddress.Text)
                    cmd.Parameters.AddWithValue("@birthday", dateBday.Value)
                    cmd.Parameters.AddWithValue("@gender", comboG.Text)
                    cmd.Parameters.AddWithValue("@year_level", comboYearLevel.Text)
                    cmd.Parameters.AddWithValue("@course", comboCourses.Text)
                    cmd.Parameters.AddWithValue("@section", comboSections.Text)
                    cmd.Parameters.AddWithValue("@status", comboStat.Text)

                    ' Add student_number to identify the student record to update
                    cmd.Parameters.AddWithValue("@student_number", txtSNumber.Text)

                    ' Check if a new image is loaded in the PictureBox
                    If studpicture.Image IsNot Nothing Then
                        ' Convert the image in the PictureBox to a byte array
                        Using ms As New MemoryStream()
                            studpicture.Image.Save(ms, studpicture.Image.RawFormat)
                            Dim imageBytes As Byte() = ms.ToArray()
                            cmd.Parameters.AddWithValue("@student_image", imageBytes)
                        End Using
                    Else
                        ' Handle case when no image is provided (e.g., set the column to NULL or leave it as is)
                        cmd.Parameters.AddWithValue("@student_image", DBNull.Value)
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data and image have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView to display updated data
                DisplayData(dataGrid)
                Form5.RefreshDataGrid()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Dim emailForm As New Form13(txtEmailAddress.Text)
        emailForm.Show()
    End Sub

    Private Sub comboManageStudentClassNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboManageStudentClassNum.SelectedIndexChanged
        ' Add code for handling class number selection if needed
    End Sub

    Private Sub txtManageStudentSearch_TextChanged(sender As Object, e As EventArgs) Handles txtManageStudentSearch.TextChanged
        FilterStudentData(txtManageStudentSearch.Text)
    End Sub

    Private Sub FilterStudentData(searchTerm As String)
        Try
            Dim filterExpression As String = ""

            If Not String.IsNullOrEmpty(searchTerm) Then
                ' Check if searchTerm is a valid integer
                Dim isNumeric As Boolean = Integer.TryParse(searchTerm, Nothing)

                If isNumeric Then
                    ' If it's an integer, filter using '=' (convert numeric search term to string for comparison)
                    filterExpression = $"student_number LIKE '{searchTerm}%' OR " &
                                   $"year_level = {searchTerm} OR " &
                                   $"section LIKE '%{searchTerm}%' OR " &
                                   $"status LIKE '%{searchTerm}%' OR " &
                                   $"contact_number LIKE '{searchTerm}%' OR " &
                                   $"Convert(birthday, 'System.String') LIKE '%{searchTerm}%' OR " &
                                   $"gender LIKE '%{searchTerm}%'"
                Else
                    ' If it's not an integer, filter using 'LIKE'
                    filterExpression = $"student_name LIKE '%{searchTerm}%' OR " &
                                   $"course LIKE '%{searchTerm}%' OR " &
                                   $"email_address LIKE '%{searchTerm}%' OR " &
                                   $"home_address LIKE '%{searchTerm}%' OR " &
                                   $"section LIKE '%{searchTerm}%' OR " &
                                   $"status LIKE '%{searchTerm}%' OR " &
                                   $"contact_number LIKE '%{searchTerm}%' OR " &
                                   $"Convert(birthday, 'System.String') LIKE '%{searchTerm}%' OR " &
                                   $"gender LIKE '%{searchTerm}%'"
                End If
            End If

            Console.WriteLine("Filter Expression: " & filterExpression) ' Debug output

            ' Check if any rows are found after filtering
            If myData IsNot Nothing AndAlso myData.Rows.Count > 0 Then
                myData.DefaultView.RowFilter = filterExpression

                If myData.DefaultView.Count = 0 Then
                    MsgBox("No matching records found.")
                End If
            End If
        Catch ex As FormatException
            ' Handle the FormatException (related to incomplete numeric parsing) silently without showing an error message
        Catch ex As Exception
            ' Handle other exceptions and show an error message
            Console.WriteLine("Error: " & ex.Message) ' Debug output
        End Try
    End Sub

    Private Sub btnUploadpicture_Click(sender As Object, e As EventArgs) Handles btnUploadpicture.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            openFileDialog.Title = "Select an Image File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim imagePath As String = openFileDialog.FileName

                ' Display the selected image in the PictureBox
                studpicture.Image = Image.FromFile(imagePath)

                ' Convert the image to a byte array
                Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

                ' Update the database with the image
                UpdateStudentImage(txtSNumber.Text, imageBytes)
            End If
        Catch ex As Exception
            MessageBox.Show("Error uploading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateStudentImage(studentNumber As String, imageBytes As Byte())
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()

                Using cmd As New MySqlCommand("UPDATE students SET student_image = @student_image WHERE student_number = @student_number", conn)
                    cmd.Parameters.AddWithValue("@student_image", imageBytes)
                    cmd.Parameters.AddWithValue("@student_number", studentNumber)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Image has been uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating student image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub studpicture_Click(sender As Object, e As EventArgs) Handles studpicture.Click

    End Sub
End Class
