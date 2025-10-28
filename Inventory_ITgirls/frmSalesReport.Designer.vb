<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Label2 = New Label()
        Label11 = New Label()
        dgvRecentTransactions = New DataGridView()
        ListView2 = New ListView()
        category = New ColumnHeader()
        Total_Items = New ColumnHeader()
        Low_Stocks = New ColumnHeader()
        Pulled = New ColumnHeader()
        Last_Update = New ColumnHeader()
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(277, 35)
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
        Label2.Size = New Size(274, 38)
        Label2.TabIndex = 16
        Label2.Text = "SALES REPORT"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkSlateGray
        Label11.Location = New Point(368, 230)
        Label11.Name = "Label11"
        Label11.Size = New Size(250, 22)
        Label11.TabIndex = 25
        Label11.Text = "RECENT TRANSACTIONS"
        ' 
        ' dgvRecentTransactions
        ' 
        dgvRecentTransactions.BackgroundColor = Color.LightCyan
        dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentTransactions.Location = New Point(16, 243)
        dgvRecentTransactions.Name = "dgvRecentTransactions"
        dgvRecentTransactions.Size = New Size(1010, 289)
        dgvRecentTransactions.TabIndex = 26
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {category, Total_Items, Low_Stocks, Pulled, Last_Update})
        ListView2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.Location = New Point(42, 269)
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
        ' frmSalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1038, 551)
        Controls.Add(ListView2)
        Controls.Add(Label1)
        Controls.Add(Label11)
        Controls.Add(dgvRecentTransactions)
        Controls.Add(Label2)
        Name = "frmSalesReport"
        Text = "SalesReport"
        CType(dgvRecentTransactions, ComponentModel.ISupportInitialize).EndInit()
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
End Class
