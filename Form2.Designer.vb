<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        btnRegister = New Button()
        txtEmployeeNumber = New TextBox()
        txtEmployeeName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtEmailAddress = New TextBox()
        txtContactNumber = New TextBox()
        txtConfirmPassword = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        comboDepartment = New ComboBox()
        comboSubjectCode = New ComboBox()
        btnExit = New Button()
        Label3 = New Label()
        Label14 = New Label()
        Label7 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.RedMajic
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(456, 552)
        Panel1.TabIndex = 20
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.TCULOGO
        PictureBox1.Location = New Point(64, 187)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(334, 268)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(64, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(334, 32)
        Label6.TabIndex = 2
        Label6.Text = "MONITORING SYSTEM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(51, 89)
        Label5.Name = "Label5"
        Label5.Size = New Size(361, 32)
        Label5.TabIndex = 1
        Label5.Text = "STUDENT ATTENDANCE"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(854, 471)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(79, 20)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Login here"
        LinkLabel1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(667, 471)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 20)
        Label4.TabIndex = 18
        Label4.Text = "Already have an account?"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.White
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.DarkRed
        btnRegister.Location = New Point(510, 417)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(554, 38)
        btnRegister.TabIndex = 16
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtEmployeeNumber
        ' 
        txtEmployeeNumber.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeNumber.Location = New Point(510, 214)
        txtEmployeeNumber.Name = "txtEmployeeNumber"
        txtEmployeeNumber.Size = New Size(254, 27)
        txtEmployeeNumber.TabIndex = 15
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeName.Location = New Point(510, 149)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(254, 27)
        txtEmployeeName.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(510, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 12
        Label2.Text = "Employee Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(712, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 32)
        Label1.TabIndex = 11
        Label1.Text = "REGISTER"
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.BorderStyle = BorderStyle.FixedSingle
        txtEmailAddress.Location = New Point(510, 346)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(254, 27)
        txtEmailAddress.TabIndex = 25
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BorderStyle = BorderStyle.FixedSingle
        txtContactNumber.Location = New Point(510, 281)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(254, 27)
        txtContactNumber.TabIndex = 23
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Location = New Point(810, 281)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(254, 27)
        txtConfirmPassword.TabIndex = 31
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(810, 214)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(254, 27)
        txtPassword.TabIndex = 29
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(810, 149)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(254, 27)
        txtUsername.TabIndex = 27
        ' 
        ' comboDepartment
        ' 
        comboDepartment.FormattingEnabled = True
        comboDepartment.Items.AddRange(New Object() {"CICT", "CAS", "CED"})
        comboDepartment.Location = New Point(810, 345)
        comboDepartment.Name = "comboDepartment"
        comboDepartment.Size = New Size(123, 28)
        comboDepartment.TabIndex = 32
        ' 
        ' comboSubjectCode
        ' 
        comboSubjectCode.FormattingEnabled = True
        comboSubjectCode.Items.AddRange(New Object() {"SDF104", "AL102", "CC101", "CC102"})
        comboSubjectCode.Location = New Point(941, 345)
        comboSubjectCode.Name = "comboSubjectCode"
        comboSubjectCode.Size = New Size(123, 28)
        comboSubjectCode.TabIndex = 33
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._Exit
        btnExit.Location = New Point(1055, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(51, 38)
        btnExit.TabIndex = 36
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(510, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 20)
        Label3.TabIndex = 14
        Label3.Text = "Employee Number"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Transparent
        Label14.Location = New Point(510, 258)
        Label14.Name = "Label14"
        Label14.Size = New Size(131, 20)
        Label14.TabIndex = 37
        Label14.Text = "Contact Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(510, 323)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 20)
        Label7.TabIndex = 38
        Label7.Text = "Email Address"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.Transparent
        Label12.Location = New Point(810, 126)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 20)
        Label12.TabIndex = 39
        Label12.Text = "Username"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.Transparent
        Label11.Location = New Point(810, 191)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 20)
        Label11.TabIndex = 40
        Label11.Text = "Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(810, 258)
        Label9.Name = "Label9"
        Label9.Size = New Size(147, 20)
        Label9.TabIndex = 41
        Label9.Text = "Confirm Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(810, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 42
        Label8.Text = "Department"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Transparent
        Label10.Location = New Point(939, 323)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 20)
        Label10.TabIndex = 43
        Label10.Text = "Subject Code"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(1106, 552)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(Label14)
        Controls.Add(btnExit)
        Controls.Add(comboSubjectCode)
        Controls.Add(comboDepartment)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtEmailAddress)
        Controls.Add(txtContactNumber)
        Controls.Add(Panel1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label4)
        Controls.Add(btnRegister)
        Controls.Add(txtEmployeeNumber)
        Controls.Add(Label3)
        Controls.Add(txtEmployeeName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents comboDepartment As ComboBox
    Friend WithEvents comboSubjectCode As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
