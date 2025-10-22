<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalPullouts
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
        dgvTotalPullouts = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(dgvTotalPullouts, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTotalPullouts
        ' 
        dgvTotalPullouts.BackgroundColor = Color.LightCyan
        dgvTotalPullouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTotalPullouts.Location = New Point(240, 85)
        dgvTotalPullouts.Name = "dgvTotalPullouts"
        dgvTotalPullouts.Size = New Size(778, 442)
        dgvTotalPullouts.TabIndex = 30
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
        PictureBox1.Size = New Size(197, 663)
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
        ' 
        ' TotalPullouts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(1040, 553)
        Controls.Add(dgvTotalPullouts)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "TotalPullouts"
        Text = "TotalPullouts"
        CType(dgvTotalPullouts, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTotalPullouts As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
