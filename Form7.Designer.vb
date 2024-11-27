<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label14 = New Label()
        comboYearLevel = New ComboBox()
        comboCourse = New ComboBox()
        Label2 = New Label()
        comboSection = New ComboBox()
        Label3 = New Label()
        btnRegister = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        comboClassNumber = New ComboBox()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        txtTeacherEmployeeID = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(220, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 39)
        Label1.TabIndex = 12
        Label1.Text = "CLASS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Transparent
        Label14.Location = New Point(146, 302)
        Label14.Name = "Label14"
        Label14.Size = New Size(96, 22)
        Label14.TabIndex = 38
        Label14.Text = "Year Level"
        ' 
        ' comboYearLevel
        ' 
        comboYearLevel.FormattingEnabled = True
        comboYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        comboYearLevel.Location = New Point(146, 329)
        comboYearLevel.Name = "comboYearLevel"
        comboYearLevel.Size = New Size(190, 28)
        comboYearLevel.TabIndex = 39
        ' 
        ' comboCourse
        ' 
        comboCourse.FormattingEnabled = True
        comboCourse.Items.AddRange(New Object() {" BSCS", "BSIS", "BSED"})
        comboCourse.Location = New Point(146, 402)
        comboCourse.Name = "comboCourse"
        comboCourse.Size = New Size(190, 28)
        comboCourse.TabIndex = 41
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(146, 375)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 22)
        Label2.TabIndex = 40
        Label2.Text = "Course"
        ' 
        ' comboSection
        ' 
        comboSection.FormattingEnabled = True
        comboSection.Items.AddRange(New Object() {"A2022", "B2022"})
        comboSection.Location = New Point(146, 472)
        comboSection.Name = "comboSection"
        comboSection.Size = New Size(190, 28)
        comboSection.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(146, 445)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 22)
        Label3.TabIndex = 42
        Label3.Text = "Section"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.DarkCyan
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(248, 588)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(88, 44)
        btnRegister.TabIndex = 44
        btnRegister.Text = "ADD"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(146, 588)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 44)
        Button1.TabIndex = 45
        Button1.Text = "CLEAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.register__1_
        PictureBox1.Location = New Point(133, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(419, 125)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(383, 375)
        DataGridView1.TabIndex = 48
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Class No."
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Year Level"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 80
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Course"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 80
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Section"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 90
        ' 
        ' comboClassNumber
        ' 
        comboClassNumber.FormattingEnabled = True
        comboClassNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        comboClassNumber.Location = New Point(146, 253)
        comboClassNumber.Name = "comboClassNumber"
        comboClassNumber.Size = New Size(190, 28)
        comboClassNumber.TabIndex = 50
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(146, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 22)
        Label4.TabIndex = 49
        Label4.Text = "Class Number"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Firebrick
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(419, 554)
        Button2.Name = "Button2"
        Button2.Size = New Size(179, 44)
        Button2.TabIndex = 52
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(623, 554)
        Button3.Name = "Button3"
        Button3.Size = New Size(179, 44)
        Button3.TabIndex = 51
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(147, 515)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 22)
        Label5.TabIndex = 54
        Label5.Text = "Your Employee ID"
        ' 
        ' txtTeacherEmployeeID
        ' 
        txtTeacherEmployeeID.BorderStyle = BorderStyle.FixedSingle
        txtTeacherEmployeeID.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtTeacherEmployeeID.Location = New Point(147, 540)
        txtTeacherEmployeeID.Margin = New Padding(4, 3, 4, 3)
        txtTeacherEmployeeID.Multiline = True
        txtTeacherEmployeeID.Name = "txtTeacherEmployeeID"
        txtTeacherEmployeeID.Size = New Size(189, 28)
        txtTeacherEmployeeID.TabIndex = 114
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(953, 728)
        Controls.Add(txtTeacherEmployeeID)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(comboClassNumber)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(btnRegister)
        Controls.Add(comboSection)
        Controls.Add(Label3)
        Controls.Add(comboCourse)
        Controls.Add(Label2)
        Controls.Add(comboYearLevel)
        Controls.Add(Label14)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Form7"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents comboYearLevel As ComboBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboSection As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboClassNumber As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTeacherEmployeeID As TextBox
End Class
