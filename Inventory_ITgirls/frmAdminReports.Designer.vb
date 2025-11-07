<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminReports
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminReports))
        Label2 = New Label()
        Label11 = New Label()
        dgvRecentTransactions = New DataGridView()
        ListView2 = New ListView()
        category = New ColumnHeader()
        Total_Items = New ColumnHeader()
        Low_Stocks = New ColumnHeader()
        Size = New ColumnHeader()
        Pulled = New ColumnHeader()
        Last_Update = New ColumnHeader()
        FromDateTimePicker = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        btnClear = New Button()
        chart1 = New DataVisualization.Charting.Chart()
        btnExport = New Button()
        txtSearch = New TextBox()
        rdoAllCategory = New RadioButton()
        rdoPE = New RadioButton()
        rdoUniform = New RadioButton()
        rdoCorporateAttire = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).BeginInit()
        CType(chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Gadugi", 24.0F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(16, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 38)
        Label2.TabIndex = 16
        Label2.Text = "REPORTS"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(372, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(258, 25)
        Label11.TabIndex = 25
        Label11.Text = "RECENT TRANSACTIONS"
        ' 
        ' dgvRecentTransactions
        ' 
        dgvRecentTransactions.BackgroundColor = Color.DarkSeaGreen
        dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentTransactions.Location = New Point(19, 129)
        dgvRecentTransactions.Name = "dgvRecentTransactions"
        dgvRecentTransactions.Size = New Size(1077, 295)
        dgvRecentTransactions.TabIndex = 26
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {category, Total_Items, Low_Stocks, Size, Pulled, Last_Update})
        ListView2.Font = New Font("Gadugi", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(45, 159)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(1027, 223)
        ListView2.TabIndex = 121
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' category
        ' 
        category.Text = "Category"
        category.Width = 90
        ' 
        ' Total_Items
        ' 
        Total_Items.Text = "Total_Items"
        Total_Items.Width = 90
        ' 
        ' Low_Stocks
        ' 
        Low_Stocks.Text = "Low_Stocks"
        Low_Stocks.Width = 90
        ' 
        ' Size
        ' 
        Size.Text = "Size"
        ' 
        ' Pulled
        ' 
        Pulled.Text = "Pulled"
        Pulled.Width = 90
        ' 
        ' Last_Update
        ' 
        Last_Update.Text = "Last_Update"
        Last_Update.Width = 120
        ' 
        ' FromDateTimePicker
        ' 
        FromDateTimePicker.CalendarMonthBackground = Color.DarkSeaGreen
        FromDateTimePicker.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FromDateTimePicker.Location = New Point(843, 86)
        FromDateTimePicker.Name = "FromDateTimePicker"
        FromDateTimePicker.Size = New Size(239, 23)
        FromDateTimePicker.TabIndex = 123
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(999, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 125
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkSlateGray
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(797, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 126
        Label4.Text = "Date: "
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = SystemColors.ControlLightLight
        btnClear.Location = New Point(963, 388)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(109, 28)
        btnClear.TabIndex = 128
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' chart1
        ' 
        chart1.BackColor = Color.DarkSeaGreen
        chart1.BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalRight
        chart1.BackSecondaryColor = Color.Transparent
        chart1.BorderlineColor = Color.RosyBrown
        chart1.BorderlineDashStyle = DataVisualization.Charting.ChartDashStyle.DashDotDot
        ChartArea3.Name = "ChartArea1"
        chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        chart1.Legends.Add(Legend3)
        chart1.Location = New Point(22, 462)
        chart1.Name = "chart1"
        chart1.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        chart1.Series.Add(Series3)
        chart1.Size = New Size(1074, 216)
        chart1.TabIndex = 129
        chart1.Text = "Chart1"
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.DarkSlateGray
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(839, 388)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(100, 28)
        btnExport.TabIndex = 130
        btnExport.Text = "Print"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(28, 85)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search item..."
        txtSearch.Size = New Size(201, 25)
        txtSearch.TabIndex = 131
        txtSearch.Text = "🔍 Search..."
        ' 
        ' rdoAllCategory
        ' 
        rdoAllCategory.AutoSize = True
        rdoAllCategory.BackColor = Color.LightCyan
        rdoAllCategory.Font = New Font("Arial Rounded MT Bold", 9.75F)
        rdoAllCategory.ForeColor = Color.Black
        rdoAllCategory.Location = New Point(261, 87)
        rdoAllCategory.Name = "rdoAllCategory"
        rdoAllCategory.Size = New Size(105, 19)
        rdoAllCategory.TabIndex = 132
        rdoAllCategory.TabStop = True
        rdoAllCategory.Text = "All Category"
        rdoAllCategory.UseVisualStyleBackColor = False
        ' 
        ' rdoPE
        ' 
        rdoPE.AutoSize = True
        rdoPE.BackColor = Color.LightCyan
        rdoPE.Font = New Font("Arial Rounded MT Bold", 9.75F)
        rdoPE.ForeColor = Color.Black
        rdoPE.Location = New Point(641, 88)
        rdoPE.Name = "rdoPE"
        rdoPE.Size = New Size(98, 19)
        rdoPE.TabIndex = 133
        rdoPE.TabStop = True
        rdoPE.Text = "PE Uniform"
        rdoPE.UseVisualStyleBackColor = False
        ' 
        ' rdoUniform
        ' 
        rdoUniform.AutoSize = True
        rdoUniform.BackColor = Color.LightCyan
        rdoUniform.Font = New Font("Arial Rounded MT Bold", 9.75F)
        rdoUniform.ForeColor = Color.Black
        rdoUniform.Location = New Point(372, 88)
        rdoUniform.Name = "rdoUniform"
        rdoUniform.Size = New Size(125, 19)
        rdoUniform.TabIndex = 134
        rdoUniform.TabStop = True
        rdoUniform.Text = "School Uniform"
        rdoUniform.UseVisualStyleBackColor = False
        ' 
        ' rdoCorporateAttire
        ' 
        rdoCorporateAttire.AutoSize = True
        rdoCorporateAttire.BackColor = Color.LightCyan
        rdoCorporateAttire.Font = New Font("Arial Rounded MT Bold", 9.75F)
        rdoCorporateAttire.ForeColor = Color.Black
        rdoCorporateAttire.Location = New Point(503, 88)
        rdoCorporateAttire.Name = "rdoCorporateAttire"
        rdoCorporateAttire.Size = New Size(132, 19)
        rdoCorporateAttire.TabIndex = 135
        rdoCorporateAttire.TabStop = True
        rdoCorporateAttire.Text = "Corporate Attire"
        rdoCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(19, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(1077, 67)
        Button1.TabIndex = 136
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.LightCyan
        Button2.Location = New Point(247, 81)
        Button2.Name = "Button2"
        Button2.Size = New Size(509, 31)
        Button2.TabIndex = 137
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' frmAdminReports
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1122, 709)
        Controls.Add(rdoCorporateAttire)
        Controls.Add(rdoUniform)
        Controls.Add(rdoPE)
        Controls.Add(rdoAllCategory)
        Controls.Add(Button2)
        Controls.Add(txtSearch)
        Controls.Add(FromDateTimePicker)
        Controls.Add(Label4)
        Controls.Add(Label11)
        Controls.Add(Button1)
        Controls.Add(btnExport)
        Controls.Add(chart1)
        Controls.Add(btnClear)
        Controls.Add(ListView2)
        Controls.Add(dgvRecentTransactions)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Name = "frmAdminReports"
        Text = "SalesReports"
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).EndInit()
        CType(chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvRecentTransactions As DataGridView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents category As ColumnHeader
    Friend WithEvents Total_Items As ColumnHeader
    Friend WithEvents Low_Stocks As ColumnHeader
    Friend WithEvents Pulled As ColumnHeader
    Friend WithEvents Last_Update As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnExport As Button
    Private WithEvents txtSearch As TextBox
    Friend WithEvents rdoAllCategory As RadioButton
    Friend WithEvents rdoPE As RadioButton
    Friend WithEvents rdoUniform As RadioButton
    Friend WithEvents rdoCorporateAttire As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
