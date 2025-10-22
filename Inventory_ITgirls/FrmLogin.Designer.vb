<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        lblTitle = New Label()
        lblStudentID = New Label()
        lblPassword = New Label()
        txtID = New TextBox()
        txtPassword = New TextBox()
        chkShowPass = New CheckBox()
        btnDone = New Button()
        lblError = New Label()
        lblAttempts = New Label()
        pnlLeftAccent = New Panel()
        pnlRightAccent = New Panel()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.LightCyan
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Controls.Add(lblStudentID)
        pnlMain.Controls.Add(lblPassword)
        pnlMain.Controls.Add(txtID)
        pnlMain.Controls.Add(txtPassword)
        pnlMain.Controls.Add(chkShowPass)
        pnlMain.Controls.Add(btnDone)
        pnlMain.Controls.Add(lblError)
        pnlMain.Location = New Point(200, 60)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(400, 330)
        pnlMain.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 28.0F)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(125, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(143, 44)
        lblTitle.TabIndex = 0
        lblTitle.Text = "LOGIN"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Arial Rounded MT Bold", 10.0F)
        lblStudentID.ForeColor = Color.DarkSlateGray
        lblStudentID.Location = New Point(65, 100)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(93, 16)
        lblStudentID.TabIndex = 1
        lblStudentID.Text = "STUDENT ID"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial Rounded MT Bold", 10.0F)
        lblPassword.ForeColor = Color.DarkSlateGray
        lblPassword.Location = New Point(65, 170)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(88, 16)
        lblPassword.TabIndex = 2
        lblPassword.Text = "PASSWORD"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.White
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Font = New Font("Arial Rounded MT Bold", 11.0F)
        txtID.ForeColor = Color.MidnightBlue
        txtID.Location = New Point(65, 120)
        txtID.Name = "txtID"
        txtID.Size = New Size(270, 24)
        txtID.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Arial Rounded MT Bold", 11.0F)
        txtPassword.ForeColor = Color.MidnightBlue
        txtPassword.Location = New Point(65, 190)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(270, 24)
        txtPassword.TabIndex = 4
        ' 
        ' chkShowPass
        ' 
        chkShowPass.AutoSize = True
        chkShowPass.Font = New Font("Arial", 8.5F)
        chkShowPass.ForeColor = Color.DarkSlateGray
        chkShowPass.Location = New Point(65, 220)
        chkShowPass.Name = "chkShowPass"
        chkShowPass.Size = New Size(116, 19)
        chkShowPass.TabIndex = 5
        chkShowPass.Text = "Show Password"
        chkShowPass.UseVisualStyleBackColor = True
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.DarkSlateGray
        btnDone.FlatAppearance.BorderSize = 0
        btnDone.FlatAppearance.MouseOverBackColor = Color.Teal
        btnDone.FlatStyle = FlatStyle.Flat
        btnDone.Font = New Font("Arial Rounded MT Bold", 10.5F)
        btnDone.ForeColor = Color.White
        btnDone.Location = New Point(135, 260)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(130, 38)
        btnDone.TabIndex = 6
        btnDone.Text = "LOGIN"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Arial", 8.5F, FontStyle.Italic)
        lblError.ForeColor = Color.Red
        lblError.Location = New Point(65, 240)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 15)
        lblError.TabIndex = 7
        ' 
        ' lblAttempts
        ' 
        lblAttempts.AutoSize = True
        lblAttempts.Font = New Font("Arial", 8.5F)
        lblAttempts.ForeColor = Color.DarkSlateGray
        lblAttempts.Location = New Point(710, 420)
        lblAttempts.Name = "lblAttempts"
        lblAttempts.Size = New Size(11, 15)
        lblAttempts.TabIndex = 12
        lblAttempts.Text = "-"
        ' 
        ' pnlLeftAccent
        ' 
        pnlLeftAccent.BackColor = Color.DarkSlateGray
        pnlLeftAccent.Dock = DockStyle.Left
        pnlLeftAccent.Location = New Point(0, 0)
        pnlLeftAccent.Name = "pnlLeftAccent"
        pnlLeftAccent.Size = New Size(80, 450)
        pnlLeftAccent.TabIndex = 1
        ' 
        ' pnlRightAccent
        ' 
        pnlRightAccent.BackColor = Color.DarkSlateGray
        pnlRightAccent.Dock = DockStyle.Right
        pnlRightAccent.Location = New Point(720, 0)
        pnlRightAccent.Name = "pnlRightAccent"
        pnlRightAccent.Size = New Size(80, 450)
        pnlRightAccent.TabIndex = 0
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(pnlRightAccent)
        Controls.Add(pnlLeftAccent)
        Controls.Add(pnlMain)
        Controls.Add(lblAttempts)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Login"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnDone As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents pnlLeftAccent As Panel
    Friend WithEvents pnlRightAccent As Panel
End Class
