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
        btnAdd = New Button()
        Panel2 = New Panel()
        btnBack = New Button()
        btnClear = New Button()
        Panel3 = New Panel()
        Panel1 = New Panel()
        cboSize = New ComboBox()
        cboGender = New ComboBox()
        cboLevel = New ComboBox()
        cboCategory = New ComboBox()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
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
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.CadetBlue
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.MintCream
        btnAdd.Location = New Point(20, 13)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(488, 35)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD ITEMS"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnAdd)
        Panel2.Location = New Point(25, 490)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(526, 105)
        Panel2.TabIndex = 37
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.Honeydew
        btnBack.Location = New Point(272, 57)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(236, 35)
        btnBack.TabIndex = 10
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.IndianRed
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Honeydew
        btnClear.Location = New Point(19, 57)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(247, 35)
        btnClear.TabIndex = 9
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkSlateGray
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Panel2)
        Panel3.Location = New Point(24, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(573, 613)
        Panel3.TabIndex = 38
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(cboSize)
        Panel1.Controls.Add(cboGender)
        Panel1.Controls.Add(cboLevel)
        Panel1.Controls.Add(cboCategory)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
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
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(25, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 453)
        Panel1.TabIndex = 39
        ' 
        ' cboSize
        ' 
        cboSize.BackColor = Color.DarkSlateGray
        cboSize.DropDownStyle = ComboBoxStyle.DropDownList
        cboSize.DropDownWidth = 190
        cboSize.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboSize.ForeColor = SystemColors.Menu
        cboSize.FormattingEnabled = True
        cboSize.Items.AddRange(New Object() {"Bachelor of Science in Information Technology / Computer Science", "Bachelor of Science in Psychology", "Bachelor of Science in Criminal Justice", "Bachelor of Science in Education", "Bachelor of Science in Tourism Management", "Bachelor of Science in Hospitality Management", "Bachelor of Science in Accountancy", "Bachelor of Science in Business Addministration", "Bachelor of Science in Customs Administration", "Bachelor of Science in Real States", "Bachelor of Science in Engineering"})
        cboSize.Location = New Point(244, 266)
        cboSize.Name = "cboSize"
        cboSize.Size = New Size(175, 22)
        cboSize.TabIndex = 1011
        ' 
        ' cboGender
        ' 
        cboGender.BackColor = Color.DarkSlateGray
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList
        cboGender.DropDownWidth = 190
        cboGender.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboGender.ForeColor = SystemColors.Menu
        cboGender.FormattingEnabled = True
        cboGender.Items.AddRange(New Object() {"Bachelor of Science in Information Technology / Computer Science", "Bachelor of Science in Psychology", "Bachelor of Science in Criminal Justice", "Bachelor of Science in Education", "Bachelor of Science in Tourism Management", "Bachelor of Science in Hospitality Management", "Bachelor of Science in Accountancy", "Bachelor of Science in Business Addministration", "Bachelor of Science in Customs Administration", "Bachelor of Science in Real States", "Bachelor of Science in Engineering"})
        cboGender.Location = New Point(244, 232)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(175, 22)
        cboGender.TabIndex = 1010
        ' 
        ' cboLevel
        ' 
        cboLevel.BackColor = Color.DarkSlateGray
        cboLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboLevel.DropDownWidth = 190
        cboLevel.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboLevel.ForeColor = SystemColors.Menu
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"Bachelor of Science in Information Technology / Computer Science", "Bachelor of Science in Psychology", "Bachelor of Science in Criminal Justice", "Bachelor of Science in Education", "Bachelor of Science in Tourism Management", "Bachelor of Science in Hospitality Management", "Bachelor of Science in Accountancy", "Bachelor of Science in Business Addministration", "Bachelor of Science in Customs Administration", "Bachelor of Science in Real States", "Bachelor of Science in Engineering"})
        cboLevel.Location = New Point(244, 306)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(175, 22)
        cboLevel.TabIndex = 1009
        ' 
        ' cboCategory
        ' 
        cboCategory.BackColor = Color.DarkSlateGray
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.DropDownWidth = 190
        cboCategory.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboCategory.ForeColor = SystemColors.Menu
        cboCategory.FormattingEnabled = True
        cboCategory.Items.AddRange(New Object() {"Correction of Typographical Error", "Price Adjustment", "Size or Category Update"})
        cboCategory.Location = New Point(244, 92)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(175, 22)
        cboCategory.TabIndex = 1007
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(116, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 16)
        Label11.TabIndex = 1008
        Label11.Text = "Category:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.DarkSlateGray
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.DropDownWidth = 190
        ComboBox1.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.Menu
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Bachelor of Science in Information Technology / Computer Science", "Bachelor of Science in Psychology", "Bachelor of Science in Criminal Justice", "Bachelor of Science in Education", "Bachelor of Science in Tourism Management", "Bachelor of Science in Hospitality Management", "Bachelor of Science in Accountancy", "Bachelor of Science in Business Addministration", "Bachelor of Science in Customs Administration", "Bachelor of Science in Real States", "Bachelor of Science in Engineering"})
        ComboBox1.Location = New Point(244, 345)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(175, 22)
        ComboBox1.TabIndex = 1006
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(116, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 16)
        Label4.TabIndex = 1005
        Label4.Text = "Course :"
        ' 
        ' cboReason
        ' 
        cboReason.BackColor = Color.DarkSlateGray
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboReason.DropDownWidth = 190
        cboReason.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboReason.ForeColor = SystemColors.Menu
        cboReason.FormattingEnabled = True
        cboReason.Items.AddRange(New Object() {"Correction of Typographical Error", "Price Adjustment", "Size or Category Update"})
        cboReason.Location = New Point(244, 162)
        cboReason.Name = "cboReason"
        cboReason.Size = New Size(175, 22)
        cboReason.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(119, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 16)
        Label1.TabIndex = 1004
        Label1.Text = "Reason : "
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.PowderBlue
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Bookman Old Style", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.DarkSlateGray
        TextBox2.Location = New Point(-6, 16)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(533, 27)
        TextBox2.TabIndex = 1000
        TextBox2.Text = "Add Items"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblDateAdded
        ' 
        lblDateAdded.AutoSize = True
        lblDateAdded.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblDateAdded.Location = New Point(244, 379)
        lblDateAdded.Name = "lblDateAdded"
        lblDateAdded.Size = New Size(11, 16)
        lblDateAdded.TabIndex = 18
        lblDateAdded.Text = " "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(115, 412)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 16)
        Label10.TabIndex = 17
        Label10.Text = "Last Updated : "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblStatus.Location = New Point(244, 346)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 16)
        lblStatus.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(115, 379)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 16)
        Label9.TabIndex = 15
        Label9.Text = "Status : "
        ' 
        ' txtPrice
        ' 
        txtPrice.BackColor = Color.DarkSlateGray
        txtPrice.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtPrice.ForeColor = SystemColors.Menu
        txtPrice.Location = New Point(244, 196)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(175, 23)
        txtPrice.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(119, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 16)
        Label8.TabIndex = 13
        Label8.Text = "Price : "
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.DarkSlateGray
        txtStock.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtStock.ForeColor = SystemColors.Menu
        txtStock.Location = New Point(244, 123)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(175, 23)
        txtStock.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(115, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 16)
        Label7.TabIndex = 11
        Label7.Text = "Stock Quantity : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(119, 233)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 9
        Label6.Text = "Gender : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(119, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 16)
        Label5.TabIndex = 7
        Label5.Text = "Size : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(116, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 16)
        Label3.TabIndex = 3
        Label3.Text = "Level : "
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.DarkSlateGray
        txtItemName.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtItemName.ForeColor = SystemColors.Info
        txtItemName.Location = New Point(244, 59)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(175, 23)
        txtItemName.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(116, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 16)
        Label2.TabIndex = 1
        Label2.Text = "Item Name :"
        ' 
        ' frmAddItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(620, 662)
        Controls.Add(Panel3)
        Name = "frmAddItems"
        Text = "frmAddItems"
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Private WithEvents btnAdd As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnClear As Button
    Private WithEvents btnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents cboGender As ComboBox
End Class
