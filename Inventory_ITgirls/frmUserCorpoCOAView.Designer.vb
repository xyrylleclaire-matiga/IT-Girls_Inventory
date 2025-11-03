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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserCorpoCOAView))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        rdoU = New RadioButton()
        Label2 = New Label()
        cmbItemName = New ComboBox()
        lblPrice = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        lblStatus = New Label()
        Label3 = New Label()
        cmbSizes = New ComboBox()
        btnBack = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(40, -108)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(362, 644)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cmbItemName)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbSizes)
        Panel1.Location = New Point(388, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 375)
        Panel1.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(57, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 15)
        Label7.TabIndex = 126
        Label7.Text = "ITEM"
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(rdoU)
        Panel2.Location = New Point(383, 190)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(82, 23)
        Panel2.TabIndex = 125
        ' 
        ' rdoU
        ' 
        rdoU.AutoSize = True
        rdoU.ForeColor = SystemColors.ActiveCaptionText
        rdoU.Location = New Point(9, 2)
        rdoU.Name = "rdoU"
        rdoU.Size = New Size(64, 19)
        rdoU.TabIndex = 86
        rdoU.TabStop = True
        rdoU.Text = "UNISEX"
        rdoU.UseVisualStyleBackColor = True
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
        ' cmbItemName
        ' 
        cmbItemName.AutoCompleteCustomSource.AddRange(New String() {"Vest", "Polo", "Slacks"})
        cmbItemName.BackColor = Color.LightCyan
        cmbItemName.FormattingEnabled = True
        cmbItemName.Items.AddRange(New Object() {"Vest", "Polo", "Slacks"})
        cmbItemName.Location = New Point(72, 190)
        cmbItemName.Name = "cmbItemName"
        cmbItemName.Size = New Size(173, 23)
        cmbItemName.TabIndex = 124
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.LightCyan
        lblPrice.Font = New Font("Arial Rounded MT Bold", 20F)
        lblPrice.ForeColor = SystemColors.ActiveCaptionText
        lblPrice.Location = New Point(90, 104)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 32)
        lblPrice.TabIndex = 121
        lblPrice.Text = "— "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(383, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 117
        Label1.Text = "GENDER"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(64, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 28)
        Label8.TabIndex = 120
        Label8.Text = "₱"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(392, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 119
        Label4.Text = "STATUS"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(414, 278)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(43, 35)
        lblStatus.TabIndex = 122
        lblStatus.Text = "—"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(59, 260)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 118
        Label3.Text = "SIZES"
        ' 
        ' cmbSizes
        ' 
        cmbSizes.BackColor = Color.LightCyan
        cmbSizes.FormattingEnabled = True
        cmbSizes.Items.AddRange(New Object() {"EXTRA SMALL", "SMALL", "MEDIUM", "LARGE", "EXTRA LARGE", "2XL", "3XL", "4XL", "5XL", "6XL"})
        cmbSizes.Location = New Point(72, 278)
        cmbSizes.Name = "cmbSizes"
        cmbSizes.Size = New Size(173, 23)
        cmbSizes.TabIndex = 123
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(974, 423)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 35
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmUserCorpoCOAView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 480)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frmUserCorpoCOAView"
        Text = "frmCOACorpoView"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdoU As RadioButton
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSizes As ComboBox
End Class
