<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        btnLogin = New Button()
        checkShowPassword = New CheckBox()
        Label4 = New Label()
        RegisterHere = New LinkLabel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        btnExit = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(813, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 32)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(692, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(692, 186)
        txtUsername.Margin = New Padding(10, 3, 3, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(341, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(692, 261)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(341, 27)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(692, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.DarkRed
        btnLogin.Location = New Point(692, 343)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(341, 38)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' checkShowPassword
        ' 
        checkShowPassword.AutoSize = True
        checkShowPassword.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        checkShowPassword.ForeColor = Color.White
        checkShowPassword.Location = New Point(692, 294)
        checkShowPassword.Name = "checkShowPassword"
        checkShowPassword.Size = New Size(121, 21)
        checkShowPassword.TabIndex = 6
        checkShowPassword.Text = "Show Password"
        checkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(719, 404)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 20)
        Label4.TabIndex = 7
        Label4.Text = "Don't have an account?"
        ' 
        ' RegisterHere
        ' 
        RegisterHere.AutoSize = True
        RegisterHere.LinkColor = Color.White
        RegisterHere.Location = New Point(902, 404)
        RegisterHere.Name = "RegisterHere"
        RegisterHere.Size = New Size(96, 20)
        RegisterHere.TabIndex = 8
        RegisterHere.TabStop = True
        RegisterHere.Text = "Register here"
        RegisterHere.TextAlign = ContentAlignment.TopRight
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
        Panel1.Size = New Size(629, 552)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.TCULOGO
        PictureBox1.Location = New Point(133, 186)
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
        Label6.Location = New Point(133, 131)
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
        Label5.Location = New Point(120, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(361, 32)
        Label5.TabIndex = 1
        Label5.Text = "STUDENT ATTENDANCE"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._Exit
        btnExit.Location = New Point(1056, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(51, 38)
        btnExit.TabIndex = 10
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(1106, 552)
        Controls.Add(btnExit)
        Controls.Add(Panel1)
        Controls.Add(RegisterHere)
        Controls.Add(Label4)
        Controls.Add(checkShowPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents checkShowPassword As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RegisterHere As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
End Class
