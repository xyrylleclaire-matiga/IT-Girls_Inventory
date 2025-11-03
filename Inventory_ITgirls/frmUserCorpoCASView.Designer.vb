<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserCorpoCASView
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
        btnBack = New Button()
        Panel1 = New Panel()
        rdoU = New RadioButton()
        Panel2 = New Panel()
        rdoF = New RadioButton()
        rdoM = New RadioButton()
        Label6 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        cmbItemName = New ComboBox()
        lblPrice = New Label()
        cmbSizes = New ComboBox()
        Label1 = New Label()
        lblStatus = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(980, 432)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 34
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(rdoU)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cmbItemName)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(cmbSizes)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(413, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 375)
        Panel1.TabIndex = 36
        ' 
        ' rdoU
        ' 
        rdoU.AutoSize = True
        rdoU.BackColor = Color.LightCyan
        rdoU.ForeColor = SystemColors.ActiveCaptionText
        rdoU.Location = New Point(544, 178)
        rdoU.Name = "rdoU"
        rdoU.Size = New Size(64, 19)
        rdoU.TabIndex = 86
        rdoU.TabStop = True
        rdoU.Text = "UNISEX"
        rdoU.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(rdoF)
        Panel2.Controls.Add(rdoM)
        Panel2.Location = New Point(391, 176)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(221, 23)
        Panel2.TabIndex = 96
        ' 
        ' rdoF
        ' 
        rdoF.AutoSize = True
        rdoF.BackColor = Color.LightCyan
        rdoF.ForeColor = SystemColors.ActiveCaptionText
        rdoF.Location = New Point(11, 2)
        rdoF.Name = "rdoF"
        rdoF.Size = New Size(68, 19)
        rdoF.TabIndex = 84
        rdoF.TabStop = True
        rdoF.Text = "FEMALE"
        rdoF.UseVisualStyleBackColor = False
        ' 
        ' rdoM
        ' 
        rdoM.AutoSize = True
        rdoM.ForeColor = SystemColors.ActiveCaptionText
        rdoM.Location = New Point(85, 2)
        rdoM.Name = "rdoM"
        rdoM.Size = New Size(56, 19)
        rdoM.TabIndex = 85
        rdoM.TabStop = True
        rdoM.Text = "MALE"
        rdoM.UseVisualStyleBackColor = True
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(65, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 95
        Label5.Text = "ITEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(298, 32)
        Label2.TabIndex = 67
        Label2.Text = "ARTS  AND  SCIENCE"
        ' 
        ' cmbItemName
        ' 
        cmbItemName.BackColor = Color.LightCyan
        cmbItemName.FormattingEnabled = True
        cmbItemName.Items.AddRange(New Object() {"Blouse", "Skirt", "Slacks"})
        cmbItemName.Location = New Point(80, 176)
        cmbItemName.Name = "cmbItemName"
        cmbItemName.Size = New Size(173, 23)
        cmbItemName.TabIndex = 94
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.LightCyan
        lblPrice.Font = New Font("Arial Rounded MT Bold", 20F)
        lblPrice.ForeColor = SystemColors.ActiveCaptionText
        lblPrice.Location = New Point(98, 90)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 32)
        lblPrice.TabIndex = 91
        lblPrice.Text = "— "
        ' 
        ' cmbSizes
        ' 
        cmbSizes.BackColor = Color.LightCyan
        cmbSizes.FormattingEnabled = True
        cmbSizes.Items.AddRange(New Object() {"EXTRA SMALL", "SMALL", "MEDIUM", "LARGE", "EXTRA LARGE", "2XL", "3XL", "4XL", "5XL", "6XL"})
        cmbSizes.Location = New Point(80, 264)
        cmbSizes.Name = "cmbSizes"
        cmbSizes.Size = New Size(173, 23)
        cmbSizes.TabIndex = 93
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(391, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 87
        Label1.Text = "GENDER"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(422, 264)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(43, 35)
        lblStatus.TabIndex = 92
        lblStatus.Text = "—"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(67, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 88
        Label3.Text = "SIZES"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(400, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 89
        Label4.Text = "STATUS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(72, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 28)
        Label8.TabIndex = 90
        Label8.Text = "₱"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_10_30_20_23_00_removebg_preview
        PictureBox1.Location = New Point(111, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(329, 423)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' frmUserCorpoCASView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 480)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(btnBack)
        Name = "frmUserCorpoCASView"
        Text = "frmUserCorpoCASView"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Private WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdoU As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdoF As RadioButton
    Friend WithEvents rdoM As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbSizes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
