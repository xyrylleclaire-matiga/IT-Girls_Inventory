<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TotalPullouts
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
        Button1 = New Button()
        Button2 = New Button()
        lblTitle = New Label()
        Label6 = New Label()
        pnlDetails = New Panel()
        cboPulloutReason = New ComboBox()
        lblItemName = New TextBox()
        Label11 = New Label()
        txtQuantity = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        lblDate = New TextBox()
        Label2 = New Label()
        ListView1 = New ListView()
        uniform_id = New ColumnHeader()
        item_name = New ColumnHeader()
        category = New ColumnHeader()
        level = New ColumnHeader()
        gender = New ColumnHeader()
        size = New ColumnHeader()
        stock_quantity = New ColumnHeader()
        price = New ColumnHeader()
        status = New ColumnHeader()
        date_added = New ColumnHeader()
        pnlDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9.0F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(950, 433)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 35)
        Button1.TabIndex = 14
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaGreen
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 9.0F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(950, 476)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 35)
        Button2.TabIndex = 15
        Button2.Text = "Save Pullout"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 11.0F)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(10, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(112, 17)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pullout Details"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(10, 50)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 1
        Label6.Text = "Item Name:"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.White
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(cboPulloutReason)
        pnlDetails.Controls.Add(lblTitle)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(lblItemName)
        pnlDetails.Controls.Add(Label11)
        pnlDetails.Controls.Add(txtQuantity)
        pnlDetails.Controls.Add(Label12)
        pnlDetails.Controls.Add(Label14)
        pnlDetails.Controls.Add(lblDate)
        pnlDetails.Location = New Point(889, 60)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(200, 350)
        pnlDetails.TabIndex = 12
        ' 
        ' cboPulloutReason
        ' 
        cboPulloutReason.FormattingEnabled = True
        cboPulloutReason.Items.AddRange(New Object() {"Damaged", "Misprinted"})
        cboPulloutReason.Location = New Point(10, 204)
        cboPulloutReason.Name = "cboPulloutReason"
        cboPulloutReason.Size = New Size(170, 23)
        cboPulloutReason.TabIndex = 11
        ' 
        ' lblItemName
        ' 
        lblItemName.Location = New Point(10, 74)
        lblItemName.Name = "lblItemName"
        lblItemName.ReadOnly = True
        lblItemName.Size = New Size(170, 23)
        lblItemName.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(10, 114)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 5
        Label11.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(10, 139)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(170, 23)
        txtQuantity.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(10, 184)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 7
        Label12.Text = "Pullout Reason:"
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(10, 245)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 9
        Label14.Text = "Date:"
        ' 
        ' lblDate
        ' 
        lblDate.Location = New Point(10, 268)
        lblDate.Name = "lblDate"
        lblDate.ReadOnly = True
        lblDate.Size = New Size(170, 23)
        lblDate.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18.0F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(291, 28)
        Label2.TabIndex = 9
        Label2.Text = "INVENTORY PULLOUTS"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.White
        ListView1.BorderStyle = BorderStyle.FixedSingle
        ListView1.Columns.AddRange(New ColumnHeader() {uniform_id, item_name, category, level, gender, size, stock_quantity, price, status, date_added})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 60)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(870, 590)
        ListView1.TabIndex = 11
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' uniform_id
        ' 
        uniform_id.DisplayIndex = 9
        uniform_id.Text = "uniform_id"
        ' 
        ' item_name
        ' 
        item_name.DisplayIndex = 0
        item_name.Text = "item_name"
        item_name.Width = 90
        ' 
        ' category
        ' 
        category.DisplayIndex = 1
        category.Text = "category"
        category.Width = 90
        ' 
        ' level
        ' 
        level.DisplayIndex = 2
        level.Text = "level"
        level.Width = 90
        ' 
        ' gender
        ' 
        gender.DisplayIndex = 3
        gender.Text = "gender"
        gender.Width = 90
        ' 
        ' size
        ' 
        size.DisplayIndex = 4
        size.Text = "size"
        size.Width = 90
        ' 
        ' stock_quantity
        ' 
        stock_quantity.DisplayIndex = 5
        stock_quantity.Text = "stock_quantity"
        stock_quantity.Width = 90
        ' 
        ' price
        ' 
        price.DisplayIndex = 6
        price.Text = "price"
        price.Width = 90
        ' 
        ' status
        ' 
        status.DisplayIndex = 7
        status.Text = "status"
        status.Width = 90
        ' 
        ' date_added
        ' 
        date_added.DisplayIndex = 8
        date_added.Text = "date_added"
        date_added.Width = 120
        ' 
        ' TotalPullouts
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(237), CByte(255))
        ClientSize = New Size(1101, 687)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(pnlDetails)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Name = "TotalPullouts"
        Text = "TotalPullouts"
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Friend WithEvents lblTitle As Label
    Private WithEvents Label6 As Label
    Friend WithEvents pnlDetails As Panel
    Private WithEvents lblItemName As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents txtQuantity As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label14 As Label
    Private WithEvents lblDate As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents ListView1 As ListView
    Friend WithEvents cboPulloutReason As ComboBox
    Friend WithEvents item_name As ColumnHeader
    Friend WithEvents category As ColumnHeader
    Friend WithEvents level As ColumnHeader
    Friend WithEvents gender As ColumnHeader
    Friend WithEvents size As ColumnHeader
    Friend WithEvents stock_quantity As ColumnHeader
    Friend WithEvents price As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents date_added As ColumnHeader
    Friend WithEvents uniform_id As ColumnHeader
End Class
