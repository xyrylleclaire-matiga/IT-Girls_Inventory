<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminAddUser
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
        txtRole = New TextBox()
        txtPassword = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        txtAdminID = New TextBox()
        lblDateAdded = New Label()
        lblStatus = New Label()
        Panel2 = New Panel()
        btnAdd = New Button()
        Button1 = New Button()
        btnBack = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(txtRole)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtMiddleName)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Controls.Add(txtLastName)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtAdminID)
        Panel1.Controls.Add(lblDateAdded)
        Panel1.Controls.Add(lblStatus)
        Panel1.Location = New Point(46, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 443)
        Panel1.TabIndex = 0
        ' 
        ' txtRole
        ' 
        txtRole.BackColor = Color.DarkSlateGray
        txtRole.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtRole.ForeColor = SystemColors.Info
        txtRole.Location = New Point(240, 382)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(175, 23)
        txtRole.TabIndex = 1033
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkSlateGray
        txtPassword.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtPassword.ForeColor = SystemColors.Info
        txtPassword.Location = New Point(240, 336)
        txtPassword.Name = "txtPassword"
        txtPassword.ReadOnly = True
        txtPassword.Size = New Size(175, 23)
        txtPassword.TabIndex = 1032
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.BackColor = Color.DarkSlateGray
        txtMiddleName.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtMiddleName.ForeColor = SystemColors.Info
        txtMiddleName.Location = New Point(240, 291)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(175, 23)
        txtMiddleName.TabIndex = 1031
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.DarkSlateGray
        txtFirstName.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtFirstName.ForeColor = SystemColors.Info
        txtFirstName.Location = New Point(240, 249)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(175, 23)
        txtFirstName.TabIndex = 1030
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.DarkSlateGray
        txtLastName.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtLastName.ForeColor = SystemColors.Info
        txtLastName.Location = New Point(240, 206)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(175, 23)
        txtLastName.TabIndex = 1029
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(108, 387)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 19)
        Label7.TabIndex = 1028
        Label7.Text = "Role :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(107, 252)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 19)
        Label6.TabIndex = 1027
        Label6.Text = "First Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(104, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 19)
        Label5.TabIndex = 1026
        Label5.Text = "Middle Name :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(106, 339)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 19)
        Label4.TabIndex = 1025
        Label4.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(107, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 19)
        Label3.TabIndex = 1024
        Label3.Text = "Last Name :"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkSlateGray
        txtUsername.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtUsername.ForeColor = SystemColors.Info
        txtUsername.Location = New Point(240, 163)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(175, 23)
        txtUsername.TabIndex = 1023
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(106, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 19)
        Label1.TabIndex = 1022
        Label1.Text = "Username :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.PowderBlue
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Bookman Old Style", 24.0F, FontStyle.Bold)
        TextBox1.ForeColor = Color.DarkSlateGray
        TextBox1.Location = New Point(0, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(526, 45)
        TextBox1.TabIndex = 1000
        TextBox1.Text = "ADD USER"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(107, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 19)
        Label2.TabIndex = 1006
        Label2.Text = "Admin ID :"
        ' 
        ' txtAdminID
        ' 
        txtAdminID.BackColor = Color.DarkSlateGray
        txtAdminID.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtAdminID.ForeColor = SystemColors.Info
        txtAdminID.Location = New Point(240, 121)
        txtAdminID.Name = "txtAdminID"
        txtAdminID.ReadOnly = True
        txtAdminID.Size = New Size(175, 23)
        txtAdminID.TabIndex = 1005
        ' 
        ' lblDateAdded
        ' 
        lblDateAdded.AutoSize = True
        lblDateAdded.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblDateAdded.Location = New Point(206, 415)
        lblDateAdded.Name = "lblDateAdded"
        lblDateAdded.Size = New Size(11, 16)
        lblDateAdded.TabIndex = 1021
        lblDateAdded.Text = " "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblStatus.Location = New Point(206, 382)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 16)
        lblStatus.TabIndex = 1019
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btnBack)
        Panel2.Location = New Point(22, 21)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 545)
        Panel2.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.DarkSeaGreen
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.DarkSlateGray
        btnAdd.Location = New Point(24, 495)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(260, 35)
        btnAdd.TabIndex = 1036
        btnAdd.Text = "ADD USER"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(238, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 35)
        Button1.TabIndex = 1035
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.DarkSlateGray
        btnBack.Location = New Point(290, 495)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(260, 35)
        btnBack.TabIndex = 1034
        btnBack.Text = "BACK TO HOME"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmAdminAddUser
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(620, 587)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "frmAdminAddUser"
        Text = "frmAdminAddUser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdminID As TextBox
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents Button1 As Button
    Private WithEvents btnBack As Button
    Private WithEvents btnAdd As Button
End Class
