<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockManagement
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
        rdoAllCategory = New RadioButton()
        rdoSchoolUniform = New RadioButton()
        rdoPEUniform = New RadioButton()
        rdoCorpo = New RadioButton()
        Panel1 = New Panel()
        Label3 = New Label()
        cboLevel = New ComboBox()
        txtSearch = New TextBox()
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
        pnlDetails = New Panel()
        txtLevel = New TextBox()
        Label8 = New Label()
        Label5 = New Label()
        txtSize = New TextBox()
        lblTitle = New Label()
        Label9 = New Label()
        Label6 = New Label()
        txtStatus = New TextBox()
        Label14 = New Label()
        txtDateAdded = New TextBox()
        Label7 = New Label()
        txtGender = New TextBox()
        txtItemName = New TextBox()
        Label11 = New Label()
        txtQuantity = New TextBox()
        Label12 = New Label()
        txtPrice = New TextBox()
        btnRemove1 = New Button()
        Panel2 = New Panel()
        btnEditItems = New Button()
        btnAdd = New Button()
        Panel1.SuspendLayout()
        pnlDetails.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(393, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 21)
        Label1.TabIndex = 20
        Label1.Text = "ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(16, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(385, 38)
        Label2.TabIndex = 16
        Label2.Text = "STOCK MANAGEMENT"
        ' 
        ' rdoAllCategory
        ' 
        rdoAllCategory.AutoSize = True
        rdoAllCategory.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        rdoAllCategory.Location = New Point(27, 13)
        rdoAllCategory.Name = "rdoAllCategory"
        rdoAllCategory.Size = New Size(103, 21)
        rdoAllCategory.TabIndex = 22
        rdoAllCategory.TabStop = True
        rdoAllCategory.Text = "All Category"
        rdoAllCategory.UseVisualStyleBackColor = True
        ' 
        ' rdoSchoolUniform
        ' 
        rdoSchoolUniform.AutoSize = True
        rdoSchoolUniform.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        rdoSchoolUniform.Location = New Point(147, 13)
        rdoSchoolUniform.Name = "rdoSchoolUniform"
        rdoSchoolUniform.Size = New Size(122, 21)
        rdoSchoolUniform.TabIndex = 23
        rdoSchoolUniform.TabStop = True
        rdoSchoolUniform.Text = "School Uniform"
        rdoSchoolUniform.UseVisualStyleBackColor = True
        ' 
        ' rdoPEUniform
        ' 
        rdoPEUniform.AutoSize = True
        rdoPEUniform.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        rdoPEUniform.Location = New Point(284, 13)
        rdoPEUniform.Name = "rdoPEUniform"
        rdoPEUniform.Size = New Size(96, 21)
        rdoPEUniform.TabIndex = 24
        rdoPEUniform.TabStop = True
        rdoPEUniform.Text = "PE Uniform"
        rdoPEUniform.UseVisualStyleBackColor = True
        ' 
        ' rdoCorpo
        ' 
        rdoCorpo.AutoSize = True
        rdoCorpo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        rdoCorpo.Location = New Point(393, 13)
        rdoCorpo.Name = "rdoCorpo"
        rdoCorpo.Size = New Size(126, 21)
        rdoCorpo.TabIndex = 25
        rdoCorpo.TabStop = True
        rdoCorpo.Text = "Corporate Attire"
        rdoCorpo.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cboLevel)
        Panel1.Controls.Add(rdoCorpo)
        Panel1.Controls.Add(rdoAllCategory)
        Panel1.Controls.Add(rdoPEUniform)
        Panel1.Controls.Add(rdoSchoolUniform)
        Panel1.Location = New Point(18, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 48)
        Panel1.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(719, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 17)
        Label3.TabIndex = 27
        Label3.Text = "School level:"
        ' 
        ' cboLevel
        ' 
        cboLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboLevel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Kindergarten", "Elementary", "Junior High", "Senior High", "College"})
        cboLevel.Location = New Point(807, 13)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(159, 25)
        cboLevel.TabIndex = 26
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(515, 81)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search item..."
        txtSearch.Size = New Size(214, 25)
        txtSearch.TabIndex = 28
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {uniform_id, Item, Level, Gender, Size, stock_quantity, price, Status, Date_added})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(19, 112)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(710, 352)
        ListView1.TabIndex = 29
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
        ' pnlDetails
        ' 
        pnlDetails.BackColor = Color.White
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(txtLevel)
        pnlDetails.Controls.Add(Label8)
        pnlDetails.Controls.Add(Label5)
        pnlDetails.Controls.Add(txtSize)
        pnlDetails.Controls.Add(lblTitle)
        pnlDetails.Controls.Add(Label9)
        pnlDetails.Controls.Add(Label6)
        pnlDetails.Controls.Add(txtStatus)
        pnlDetails.Controls.Add(Label14)
        pnlDetails.Controls.Add(txtDateAdded)
        pnlDetails.Controls.Add(Label7)
        pnlDetails.Controls.Add(txtGender)
        pnlDetails.Controls.Add(txtItemName)
        pnlDetails.Controls.Add(Label11)
        pnlDetails.Controls.Add(txtQuantity)
        pnlDetails.Controls.Add(Label12)
        pnlDetails.Controls.Add(txtPrice)
        pnlDetails.Location = New Point(759, 90)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Size = New Size(225, 423)
        pnlDetails.TabIndex = 30
        ' 
        ' txtLevel
        ' 
        txtLevel.Font = New Font("Arial Rounded MT Bold", 9F)
        txtLevel.Location = New Point(10, 199)
        txtLevel.Name = "txtLevel"
        txtLevel.ReadOnly = True
        txtLevel.Size = New Size(200, 21)
        txtLevel.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial Rounded MT Bold", 9F)
        Label8.Location = New Point(10, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 11
        Label8.Text = "Level:"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Rounded MT Bold", 9F)
        Label5.Location = New Point(10, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 5
        Label5.Text = "Size:"
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Arial Rounded MT Bold", 9F)
        txtSize.Location = New Point(10, 291)
        txtSize.Name = "txtSize"
        txtSize.ReadOnly = True
        txtSize.Size = New Size(200, 21)
        txtSize.TabIndex = 6
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
        ' Label9
        ' 
        Label9.Font = New Font("Arial Rounded MT Bold", 9F)
        Label9.Location = New Point(10, 320)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 9
        Label9.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial Rounded MT Bold", 9F)
        Label6.Location = New Point(10, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 3
        Label6.Text = "Gender:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Arial Rounded MT Bold", 9F)
        txtStatus.Location = New Point(10, 337)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(200, 21)
        txtStatus.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial Rounded MT Bold", 9F)
        Label14.Location = New Point(10, 365)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 9
        Label14.Text = "Date Added:"
        ' 
        ' txtDateAdded
        ' 
        txtDateAdded.Font = New Font("Arial Rounded MT Bold", 9F)
        txtDateAdded.Location = New Point(10, 385)
        txtDateAdded.Name = "txtDateAdded"
        txtDateAdded.ReadOnly = True
        txtDateAdded.Size = New Size(200, 21)
        txtDateAdded.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial Rounded MT Bold", 9F)
        Label7.Location = New Point(10, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 1
        Label7.Text = "Item Name:"
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Arial Rounded MT Bold", 9F)
        txtGender.Location = New Point(10, 245)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(200, 21)
        txtGender.TabIndex = 4
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Arial Rounded MT Bold", 9F)
        txtItemName.Location = New Point(10, 55)
        txtItemName.Name = "txtItemName"
        txtItemName.ReadOnly = True
        txtItemName.Size = New Size(200, 21)
        txtItemName.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial Rounded MT Bold", 9F)
        Label11.Location = New Point(10, 88)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 5
        Label11.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Rounded MT Bold", 9F)
        txtQuantity.Location = New Point(10, 107)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.ReadOnly = True
        txtQuantity.Size = New Size(200, 21)
        txtQuantity.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial Rounded MT Bold", 9F)
        Label12.Location = New Point(10, 136)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 7
        Label12.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Rounded MT Bold", 9F)
        txtPrice.Location = New Point(10, 154)
        txtPrice.Name = "txtPrice"
        txtPrice.ReadOnly = True
        txtPrice.Size = New Size(200, 21)
        txtPrice.TabIndex = 8
        ' 
        ' btnRemove1
        ' 
        btnRemove1.BackColor = Color.Firebrick
        btnRemove1.FlatAppearance.BorderSize = 0
        btnRemove1.FlatStyle = FlatStyle.Flat
        btnRemove1.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemove1.ForeColor = Color.White
        btnRemove1.Location = New Point(439, 477)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(137, 36)
        btnRemove1.TabIndex = 34
        btnRemove1.Text = "Remove"
        btnRemove1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel2.Controls.Add(btnEditItems)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(btnRemove1)
        Panel2.Controls.Add(pnlDetails)
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(ListView1)
        Panel2.Location = New Point(12, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1014, 608)
        Panel2.TabIndex = 35
        ' 
        ' btnEditItems
        ' 
        btnEditItems.BackColor = Color.SaddleBrown
        btnEditItems.FlatAppearance.BorderSize = 0
        btnEditItems.FlatStyle = FlatStyle.Flat
        btnEditItems.Font = New Font("Arial Rounded MT Bold", 12F)
        btnEditItems.ForeColor = Color.White
        btnEditItems.Location = New Point(290, 477)
        btnEditItems.Name = "btnEditItems"
        btnEditItems.Size = New Size(128, 36)
        btnEditItems.TabIndex = 36
        btnEditItems.Text = "Edit Items"
        btnEditItems.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.SeaGreen
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial Rounded MT Bold", 12F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(142, 477)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(128, 36)
        btnAdd.TabIndex = 35
        btnAdd.Text = "Add Items"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' frmStockManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1038, 693)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "frmStockManagement"
        Text = "StockManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoAllCategory As RadioButton
    Friend WithEvents rdoSchoolUniform As RadioButton
    Friend WithEvents rdoPEUniform As RadioButton
    Friend WithEvents rdoCorpo As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents Label3 As Label
    Private WithEvents txtSearch As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents Level As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents stock_quantity As ColumnHeader
    Friend WithEvents price As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Date_added As ColumnHeader
    Friend WithEvents pnlDetails As Panel
    Private WithEvents Label5 As Label
    Private WithEvents txtSize As TextBox
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
    Private WithEvents txtQuantity As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtPrice As TextBox
    Private WithEvents btnRemove1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents uniform_id As ColumnHeader
    Private WithEvents btnAdd As Button
    Private WithEvents btnEditItems As Button
    Private WithEvents Label8 As Label
End Class
