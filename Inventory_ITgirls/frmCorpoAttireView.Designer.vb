Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCorpoAttireView
    Inherits Form

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Panel1 = New Panel()
        txtSearch = New TextBox()
        btnBack1 = New Button()
        btnSave = New Button()
        pnlDetails = New Panel()
        Label5 = New Label()
        txtSize = New TextBox()
        Label4 = New Label()
        lblTitle = New Label()
        txtLevel = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        txtStatus = New TextBox()
        Label14 = New Label()
        txtDateAdded = New TextBox()
        Label7 = New Label()
        txtGender = New TextBox()
        txtItemName = New TextBox()
        Label11 = New Label()
        txtStockQuantity = New TextBox()
        Label12 = New Label()
        txtPrice = New TextBox()
        ListView1 = New ListView()
        uniform_id = New ColumnHeader()
        Item = New ColumnHeader()
        Level = New ColumnHeader()
        Gender = New ColumnHeader()
        Size = New ColumnHeader()
        stock_quantity = New ColumnHeader()
        price = New ColumnHeader()
        Status = New ColumnHeader()
        Date_added = New ColumnHeader()
        btnRemove = New Button()
        Panel1.SuspendLayout()
        pnlDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(25, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 28)
        Label2.TabIndex = 111
        Label2.Text = "CORPORATE ATTIRE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(btnBack1)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(pnlDetails)
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(btnRemove)
        Panel1.Location = New Point(12, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(944, 576)
        Panel1.TabIndex = 118
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(512, 28)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search item..."
        txtSearch.Size = New Size(200, 25)
        txtSearch.TabIndex = 119
        ' 
        ' btnBack1
        ' 
        btnBack1.BackColor = Color.DimGray
        btnBack1.FlatAppearance.BorderSize = 0
        btnBack1.FlatStyle = FlatStyle.Flat
        btnBack1.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack1.ForeColor = Color.White
        btnBack1.Location = New Point(465, 484)
        btnBack1.Name = "btnBack1"
        btnBack1.Size = New Size(137, 36)
        btnBack1.TabIndex = 123
        btnBack1.Text = "Back"
        btnBack1.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SeaGreen
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 12F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(154, 484)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(128, 36)
        btnSave.TabIndex = 122
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.White
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(Label5)
        pnlDetails.Controls.Add(txtSize)
        pnlDetails.Controls.Add(Label4)
        pnlDetails.Controls.Add(lblTitle)
        pnlDetails.Controls.Add(txtLevel)
        pnlDetails.Controls.Add(Label9)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(txtStatus)
        pnlDetails.Controls.Add(Label14)
        pnlDetails.Controls.Add(txtDateAdded)
        pnlDetails.Controls.Add(Label7)
        pnlDetails.Controls.Add(txtGender)
        pnlDetails.Controls.Add(txtItemName)
        pnlDetails.Controls.Add(Label11)
        pnlDetails.Controls.Add(txtStockQuantity)
        pnlDetails.Controls.Add(Label12)
        pnlDetails.Controls.Add(txtPrice)
        pnlDetails.Location = New Point(727, 37)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(200, 423)
        pnlDetails.TabIndex = 121
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Rounded MT Bold", 9F)
        Label5.Location = New Point(9, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 5
        Label5.Text = "Size:"
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Arial Rounded MT Bold", 9F)
        txtSize.Location = New Point(9, 290)
        txtSize.Name = "txtSize"
        txtSize.ReadOnly = True
        txtSize.Size = New Size(170, 21)
        txtSize.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial Rounded MT Bold", 9F)
        Label4.Location = New Point(9, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 1
        Label4.Text = "Level:"
        Label4.Visible = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 11F)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(9, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(94, 17)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Item Details"
        ' 
        ' txtLevel
        ' 
        txtLevel.Font = New Font("Arial Rounded MT Bold", 9F)
        txtLevel.Location = New Point(9, 198)
        txtLevel.Name = "txtLevel"
        txtLevel.ReadOnly = True
        txtLevel.Size = New Size(170, 21)
        txtLevel.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial Rounded MT Bold", 9F)
        Label9.Location = New Point(9, 319)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 9
        Label9.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Rounded MT Bold", 9F)
        Label6.Location = New Point(9, 225)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 3
        Label6.Text = "Gender:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Arial Rounded MT Bold", 9F)
        txtStatus.Location = New Point(9, 336)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(170, 21)
        txtStatus.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial Rounded MT Bold", 9F)
        Label14.Location = New Point(9, 364)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 9
        Label14.Text = "Date Added:"
        ' 
        ' txtDateAdded
        ' 
        txtDateAdded.Font = New Font("Arial Rounded MT Bold", 9F)
        txtDateAdded.Location = New Point(9, 384)
        txtDateAdded.Name = "txtDateAdded"
        txtDateAdded.ReadOnly = True
        txtDateAdded.Size = New Size(170, 21)
        txtDateAdded.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial Rounded MT Bold", 9F)
        Label7.Location = New Point(9, 34)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 1
        Label7.Text = "Item Name:"
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Arial Rounded MT Bold", 9F)
        txtGender.Location = New Point(9, 244)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(170, 21)
        txtGender.TabIndex = 4
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Arial Rounded MT Bold", 9F)
        txtItemName.Location = New Point(9, 54)
        txtItemName.Name = "txtItemName"
        txtItemName.ReadOnly = True
        txtItemName.Size = New Size(170, 21)
        txtItemName.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial Rounded MT Bold", 9F)
        Label11.Location = New Point(9, 87)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 5
        Label11.Text = "Quantity:"
        ' 
        ' txtStockQuantity
        ' 
        txtStockQuantity.Font = New Font("Arial Rounded MT Bold", 9F)
        txtStockQuantity.Location = New Point(9, 106)
        txtStockQuantity.Name = "txtStockQuantity"
        txtStockQuantity.Size = New Size(170, 21)
        txtStockQuantity.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial Rounded MT Bold", 9F)
        Label12.Location = New Point(9, 135)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 7
        Label12.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Rounded MT Bold", 9F)
        txtPrice.Location = New Point(9, 153)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(170, 21)
        txtPrice.TabIndex = 8
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {uniform_id, Item, Level, Gender, Size, stock_quantity, price, Status, Date_added})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(16, 59)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(696, 401)
        ListView1.TabIndex = 120
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' uniform_id
        ' 
        uniform_id.Text = "id"
        ' 
        ' Item
        ' 
        Item.Text = "Item"
        Item.Width = 90
        ' 
        ' Level
        ' 
        Level.Text = "Level"
        Level.Width = 80
        ' 
        ' Gender
        ' 
        Gender.Text = "Gender"
        ' 
        ' Size
        ' 
        Size.Text = "Size"
        Size.Width = 90
        ' 
        ' stock_quantity
        ' 
        stock_quantity.Text = "Stock Quantity"
        stock_quantity.Width = 90
        ' 
        ' price
        ' 
        price.Text = "Price"
        ' 
        ' Status
        ' 
        Status.Text = "Status"
        Status.Width = 80
        ' 
        ' Date_added
        ' 
        Date_added.Text = "Date_added"
        Date_added.Width = 120
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Firebrick
        btnRemove.FlatAppearance.BorderSize = 0
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(305, 484)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(137, 36)
        btnRemove.TabIndex = 124
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' frmCorpoAttireView
        ' 
        BackColor = Color.LightCyan
        ClientSize = New Size(968, 664)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmCorpoAttireView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents txtSearch As TextBox
    Private WithEvents btnBack1 As Button
    Private WithEvents btnSave As Button
    Friend WithEvents pnlDetails As Panel
    Private WithEvents Label5 As Label
    Private WithEvents txtSize As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents lblTitle As Label
    Private WithEvents txtLevel As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents Label6 As Label
    Private WithEvents txtStatus As TextBox
    Private WithEvents Label14 As Label
    Private WithEvents txtDateAdded As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents txtGender As TextBox
    Private WithEvents txtItemName As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents txtStockQuantity As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtPrice As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Level As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents stock_quantity As ColumnHeader
    Friend WithEvents price As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Date_added As ColumnHeader
    Private WithEvents btnRemove As Button
    Friend WithEvents uniform_id As ColumnHeader

End Class
