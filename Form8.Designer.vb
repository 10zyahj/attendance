<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Label1 = New Label()
        btnViewStudent = New Button()
        Label3 = New Label()
        txtStudentName = New TextBox()
        Label4 = New Label()
        txtStudentNum = New TextBox()
        txtContact = New TextBox()
        Label2 = New Label()
        txtEmail = New TextBox()
        Label5 = New Label()
        txtAddress = New TextBox()
        Label6 = New Label()
        Label9 = New Label()
        comboGender = New ComboBox()
        comboStatus = New ComboBox()
        comboYear = New ComboBox()
        Label10 = New Label()
        comboCourse = New ComboBox()
        Label11 = New Label()
        comboSection = New ComboBox()
        Label12 = New Label()
        btnRegister = New Button()
        btnClear = New Button()
        Label8 = New Label()
        Label7 = New Label()
        dateBirthday = New DateTimePicker()
        studpic = New PictureBox()
        btnUploadpic = New Button()
        Label13 = New Label()
        CType(studpic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(271, 71)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(411, 42)
        Label1.TabIndex = 13
        Label1.Text = "REGISTER STUDENT"
        ' 
        ' btnViewStudent
        ' 
        btnViewStudent.BackColor = Color.Tomato
        btnViewStudent.FlatAppearance.BorderSize = 0
        btnViewStudent.FlatStyle = FlatStyle.Flat
        btnViewStudent.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewStudent.ForeColor = Color.White
        btnViewStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnViewStudent.Location = New Point(777, 12)
        btnViewStudent.Margin = New Padding(4, 3, 4, 3)
        btnViewStudent.Name = "btnViewStudent"
        btnViewStudent.Size = New Size(163, 49)
        btnViewStudent.TabIndex = 14
        btnViewStudent.Text = "View Student"
        btnViewStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewStudent.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(124, 430)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 15
        Label3.Text = "Student Name"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BorderStyle = BorderStyle.FixedSingle
        txtStudentName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentName.Location = New Point(124, 457)
        txtStudentName.Margin = New Padding(4, 3, 4, 3)
        txtStudentName.Multiline = True
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(304, 29)
        txtStudentName.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(124, 508)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 20)
        Label4.TabIndex = 17
        Label4.Text = "Student Number"
        ' 
        ' txtStudentNum
        ' 
        txtStudentNum.BorderStyle = BorderStyle.FixedSingle
        txtStudentNum.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentNum.Location = New Point(124, 535)
        txtStudentNum.Margin = New Padding(4, 3, 4, 3)
        txtStudentNum.Multiline = True
        txtStudentNum.Name = "txtStudentNum"
        txtStudentNum.Size = New Size(304, 29)
        txtStudentNum.TabIndex = 18
        ' 
        ' txtContact
        ' 
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.Location = New Point(524, 247)
        txtContact.Margin = New Padding(4, 3, 4, 3)
        txtContact.Multiline = True
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(304, 29)
        txtContact.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(524, 220)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 19
        Label2.Text = "Contact Number"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(524, 321)
        txtEmail.Margin = New Padding(4, 3, 4, 3)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(304, 29)
        txtEmail.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(524, 294)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 21
        Label5.Text = "Email Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(524, 174)
        txtAddress.Margin = New Padding(4, 3, 4, 3)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(304, 29)
        txtAddress.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(524, 147)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 23
        Label6.Text = "Home Address"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(690, 508)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 30
        Label9.Text = "Status"
        ' 
        ' comboGender
        ' 
        comboGender.FormattingEnabled = True
        comboGender.Items.AddRange(New Object() {"Female", "Male"})
        comboGender.Location = New Point(690, 391)
        comboGender.Margin = New Padding(4, 3, 4, 3)
        comboGender.Name = "comboGender"
        comboGender.Size = New Size(138, 28)
        comboGender.TabIndex = 33
        ' 
        ' comboStatus
        ' 
        comboStatus.FormattingEnabled = True
        comboStatus.Items.AddRange(New Object() {"Scholar", "Non-Scholar"})
        comboStatus.Location = New Point(690, 536)
        comboStatus.Margin = New Padding(4, 3, 4, 3)
        comboStatus.Name = "comboStatus"
        comboStatus.Size = New Size(138, 28)
        comboStatus.TabIndex = 34
        ' 
        ' comboYear
        ' 
        comboYear.FormattingEnabled = True
        comboYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        comboYear.Location = New Point(524, 465)
        comboYear.Margin = New Padding(4, 3, 4, 3)
        comboYear.Name = "comboYear"
        comboYear.Size = New Size(143, 28)
        comboYear.TabIndex = 36
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(524, 442)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 35
        Label10.Text = "Year Level"
        ' 
        ' comboCourse
        ' 
        comboCourse.FormattingEnabled = True
        comboCourse.Items.AddRange(New Object() {"BSCS", "BSIS", "BSOA", "BSED", "BSHM"})
        comboCourse.Location = New Point(690, 465)
        comboCourse.Margin = New Padding(4, 3, 4, 3)
        comboCourse.Name = "comboCourse"
        comboCourse.Size = New Size(138, 28)
        comboCourse.TabIndex = 38
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(690, 442)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 37
        Label11.Text = "Course"
        ' 
        ' comboSection
        ' 
        comboSection.FormattingEnabled = True
        comboSection.Items.AddRange(New Object() {"A2020", "B2020", "C2020", "A2021", "B2021", "C2021", "A2022", "B2022"})
        comboSection.Location = New Point(524, 536)
        comboSection.Margin = New Padding(4, 3, 4, 3)
        comboSection.Name = "comboSection"
        comboSection.Size = New Size(143, 28)
        comboSection.TabIndex = 40
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(524, 508)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 20)
        Label12.TabIndex = 39
        Label12.Text = "Section"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.White
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.DarkRed
        btnRegister.Location = New Point(487, 604)
        btnRegister.Margin = New Padding(4, 3, 4, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(341, 44)
        btnRegister.TabIndex = 45
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Firebrick
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(124, 604)
        btnClear.Margin = New Padding(4, 3, 4, 3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(355, 44)
        btnClear.TabIndex = 46
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(690, 362)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 20)
        Label8.TabIndex = 25
        Label8.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(523, 362)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 47
        Label7.Text = "Birthday"
        ' 
        ' dateBirthday
        ' 
        dateBirthday.Location = New Point(523, 392)
        dateBirthday.Name = "dateBirthday"
        dateBirthday.Size = New Size(144, 27)
        dateBirthday.TabIndex = 49
        ' 
        ' studpic
        ' 
        studpic.Image = My.Resources.Resources.icon
        studpic.Location = New Point(195, 157)
        studpic.Name = "studpic"
        studpic.Size = New Size(170, 163)
        studpic.SizeMode = PictureBoxSizeMode.Zoom
        studpic.TabIndex = 50
        studpic.TabStop = False
        ' 
        ' btnUploadpic
        ' 
        btnUploadpic.BackColor = Color.White
        btnUploadpic.FlatStyle = FlatStyle.Flat
        btnUploadpic.ForeColor = Color.Black
        btnUploadpic.Location = New Point(195, 362)
        btnUploadpic.Name = "btnUploadpic"
        btnUploadpic.Size = New Size(170, 30)
        btnUploadpic.TabIndex = 51
        btnUploadpic.Text = "Upload Picture"
        btnUploadpic.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(217, 331)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 20)
        Label13.TabIndex = 52
        Label13.Text = "Student Picture"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(953, 728)
        Controls.Add(Label13)
        Controls.Add(btnUploadpic)
        Controls.Add(studpic)
        Controls.Add(dateBirthday)
        Controls.Add(Label7)
        Controls.Add(btnClear)
        Controls.Add(btnRegister)
        Controls.Add(comboSection)
        Controls.Add(Label12)
        Controls.Add(comboCourse)
        Controls.Add(Label11)
        Controls.Add(comboYear)
        Controls.Add(Label10)
        Controls.Add(comboStatus)
        Controls.Add(comboGender)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtAddress)
        Controls.Add(Label6)
        Controls.Add(txtEmail)
        Controls.Add(Label5)
        Controls.Add(txtContact)
        Controls.Add(Label2)
        Controls.Add(txtStudentNum)
        Controls.Add(Label3)
        Controls.Add(txtStudentName)
        Controls.Add(Label4)
        Controls.Add(btnViewStudent)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form8"
        Text = "Form8"
        CType(studpic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMainPage As Button
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentName As TextBox
    Protected Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents txtContact As TextBox
    Protected Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Protected Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Protected Friend WithEvents Label6 As Label
    Protected Friend WithEvents Label9 As Label
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents comboYear As ComboBox
    Protected Friend WithEvents Label10 As Label
    Friend WithEvents comboCourse As ComboBox
    Protected Friend WithEvents Label11 As Label
    Friend WithEvents comboSection As ComboBox
    Protected Friend WithEvents Label12 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend Protected WithEvents Label8 As Label
    Friend Protected WithEvents Label7 As Label
    Friend WithEvents dateBirthday As DateTimePicker
    Friend WithEvents studpic As PictureBox
    Friend WithEvents btnUploadpic As Button
    Friend WithEvents Label13 As Label
End Class
