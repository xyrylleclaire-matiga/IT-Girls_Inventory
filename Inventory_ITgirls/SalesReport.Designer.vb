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
        Button1 = New Button()
        lblLowStockAlerts = New Label()
        Panel3 = New Panel()
        Button3 = New Button()
        lblTotalStocks = New Label()
        Panel4 = New Panel()
        Button4 = New Button()
        lblPendingRequest = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        lblTotalPullouts = New Label()
        Label11 = New Label()
        dgvRecentTransactions = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.Location = New Point(12, 517)
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
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lblLowStockAlerts)
        Panel1.Location = New Point(222, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(183, 116)
        Panel1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(11, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 23)
        Button1.TabIndex = 26
        Button1.Text = "Low Stock Alerts"
        Button1.UseVisualStyleBackColor = False
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(lblTotalStocks)
        Panel3.Location = New Point(627, 77)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(183, 116)
        Panel3.TabIndex = 23
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateGray
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(3, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 23)
        Button3.TabIndex = 28
        Button3.Text = "Total Stocks"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' lblTotalStocks
        ' 
        lblTotalStocks.AutoSize = True
        lblTotalStocks.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalStocks.ForeColor = SystemColors.ButtonFace
        lblTotalStocks.Location = New Point(126, 73)
        lblTotalStocks.Name = "lblTotalStocks"
        lblTotalStocks.Size = New Size(20, 25)
        lblTotalStocks.TabIndex = 26
        lblTotalStocks.Text = "-"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkSlateGray
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(lblPendingRequest)
        Panel4.Location = New Point(827, 77)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(189, 116)
        Panel4.TabIndex = 24
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(116, 23)
        Button4.TabIndex = 27
        Button4.Text = "Pending Requests"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblPendingRequest
        ' 
        lblPendingRequest.AutoSize = True
        lblPendingRequest.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPendingRequest.ForeColor = SystemColors.ButtonFace
        lblPendingRequest.Location = New Point(129, 74)
        lblPendingRequest.Name = "lblPendingRequest"
        lblPendingRequest.Size = New Size(20, 25)
        lblPendingRequest.TabIndex = 26
        lblPendingRequest.Text = "-"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(lblTotalPullouts)
        Panel2.Location = New Point(424, 77)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(183, 116)
        Panel2.TabIndex = 23
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 23)
        Button2.TabIndex = 27
        Button2.Text = "Total Pullouts"
        Button2.UseVisualStyleBackColor = False
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(521, 231)
        Label11.Name = "Label11"
        Label11.Size = New Size(212, 18)
        Label11.TabIndex = 25
        Label11.Text = "RECENT TRANSACTIONS"
        ' 
        ' dgvRecentTransactions
        ' 
        dgvRecentTransactions.BackgroundColor = Color.LightCyan
        dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentTransactions.Location = New Point(222, 252)
        dgvRecentTransactions.Name = "dgvRecentTransactions"
        dgvRecentTransactions.Size = New Size(794, 289)
        dgvRecentTransactions.TabIndex = 26
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(1040, 553)
        Controls.Add(dgvRecentTransactions)
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
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblLowStockAlerts As Label
    Friend WithEvents lblTotalStocks As Label
    Friend WithEvents lblPendingRequest As Label
    Friend WithEvents lblTotalPullouts As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvRecentTransactions As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
