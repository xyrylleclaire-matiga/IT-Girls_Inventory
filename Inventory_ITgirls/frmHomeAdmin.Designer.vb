<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeAdmin))
        PanelMain = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        btnCorporateAttire = New Button()
        picCorpo = New PictureBox()
        btnSchoolUniform = New Button()
        Label1 = New Label()
        btnPeUniform = New Button()
        PictureBox2 = New PictureBox()
        picPEUniform = New PictureBox()
        Panel17 = New Panel()
        Panel4 = New Panel()
        Button4 = New Button()
        lblPendingRequest = New Label()
        picSchoolUniform = New PictureBox()
        Panel16 = New Panel()
        Panel3 = New Panel()
        Button3 = New Button()
        lblTotalStocks = New Label()
        Panel15 = New Panel()
        Panel5 = New Panel()
        Button2 = New Button()
        lblTotalPullouts = New Label()
        Panel6 = New Panel()
        PanelLowStock = New Panel()
        Button1 = New Button()
        lblLowStockAlerts = New Label()
        PanelMain.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        Panel17.SuspendLayout()
        Panel4.SuspendLayout()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        Panel16.SuspendLayout()
        Panel3.SuspendLayout()
        Panel15.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        PanelLowStock.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.LightCyan
        PanelMain.Controls.Add(Label2)
        PanelMain.Controls.Add(PictureBox3)
        PanelMain.Controls.Add(btnCorporateAttire)
        PanelMain.Controls.Add(picCorpo)
        PanelMain.Controls.Add(btnSchoolUniform)
        PanelMain.Controls.Add(Label1)
        PanelMain.Controls.Add(btnPeUniform)
        PanelMain.Controls.Add(PictureBox2)
        PanelMain.Controls.Add(picPEUniform)
        PanelMain.Controls.Add(Panel17)
        PanelMain.Controls.Add(picSchoolUniform)
        PanelMain.Controls.Add(Panel16)
        PanelMain.Controls.Add(Panel15)
        PanelMain.Controls.Add(Panel6)
        PanelMain.Location = New Point(-4, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1054, 667)
        PanelMain.TabIndex = 61
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSlateGray
        Label2.Font = New Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LightCyan
        Label2.Location = New Point(367, 41)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(410, 26)
        Label2.TabIndex = 78
        Label2.Text = "INVENTORY MANAGEMENT SYSTEM"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DarkSlateGray
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(268, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 70)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 80
        PictureBox3.TabStop = False
        ' 
        ' btnCorporateAttire
        ' 
        btnCorporateAttire.BackColor = Color.DarkSlateGray
        btnCorporateAttire.FlatStyle = FlatStyle.Popup
        btnCorporateAttire.Font = New Font("Arial Rounded MT Bold", 16F)
        btnCorporateAttire.ForeColor = Color.MintCream
        btnCorporateAttire.Location = New Point(686, 561)
        btnCorporateAttire.Name = "btnCorporateAttire"
        btnCorporateAttire.Size = New Size(254, 38)
        btnCorporateAttire.TabIndex = 69
        btnCorporateAttire.Text = "CORPORATE ATTIRE"
        btnCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.LightGray
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(668, 277)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(272, 364)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 68
        picCorpo.TabStop = False
        ' 
        ' btnSchoolUniform
        ' 
        btnSchoolUniform.BackColor = Color.DarkSlateGray
        btnSchoolUniform.FlatStyle = FlatStyle.Popup
        btnSchoolUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnSchoolUniform.ForeColor = Color.MintCream
        btnSchoolUniform.Location = New Point(398, 572)
        btnSchoolUniform.Name = "btnSchoolUniform"
        btnSchoolUniform.Size = New Size(264, 38)
        btnSchoolUniform.TabIndex = 67
        btnSchoolUniform.Text = "SCHOOL UNIFORM"
        btnSchoolUniform.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateGray
        Label1.Font = New Font("Perpetua", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(471, 24)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 17)
        Label1.TabIndex = 76
        Label1.Text = "BOOKSTORE DEPARTMENT"
        ' 
        ' btnPeUniform
        ' 
        btnPeUniform.BackColor = Color.DarkSlateGray
        btnPeUniform.FlatStyle = FlatStyle.Popup
        btnPeUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnPeUniform.ForeColor = Color.MintCream
        btnPeUniform.Location = New Point(130, 561)
        btnPeUniform.Name = "btnPeUniform"
        btnPeUniform.Size = New Size(246, 38)
        btnPeUniform.TabIndex = 66
        btnPeUniform.Text = "PE UNIFORM"
        btnPeUniform.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkSlateGray
        PictureBox2.Location = New Point(-19, 0)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1077, 72)
        PictureBox2.TabIndex = 75
        PictureBox2.TabStop = False
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.LightGray
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = CType(resources.GetObject("picPEUniform.Image"), Image)
        picPEUniform.Location = New Point(113, 277)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(275, 364)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 64
        picPEUniform.TabStop = False
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.DarkSlateGray
        Panel17.Controls.Add(Panel4)
        Panel17.Location = New Point(789, 86)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(224, 137)
        Panel17.TabIndex = 70
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightCyan
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(lblPendingRequest)
        Panel4.Location = New Point(21, 13)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(189, 116)
        Panel4.TabIndex = 71
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(9, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(116, 27)
        Button4.TabIndex = 27
        Button4.Text = "Pending Requests"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblPendingRequest
        ' 
        lblPendingRequest.AutoSize = True
        lblPendingRequest.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPendingRequest.ForeColor = SystemColors.ActiveCaptionText
        lblPendingRequest.Location = New Point(137, 69)
        lblPendingRequest.Name = "lblPendingRequest"
        lblPendingRequest.Size = New Size(20, 25)
        lblPendingRequest.TabIndex = 26
        lblPendingRequest.Text = "-"
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(388, 255)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 401)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 65
        picSchoolUniform.TabStop = False
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.DarkGoldenrod
        Panel16.Controls.Add(Panel3)
        Panel16.Location = New Point(535, 86)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(224, 137)
        Panel16.TabIndex = 29
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Beige
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(lblTotalStocks)
        Panel3.Location = New Point(23, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(183, 116)
        Panel3.TabIndex = 69
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGoldenrod
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(7, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 27)
        Button3.TabIndex = 28
        Button3.Text = "Total Stocks"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' lblTotalStocks
        ' 
        lblTotalStocks.AutoSize = True
        lblTotalStocks.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalStocks.ForeColor = SystemColors.ActiveCaptionText
        lblTotalStocks.Location = New Point(135, 75)
        lblTotalStocks.Name = "lblTotalStocks"
        lblTotalStocks.Size = New Size(20, 25)
        lblTotalStocks.TabIndex = 26
        lblTotalStocks.Text = "-"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.SeaGreen
        Panel15.Controls.Add(Panel5)
        Panel15.Location = New Point(284, 86)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(224, 137)
        Panel15.TabIndex = 73
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Honeydew
        Panel5.Controls.Add(Button2)
        Panel5.Controls.Add(lblTotalPullouts)
        Panel5.Location = New Point(26, 11)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(183, 116)
        Panel5.TabIndex = 70
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(7, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 23)
        Button2.TabIndex = 27
        Button2.Text = "Total Pullouts"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblTotalPullouts
        ' 
        lblTotalPullouts.AutoSize = True
        lblTotalPullouts.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPullouts.ForeColor = SystemColors.ActiveCaptionText
        lblTotalPullouts.Location = New Point(125, 80)
        lblTotalPullouts.Name = "lblTotalPullouts"
        lblTotalPullouts.Size = New Size(20, 25)
        lblTotalPullouts.TabIndex = 26
        lblTotalPullouts.Text = "-"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Brown
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(PanelLowStock)
        Panel6.Location = New Point(33, 86)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(224, 137)
        Panel6.TabIndex = 72
        ' 
        ' PanelLowStock
        ' 
        PanelLowStock.BackColor = Color.MistyRose
        PanelLowStock.Controls.Add(Button1)
        PanelLowStock.Controls.Add(lblLowStockAlerts)
        PanelLowStock.Location = New Point(21, 9)
        PanelLowStock.Name = "PanelLowStock"
        PanelLowStock.Size = New Size(183, 116)
        PanelLowStock.TabIndex = 68
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(8, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 23)
        Button1.TabIndex = 26
        Button1.Text = "Low Stock Alerts"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblLowStockAlerts
        ' 
        lblLowStockAlerts.AutoSize = True
        lblLowStockAlerts.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLowStockAlerts.ForeColor = SystemColors.ActiveCaptionText
        lblLowStockAlerts.Location = New Point(122, 79)
        lblLowStockAlerts.Name = "lblLowStockAlerts"
        lblLowStockAlerts.Size = New Size(20, 25)
        lblLowStockAlerts.TabIndex = 25
        lblLowStockAlerts.Text = "-"
        ' 
        ' frmHomeAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 693)
        Controls.Add(PanelMain)
        Name = "frmHomeAdmin"
        Text = "frmHomeAdmin"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        Panel17.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        Panel16.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        PanelLowStock.ResumeLayout(False)
        PanelLowStock.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents lblPendingRequest As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents lblTotalStocks As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTotalPullouts As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelLowStock As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLowStockAlerts As Label
    Friend WithEvents btnCorporateAttire As Button
    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents btnSchoolUniform As Button
    Friend WithEvents btnPeUniform As Button
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
