Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCorpoAttireView
    Inherits Form
    Private Label2 As Label
    Private WithEvents txtSearch As TextBox
    Private WithEvents btnModify, btnSave1 As Button


    Private txtItemName, txtCategory, txtStockQuantity, txtPrice, txtDateAdded As TextBox
    Private Label6, Label7, Label11, Label12, Label14 As Label
    Private btnRemove As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        txtSearch = New TextBox()
        pnlDetails = New Panel()
        Label5 = New Label()
        txtSize = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        lblTitle = New Label()
        TextBox5 = New TextBox()
        txtLevel = New TextBox()
        Label9 = New Label()
        Label4 = New Label()
        txtStatus = New TextBox()
        Label14 = New Label()
        txtDateAdded = New TextBox()
        Label6 = New Label()
        txtGender = New TextBox()
        txtItemName = New TextBox()
        Label7 = New Label()
        txtCategory = New TextBox()
        Label11 = New Label()
        txtStockQuantity = New TextBox()
        Label12 = New Label()
        txtPrice = New TextBox()
        btnModify = New Button()
        btnSave1 = New Button()
        btnBack = New Button()
        ListView1 = New ListView()
        Item = New ColumnHeader()
        Level = New ColumnHeader()
        Gender = New ColumnHeader()
        Size = New ColumnHeader()
        stock_quantity = New ColumnHeader()
        price = New ColumnHeader()
        Status = New ColumnHeader()
        Date_added = New ColumnHeader()
        Label1 = New Label()
        btnRemove1 = New Button()
        pnlDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(29, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 28)
        Label2.TabIndex = 1
        Label2.Text = "CORPORATE ATTIRE"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(567, 22)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search item..."
        txtSearch.Size = New Size(200, 25)
        txtSearch.TabIndex = 2
        ' 
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.White
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(Label5)
        pnlDetails.Controls.Add(txtSize)
        pnlDetails.Controls.Add(Label3)
        pnlDetails.Controls.Add(Label8)
        pnlDetails.Controls.Add(lblTitle)
        pnlDetails.Controls.Add(TextBox5)
        pnlDetails.Controls.Add(txtLevel)
        pnlDetails.Controls.Add(Label9)
        pnlDetails.Controls.Add(Label4)
        pnlDetails.Controls.Add(txtStatus)
        pnlDetails.Controls.Add(Label14)
        pnlDetails.Controls.Add(txtDateAdded)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(txtGender)
        pnlDetails.Controls.Add(txtItemName)
        pnlDetails.Controls.Add(Label7)
        pnlDetails.Controls.Add(txtCategory)
        pnlDetails.Controls.Add(Label11)
        pnlDetails.Controls.Add(txtStockQuantity)
        pnlDetails.Controls.Add(Label12)
        pnlDetails.Controls.Add(txtPrice)
        pnlDetails.Location = New Point(755, 70)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(200, 518)
        pnlDetails.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Rounded MT Bold", 9F)
        Label5.Location = New Point(10, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 5
        Label5.Text = "Size:"
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Arial Rounded MT Bold", 9F)
        txtSize.Location = New Point(10, 335)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(170, 21)
        txtSize.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial Rounded MT Bold", 9F)
        Label3.Location = New Point(10, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 1
        Label3.Text = "Level:"
        Label3.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial Rounded MT Bold", 9F)
        Label8.Location = New Point(10, 361)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 7
        Label8.Text = "Price:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 11F)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(10, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(94, 17)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Item Details"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Arial Rounded MT Bold", 9F)
        TextBox5.Location = New Point(10, 382)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(170, 21)
        TextBox5.TabIndex = 8
        ' 
        ' txtLevel
        ' 
        txtLevel.Font = New Font("Arial Rounded MT Bold", 9F)
        txtLevel.Location = New Point(10, 243)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(170, 21)
        txtLevel.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial Rounded MT Bold", 9F)
        Label9.Location = New Point(10, 410)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 9
        Label9.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial Rounded MT Bold", 9F)
        Label4.Location = New Point(10, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Gender:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Arial Rounded MT Bold", 9F)
        txtStatus.Location = New Point(10, 427)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(170, 21)
        txtStatus.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial Rounded MT Bold", 9F)
        Label14.Location = New Point(10, 455)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 9
        Label14.Text = "Date Added:"
        ' 
        ' txtDateAdded
        ' 
        txtDateAdded.Font = New Font("Arial Rounded MT Bold", 9F)
        txtDateAdded.Location = New Point(10, 475)
        txtDateAdded.Name = "txtDateAdded"
        txtDateAdded.Size = New Size(170, 21)
        txtDateAdded.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Rounded MT Bold", 9F)
        Label6.Location = New Point(10, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 1
        Label6.Text = "Item Name:"
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Arial Rounded MT Bold", 9F)
        txtGender.Location = New Point(10, 289)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(170, 21)
        txtGender.TabIndex = 4
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Arial Rounded MT Bold", 9F)
        txtItemName.Location = New Point(10, 55)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(170, 21)
        txtItemName.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial Rounded MT Bold", 9F)
        Label7.Location = New Point(10, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 3
        Label7.Text = "Category:"
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Arial Rounded MT Bold", 9F)
        txtCategory.Location = New Point(10, 103)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(170, 21)
        txtCategory.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial Rounded MT Bold", 9F)
        Label11.Location = New Point(10, 132)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 5
        Label11.Text = "Quantity:"
        ' 
        ' txtStockQuantity
        ' 
        txtStockQuantity.Font = New Font("Arial Rounded MT Bold", 9F)
        txtStockQuantity.Location = New Point(10, 151)
        txtStockQuantity.Name = "txtStockQuantity"
        txtStockQuantity.Size = New Size(170, 21)
        txtStockQuantity.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial Rounded MT Bold", 9F)
        Label12.Location = New Point(10, 180)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 7
        Label12.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Rounded MT Bold", 9F)
        txtPrice.Location = New Point(10, 198)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(170, 21)
        txtPrice.TabIndex = 8
        ' 
        ' btnModify
        ' 
        btnModify.BackColor = Color.Teal
        btnModify.FlatAppearance.BorderSize = 0
        btnModify.FlatStyle = FlatStyle.Flat
        btnModify.Font = New Font("Arial Rounded MT Bold", 12F)
        btnModify.ForeColor = Color.White
        btnModify.Location = New Point(51, 498)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(128, 36)
        btnModify.TabIndex = 5
        btnModify.Text = "Modify"
        btnModify.UseVisualStyleBackColor = False
        ' 
        ' btnSave1
        ' 
        btnSave1.BackColor = Color.SeaGreen
        btnSave1.FlatAppearance.BorderSize = 0
        btnSave1.FlatStyle = FlatStyle.Flat
        btnSave1.Font = New Font("Arial Rounded MT Bold", 12F)
        btnSave1.ForeColor = Color.White
        btnSave1.Location = New Point(362, 498)
        btnSave1.Name = "btnSave1"
        btnSave1.Size = New Size(128, 36)
        btnSave1.TabIndex = 7
        btnSave1.Text = "Save"
        btnSave1.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(513, 498)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Item, Level, Gender, Size, stock_quantity, price, Status, Date_added})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 81)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(728, 401)
        ListView1.TabIndex = 13
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Item
        ' 
        Item.Text = "Item"
        ' 
        ' Level
        ' 
        Level.Text = "Level"
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
        Date_added.Text = "Date Added"
        Date_added.Width = 120
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 0
        Label1.Text = "REMOVE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRemove1
        ' 
        btnRemove1.BackColor = Color.Firebrick
        btnRemove1.FlatAppearance.BorderSize = 0
        btnRemove1.FlatStyle = FlatStyle.Flat
        btnRemove1.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemove1.ForeColor = Color.White
        btnRemove1.Location = New Point(201, 498)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(137, 36)
        btnRemove1.TabIndex = 14
        btnRemove1.Text = "Remove"
        btnRemove1.UseVisualStyleBackColor = False
        ' 
        ' frmCorpoAttireView
        ' 
        BackColor = Color.LightCyan
        ClientSize = New Size(968, 600)
        Controls.Add(btnRemove1)
        Controls.Add(ListView1)
        Controls.Add(btnBack)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(pnlDetails)
        Controls.Add(btnModify)
        Controls.Add(btnSave1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmCorpoAttireView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management"
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblTitle As Label
    Private WithEvents Label3 As Label
    Private WithEvents txtLevel As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txtGender As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtSize As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents TextBox5 As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents txtStatus As TextBox
    Private WithEvents btnBack As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Level As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents stock_quantity As ColumnHeader
    Friend WithEvents price As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Date_added As ColumnHeader
    Friend WithEvents Label1 As Label
    Private WithEvents btnRemove1 As Button

End Class
