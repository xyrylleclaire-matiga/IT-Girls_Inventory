<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminStockReceiving
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
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Gadugi", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(27, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(292, 38)
        Label2.TabIndex = 18
        Label2.Text = "STOCK RECEIVING"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Location = New Point(27, 100)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1053, 573)
        Panel1.TabIndex = 19
        ' 
        ' frmAdminStockReceiving
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1122, 709)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "frmAdminStockReceiving"
        Text = "frmAdminStockReceiving"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
