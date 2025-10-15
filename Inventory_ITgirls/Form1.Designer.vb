<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        txtStudentID = New TextBox()
        PictureBox2 = New PictureBox()
        btnDone = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(41, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(514, 372)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtStudentID
        ' 
        txtStudentID.BackColor = Color.LightCyan
        txtStudentID.BorderStyle = BorderStyle.None
        txtStudentID.ForeColor = Color.MidnightBlue
        txtStudentID.Location = New Point(180, 199)
        txtStudentID.Multiline = True
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(217, 28)
        txtStudentID.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.LightCyan
        PictureBox2.Location = New Point(554, 40)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(188, 372)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.DarkSlateGray
        btnDone.FlatStyle = FlatStyle.Flat
        btnDone.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDone.ForeColor = Color.White
        btnDone.Location = New Point(239, 333)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(98, 37)
        btnDone.TabIndex = 2
        btnDone.Text = "DONE"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.LightCyan
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.MidnightBlue
        txtPassword.Location = New Point(180, 273)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(217, 28)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(205, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 55)
        Label1.TabIndex = 7
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 9F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(177, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 14)
        Label2.TabIndex = 8
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 9F)
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(176, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 14)
        Label3.TabIndex = 9
        Label3.Text = "STUDENT ID"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DarkSlateGray
        PictureBox3.Location = New Point(603, 40)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(139, 372)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.LightCyan
        PictureBox4.Location = New Point(617, 40)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(11, 372)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(btnDone)
        Controls.Add(PictureBox2)
        Controls.Add(txtStudentID)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnDone As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
