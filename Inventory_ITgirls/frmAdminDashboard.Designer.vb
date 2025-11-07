Imports System.Windows.Forms.DataVisualization.Charting

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea3 As ChartArea = New ChartArea()
        Dim Legend3 As Legend = New Legend()
        Dim Series3 As Series = New Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminDashboard))
        PanelMain = New Panel()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Button5 = New Button()
        lblMonthlyIssuance = New Label()
        Panel17 = New Panel()
        PanelPendingRequests = New Panel()
        Button4 = New Button()
        lblPendingRequest = New Label()
        Panel16 = New Panel()
        PanelTotalStocks = New Panel()
        Button3 = New Button()
        lblTotalStocks = New Label()
        Panel15 = New Panel()
        PanelTotalPullouts = New Panel()
        Button2 = New Button()
        lblTotalPullouts = New Label()
        Panel6 = New Panel()
        PanelLowStock = New Panel()
        Button1 = New Button()
        lblLowStockAlerts = New Label()
        Chart1 = New Chart()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PanelMain.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel17.SuspendLayout()
        PanelPendingRequests.SuspendLayout()
        Panel16.SuspendLayout()
        PanelTotalStocks.SuspendLayout()
        Panel15.SuspendLayout()
        PanelTotalPullouts.SuspendLayout()
        Panel6.SuspendLayout()
        PanelLowStock.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.LightCyan
        PanelMain.Controls.Add(Label2)
        PanelMain.Controls.Add(PictureBox3)
        PanelMain.Controls.Add(Label1)
        PanelMain.Controls.Add(Chart1)
        PanelMain.Controls.Add(Panel3)
        PanelMain.Controls.Add(Panel17)
        PanelMain.Controls.Add(Panel16)
        PanelMain.Controls.Add(Panel15)
        PanelMain.Controls.Add(Panel6)
        PanelMain.Controls.Add(PictureBox2)
        PanelMain.Location = New Point(-4, 0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1138, 748)
        PanelMain.TabIndex = 61
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkSlateGray
        PictureBox2.Location = New Point(-19, 0)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1155, 101)
        PictureBox2.TabIndex = 75
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(913, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(204, 137)
        Panel3.TabIndex = 76
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightCyan
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(lblMonthlyIssuance)
        Panel4.Location = New Point(17, 13)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(171, 116)
        Panel4.TabIndex = 71
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkSlateGray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Gadugi", 9.75F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(5, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 27)
        Button5.TabIndex = 27
        Button5.Text = "Monthly Issuance"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' lblMonthlyIssuance
        ' 
        lblMonthlyIssuance.AutoSize = True
        lblMonthlyIssuance.Font = New Font("Arial Rounded MT Bold", 18F)
        lblMonthlyIssuance.ForeColor = SystemColors.ActiveCaptionText
        lblMonthlyIssuance.Location = New Point(76, 58)
        lblMonthlyIssuance.Name = "lblMonthlyIssuance"
        lblMonthlyIssuance.Size = New Size(20, 28)
        lblMonthlyIssuance.TabIndex = 26
        lblMonthlyIssuance.Text = "-"
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.Teal
        Panel17.Controls.Add(PanelPendingRequests)
        Panel17.Location = New Point(688, 134)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(204, 137)
        Panel17.TabIndex = 75
        ' 
        ' PanelPendingRequests
        ' 
        PanelPendingRequests.BackColor = Color.LightCyan
        PanelPendingRequests.Controls.Add(Button4)
        PanelPendingRequests.Controls.Add(lblPendingRequest)
        PanelPendingRequests.Location = New Point(17, 13)
        PanelPendingRequests.Name = "PanelPendingRequests"
        PanelPendingRequests.Size = New Size(171, 116)
        PanelPendingRequests.TabIndex = 71
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Teal
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Gadugi", 9.75F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(5, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(163, 27)
        Button4.TabIndex = 27
        Button4.Text = "Pending Requests"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblPendingRequest
        ' 
        lblPendingRequest.AutoSize = True
        lblPendingRequest.Font = New Font("Arial Rounded MT Bold", 18F)
        lblPendingRequest.ForeColor = SystemColors.ActiveCaptionText
        lblPendingRequest.Location = New Point(76, 58)
        lblPendingRequest.Name = "lblPendingRequest"
        lblPendingRequest.Size = New Size(20, 28)
        lblPendingRequest.TabIndex = 26
        lblPendingRequest.Text = "-"
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.CadetBlue
        Panel16.Controls.Add(PanelTotalStocks)
        Panel16.Location = New Point(463, 134)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(204, 137)
        Panel16.TabIndex = 74
        ' 
        ' PanelTotalStocks
        ' 
        PanelTotalStocks.BackColor = Color.LightCyan
        PanelTotalStocks.Controls.Add(Button3)
        PanelTotalStocks.Controls.Add(lblTotalStocks)
        PanelTotalStocks.Location = New Point(19, 12)
        PanelTotalStocks.Name = "PanelTotalStocks"
        PanelTotalStocks.Size = New Size(169, 116)
        PanelTotalStocks.TabIndex = 69
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.CadetBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Gadugi", 9.75F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(3, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(163, 27)
        Button3.TabIndex = 28
        Button3.Text = "Total Stocks"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' lblTotalStocks
        ' 
        lblTotalStocks.AutoSize = True
        lblTotalStocks.Font = New Font("Arial Rounded MT Bold", 18F)
        lblTotalStocks.ForeColor = SystemColors.ActiveCaptionText
        lblTotalStocks.Location = New Point(73, 59)
        lblTotalStocks.Name = "lblTotalStocks"
        lblTotalStocks.Size = New Size(20, 28)
        lblTotalStocks.TabIndex = 26
        lblTotalStocks.Text = "-"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.LightSeaGreen
        Panel15.Controls.Add(PanelTotalPullouts)
        Panel15.Location = New Point(238, 134)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(204, 137)
        Panel15.TabIndex = 78
        ' 
        ' PanelTotalPullouts
        ' 
        PanelTotalPullouts.BackColor = Color.LightCyan
        PanelTotalPullouts.Controls.Add(Button2)
        PanelTotalPullouts.Controls.Add(lblTotalPullouts)
        PanelTotalPullouts.Location = New Point(17, 11)
        PanelTotalPullouts.Name = "PanelTotalPullouts"
        PanelTotalPullouts.Size = New Size(171, 116)
        PanelTotalPullouts.TabIndex = 70
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSeaGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Gadugi", 9.75F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 27)
        Button2.TabIndex = 27
        Button2.Text = "Total Pullouts"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblTotalPullouts
        ' 
        lblTotalPullouts.AutoSize = True
        lblTotalPullouts.Font = New Font("Arial Rounded MT Bold", 18F)
        lblTotalPullouts.ForeColor = SystemColors.ActiveCaptionText
        lblTotalPullouts.Location = New Point(75, 60)
        lblTotalPullouts.Name = "lblTotalPullouts"
        lblTotalPullouts.Size = New Size(20, 28)
        lblTotalPullouts.TabIndex = 26
        lblTotalPullouts.Text = "-"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.MediumAquamarine
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(PanelLowStock)
        Panel6.Location = New Point(17, 134)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(204, 137)
        Panel6.TabIndex = 77
        ' 
        ' PanelLowStock
        ' 
        PanelLowStock.BackColor = Color.LightCyan
        PanelLowStock.Controls.Add(Button1)
        PanelLowStock.Controls.Add(lblLowStockAlerts)
        PanelLowStock.Location = New Point(17, 9)
        PanelLowStock.Name = "PanelLowStock"
        PanelLowStock.Size = New Size(166, 116)
        PanelLowStock.TabIndex = 68
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumAquamarine
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Gadugi", 9.75F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 27)
        Button1.TabIndex = 26
        Button1.Text = "Low Stock Alerts"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblLowStockAlerts
        ' 
        lblLowStockAlerts.AutoSize = True
        lblLowStockAlerts.Font = New Font("Arial Rounded MT Bold", 18F)
        lblLowStockAlerts.ForeColor = SystemColors.ActiveCaptionText
        lblLowStockAlerts.Location = New Point(77, 60)
        lblLowStockAlerts.Name = "lblLowStockAlerts"
        lblLowStockAlerts.Size = New Size(20, 28)
        lblLowStockAlerts.TabIndex = 25
        lblLowStockAlerts.Text = "-"
        ' 
        ' Chart1
        ' 
        Chart1.BackColor = Color.DarkSeaGreen
        Chart1.BackGradientStyle = GradientStyle.DiagonalRight
        Chart1.BackSecondaryColor = Color.Transparent
        Chart1.BorderlineColor = Color.RosyBrown
        Chart1.BorderlineDashStyle = ChartDashStyle.DashDotDot
        ChartArea3.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Chart1.Legends.Add(Legend3)
        Chart1.Location = New Point(16, 316)
        Chart1.Name = "Chart1"
        Chart1.Palette = ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Chart1.Series.Add(Series3)
        Chart1.Size = New Size(1100, 372)
        Chart1.TabIndex = 131
        Chart1.Text = "Chart1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSlateGray
        Label2.Font = New Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LightCyan
        Label2.Location = New Point(403, 50)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(420, 29)
        Label2.TabIndex = 134
        Label2.Text = "INVENTORY MANAGEMENT SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSlateGray
        Label1.Font = New Font("Perpetua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(489, 17)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 22)
        Label1.TabIndex = 133
        Label1.Text = "BOOKSTORE DEPARTMENT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DarkSlateGray
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(312, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(112, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 72
        PictureBox3.TabStop = False
        ' 
        ' frmAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1122, 709)
        Controls.Add(PanelMain)
        Name = "frmAdminDashboard"
        Text = "frmAdminDashboard"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel17.ResumeLayout(False)
        PanelPendingRequests.ResumeLayout(False)
        PanelPendingRequests.PerformLayout()
        Panel16.ResumeLayout(False)
        PanelTotalStocks.ResumeLayout(False)
        PanelTotalStocks.PerformLayout()
        Panel15.ResumeLayout(False)
        PanelTotalPullouts.ResumeLayout(False)
        PanelTotalPullouts.PerformLayout()
        Panel6.ResumeLayout(False)
        PanelLowStock.ResumeLayout(False)
        PanelLowStock.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents lblMonthlyIssuance As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PanelPendingRequests As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents lblPendingRequest As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents PanelTotalStocks As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents lblTotalStocks As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents PanelTotalPullouts As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTotalPullouts As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelLowStock As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLowStockAlerts As Label
    Friend WithEvents Chart1 As Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
