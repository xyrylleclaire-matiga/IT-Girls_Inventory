<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesReport
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Label1 = New Label()
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
        btnApply = New Button()
        btnClear = New Button()
        chart1 = New DataVisualization.Charting.Chart()
        btnExport = New Button()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).BeginInit()
        CType(chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(151, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 21)
        Label1.TabIndex = 21
        Label1.Text = "ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(12, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 38)
        Label2.TabIndex = 16
        Label2.Text = "REPORT"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(375, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(274, 24)
        Label11.TabIndex = 25
        Label11.Text = "RECENT TRANSACTIONS"
        ' 
        ' dgvRecentTransactions
        ' 
        dgvRecentTransactions.BackgroundColor = Color.DarkSeaGreen
        dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentTransactions.Location = New Point(16, 93)
        dgvRecentTransactions.Name = "dgvRecentTransactions"
        dgvRecentTransactions.Size = New Size(1010, 322)
        dgvRecentTransactions.TabIndex = 26
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {category, Total_Items, Low_Stocks, Size, Pulled, Last_Update})
        ListView2.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(42, 127)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(960, 246)
        ListView2.TabIndex = 121
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' category
        ' 
        category.Text = "category"
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
        FromDateTimePicker.Location = New Point(826, 35)
        FromDateTimePicker.Name = "FromDateTimePicker"
        FromDateTimePicker.Size = New Size(200, 23)
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
        Label4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label4.Location = New Point(789, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 126
        Label4.Text = "From:"
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.SeaGreen
        btnApply.Location = New Point(842, 64)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(75, 23)
        btnApply.TabIndex = 127
        btnApply.Text = "Apply"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DarkRed
        btnClear.ForeColor = SystemColors.ControlLightLight
        btnClear.Location = New Point(927, 64)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
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
        ChartArea1.Name = "ChartArea1"
        chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chart1.Legends.Add(Legend1)
        chart1.Location = New Point(16, 435)
        chart1.Name = "chart1"
        chart1.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chart1.Series.Add(Series1)
        chart1.Size = New Size(1010, 216)
        chart1.TabIndex = 129
        chart1.Text = "Chart1"
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.DarkCyan
        btnExport.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnExport.ForeColor = SystemColors.ControlLightLight
        btnExport.Location = New Point(924, 379)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(79, 28)
        btnExport.TabIndex = 130
        btnExport.Text = "PRINT"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' frmSalesReport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1038, 551)
        Controls.Add(btnExport)
        Controls.Add(chart1)
        Controls.Add(btnClear)
        Controls.Add(btnApply)
        Controls.Add(FromDateTimePicker)
        Controls.Add(ListView2)
        Controls.Add(Label1)
        Controls.Add(Label11)
        Controls.Add(dgvRecentTransactions)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "frmSalesReport"
        Text = "SalesReport"
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).EndInit()
        CType(chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents btnApply As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnExport As Button

End Class
