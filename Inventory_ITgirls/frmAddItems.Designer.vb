<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItems
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
        Panel1 = New Panel()
        cboReason = New ComboBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        lblDateAdded = New Label()
        Label10 = New Label()
        lblStatus = New Label()
        Label9 = New Label()
        txtPrice = New TextBox()
        Label8 = New Label()
        txtStock = New TextBox()
        Label7 = New Label()
        cboGender = New ComboBox()
        Label6 = New Label()
        cboSize = New ComboBox()
        Label5 = New Label()
        cboCategory = New ComboBox()
        Label4 = New Label()
        cboLevel = New ComboBox()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label2 = New Label()
        btnAdd = New Button()
        Panel2 = New Panel()
        btnBack = New Button()
        btnClear = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.Controls.Add(cboReason)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(lblDateAdded)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(lblStatus)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtPrice)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtStock)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(cboGender)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(cboSize)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(cboCategory)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cboLevel)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(31, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(351, 431)
        Panel1.TabIndex = 0
        ' 
        ' cboReason
        ' 
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboReason.DropDownWidth = 190
        cboReason.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboReason.FormattingEnabled = True
        cboReason.Items.AddRange(New Object() {"New Uniform Design", "Initial Stock Entry", "New Supplier Item"})
        cboReason.Location = New Point(149, 121)
        cboReason.Name = "cboReason"
        cboReason.Size = New Size(175, 22)
        cboReason.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(21, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 16)
        Label1.TabIndex = 1001
        Label1.Text = "Reason: "
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DarkSlateGray
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Bookman Old Style", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(-7, 11)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(366, 27)
        TextBox2.TabIndex = 1000
        TextBox2.Text = "Add New Item"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblDateAdded
        ' 
        lblDateAdded.AutoSize = True
        lblDateAdded.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblDateAdded.Location = New Point(149, 367)
        lblDateAdded.Name = "lblDateAdded"
        lblDateAdded.Size = New Size(11, 16)
        lblDateAdded.TabIndex = 18
        lblDateAdded.Text = " "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(21, 367)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 16)
        Label10.TabIndex = 17
        Label10.Text = "Date Added : "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblStatus.Location = New Point(149, 335)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 16)
        lblStatus.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(21, 335)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 16)
        Label9.TabIndex = 15
        Label9.Text = "Status : "
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtPrice.Location = New Point(149, 189)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(175, 23)
        txtPrice.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(24, 192)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 16)
        Label8.TabIndex = 13
        Label8.Text = "Price : "
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtStock.Location = New Point(149, 154)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(175, 23)
        txtStock.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(20, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 16)
        Label7.TabIndex = 11
        Label7.Text = "Stock Quantity : "
        ' 
        ' cboGender
        ' 
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList
        cboGender.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        cboGender.FormattingEnabled = True
        cboGender.Items.AddRange(New Object() {"Female", "Male", "Unisex"})
        cboGender.Location = New Point(149, 224)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(175, 24)
        cboGender.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(24, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 9
        Label6.Text = "Gender : "
        ' 
        ' cboSize
        ' 
        cboSize.DropDownStyle = ComboBoxStyle.DropDownList
        cboSize.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        cboSize.FormattingEnabled = True
        cboSize.Items.AddRange(New Object() {"Extra Small", "Small", "Medium", "Large", "Extra Large", "2XL", "3XL", "4XL", "5XL", "6XL"})
        cboSize.Location = New Point(149, 262)
        cboSize.Name = "cboSize"
        cboSize.Size = New Size(175, 24)
        cboSize.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(24, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 16)
        Label5.TabIndex = 7
        Label5.Text = "Size : "
        ' 
        ' cboCategory
        ' 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        cboCategory.FormattingEnabled = True
        cboCategory.Items.AddRange(New Object() {"School Uniform", "Corporate Attire", "PE Uniform"})
        cboCategory.Location = New Point(149, 86)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(175, 24)
        cboCategory.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(21, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 16)
        Label4.TabIndex = 5
        Label4.Text = "Category : "
        ' 
        ' cboLevel
        ' 
        cboLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboLevel.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"College", "Elementary", "Junior High", "Kindergarten", "Senior High"})
        cboLevel.Location = New Point(149, 297)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(175, 24)
        cboLevel.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(21, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 16)
        Label3.TabIndex = 3
        Label3.Text = "Level : "
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtItemName.Location = New Point(149, 51)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(175, 23)
        txtItemName.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(21, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 16)
        Label2.TabIndex = 1
        Label2.Text = "Item Name :"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.SeaGreen
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(20, 13)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 35)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add Items"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSeaGreen
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnAdd)
        Panel2.Location = New Point(30, 438)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(352, 67)
        Panel2.TabIndex = 37
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(237, 13)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(95, 35)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(128, 13)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(95, 35)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' frmAddItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(412, 540)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmAddItems"
        Text = "frmAddItems"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents Label10 As Label
    Private WithEvents btnAdd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Private WithEvents btnClear As Button
    Private WithEvents btnBack As Button
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents Label1 As Label
End Class
