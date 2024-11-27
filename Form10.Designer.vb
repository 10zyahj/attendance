<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label16 = New Label()
        DataGridView2 = New DataGridView()
        btnCheckAttendance = New Button()
        Label1 = New Label()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = SystemColors.Control
        Label16.Location = New Point(281, 55)
        Label16.Name = "Label16"
        Label16.Size = New Size(391, 42)
        Label16.TabIndex = 77
        Label16.Text = "VIEW ATTENDANCE"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToOrderColumns = True
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(37, 227)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(878, 463)
        DataGridView2.TabIndex = 76
        ' 
        ' btnCheckAttendance
        ' 
        btnCheckAttendance.BackColor = Color.Tomato
        btnCheckAttendance.FlatAppearance.BorderSize = 0
        btnCheckAttendance.FlatStyle = FlatStyle.Flat
        btnCheckAttendance.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCheckAttendance.ForeColor = Color.White
        btnCheckAttendance.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckAttendance.Location = New Point(769, 12)
        btnCheckAttendance.Margin = New Padding(4, 3, 4, 3)
        btnCheckAttendance.Name = "btnCheckAttendance"
        btnCheckAttendance.Size = New Size(171, 49)
        btnCheckAttendance.TabIndex = 108
        btnCheckAttendance.Text = "Check Attendance"
        btnCheckAttendance.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCheckAttendance.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(372, 111)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 117
        Label1.Text = "SEMESTER"
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(953, 728)
        Controls.Add(Label1)
        Controls.Add(btnCheckAttendance)
        Controls.Add(Label16)
        Controls.Add(DataGridView2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form10"
        Text = "Form10"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCheckAttendance As Button
    Friend Protected WithEvents Label1 As Label
End Class
