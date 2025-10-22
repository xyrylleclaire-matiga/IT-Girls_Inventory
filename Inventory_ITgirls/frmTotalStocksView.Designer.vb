<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalStocksView
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
        dgvTotalStocks = New DataGridView()
        btnBack = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(dgvTotalStocks, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTotalStocks
        ' 
        dgvTotalStocks.BackgroundColor = Color.LightCyan
        dgvTotalStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTotalStocks.Location = New Point(240, 88)
        dgvTotalStocks.Name = "dgvTotalStocks"
        dgvTotalStocks.Size = New Size(766, 431)
        dgvTotalStocks.TabIndex = 36
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
        btnBack.TabIndex = 35
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(33, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 38)
        Label1.TabIndex = 34
        Label1.Text = "TOTAL STOCKS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.Location = New Point(0, -104)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 661)
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(52, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 38)
        Label2.TabIndex = 32
        ' 
        ' TotalStocksView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(1040, 553)
        Controls.Add(dgvTotalStocks)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "TotalStocksView"
        Text = "TotalStocksView"
        CType(dgvTotalStocks, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvTotalStocks As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
