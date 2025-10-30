<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserCorpoCOAView
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
        Panel1 = New Panel()
        cmbGender = New ComboBox()
        lblPrice = New Label()
        lblStatus = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        btnBack = New Button()
        cmbSizes = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(125, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 438)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(cmbSizes)
        Panel1.Controls.Add(cmbGender)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(388, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 375)
        Panel1.TabIndex = 16
        ' 
        ' cmbGender
        ' 
        cmbGender.BackColor = Color.LightCyan
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"FEMALE ", "MALE"})
        cmbGender.Location = New Point(62, 127)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(173, 23)
        cmbGender.TabIndex = 77
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.LightCyan
        lblPrice.Font = New Font("Arial Rounded MT Bold", 20F)
        lblPrice.ForeColor = SystemColors.ActiveCaptionText
        lblPrice.Location = New Point(324, 18)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 32)
        lblPrice.TabIndex = 76
        lblPrice.Text = "— "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(87, 264)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(43, 35)
        lblStatus.TabIndex = 74
        lblStatus.Text = "—"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(38, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(178, 18)
        Label6.TabIndex = 73
        Label6.Text = "CORPORATE ATTIRE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(49, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 71
        Label4.Text = "STATUS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(49, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 69
        Label3.Text = "SIZES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 32)
        Label2.TabIndex = 67
        Label2.Text = "ACCOUNTANCY"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(49, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 2
        Label1.Text = "GENDER"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(304, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 28)
        Label8.TabIndex = 75
        Label8.Text = "₱"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(974, 432)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 35
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' cmbSizes
        ' 
        cmbSizes.BackColor = Color.LightCyan
        cmbSizes.FormattingEnabled = True
        cmbSizes.Items.AddRange(New Object() {"EXTRA SMALL", "SMALL", "MEDIUM", "LARGE", "EXTRA LARGE", "2XL", "3XL", "4XL", "5XL", "6XL"})
        cmbSizes.Location = New Point(62, 197)
        cmbSizes.Name = "cmbSizes"
        cmbSizes.Size = New Size(173, 23)
        cmbSizes.TabIndex = 84
        ' 
        ' frmUserCorpoCOAView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 480)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmUserCorpoCOAView"
        Text = "frmCOACorpoView"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Private WithEvents btnBack As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbSizes As ComboBox
End Class
