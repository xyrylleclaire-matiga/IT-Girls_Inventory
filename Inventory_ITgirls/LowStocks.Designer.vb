<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LowStocks
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
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnStockManagement = New Button()
        btnSalesReport = New Button()
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(30, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 38)
        Label2.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(-8, -135)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 652)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(21, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 38)
        Label1.TabIndex = 19
        Label1.Text = "LOW STOCK ALERT"
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(12, 134)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(170, 46)
        btnStockManagement.TabIndex = 20
        btnStockManagement.Text = "STOCK MANAGEMENT"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.PaleTurquoise
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.DarkSlateGray
        btnSalesReport.Location = New Point(12, 206)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(170, 44)
        btnSalesReport.TabIndex = 21
        btnSalesReport.Text = "SALES REPORT"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSlateGray
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 423)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(170, 24)
        btnBack.TabIndex = 22
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightCyan
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(235, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(529, 332)
        DataGridView1.TabIndex = 23
        ' 
        ' LowStocks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(btnSalesReport)
        Controls.Add(btnStockManagement)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "LowStocks"
        Text = "LowStocks"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
