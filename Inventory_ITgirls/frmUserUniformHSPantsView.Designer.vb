﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserUniformHSPantsView
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
        cmbSizes = New ComboBox()
        lblStatus = New Label()
        lblPrice = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnBack = New Button()
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(cmbSizes)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(368, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 358)
        Panel1.TabIndex = 22
        ' 
        ' cmbSizes
        ' 
        cmbSizes.BackColor = Color.LightCyan
        cmbSizes.FormattingEnabled = True
        cmbSizes.Items.AddRange(New Object() {"EXTRA SMALL", "SMALL", "MEDIUM", "LARGE", "EXTRA LARGE", "2XL", "3XL", "4XL", "5XL", "6XL"})
        cmbSizes.Location = New Point(75, 255)
        cmbSizes.Name = "cmbSizes"
        cmbSizes.Size = New Size(173, 23)
        cmbSizes.TabIndex = 81
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(417, 255)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(43, 35)
        lblStatus.TabIndex = 80
        lblStatus.Text = "—"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.LightCyan
        lblPrice.Font = New Font("Arial Rounded MT Bold", 20F)
        lblPrice.ForeColor = SystemColors.ActiveCaptionText
        lblPrice.Location = New Point(93, 81)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 32)
        lblPrice.TabIndex = 79
        lblPrice.Text = "— "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(67, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 28)
        Label8.TabIndex = 77
        Label8.Text = "₱"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(395, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 71
        Label4.Text = "STATUS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(62, 237)
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
        Label2.Size = New Size(725, 32)
        Label2.TabIndex = 67
        Label2.Text = "HIGH SCHOOL AND SENIOR HIGH SCHOOL UNIFORM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(386, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 2
        Label1.Text = "GENDER"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(1025, 432)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 35
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2025_10_30_20_22_47_removebg_preview
        PictureBox1.Location = New Point(34, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(402, 456)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.LightCyan
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"POLO", "BLOUSE", "TROUSERS", "SKIRT"})
        ComboBox1.Location = New Point(75, 167)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(173, 23)
        ComboBox1.TabIndex = 82
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(60, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 83
        Label5.Text = "ITEM"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.LightCyan
        RadioButton1.ForeColor = SystemColors.ActiveCaptionText
        RadioButton1.Location = New Point(23, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(68, 19)
        RadioButton1.TabIndex = 84
        RadioButton1.TabStop = True
        RadioButton1.Text = "FEMALE"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = SystemColors.ActiveCaptionText
        RadioButton2.Location = New Point(123, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 19)
        RadioButton2.TabIndex = 85
        RadioButton2.TabStop = True
        RadioButton2.Text = "MALE"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Location = New Point(386, 167)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 23)
        Panel2.TabIndex = 86
        ' 
        ' frmUserUniformHSPantsView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 480)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "frmUserUniformHSPantsView"
        Text = "frmHSUnifPants"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Private WithEvents btnBack As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbSizes As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel2 As Panel
End Class
