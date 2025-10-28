<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUniformView
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
        ListView2 = New ListView()
        uniform_id = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Label1 = New Label()
        txtSize = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        txtLevel = New TextBox()
        Label10 = New Label()
        Label13 = New Label()
        txtStatus = New TextBox()
        Label15 = New Label()
        txtDateAdded = New TextBox()
        btnRemove1 = New Button()
        Label16 = New Label()
        txtGender = New TextBox()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        Label17 = New Label()
        txtPrice = New TextBox()
        txtSearch = New TextBox()
        btnBack = New Button()
        btnSave = New Button()
        Panel1 = New Panel()
        Label18 = New Label()
        Panel2 = New Panel()
        ColumnHeader8 = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 18F)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(25, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(236, 28)
        Label2.TabIndex = 111
        Label2.Text = "SCHOOL UNIFORM"
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {uniform_id, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        ListView2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView2.GridLines = True
        ListView2.Location = New Point(16, 59)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(696, 401)
        ListView2.TabIndex = 120
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' uniform_id
        ' 
        uniform_id.Text = "id"
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Item"
        ColumnHeader1.Width = 90
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Level"
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Gender"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Size"
        ColumnHeader4.Width = 90
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Stock Quantity"
        ColumnHeader5.Width = 90
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Price"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ColumnHeader7.Width = 80
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial Rounded MT Bold", 9F)
        Label1.Location = New Point(9, 271)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 5
        Label1.Text = "Size:"
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
        ' Label3
        ' 
        Label3.Font = New Font("Arial Rounded MT Bold", 9F)
        Label3.Location = New Point(9, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 1
        Label3.Text = "Level:"
        Label3.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 11F)
        Label8.ForeColor = Color.DarkSlateGray
        Label8.Location = New Point(9, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 17)
        Label8.TabIndex = 0
        Label8.Text = "Item Details"
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
        ' Label10
        ' 
        Label10.Font = New Font("Arial Rounded MT Bold", 9F)
        Label10.Location = New Point(9, 319)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 9
        Label10.Text = "Status"
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Arial Rounded MT Bold", 9F)
        Label13.Location = New Point(9, 225)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 23)
        Label13.TabIndex = 3
        Label13.Text = "Gender:"
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
        ' Label15
        ' 
        Label15.Font = New Font("Arial Rounded MT Bold", 9F)
        Label15.Location = New Point(9, 364)
        Label15.Name = "Label15"
        Label15.Size = New Size(100, 23)
        Label15.TabIndex = 9
        Label15.Text = "Date Added:"
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
        ' btnRemove1
        ' 
        btnRemove1.BackColor = Color.Firebrick
        btnRemove1.FlatAppearance.BorderSize = 0
        btnRemove1.FlatStyle = FlatStyle.Flat
        btnRemove1.Font = New Font("Arial Rounded MT Bold", 12F)
        btnRemove1.ForeColor = Color.White
        btnRemove1.Location = New Point(305, 484)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(137, 36)
        btnRemove1.TabIndex = 124
        btnRemove1.Text = "Remove"
        btnRemove1.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Arial Rounded MT Bold", 9F)
        Label16.Location = New Point(9, 34)
        Label16.Name = "Label16"
        Label16.Size = New Size(100, 23)
        Label16.TabIndex = 1
        Label16.Text = "Item Name:"
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
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Rounded MT Bold", 9F)
        txtQuantity.Location = New Point(9, 106)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(170, 21)
        txtQuantity.TabIndex = 6
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("Arial Rounded MT Bold", 9F)
        Label17.Location = New Point(9, 135)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 23)
        Label17.TabIndex = 7
        Label17.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Rounded MT Bold", 9F)
        txtPrice.Location = New Point(9, 153)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(170, 21)
        txtPrice.TabIndex = 8
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
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 12F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(465, 484)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 123
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtLevel)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtStatus)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtDateAdded)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtGender)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(txtPrice)
        Panel1.Location = New Point(727, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 423)
        Panel1.TabIndex = 121
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Arial Rounded MT Bold", 9F)
        Label18.Location = New Point(9, 87)
        Label18.Name = "Label18"
        Label18.Size = New Size(100, 23)
        Label18.TabIndex = 5
        Label18.Text = "Quantity:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel2.Controls.Add(txtSearch)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(ListView2)
        Panel2.Controls.Add(btnRemove1)
        Panel2.Location = New Point(12, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(944, 576)
        Panel2.TabIndex = 120
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Date Added"
        ColumnHeader8.Width = 120
        ' 
        ' frmUniformView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(968, 664)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Name = "frmUniformView"
        Text = "School Uniform View"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents Label2 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents uniform_id As ColumnHeader
    Private WithEvents Label1 As Label
    Private WithEvents txtSize As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Private WithEvents txtLevel As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label13 As Label
    Private WithEvents txtStatus As TextBox
    Private WithEvents Label15 As Label
    Private WithEvents txtDateAdded As TextBox
    Private WithEvents btnRemove1 As Button
    Private WithEvents Label16 As Label
    Private WithEvents txtGender As TextBox
    Private WithEvents txtItemName As TextBox
    Private WithEvents txtQuantity As TextBox
    Private WithEvents Label17 As Label
    Private WithEvents txtPrice As TextBox
    Private WithEvents txtSearch As TextBox
    Private WithEvents btnBack As Button
    Private WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Private WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
