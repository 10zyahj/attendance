Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form12

    Dim conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()

            Dim sql As String = "INSERT INTO classes ( CYear, CSection, CCourse, class_number) " &
                               "VALUES ( @year, @section, @course, @class_number)"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@year", comboYear.Text)
                cmd.Parameters.AddWithValue("@section", comboSection.Text)
                cmd.Parameters.AddWithValue("@course", comboCourse.Text)
                cmd.Parameters.AddWithValue("@class_number", comboClassNum.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DisplayData(dataGridClass)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        comboYear.SelectedIndex = -1
        comboSection.SelectedIndex = -1
        comboCourse.SelectedIndex = -1
        comboClassNum.SelectedIndex = -1
        txtEmpID.Clear()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData(dataGridClass)
    End Sub
    Private Sub DisplayData(dataGridClass As DataGridView)
        Dim myData As New DataTable

        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()
                Dim query As String = "SELECT class_number, CYear, CCourse, CSection FROM classes"

                Using da As New MySqlDataAdapter(query, conn)
                    myData.Clear()
                    da.Fill(myData)
                    dataGridClass.DataSource = myData
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dataGridClass_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridClass.CellMouseClick
        If dataGridClass.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dataGridClass.SelectedRows(0)

            comboYear.Text = selectedRow.Cells("col2").Value.ToString()
            comboSection.Text = selectedRow.Cells("col4").Value.ToString()
            comboCourse.Text = selectedRow.Cells("col3").Value.ToString()
            comboClassNum.Text = selectedRow.Cells("col1").Value.ToString()


        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If dataGridClass.SelectedRows.Count > 0 Then
            ' Get the selected student_number
            Dim classNumber As String = dataGridClass.SelectedRows(0).Cells("col1").Value.ToString()

            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the class: {classNumber}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' If user confirms, proceed with deletion
                DeleteClass(classNumber)
                DisplayData(dataGridClass)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteClass(classNumber As String)
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;database=attendancesystem;username=root;password=;")
                conn.Open()

                Using cmd As New MySqlCommand("DELETE FROM classes WHERE class_number = @class_number", conn)
                    cmd.Parameters.AddWithValue("@class_number", classNumber)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show($"A class {classNumber} has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class