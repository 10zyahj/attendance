﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblEmployeeName = New Label()
        txtDepartment = New TextBox()
        pictureEmployee = New PictureBox()
        Label5 = New Label()
        lblEmployeeID = New Label()
        txtSubject = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        txtContactNumber = New TextBox()
        txtEmailAddress = New TextBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(pictureEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblEmployeeName)
        Panel1.Controls.Add(txtDepartment)
        Panel1.Controls.Add(pictureEmployee)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(lblEmployeeID)
        Panel1.Controls.Add(txtSubject)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtContactNumber)
        Panel1.Controls.Add(txtEmailAddress)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(941, 716)
        Panel1.TabIndex = 16
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.FlatStyle = FlatStyle.Flat
        lblEmployeeName.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployeeName.ForeColor = Color.White
        lblEmployeeName.Location = New Point(0, 284)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(955, 41)
        lblEmployeeName.TabIndex = 15
        lblEmployeeName.Text = "EMPLOYEE  FULLNAME"
        lblEmployeeName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtDepartment
        ' 
        txtDepartment.BorderStyle = BorderStyle.FixedSingle
        txtDepartment.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtDepartment.Location = New Point(511, 526)
        txtDepartment.Multiline = True
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(280, 36)
        txtDepartment.TabIndex = 14
        ' 
        ' pictureEmployee
        ' 
        pictureEmployee.Image = My.Resources.Resources.icon
        pictureEmployee.Location = New Point(392, 103)
        pictureEmployee.Name = "pictureEmployee"
        pictureEmployee.Size = New Size(184, 158)
        pictureEmployee.SizeMode = PictureBoxSizeMode.Zoom
        pictureEmployee.TabIndex = 0
        pictureEmployee.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(511, 497)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 23)
        Label5.TabIndex = 13
        Label5.Text = "Department"
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployeeID.ForeColor = Color.White
        lblEmployeeID.Location = New Point(337, 325)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(281, 23)
        lblEmployeeID.TabIndex = 5
        lblEmployeeID.Text = "009988"
        lblEmployeeID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSubject
        ' 
        txtSubject.BorderStyle = BorderStyle.FixedSingle
        txtSubject.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubject.Location = New Point(511, 416)
        txtSubject.Multiline = True
        txtSubject.Name = "txtSubject"
        txtSubject.ReadOnly = True
        txtSubject.Size = New Size(280, 36)
        txtSubject.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(155, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 23)
        Label3.TabIndex = 7
        Label3.Text = "Contact Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(511, 389)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 23)
        Label1.TabIndex = 11
        Label1.Text = "Subject"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BorderStyle = BorderStyle.FixedSingle
        txtContactNumber.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtContactNumber.Location = New Point(155, 416)
        txtContactNumber.Multiline = True
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(280, 36)
        txtContactNumber.TabIndex = 8
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.BorderStyle = BorderStyle.FixedSingle
        txtEmailAddress.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmailAddress.Location = New Point(155, 526)
        txtEmailAddress.Multiline = True
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(280, 36)
        txtEmailAddress.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(155, 497)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 23)
        Label4.TabIndex = 9
        Label4.Text = "Email Address"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(953, 728)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pictureEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents pictureEmployee As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Label4 As Label
End Class
