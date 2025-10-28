<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserCollegeUniformTopView
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
        Label5 = New Label()
        Label4 = New Label()
        ComboBox3 = New ComboBox()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(37, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 375)
        PictureBox1.TabIndex = 17
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
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(300, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 375)
        Panel1.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(40, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 18)
        Label6.TabIndex = 73
        Label6.Text = "BLOUSE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumTurquoise
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(62, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 72
        Label5.Text = "100,000"
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
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(75, 301)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(173, 23)
        ComboBox3.TabIndex = 70
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
        Label2.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(403, 32)
        Label2.TabIndex = 67
        Label2.Text = "COLLEGE SCHOOL UNIFORM"
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
        ' frmUserCollegeUniformTopView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1130, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmUserCollegeUniformTopView"
        Text = "frmCollegeUniform"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
