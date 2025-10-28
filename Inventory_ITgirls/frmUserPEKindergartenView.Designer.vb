<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserPEKindergartenView
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
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        Panel1 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(129, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 375)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(75, 165)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(173, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(392, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 375)
        Panel1.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(40, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 18)
        Label6.TabIndex = 73
        Label6.Text = "T-SHIRT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(62, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 71
        Label4.Text = "STATUS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(62, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 69
        Label3.Text = "SIZES"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(75, 235)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(173, 23)
        ComboBox2.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(578, 43)
        Label2.TabIndex = 67
        Label2.Text = "KINDERGARTEN PE UNIFORM "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(62, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 2
        Label1.Text = "GENDER"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumTurquoise
        Label7.Font = New Font("Arial Rounded MT Bold", 20F)
        Label7.Location = New Point(83, 92)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 32)
        Label7.TabIndex = 78
        Label7.Text = "100,000"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(62, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 28)
        Label8.TabIndex = 79
        Label8.Text = "₱"
        ' 
        ' frmPEKindergartenView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 431)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frmPEKindergartenView"
        Text = "frmPEKindergartenView"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
