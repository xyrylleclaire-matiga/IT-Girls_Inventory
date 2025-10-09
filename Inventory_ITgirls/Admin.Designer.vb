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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        btnLogOut = New Button()
        btnStockManagement = New Button()
        btnSalesReport = New Button()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 452)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 25F, FontStyle.Bold)
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(21, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(353, 40)
        Label2.TabIndex = 9
        Label2.Text = "INVENTORY SYSTEM"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.SteelBlue
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(12, 414)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(174, 24)
        btnLogOut.TabIndex = 10
        btnLogOut.Text = "LOG OUT"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnStockManagement
        ' 
        btnStockManagement.BackColor = Color.SteelBlue
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.Location = New Point(12, 133)
        btnStockManagement.Name = "btnStockManagement"
        btnStockManagement.Size = New Size(174, 46)
        btnStockManagement.TabIndex = 12
        btnStockManagement.Text = "STOCK MANAGEMENT"
        btnStockManagement.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.BackColor = Color.SteelBlue
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.White
        btnSalesReport.Location = New Point(12, 206)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(174, 44)
        btnSalesReport.TabIndex = 13
        btnSalesReport.Text = "SALES REPORT"
        btnSalesReport.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(367, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 21)
        Label1.TabIndex = 14
        Label1.Text = "ADMIN"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnSalesReport)
        Controls.Add(btnStockManagement)
        Controls.Add(btnLogOut)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Admin"
        Text = "Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnStockManagement As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents Label1 As Label
End Class
