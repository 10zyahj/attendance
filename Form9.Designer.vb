<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnRegisterStudent = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        gridData = New DataGridView()
        col1 = New DataGridViewTextBoxColumn()
        col2 = New DataGridViewTextBoxColumn()
        col3 = New DataGridViewTextBoxColumn()
        col4 = New DataGridViewTextBoxColumn()
        col5 = New DataGridViewTextBoxColumn()
        col6 = New DataGridViewTextBoxColumn()
        Col7 = New DataGridViewTextBoxColumn()
        col8 = New DataGridViewTextBoxColumn()
        col9 = New DataGridViewTextBoxColumn()
        col10 = New DataGridViewTextBoxColumn()
        txtStudNum = New TextBox()
        Label3 = New Label()
        txtStudName = New TextBox()
        Label4 = New Label()
        comboSection = New ComboBox()
        Label12 = New Label()
        comboCourse = New ComboBox()
        Label11 = New Label()
        comboYear = New ComboBox()
        Label10 = New Label()
        comboStatus = New ComboBox()
        Label9 = New Label()
        pictureEmployee = New PictureBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        txtvsSearch = New TextBox()
        Label5 = New Label()
        btnSendEmail = New Button()
        CType(gridData, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRegisterStudent
        ' 
        btnRegisterStudent.BackColor = Color.Tomato
        btnRegisterStudent.FlatAppearance.BorderSize = 0
        btnRegisterStudent.FlatStyle = FlatStyle.Flat
        btnRegisterStudent.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnRegisterStudent.ForeColor = Color.White
        btnRegisterStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnRegisterStudent.Location = New Point(777, 12)
        btnRegisterStudent.Margin = New Padding(4, 3, 4, 3)
        btnRegisterStudent.Name = "btnRegisterStudent"
        btnRegisterStudent.Size = New Size(163, 49)
        btnRegisterStudent.TabIndex = 12
        btnRegisterStudent.Text = "Register Student"
        btnRegisterStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRegisterStudent.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(326, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 42)
        Label1.TabIndex = 49
        Label1.Text = "VIEW STUDENT"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.DarkRed
        Button2.Location = New Point(185, 553)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 38)
        Button2.TabIndex = 7
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Brown
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(53, 553)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 38)
        Button3.TabIndex = 6
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' gridData
        ' 
        gridData.AllowUserToOrderColumns = True
        gridData.BackgroundColor = Color.White
        gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridData.Columns.AddRange(New DataGridViewColumn() {col1, col2, col3, col4, col5, col6, Col7, col8, col9, col10})
        gridData.Location = New Point(327, 172)
        gridData.Name = "gridData"
        gridData.RowHeadersWidth = 51
        gridData.RowTemplate.Height = 29
        gridData.Size = New Size(570, 482)
        gridData.TabIndex = 11
        ' 
        ' col1
        ' 
        col1.DataPropertyName = "student_name"
        col1.HeaderText = "Student Name"
        col1.MinimumWidth = 6
        col1.Name = "col1"
        col1.Width = 125
        ' 
        ' col2
        ' 
        col2.DataPropertyName = "student_number"
        col2.HeaderText = "Student Number"
        col2.MinimumWidth = 6
        col2.Name = "col2"
        col2.Width = 125
        ' 
        ' col3
        ' 
        col3.DataPropertyName = "year_level"
        col3.HeaderText = "Year Level"
        col3.MinimumWidth = 6
        col3.Name = "col3"
        col3.Width = 125
        ' 
        ' col4
        ' 
        col4.DataPropertyName = "course"
        col4.HeaderText = "Course"
        col4.MinimumWidth = 6
        col4.Name = "col4"
        col4.Width = 125
        ' 
        ' col5
        ' 
        col5.DataPropertyName = "section"
        col5.HeaderText = "Section"
        col5.MinimumWidth = 6
        col5.Name = "col5"
        col5.Width = 125
        ' 
        ' col6
        ' 
        col6.DataPropertyName = "home_address"
        col6.HeaderText = "Home Address"
        col6.MinimumWidth = 6
        col6.Name = "col6"
        col6.Width = 125
        ' 
        ' Col7
        ' 
        Col7.DataPropertyName = "contact_number"
        Col7.HeaderText = "Contact Number"
        Col7.MinimumWidth = 6
        Col7.Name = "Col7"
        Col7.Width = 125
        ' 
        ' col8
        ' 
        col8.DataPropertyName = "birthday"
        col8.HeaderText = "Birthday"
        col8.MinimumWidth = 6
        col8.Name = "col8"
        col8.Width = 125
        ' 
        ' col9
        ' 
        col9.DataPropertyName = "gender"
        col9.HeaderText = "Gender"
        col9.MinimumWidth = 6
        col9.Name = "col9"
        col9.Width = 125
        ' 
        ' col10
        ' 
        col10.DataPropertyName = "status"
        col10.HeaderText = "Status"
        col10.MinimumWidth = 6
        col10.Name = "col10"
        col10.Width = 125
        ' 
        ' txtStudNum
        ' 
        txtStudNum.BorderStyle = BorderStyle.FixedSingle
        txtStudNum.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudNum.Location = New Point(52, 335)
        txtStudNum.Margin = New Padding(4, 3, 4, 3)
        txtStudNum.Multiline = True
        txtStudNum.Name = "txtStudNum"
        txtStudNum.Size = New Size(247, 29)
        txtStudNum.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(52, 232)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 55
        Label3.Text = "Student Name"
        ' 
        ' txtStudName
        ' 
        txtStudName.BorderStyle = BorderStyle.FixedSingle
        txtStudName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudName.Location = New Point(52, 259)
        txtStudName.Margin = New Padding(4, 3, 4, 3)
        txtStudName.Multiline = True
        txtStudName.Name = "txtStudName"
        txtStudName.Size = New Size(247, 29)
        txtStudName.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(52, 308)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 20)
        Label4.TabIndex = 57
        Label4.Text = "Student Number"
        ' 
        ' comboSection
        ' 
        comboSection.FormattingEnabled = True
        comboSection.Location = New Point(55, 488)
        comboSection.Margin = New Padding(4, 3, 4, 3)
        comboSection.Name = "comboSection"
        comboSection.Size = New Size(94, 28)
        comboSection.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(55, 464)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 20)
        Label12.TabIndex = 63
        Label12.Text = "Section"
        ' 
        ' comboCourse
        ' 
        comboCourse.FormattingEnabled = True
        comboCourse.Location = New Point(171, 411)
        comboCourse.Margin = New Padding(4, 3, 4, 3)
        comboCourse.Name = "comboCourse"
        comboCourse.Size = New Size(128, 28)
        comboCourse.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(171, 386)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 61
        Label11.Text = "Course"
        ' 
        ' comboYear
        ' 
        comboYear.FormattingEnabled = True
        comboYear.Location = New Point(55, 411)
        comboYear.Margin = New Padding(4, 3, 4, 3)
        comboYear.Name = "comboYear"
        comboYear.Size = New Size(94, 28)
        comboYear.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(55, 386)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 59
        Label10.Text = "Year Level"
        ' 
        ' comboStatus
        ' 
        comboStatus.FormattingEnabled = True
        comboStatus.Location = New Point(171, 488)
        comboStatus.Margin = New Padding(4, 3, 4, 3)
        comboStatus.Name = "comboStatus"
        comboStatus.Size = New Size(128, 28)
        comboStatus.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(171, 464)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 65
        Label9.Text = "Status"
        ' 
        ' pictureEmployee
        ' 
        pictureEmployee.BackColor = Color.Transparent
        pictureEmployee.Image = My.Resources.Resources.icon
        pictureEmployee.Location = New Point(81, 76)
        pictureEmployee.Name = "pictureEmployee"
        pictureEmployee.Size = New Size(186, 127)
        pictureEmployee.SizeMode = PictureBoxSizeMode.Zoom
        pictureEmployee.TabIndex = 67
        pictureEmployee.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(750, 128)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(147, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(666, 132)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 68
        Label2.Text = "Class No."
        ' 
        ' txtvsSearch
        ' 
        txtvsSearch.BorderStyle = BorderStyle.FixedSingle
        txtvsSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtvsSearch.Location = New Point(396, 127)
        txtvsSearch.Margin = New Padding(4, 3, 4, 3)
        txtvsSearch.Multiline = True
        txtvsSearch.Name = "txtvsSearch"
        txtvsSearch.Size = New Size(217, 28)
        txtvsSearch.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(326, 133)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 71
        Label5.Text = "Search"
        ' 
        ' btnSendEmail
        ' 
        btnSendEmail.FlatAppearance.BorderSize = 0
        btnSendEmail.FlatStyle = FlatStyle.Flat
        btnSendEmail.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnSendEmail.ForeColor = Color.White
        btnSendEmail.Image = My.Resources.Resources.send__1_
        btnSendEmail.ImageAlign = ContentAlignment.MiddleLeft
        btnSendEmail.Location = New Point(55, 606)
        btnSendEmail.Name = "btnSendEmail"
        btnSendEmail.Padding = New Padding(30, 0, 0, 0)
        btnSendEmail.Size = New Size(244, 48)
        btnSendEmail.TabIndex = 8
        btnSendEmail.Text = "   Send Email"
        btnSendEmail.TextAlign = ContentAlignment.MiddleLeft
        btnSendEmail.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSendEmail.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(953, 728)
        Controls.Add(btnSendEmail)
        Controls.Add(Label5)
        Controls.Add(txtvsSearch)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(pictureEmployee)
        Controls.Add(comboStatus)
        Controls.Add(Label9)
        Controls.Add(comboSection)
        Controls.Add(Label12)
        Controls.Add(comboCourse)
        Controls.Add(Label11)
        Controls.Add(comboYear)
        Controls.Add(Label10)
        Controls.Add(txtStudNum)
        Controls.Add(Label3)
        Controls.Add(txtStudName)
        Controls.Add(Label4)
        Controls.Add(gridData)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(btnRegisterStudent)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form9"
        Text = "Form9"
        CType(gridData, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegisterStudent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gridData As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend Protected WithEvents Label4 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend Protected WithEvents Label12 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend Protected WithEvents Label11 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend Protected WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend Protected WithEvents Label9 As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents pictureEmployee As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend Protected WithEvents Label2 As Label
    Friend WithEvents txtvsSearch As TextBox
    Friend Protected WithEvents Label5 As Label
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents txtStudNum As TextBox
    Friend WithEvents txtStudName As TextBox
    Friend WithEvents comboSection As ComboBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents comboYear As ComboBox
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
    Friend WithEvents col4 As DataGridViewTextBoxColumn
    Friend WithEvents col5 As DataGridViewTextBoxColumn
    Friend WithEvents col6 As DataGridViewTextBoxColumn
    Friend WithEvents Col7 As DataGridViewTextBoxColumn
    Friend WithEvents col8 As DataGridViewTextBoxColumn
    Friend WithEvents col9 As DataGridViewTextBoxColumn
    Friend WithEvents col10 As DataGridViewTextBoxColumn
End Class
