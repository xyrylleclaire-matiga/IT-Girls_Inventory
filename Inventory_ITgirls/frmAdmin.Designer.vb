<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Label3 = New Label()
        PanelMain = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        btnCorporateAttire = New Button()
        picCorpo = New PictureBox()
        btnSchoolUniform = New Button()
        btnPeUniform = New Button()
        picPEUniform = New PictureBox()
        picSchoolUniform = New PictureBox()
        btnBack = New Button()
        btnSalesReport = New Button()
        btnStockManagement = New Button()
        PictureBox1 = New PictureBox()
        btnHome = New Button()
        btnPullOut = New Button()
        PanelMain.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(791, 356)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 24)
        Label3.TabIndex = 53
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.LightCyan
        PanelMain.Controls.Add(Panel1)
        PanelMain.Location = New Point(204, -1)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1056, 670)
        PanelMain.TabIndex = 58
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnCorporateAttire)
        Panel1.Controls.Add(picCorpo)
        Panel1.Controls.Add(btnSchoolUniform)
        Panel1.Controls.Add(btnPeUniform)
        Panel1.Controls.Add(picPEUniform)
        Panel1.Controls.Add(picSchoolUniform)
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 667)
        Panel1.TabIndex = 60
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(689, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 24)
        Label1.TabIndex = 67
        Label1.Text = "ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(302, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(400, 43)
        Label2.TabIndex = 66
        Label2.Text = "INVENTORY SYSTEM"
        ' 
        ' btnCorporateAttire
        ' 
        btnCorporateAttire.BackColor = Color.DarkSlateGray
        btnCorporateAttire.FlatStyle = FlatStyle.Popup
        btnCorporateAttire.Font = New Font("Arial Rounded MT Bold", 16F)
        btnCorporateAttire.ForeColor = Color.MintCream
        btnCorporateAttire.Location = New Point(688, 395)
        btnCorporateAttire.Name = "btnCorporateAttire"
        btnCorporateAttire.Size = New Size(254, 38)
        btnCorporateAttire.TabIndex = 63
        btnCorporateAttire.Text = "CORPORATE ATTIRE"
        btnCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.LightGray
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(670, 111)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(272, 364)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 62
        picCorpo.TabStop = False
        ' 
        ' btnSchoolUniform
        ' 
        btnSchoolUniform.BackColor = Color.DarkSlateGray
        btnSchoolUniform.FlatStyle = FlatStyle.Popup
        btnSchoolUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnSchoolUniform.ForeColor = Color.MintCream
        btnSchoolUniform.Location = New Point(400, 406)
        btnSchoolUniform.Name = "btnSchoolUniform"
        btnSchoolUniform.Size = New Size(264, 38)
        btnSchoolUniform.TabIndex = 61
        btnSchoolUniform.Text = "SCHOOL UNIFORM"
        btnSchoolUniform.UseVisualStyleBackColor = False
        ' 
        ' btnPeUniform
        ' 
        btnPeUniform.BackColor = Color.DarkSlateGray
        btnPeUniform.FlatStyle = FlatStyle.Popup
        btnPeUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnPeUniform.ForeColor = Color.MintCream
        btnPeUniform.Location = New Point(132, 395)
        btnPeUniform.Name = "btnPeUniform"
        btnPeUniform.Size = New Size(246, 38)
        btnPeUniform.TabIndex = 60
        btnPeUniform.Text = "PE UNIFORM"
        btnPeUniform.UseVisualStyleBackColor = False
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.LightGray
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = CType(resources.GetObject("picPEUniform.Image"), Image)
        picPEUniform.Location = New Point(115, 111)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(275, 364)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 41
        picPEUniform.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(390, 89)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 401)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 47
        picSchoolUniform.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Teal
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 10F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(11, 617)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(180, 35)
        btnBack.TabIndex = 2
        btnBack.Text = "LOGOUT"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.DarkSlateGray
        btnSalesReport.FlatAppearance.BorderSize = 0
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 11.25F)
        btnSalesReport.ForeColor = Color.White
        btnSalesReport.Location = New Point(11, 208)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(180, 40)
        btnSalesReport.TabIndex = 1
        btnSalesReport.Text = "REPORTS"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatAppearance.BorderSize = 0
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Arial Rounded MT Bold", 11.25F)
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(11, 158)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(180, 40)
        btnStockManagement.TabIndex = 0
        btnStockManagement.Text = "STOCK"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkSlateGray
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 664)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.DarkSlateGray
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Arial Rounded MT Bold", 11.25F)
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(11, 112)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(180, 40)
        btnHome.TabIndex = 59
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnPullOut
        ' 
        btnPullOut.BackColor = Color.DarkSlateGray
        btnPullOut.FlatAppearance.BorderSize = 0
        btnPullOut.FlatStyle = FlatStyle.Flat
        btnPullOut.Font = New Font("Arial Rounded MT Bold", 11.25F)
        btnPullOut.ForeColor = Color.White
        btnPullOut.Location = New Point(12, 254)
        btnPullOut.Name = "btnPullOut"
        btnPullOut.Size = New Size(180, 40)
        btnPullOut.TabIndex = 69
        btnPullOut.Text = "PULLOUTS"
        btnPullOut.UseVisualStyleBackColor = False
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1257, 664)
        Controls.Add(btnPullOut)
        Controls.Add(btnHome)
        Controls.Add(PanelMain)
        Controls.Add(btnSalesReport)
        Controls.Add(Label3)
        Controls.Add(btnStockManagement)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Name = "frmAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        PanelMain.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCorporateAttire As Button
    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents btnSchoolUniform As Button
    Friend WithEvents btnPeUniform As Button
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPullOut As Button
End Class
