<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalPullouts
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
        DataGridView1 = New DataGridView()
        btnBack = New Button()
        btnSalesReport = New Button()
        btnStockManagement = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightCyan
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(240, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(529, 332)
        DataGridView1.TabIndex = 30
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSlateGray
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(34, 457)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(170, 24)
        btnBack.TabIndex = 29
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.PaleTurquoise
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.DarkSlateGray
        btnSalesReport.Location = New Point(19, 213)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(170, 44)
        btnSalesReport.TabIndex = 28
        btnSalesReport.Text = "SALES REPORT"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(17, 142)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(170, 46)
        btnStockManagement.TabIndex = 27
        btnStockManagement.Text = "STOCK MANAGEMENT"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(33, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 38)
        Label1.TabIndex = 26
        Label1.Text = "TOTAL PULLOUTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(0, -107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 652)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(52, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 38)
        Label2.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(17, 422)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 24)
        Button1.TabIndex = 31
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TotalPullouts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(btnSalesReport)
        Controls.Add(btnStockManagement)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "TotalPullouts"
        Text = "TotalPullouts"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
