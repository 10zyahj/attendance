<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        PictureBox1 = New PictureBox()
        txtEmpID = New TextBox()
        Label6 = New Label()
        comboClassNum = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        comboYear = New ComboBox()
        Label4 = New Label()
        comboSection = New ComboBox()
        Label5 = New Label()
        comboCourse = New ComboBox()
        btnClear = New Button()
        btnAdd = New Button()
        dataGridClass = New DataGridView()
        col1 = New DataGridViewTextBoxColumn()
        col2 = New DataGridViewTextBoxColumn()
        col3 = New DataGridViewTextBoxColumn()
        col4 = New DataGridViewTextBoxColumn()
        btnDelete = New Button()
        btnUpdate = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridClass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(195, 110)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 42)
        Label1.TabIndex = 54
        Label1.Text = "CLASS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.register__1_
        PictureBox1.Location = New Point(73, 72)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 115)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' txtEmpID
        ' 
        txtEmpID.BorderStyle = BorderStyle.FixedSingle
        txtEmpID.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmpID.Location = New Point(73, 540)
        txtEmpID.Margin = New Padding(4, 3, 4, 3)
        txtEmpID.Multiline = True
        txtEmpID.Name = "txtEmpID"
        txtEmpID.Size = New Size(250, 29)
        txtEmpID.TabIndex = 65
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(73, 513)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 64
        Label6.Text = "Employee ID"
        ' 
        ' comboClassNum
        ' 
        comboClassNum.FormattingEnabled = True
        comboClassNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        comboClassNum.Location = New Point(73, 246)
        comboClassNum.Name = "comboClassNum"
        comboClassNum.Size = New Size(250, 28)
        comboClassNum.TabIndex = 66
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(73, 218)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 67
        Label2.Text = "Class Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(73, 290)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 69
        Label3.Text = "Year Level"
        ' 
        ' comboYear
        ' 
        comboYear.FormattingEnabled = True
        comboYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        comboYear.Location = New Point(73, 318)
        comboYear.Name = "comboYear"
        comboYear.Size = New Size(250, 28)
        comboYear.TabIndex = 68
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(73, 437)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 73
        Label4.Text = "Section"
        ' 
        ' comboSection
        ' 
        comboSection.FormattingEnabled = True
        comboSection.Items.AddRange(New Object() {"A2020", "B2020", "C2020", "A2021", "B2021", "C2021", "A2022", "B2022"})
        comboSection.Location = New Point(73, 465)
        comboSection.Name = "comboSection"
        comboSection.Size = New Size(250, 28)
        comboSection.TabIndex = 72
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(73, 362)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 71
        Label5.Text = "Course"
        ' 
        ' comboCourse
        ' 
        comboCourse.FormattingEnabled = True
        comboCourse.Items.AddRange(New Object() {"BSCS", "BSIS", "BSOA", "BSED", "BSHM"})
        comboCourse.Location = New Point(73, 390)
        comboCourse.Name = "comboCourse"
        comboCourse.Size = New Size(250, 28)
        comboCourse.TabIndex = 70
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Firebrick
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(73, 595)
        btnClear.Margin = New Padding(4, 3, 4, 3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(116, 44)
        btnClear.TabIndex = 76
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.White
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.DarkRed
        btnAdd.Location = New Point(207, 595)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(116, 44)
        btnAdd.TabIndex = 77
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dataGridClass
        ' 
        dataGridClass.AllowUserToOrderColumns = True
        dataGridClass.BackgroundColor = Color.White
        dataGridClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridClass.Columns.AddRange(New DataGridViewColumn() {col1, col2, col3, col4})
        dataGridClass.Location = New Point(375, 110)
        dataGridClass.Name = "dataGridClass"
        dataGridClass.RowHeadersWidth = 51
        dataGridClass.RowTemplate.Height = 29
        dataGridClass.Size = New Size(505, 459)
        dataGridClass.TabIndex = 78
        ' 
        ' col1
        ' 
        col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col1.DataPropertyName = "class_number"
        col1.HeaderText = "Class No."
        col1.MinimumWidth = 6
        col1.Name = "col1"
        col1.ReadOnly = True
        col1.Width = 98
        ' 
        ' col2
        ' 
        col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        col2.DataPropertyName = "CYear"
        col2.HeaderText = "Year Level"
        col2.MinimumWidth = 6
        col2.Name = "col2"
        col2.ReadOnly = True
        col2.Width = 104
        ' 
        ' col3
        ' 
        col3.DataPropertyName = "CCourse"
        col3.HeaderText = "Course"
        col3.MinimumWidth = 6
        col3.Name = "col3"
        col3.ReadOnly = True
        col3.Width = 125
        ' 
        ' col4
        ' 
        col4.DataPropertyName = "CSection"
        col4.HeaderText = "Section"
        col4.MinimumWidth = 6
        col4.Name = "col4"
        col4.ReadOnly = True
        col4.Width = 125
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Firebrick
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(375, 595)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(246, 44)
        btnDelete.TabIndex = 79
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.OrangeRed
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(634, 595)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(246, 44)
        btnUpdate.TabIndex = 80
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(953, 728)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(dataGridClass)
        Controls.Add(btnAdd)
        Controls.Add(btnClear)
        Controls.Add(Label4)
        Controls.Add(comboSection)
        Controls.Add(Label5)
        Controls.Add(comboCourse)
        Controls.Add(Label3)
        Controls.Add(comboYear)
        Controls.Add(Label2)
        Controls.Add(comboClassNum)
        Controls.Add(txtEmpID)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        ForeColor = Color.ForestGreen
        FormBorderStyle = FormBorderStyle.None
        Name = "Form12"
        Text = "Form12"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridClass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEmpID As TextBox
    Friend Protected WithEvents Label6 As Label
    Friend WithEvents comboClassNum As ComboBox
    Friend Protected WithEvents Label2 As Label
    Friend Protected WithEvents Label3 As Label
    Friend WithEvents comboYear As ComboBox
    Friend Protected WithEvents Label4 As Label
    Friend WithEvents comboSection As ComboBox
    Friend Protected WithEvents Label5 As Label
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dataGridClass As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
    Friend WithEvents col4 As DataGridViewTextBoxColumn
End Class
