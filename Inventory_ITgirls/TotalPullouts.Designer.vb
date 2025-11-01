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
        btnClear = New Button()
        btnSave = New Button()
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
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtSearch = New TextBox()
        pnlDetails.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DimGray
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(393, 131)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(100, 35)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SeaGreen
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(273, 131)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 35)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Pullout"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(8, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(157, 24)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pullout Details"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label6.Location = New Point(10, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 1
        Label6.Text = "Item Name:"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.WhiteSmoke
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(cboPulloutReason)
        pnlDetails.Controls.Add(lblTitle)
        pnlDetails.Controls.Add(btnClear)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(btnSave)
        pnlDetails.Controls.Add(lblItemName)
        pnlDetails.Controls.Add(Label11)
        pnlDetails.Controls.Add(txtQuantity)
        pnlDetails.Controls.Add(Label12)
        pnlDetails.Controls.Add(Label14)
        pnlDetails.Controls.Add(lblDate)
        pnlDetails.Location = New Point(95, 14)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(816, 182)
        pnlDetails.TabIndex = 12
        ' 
        ' cboPulloutReason
        ' 
        cboPulloutReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboPulloutReason.Font = New Font("Arial Rounded MT Bold", 9.75F)
        cboPulloutReason.FormattingEnabled = True
        cboPulloutReason.Items.AddRange(New Object() {"Damaged", "Misprinted"})
        cboPulloutReason.Location = New Point(412, 84)
        cboPulloutReason.Name = "cboPulloutReason"
        cboPulloutReason.Size = New Size(170, 23)
        cboPulloutReason.TabIndex = 4
        ' 
        ' lblItemName
        ' 
        lblItemName.Font = New Font("Arial Rounded MT Bold", 9.75F)
        lblItemName.Location = New Point(10, 84)
        lblItemName.Name = "lblItemName"
        lblItemName.ReadOnly = True
        lblItemName.Size = New Size(170, 23)
        lblItemName.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label11.Location = New Point(209, 59)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 5
        Label11.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Rounded MT Bold", 9.75F)
        txtQuantity.Location = New Point(209, 84)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(170, 23)
        txtQuantity.TabIndex = 3
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label12.Location = New Point(412, 64)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 7
        Label12.Text = "Pullout Reason:"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial Rounded MT Bold", 9.75F)
        Label14.Location = New Point(616, 61)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 9
        Label14.Text = "Date:"
        ' 
        ' lblDate
        ' 
        lblDate.Font = New Font("Arial Rounded MT Bold", 9.75F)
        lblDate.Location = New Point(616, 84)
        lblDate.Name = "lblDate"
        lblDate.ReadOnly = True
        lblDate.Size = New Size(170, 23)
        lblDate.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(12, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(403, 38)
        Label2.TabIndex = 9
        Label2.Text = "INVENTORY PULLOUTS"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.White
        ListView1.Columns.AddRange(New ColumnHeader() {uniform_id, item_name, category, level, gender, size, stock_quantity, price, status, date_added})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(21, 45)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(828, 291)
        ListView1.TabIndex = 11
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' uniform_id
        ' 
        uniform_id.Text = "ID"
        ' 
        ' item_name
        ' 
        item_name.Text = "item_name"
        item_name.Width = 82
        ' 
        ' category
        ' 
        category.Text = "category"
        category.Width = 100
        ' 
        ' level
        ' 
        level.Text = "level"
        level.Width = 75
        ' 
        ' gender
        ' 
        gender.Text = "gender"
        gender.Width = 75
        ' 
        ' size
        ' 
        size.Text = "size"
        size.Width = 80
        ' 
        ' stock_quantity
        ' 
        stock_quantity.Text = "stock_quantity"
        stock_quantity.Width = 100
        ' 
        ' price
        ' 
        price.Text = "price"
        ' 
        ' status
        ' 
        status.Text = "status"
        status.Width = 75
        ' 
        ' date_added
        ' 
        date_added.Text = "date_added"
        date_added.Width = 160
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(405, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 21)
        Label1.TabIndex = 21
        Label1.Text = "ADMIN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(pnlDetails)
        Panel1.Location = New Point(22, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1012, 590)
        Panel1.TabIndex = 22
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSeaGreen
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(ListView1)
        Panel2.Location = New Point(57, 221)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(881, 354)
        Panel2.TabIndex = 16
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(649, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search item..."
        txtSearch.Size = New Size(200, 25)
        txtSearch.TabIndex = 29
        ' 
        ' TotalPullouts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1101, 687)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "TotalPullouts"
        Text = "TotalPullouts"
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents btnClear As Button
    Private WithEvents btnSave As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents txtSearch As TextBox
End Class
