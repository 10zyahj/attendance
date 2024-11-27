<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        btnLogout = New Button()
        btnStudent = New Button()
        btnAttendance = New Button()
        btnProfile = New Button()
        btnMainPage = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnStudent)
        Panel1.Controls.Add(btnAttendance)
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnMainPage)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(264, 728)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = My.Resources.Resources.logout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 662)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(30, 0, 0, 0)
        btnLogout.Size = New Size(264, 54)
        btnLogout.TabIndex = 6
        btnLogout.Text = "   Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnStudent
        ' 
        btnStudent.Dock = DockStyle.Top
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnStudent.ForeColor = Color.White
        btnStudent.Image = My.Resources.Resources.Student
        btnStudent.ImageAlign = ContentAlignment.MiddleLeft
        btnStudent.Location = New Point(0, 345)
        btnStudent.Name = "btnStudent"
        btnStudent.Padding = New Padding(30, 0, 0, 0)
        btnStudent.Size = New Size(264, 62)
        btnStudent.TabIndex = 4
        btnStudent.Text = "   Student"
        btnStudent.TextAlign = ContentAlignment.MiddleLeft
        btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStudent.UseVisualStyleBackColor = True
        ' 
        ' btnAttendance
        ' 
        btnAttendance.Dock = DockStyle.Top
        btnAttendance.FlatAppearance.BorderSize = 0
        btnAttendance.FlatStyle = FlatStyle.Flat
        btnAttendance.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnAttendance.ForeColor = Color.White
        btnAttendance.Image = My.Resources.Resources.calendar__1_
        btnAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnAttendance.Location = New Point(0, 283)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Padding = New Padding(30, 0, 0, 0)
        btnAttendance.Size = New Size(264, 62)
        btnAttendance.TabIndex = 3
        btnAttendance.Text = "   Attendance"
        btnAttendance.TextAlign = ContentAlignment.MiddleLeft
        btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.Dock = DockStyle.Top
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnProfile.ForeColor = Color.White
        btnProfile.Image = My.Resources.Resources.user
        btnProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnProfile.Location = New Point(0, 221)
        btnProfile.Name = "btnProfile"
        btnProfile.Padding = New Padding(30, 0, 0, 0)
        btnProfile.Size = New Size(264, 62)
        btnProfile.TabIndex = 2
        btnProfile.Text = "   Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnMainPage
        ' 
        btnMainPage.Dock = DockStyle.Top
        btnMainPage.FlatAppearance.BorderSize = 0
        btnMainPage.FlatStyle = FlatStyle.Flat
        btnMainPage.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnMainPage.ForeColor = Color.White
        btnMainPage.Image = My.Resources.Resources.home
        btnMainPage.ImageAlign = ContentAlignment.MiddleLeft
        btnMainPage.Location = New Point(0, 159)
        btnMainPage.Name = "btnMainPage"
        btnMainPage.Padding = New Padding(30, 0, 0, 0)
        btnMainPage.Size = New Size(264, 62)
        btnMainPage.TabIndex = 1
        btnMainPage.Text = "   Main Page"
        btnMainPage.TextAlign = ContentAlignment.MiddleLeft
        btnMainPage.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMainPage.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(264, 159)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icon
        PictureBox1.Location = New Point(66, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(264, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(953, 728)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.TCULOGO
        PictureBox2.Location = New Point(236, 221)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(469, 362)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(236, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(469, 46)
        Label3.TabIndex = 4
        Label3.Text = "MONITORING SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(221, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(510, 46)
        Label2.TabIndex = 3
        Label2.Text = "STUDENT ATTENDANCE"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.RedMajic
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1217, 728)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnMainPage As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
