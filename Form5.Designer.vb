<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnClear = New Button()
        btnSave = New Button()
        day = New DateTimePicker()
        Label20 = New Label()
        btnViewAttendance = New Button()
        lblLate = New Label()
        lblAbsent = New Label()
        lblPresent = New Label()
        lblNumStud = New Label()
        datagrid = New DataGridView()
        CType(datagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Firebrick
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(64, 636)
        btnClear.Margin = New Padding(4, 3, 4, 3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(396, 44)
        btnClear.TabIndex = 106
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.DarkRed
        btnSave.Location = New Point(477, 636)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(396, 44)
        btnSave.TabIndex = 105
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' day
        ' 
        day.AllowDrop = True
        day.Location = New Point(352, 105)
        day.Name = "day"
        day.Size = New Size(250, 27)
        day.TabIndex = 92
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = SystemColors.Control
        Label20.Location = New Point(263, 50)
        Label20.Name = "Label20"
        Label20.Size = New Size(429, 42)
        Label20.TabIndex = 91
        Label20.Text = "CHECK ATTENDANCE"
        ' 
        ' btnViewAttendance
        ' 
        btnViewAttendance.BackColor = Color.Tomato
        btnViewAttendance.FlatAppearance.BorderSize = 0
        btnViewAttendance.FlatStyle = FlatStyle.Flat
        btnViewAttendance.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewAttendance.ForeColor = Color.White
        btnViewAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnViewAttendance.Location = New Point(772, 12)
        btnViewAttendance.Margin = New Padding(4, 3, 4, 3)
        btnViewAttendance.Name = "btnViewAttendance"
        btnViewAttendance.Size = New Size(168, 49)
        btnViewAttendance.TabIndex = 109
        btnViewAttendance.Text = "View Attendance"
        btnViewAttendance.TextImageRelation = TextImageRelation.ImageBeforeText
        btnViewAttendance.UseVisualStyleBackColor = False
        ' 
        ' lblLate
        ' 
        lblLate.AutoSize = True
        lblLate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblLate.ForeColor = Color.White
        lblLate.Location = New Point(788, 593)
        lblLate.Margin = New Padding(4, 0, 4, 0)
        lblLate.Name = "lblLate"
        lblLate.Size = New Size(43, 18)
        lblLate.TabIndex = 125
        lblLate.Text = "       "
        ' 
        ' lblAbsent
        ' 
        lblAbsent.AutoSize = True
        lblAbsent.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblAbsent.ForeColor = Color.White
        lblAbsent.Location = New Point(600, 593)
        lblAbsent.Margin = New Padding(4, 0, 4, 0)
        lblAbsent.Name = "lblAbsent"
        lblAbsent.Size = New Size(43, 18)
        lblAbsent.TabIndex = 124
        lblAbsent.Text = "       "
        ' 
        ' lblPresent
        ' 
        lblPresent.AutoSize = True
        lblPresent.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblPresent.ForeColor = Color.White
        lblPresent.Location = New Point(417, 593)
        lblPresent.Margin = New Padding(4, 0, 4, 0)
        lblPresent.Name = "lblPresent"
        lblPresent.Size = New Size(43, 18)
        lblPresent.TabIndex = 123
        lblPresent.Text = "       "
        ' 
        ' lblNumStud
        ' 
        lblNumStud.AutoSize = True
        lblNumStud.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumStud.ForeColor = Color.White
        lblNumStud.Location = New Point(232, 593)
        lblNumStud.Margin = New Padding(4, 0, 4, 0)
        lblNumStud.Name = "lblNumStud"
        lblNumStud.Size = New Size(43, 18)
        lblNumStud.TabIndex = 122
        lblNumStud.Text = "       "
        ' 
        ' datagrid
        ' 
        datagrid.AllowUserToAddRows = False
        datagrid.BackgroundColor = SystemColors.Control
        datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datagrid.Location = New Point(64, 208)
        datagrid.Name = "datagrid"
        datagrid.RowHeadersWidth = 51
        datagrid.RowTemplate.Height = 29
        datagrid.Size = New Size(809, 355)
        datagrid.TabIndex = 129
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(953, 728)
        Controls.Add(datagrid)
        Controls.Add(lblLate)
        Controls.Add(lblAbsent)
        Controls.Add(lblPresent)
        Controls.Add(lblNumStud)
        Controls.Add(btnViewAttendance)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(day)
        Controls.Add(Label20)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        Text = "Form5"
        CType(datagrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend Protected WithEvents Label9 As Label
    Friend WithEvents day As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents btnViewAttendance As Button
    Friend Protected WithEvents lblLate As Label
    Friend Protected WithEvents lblAbsent As Label
    Friend Protected WithEvents lblPresent As Label
    Friend Protected WithEvents lblNumStud As Label
    Friend WithEvents datagrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents comboYear As ComboBox
    Friend WithEvents comboCourse As ComboBox
    Friend WithEvents comboSection As ComboBox
    Friend WithEvents comboClass1 As ComboBox
    Friend WithEvents txtSection1 As TextBox
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtYear1 As TextBox
    Friend WithEvents col7 As DataGridViewImageColumn
End Class
