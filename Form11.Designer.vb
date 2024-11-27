<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Label13 = New Label()
        btnUploadpicture = New Button()
        studpicture = New PictureBox()
        dateBday = New DateTimePicker()
        Label7 = New Label()
        buttonClear = New Button()
        buttonSave = New Button()
        comboSections = New ComboBox()
        Label12 = New Label()
        comboCourses = New ComboBox()
        Label11 = New Label()
        comboYearLevel = New ComboBox()
        Label10 = New Label()
        comboStat = New ComboBox()
        comboG = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        txtHomeAddress = New TextBox()
        Label6 = New Label()
        txtEmailAddress = New TextBox()
        Label5 = New Label()
        txtConNumber = New TextBox()
        Label2 = New Label()
        txtSNumber = New TextBox()
        Label3 = New Label()
        txtSName = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        buttonDelete = New Button()
        buttonUpdate = New Button()
        Label14 = New Label()
        txtManageStudentSearch = New TextBox()
        comboManageStudentClassNum = New ComboBox()
        btnEmail = New Button()
        btnExit = New Button()
        dataGrid = New DataGridView()
        col2 = New DataGridViewTextBoxColumn()
        col1 = New DataGridViewTextBoxColumn()
        col3 = New DataGridViewTextBoxColumn()
        col4 = New DataGridViewTextBoxColumn()
        col5 = New DataGridViewTextBoxColumn()
        col10 = New DataGridViewTextBoxColumn()
        col9 = New DataGridViewTextBoxColumn()
        Col7 = New DataGridViewTextBoxColumn()
        col11 = New DataGridViewTextBoxColumn()
        col6 = New DataGridViewTextBoxColumn()
        col8 = New DataGridViewTextBoxColumn()
        CType(studpicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(108, 294)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 20)
        Label13.TabIndex = 80
        Label13.Text = "Student Picture"
        ' 
        ' btnUploadpicture
        ' 
        btnUploadpicture.BackColor = Color.White
        btnUploadpicture.FlatStyle = FlatStyle.Flat
        btnUploadpicture.ForeColor = Color.Black
        btnUploadpicture.Location = New Point(105, 325)
        btnUploadpicture.Name = "btnUploadpicture"
        btnUploadpicture.Size = New Size(137, 30)
        btnUploadpicture.TabIndex = 79
        btnUploadpicture.Text = "Upload Picture"
        btnUploadpicture.UseVisualStyleBackColor = False
        ' 
        ' studpicture
        ' 
        studpicture.Image = My.Resources.Resources.icon
        studpicture.Location = New Point(86, 122)
        studpicture.Name = "studpicture"
        studpicture.Size = New Size(183, 161)
        studpicture.SizeMode = PictureBoxSizeMode.Zoom
        studpicture.TabIndex = 78
        studpicture.TabStop = False
        ' 
        ' dateBday
        ' 
        dateBday.Location = New Point(317, 367)
        dateBday.Name = "dateBday"
        dateBday.Size = New Size(115, 27)
        dateBday.TabIndex = 77
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(317, 337)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 76
        Label7.Text = "Birthday"
        ' 
        ' buttonClear
        ' 
        buttonClear.BackColor = Color.Firebrick
        buttonClear.FlatStyle = FlatStyle.Flat
        buttonClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonClear.ForeColor = Color.White
        buttonClear.Location = New Point(45, 638)
        buttonClear.Margin = New Padding(4, 3, 4, 3)
        buttonClear.Name = "buttonClear"
        buttonClear.Size = New Size(250, 44)
        buttonClear.TabIndex = 75
        buttonClear.Text = "CLEAR"
        buttonClear.UseVisualStyleBackColor = False
        ' 
        ' buttonSave
        ' 
        buttonSave.BackColor = Color.White
        buttonSave.FlatStyle = FlatStyle.Flat
        buttonSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonSave.ForeColor = Color.DarkRed
        buttonSave.Location = New Point(44, 577)
        buttonSave.Margin = New Padding(4, 3, 4, 3)
        buttonSave.Name = "buttonSave"
        buttonSave.Size = New Size(251, 44)
        buttonSave.TabIndex = 74
        buttonSave.Text = "ADD"
        buttonSave.UseVisualStyleBackColor = False
        ' 
        ' comboSections
        ' 
        comboSections.FormattingEnabled = True
        comboSections.Items.AddRange(New Object() {"A2020", "B2020", "C2020", "A2021", "B2021", "C2021", "A2022", "B2022"})
        comboSections.Location = New Point(318, 511)
        comboSections.Margin = New Padding(4, 3, 4, 3)
        comboSections.Name = "comboSections"
        comboSections.Size = New Size(114, 28)
        comboSections.TabIndex = 73
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(318, 483)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 20)
        Label12.TabIndex = 72
        Label12.Text = "Section"
        ' 
        ' comboCourses
        ' 
        comboCourses.FormattingEnabled = True
        comboCourses.Items.AddRange(New Object() {"BSCS", "BSIS", "BSOA", "BSED", "BSHM"})
        comboCourses.Location = New Point(453, 440)
        comboCourses.Margin = New Padding(4, 3, 4, 3)
        comboCourses.Name = "comboCourses"
        comboCourses.Size = New Size(115, 28)
        comboCourses.TabIndex = 71
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(453, 417)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 70
        Label11.Text = "Course"
        ' 
        ' comboYearLevel
        ' 
        comboYearLevel.FormattingEnabled = True
        comboYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        comboYearLevel.Location = New Point(318, 440)
        comboYearLevel.Margin = New Padding(4, 3, 4, 3)
        comboYearLevel.Name = "comboYearLevel"
        comboYearLevel.Size = New Size(114, 28)
        comboYearLevel.TabIndex = 69
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(318, 417)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 68
        Label10.Text = "Year Level"
        ' 
        ' comboStat
        ' 
        comboStat.FormattingEnabled = True
        comboStat.Items.AddRange(New Object() {"Scholar", "Non-Scholar"})
        comboStat.Location = New Point(453, 511)
        comboStat.Margin = New Padding(4, 3, 4, 3)
        comboStat.Name = "comboStat"
        comboStat.Size = New Size(115, 28)
        comboStat.TabIndex = 67
        ' 
        ' comboG
        ' 
        comboG.FormattingEnabled = True
        comboG.Items.AddRange(New Object() {"Female", "Male"})
        comboG.Location = New Point(453, 366)
        comboG.Margin = New Padding(4, 3, 4, 3)
        comboG.Name = "comboG"
        comboG.Size = New Size(115, 28)
        comboG.TabIndex = 66
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(453, 483)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 65
        Label9.Text = "Status"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(453, 337)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 20)
        Label8.TabIndex = 64
        Label8.Text = "Gender"
        ' 
        ' txtHomeAddress
        ' 
        txtHomeAddress.BorderStyle = BorderStyle.FixedSingle
        txtHomeAddress.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtHomeAddress.Location = New Point(318, 149)
        txtHomeAddress.Margin = New Padding(4, 3, 4, 3)
        txtHomeAddress.Multiline = True
        txtHomeAddress.Name = "txtHomeAddress"
        txtHomeAddress.Size = New Size(250, 29)
        txtHomeAddress.TabIndex = 63
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(318, 122)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 62
        Label6.Text = "Home Address"
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.BorderStyle = BorderStyle.FixedSingle
        txtEmailAddress.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmailAddress.Location = New Point(318, 296)
        txtEmailAddress.Margin = New Padding(4, 3, 4, 3)
        txtEmailAddress.Multiline = True
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(250, 29)
        txtEmailAddress.TabIndex = 61
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(318, 269)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 60
        Label5.Text = "Email Address"
        ' 
        ' txtConNumber
        ' 
        txtConNumber.BorderStyle = BorderStyle.FixedSingle
        txtConNumber.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtConNumber.Location = New Point(318, 222)
        txtConNumber.Margin = New Padding(4, 3, 4, 3)
        txtConNumber.Multiline = True
        txtConNumber.Name = "txtConNumber"
        txtConNumber.Size = New Size(250, 29)
        txtConNumber.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(318, 195)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 58
        Label2.Text = "Contact Number"
        ' 
        ' txtSNumber
        ' 
        txtSNumber.BorderStyle = BorderStyle.FixedSingle
        txtSNumber.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtSNumber.Location = New Point(45, 462)
        txtSNumber.Margin = New Padding(4, 3, 4, 3)
        txtSNumber.Multiline = True
        txtSNumber.Name = "txtSNumber"
        txtSNumber.Size = New Size(250, 29)
        txtSNumber.TabIndex = 57
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(45, 371)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 54
        Label3.Text = "Student Name"
        ' 
        ' txtSName
        ' 
        txtSName.BorderStyle = BorderStyle.FixedSingle
        txtSName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtSName.Location = New Point(45, 396)
        txtSName.Margin = New Padding(4, 3, 4, 3)
        txtSName.Multiline = True
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(250, 29)
        txtSName.TabIndex = 55
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(45, 439)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 20)
        Label4.TabIndex = 56
        Label4.Text = "Student Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(45, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 42)
        Label1.TabIndex = 53
        Label1.Text = "STUDENT"
        ' 
        ' buttonDelete
        ' 
        buttonDelete.BackColor = Color.Brown
        buttonDelete.FlatStyle = FlatStyle.Flat
        buttonDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonDelete.ForeColor = Color.White
        buttonDelete.Location = New Point(317, 638)
        buttonDelete.Name = "buttonDelete"
        buttonDelete.Size = New Size(250, 44)
        buttonDelete.TabIndex = 82
        buttonDelete.Text = "DELETE"
        buttonDelete.UseVisualStyleBackColor = False
        ' 
        ' buttonUpdate
        ' 
        buttonUpdate.BackColor = Color.OrangeRed
        buttonUpdate.FlatAppearance.BorderSize = 0
        buttonUpdate.FlatStyle = FlatStyle.Flat
        buttonUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonUpdate.ForeColor = Color.White
        buttonUpdate.Location = New Point(318, 577)
        buttonUpdate.Name = "buttonUpdate"
        buttonUpdate.Size = New Size(251, 44)
        buttonUpdate.TabIndex = 83
        buttonUpdate.Text = "UPDATE"
        buttonUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(608, 84)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(62, 20)
        Label14.TabIndex = 87
        Label14.Text = "Search"
        ' 
        ' txtManageStudentSearch
        ' 
        txtManageStudentSearch.BorderStyle = BorderStyle.FixedSingle
        txtManageStudentSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtManageStudentSearch.Location = New Point(678, 78)
        txtManageStudentSearch.Margin = New Padding(4, 3, 4, 3)
        txtManageStudentSearch.Multiline = True
        txtManageStudentSearch.Name = "txtManageStudentSearch"
        txtManageStudentSearch.Size = New Size(217, 28)
        txtManageStudentSearch.TabIndex = 84
        ' 
        ' comboManageStudentClassNum
        ' 
        comboManageStudentClassNum.FormattingEnabled = True
        comboManageStudentClassNum.Location = New Point(1032, 79)
        comboManageStudentClassNum.Margin = New Padding(4, 3, 4, 3)
        comboManageStudentClassNum.Name = "comboManageStudentClassNum"
        comboManageStudentClassNum.Size = New Size(147, 28)
        comboManageStudentClassNum.TabIndex = 85
        ' 
        ' btnEmail
        ' 
        btnEmail.FlatAppearance.BorderSize = 0
        btnEmail.FlatStyle = FlatStyle.Flat
        btnEmail.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnEmail.ForeColor = Color.White
        btnEmail.Image = My.Resources.Resources.send__1_
        btnEmail.ImageAlign = ContentAlignment.MiddleLeft
        btnEmail.Location = New Point(45, 511)
        btnEmail.Name = "btnEmail"
        btnEmail.Padding = New Padding(30, 0, 0, 0)
        btnEmail.Size = New Size(250, 48)
        btnEmail.TabIndex = 88
        btnEmail.Text = "   Send Email"
        btnEmail.TextAlign = ContentAlignment.MiddleLeft
        btnEmail.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEmail.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._Exit
        btnExit.Location = New Point(1170, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(51, 38)
        btnExit.TabIndex = 89
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' dataGrid
        ' 
        dataGrid.AllowUserToOrderColumns = True
        dataGrid.BackgroundColor = Color.White
        dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGrid.Columns.AddRange(New DataGridViewColumn() {col2, col1, col3, col4, col5, col10, col9, Col7, col11, col6, col8})
        dataGrid.Location = New Point(609, 131)
        dataGrid.Name = "dataGrid"
        dataGrid.RowHeadersWidth = 51
        dataGrid.RowTemplate.Height = 29
        dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGrid.Size = New Size(570, 551)
        dataGrid.TabIndex = 81
        ' 
        ' col2
        ' 
        col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col2.DataPropertyName = "student_number"
        col2.HeaderText = "Student Number"
        col2.MinimumWidth = 6
        col2.Name = "col2"
        col2.Width = 147
        ' 
        ' col1
        ' 
        col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col1.DataPropertyName = "student_name"
        col1.HeaderText = "Student Name"
        col1.MinimumWidth = 6
        col1.Name = "col1"
        col1.Width = 133
        ' 
        ' col3
        ' 
        col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col3.DataPropertyName = "year_level"
        col3.HeaderText = "Year Level"
        col3.MinimumWidth = 6
        col3.Name = "col3"
        col3.Width = 104
        ' 
        ' col4
        ' 
        col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col4.DataPropertyName = "course"
        col4.HeaderText = "Course"
        col4.MinimumWidth = 6
        col4.Name = "col4"
        col4.Width = 83
        ' 
        ' col5
        ' 
        col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col5.DataPropertyName = "section"
        col5.HeaderText = "Section"
        col5.MinimumWidth = 6
        col5.Name = "col5"
        col5.Width = 87
        ' 
        ' col10
        ' 
        col10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col10.DataPropertyName = "status"
        col10.HeaderText = "Status"
        col10.MinimumWidth = 6
        col10.Name = "col10"
        col10.Width = 78
        ' 
        ' col9
        ' 
        col9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col9.DataPropertyName = "gender"
        col9.HeaderText = "Gender"
        col9.MinimumWidth = 6
        col9.Name = "col9"
        col9.Width = 86
        ' 
        ' Col7
        ' 
        Col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Col7.DataPropertyName = "contact_number"
        Col7.HeaderText = "Contact Number"
        Col7.MinimumWidth = 6
        Col7.Name = "Col7"
        Col7.Width = 147
        ' 
        ' col11
        ' 
        col11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col11.DataPropertyName = "email_address"
        col11.HeaderText = "Email Address"
        col11.MinimumWidth = 6
        col11.Name = "col11"
        col11.Width = 132
        ' 
        ' col6
        ' 
        col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col6.DataPropertyName = "home_address"
        col6.HeaderText = "Home Address"
        col6.MinimumWidth = 6
        col6.Name = "col6"
        col6.Width = 136
        ' 
        ' col8
        ' 
        col8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col8.DataPropertyName = "birthday"
        col8.HeaderText = "Birthday"
        col8.MinimumWidth = 6
        col8.Name = "col8"
        col8.Width = 93
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(1221, 728)
        Controls.Add(btnExit)
        Controls.Add(btnEmail)
        Controls.Add(Label14)
        Controls.Add(txtManageStudentSearch)
        Controls.Add(comboManageStudentClassNum)
        Controls.Add(buttonDelete)
        Controls.Add(buttonUpdate)
        Controls.Add(dataGrid)
        Controls.Add(Label13)
        Controls.Add(btnUploadpicture)
        Controls.Add(studpicture)
        Controls.Add(dateBday)
        Controls.Add(Label7)
        Controls.Add(buttonClear)
        Controls.Add(buttonSave)
        Controls.Add(comboSections)
        Controls.Add(Label12)
        Controls.Add(comboCourses)
        Controls.Add(Label11)
        Controls.Add(comboYearLevel)
        Controls.Add(Label10)
        Controls.Add(comboStat)
        Controls.Add(comboG)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtHomeAddress)
        Controls.Add(Label6)
        Controls.Add(txtEmailAddress)
        Controls.Add(Label5)
        Controls.Add(txtConNumber)
        Controls.Add(Label2)
        Controls.Add(txtSNumber)
        Controls.Add(Label3)
        Controls.Add(txtSName)
        Controls.Add(Label4)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form11"
        Text = "Form11"
        CType(studpicture, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents btnUploadpicture As Button
    Friend WithEvents studpicture As PictureBox
    Friend WithEvents dateBday As DateTimePicker
    Protected Friend WithEvents Label7 As Label
    Friend WithEvents buttonClear As Button
    Friend WithEvents buttonSave As Button
    Friend WithEvents comboSections As ComboBox
    Protected Friend WithEvents Label12 As Label
    Friend WithEvents comboCourses As ComboBox
    Protected Friend WithEvents Label11 As Label
    Friend WithEvents comboYearLevel As ComboBox
    Protected Friend WithEvents Label10 As Label
    Friend WithEvents comboStat As ComboBox
    Friend WithEvents comboG As ComboBox
    Protected Friend WithEvents Label9 As Label
    Protected Friend WithEvents Label8 As Label
    Friend WithEvents txtHomeAddress As TextBox
    Protected Friend WithEvents Label6 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Protected Friend WithEvents Label5 As Label
    Friend WithEvents txtConNumber As TextBox
    Protected Friend WithEvents Label2 As Label
    Friend WithEvents txtSNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSName As TextBox
    Protected Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonUpdate As Button
    Protected Friend WithEvents Label14 As Label
    Friend WithEvents txtManageStudentSearch As TextBox
    Friend WithEvents comboManageStudentClassNum As ComboBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
    Friend WithEvents col4 As DataGridViewTextBoxColumn
    Friend WithEvents col5 As DataGridViewTextBoxColumn
    Friend WithEvents col10 As DataGridViewTextBoxColumn
    Friend WithEvents col9 As DataGridViewTextBoxColumn
    Friend WithEvents Col7 As DataGridViewTextBoxColumn
    Friend WithEvents col11 As DataGridViewTextBoxColumn
    Friend WithEvents col6 As DataGridViewTextBoxColumn
    Friend WithEvents col8 As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
End Class
