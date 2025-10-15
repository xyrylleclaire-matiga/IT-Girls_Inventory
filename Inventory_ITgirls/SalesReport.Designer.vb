<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Label1 = New Label()
        btnSalesReport = New Button()
        btnStockManagement = New Button()
        btnBack = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        lblLowStockAlerts = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        lblTotalStocks = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        lblPendingRequest = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        lblTotalPullouts = New Label()
        Label4 = New Label()
        Label11 = New Label()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(370, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 21)
        Label1.TabIndex = 21
        Label1.Text = "ADMIN"
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.PaleTurquoise
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.DarkSlateGray
        btnSalesReport.Location = New Point(15, 206)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(170, 44)
        btnSalesReport.TabIndex = 20
        btnSalesReport.Text = "SALES REPORT"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(15, 133)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(170, 46)
        btnStockManagement.TabIndex = 19
        btnStockManagement.Text = "STOCK MANAGEMENT"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSlateGray
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(15, 483)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(170, 24)
        btnBack.TabIndex = 17
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(20, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(357, 38)
        Label2.TabIndex = 16
        Label2.Text = "INVENTORY SYSTEM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(-6, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 652)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(lblLowStockAlerts)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(211, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(175, 105)
        Panel1.TabIndex = 22
        ' 
        ' lblLowStockAlerts
        ' 
        lblLowStockAlerts.AutoSize = True
        lblLowStockAlerts.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLowStockAlerts.ForeColor = SystemColors.ButtonFace
        lblLowStockAlerts.Location = New Point(118, 73)
        lblLowStockAlerts.Name = "lblLowStockAlerts"
        lblLowStockAlerts.Size = New Size(20, 25)
        lblLowStockAlerts.TabIndex = 25
        lblLowStockAlerts.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 17)
        Label3.TabIndex = 0
        Label3.Text = "Low Stock Alerts"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(lblTotalStocks)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(588, 63)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(175, 105)
        Panel3.TabIndex = 23
        ' 
        ' lblTotalStocks
        ' 
        lblTotalStocks.AutoSize = True
        lblTotalStocks.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalStocks.ForeColor = SystemColors.ButtonFace
        lblTotalStocks.Location = New Point(126, 75)
        lblTotalStocks.Name = "lblTotalStocks"
        lblTotalStocks.Size = New Size(20, 25)
        lblTotalStocks.TabIndex = 26
        lblTotalStocks.Text = "-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(13, 4)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 17)
        Label5.TabIndex = 25
        Label5.Text = "Total Stocks"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkSlateGray
        Panel4.Controls.Add(lblPendingRequest)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(777, 63)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(175, 105)
        Panel4.TabIndex = 24
        ' 
        ' lblPendingRequest
        ' 
        lblPendingRequest.AutoSize = True
        lblPendingRequest.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPendingRequest.ForeColor = SystemColors.ButtonFace
        lblPendingRequest.Location = New Point(134, 76)
        lblPendingRequest.Name = "lblPendingRequest"
        lblPendingRequest.Size = New Size(20, 25)
        lblPendingRequest.TabIndex = 26
        lblPendingRequest.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(14, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 17)
        Label6.TabIndex = 25
        Label6.Text = "Pending Requests"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.Controls.Add(lblTotalPullouts)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(399, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(175, 105)
        Panel2.TabIndex = 23
        ' 
        ' lblTotalPullouts
        ' 
        lblTotalPullouts.AutoSize = True
        lblTotalPullouts.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPullouts.ForeColor = SystemColors.ButtonFace
        lblTotalPullouts.Location = New Point(121, 73)
        lblTotalPullouts.Name = "lblTotalPullouts"
        lblTotalPullouts.Size = New Size(20, 25)
        lblTotalPullouts.TabIndex = 26
        lblTotalPullouts.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(13, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 17)
        Label4.TabIndex = 25
        Label4.Text = "Total Pullouts"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(383, 229)
        Label11.Name = "Label11"
        Label11.Size = New Size(212, 18)
        Label11.TabIndex = 25
        Label11.Text = "RECENT TRANSACTIONS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightCyan
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(211, 252)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(552, 255)
        DataGridView1.TabIndex = 26
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(960, 541)
        Controls.Add(DataGridView1)
        Controls.Add(Label11)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(btnSalesReport)
        Controls.Add(btnStockManagement)
        Controls.Add(btnBack)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "SalesReport"
        Text = "SalesReport"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLowStockAlerts As Label
    Friend WithEvents lblTotalStocks As Label
    Friend WithEvents lblPendingRequest As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalPullouts As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
