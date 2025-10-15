<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        PictureBox1 = New PictureBox()
        btnLogOut = New Button()
        btnStockManagement = New Button()
        btnSalesReport = New Button()
        PictureBox5 = New PictureBox()
        picSchoolUniform = New PictureBox()
        PictureBox8 = New PictureBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 538)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.DarkSlateGray
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(12, 453)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(174, 30)
        btnLogOut.TabIndex = 10
        btnLogOut.Text = "LOG OUT"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(12, 169)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(174, 46)
        btnStockManagement.TabIndex = 12
        btnStockManagement.Text = "STOCK MANAGEMENT"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.PaleTurquoise
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.DarkSlateGray
        btnSalesReport.Location = New Point(12, 223)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(174, 44)
        btnSalesReport.TabIndex = 13
        btnSalesReport.Text = "SALES REPORT"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.LightGray
        PictureBox5.BorderStyle = BorderStyle.Fixed3D
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(205, 70)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(277, 364)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 41
        PictureBox5.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(475, 58)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 387)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 47
        picSchoolUniform.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.LightGray
        PictureBox8.BorderStyle = BorderStyle.Fixed3D
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(758, 68)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(266, 363)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 52
        PictureBox8.TabStop = False
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
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Rounded MT Bold", 16.0F)
        Button1.ForeColor = Color.MintCream
        Button1.Location = New Point(256, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(179, 38)
        Button1.TabIndex = 54
        Button1.Text = "PE UNIFORM"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Arial Rounded MT Bold", 16.0F)
        Button2.ForeColor = Color.MintCream
        Button2.Location = New Point(501, 365)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 38)
        Button2.TabIndex = 55
        Button2.Text = "SCHOOL UNIFORM"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateGray
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.MintCream
        Button3.Location = New Point(797, 360)
        Button3.Name = "Button3"
        Button3.Size = New Size(185, 41)
        Button3.TabIndex = 56
        Button3.Text = "CORPORATE ATTIRE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1040, 495)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(PictureBox8)
        Controls.Add(picSchoolUniform)
        Controls.Add(PictureBox5)
        Controls.Add(btnSalesReport)
        Controls.Add(btnStockManagement)
        Controls.Add(btnLogOut)
        Controls.Add(PictureBox1)
        Name = "Admin"
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
