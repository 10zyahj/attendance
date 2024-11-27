<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form13))
        Label20 = New Label()
        txtBody = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        buttonSend = New Button()
        buttonClear = New Button()
        txtTo = New TextBox()
        txtSubject = New TextBox()
        SuspendLayout()
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = SystemColors.Control
        Label20.Location = New Point(229, 55)
        Label20.Name = "Label20"
        Label20.Size = New Size(253, 42)
        Label20.TabIndex = 92
        Label20.Text = "SEND EMAIL"
        ' 
        ' txtBody
        ' 
        txtBody.BorderStyle = BorderStyle.FixedSingle
        txtBody.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtBody.Location = New Point(165, 237)
        txtBody.Margin = New Padding(4, 3, 4, 3)
        txtBody.Multiline = True
        txtBody.Name = "txtBody"
        txtBody.Size = New Size(399, 221)
        txtBody.TabIndex = 97
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(65, 148)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 20)
        Label2.TabIndex = 100
        Label2.Text = "TO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(65, 194)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 101
        Label3.Text = "SUBJECT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(65, 237)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 102
        Label4.Text = "MESSAGE"
        ' 
        ' buttonSend
        ' 
        buttonSend.BackColor = Color.White
        buttonSend.FlatStyle = FlatStyle.Flat
        buttonSend.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonSend.ForeColor = Color.DarkRed
        buttonSend.Location = New Point(371, 478)
        buttonSend.Margin = New Padding(4, 3, 4, 3)
        buttonSend.Name = "buttonSend"
        buttonSend.Size = New Size(193, 41)
        buttonSend.TabIndex = 103
        buttonSend.Text = "SEND"
        buttonSend.UseVisualStyleBackColor = False
        ' 
        ' buttonClear
        ' 
        buttonClear.BackColor = Color.Firebrick
        buttonClear.FlatStyle = FlatStyle.Flat
        buttonClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        buttonClear.ForeColor = Color.White
        buttonClear.Location = New Point(165, 478)
        buttonClear.Margin = New Padding(4, 3, 4, 3)
        buttonClear.Name = "buttonClear"
        buttonClear.Size = New Size(193, 41)
        buttonClear.TabIndex = 104
        buttonClear.Text = "CLEAR"
        buttonClear.UseVisualStyleBackColor = False
        ' 
        ' txtTo
        ' 
        txtTo.BorderStyle = BorderStyle.FixedSingle
        txtTo.Location = New Point(165, 146)
        txtTo.Multiline = True
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(399, 29)
        txtTo.TabIndex = 105
        ' 
        ' txtSubject
        ' 
        txtSubject.BorderStyle = BorderStyle.FixedSingle
        txtSubject.Location = New Point(165, 192)
        txtSubject.Multiline = True
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(399, 29)
        txtSubject.TabIndex = 106
        ' 
        ' Form13
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(711, 591)
        Controls.Add(txtSubject)
        Controls.Add(txtTo)
        Controls.Add(buttonClear)
        Controls.Add(buttonSend)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtBody)
        Controls.Add(Label20)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form13"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents txtMessage As TextBox
    Protected Friend WithEvents Label2 As Label
    Protected Friend WithEvents Label3 As Label
    Protected Friend WithEvents Label4 As Label
    Friend WithEvents buttonSend As Button
    Friend WithEvents buttonClear As Button
    Friend WithEvents txtBody As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtSubject As TextBox
End Class
