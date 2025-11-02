<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditItems
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
        btnClear = New Button()
        TextBox2 = New TextBox()
        lblDateAdded = New Label()
        Label10 = New Label()
        lblStatus = New Label()
        Label9 = New Label()
        txtPrice = New TextBox()
        Label8 = New Label()
        txtStock = New TextBox()
        Label7 = New Label()
        Panel2 = New Panel()
        btnBack = New Button()
        btnSave = New Button()
        Label6 = New Label()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        cboReason = New ComboBox()
        Label1 = New Label()
        txtLevel = New TextBox()
        txtSize = New TextBox()
        txtGender = New TextBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(136, 19)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(95, 35)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.SaddleBrown
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Bookman Old Style", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(-7, 11)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(366, 27)
        TextBox2.TabIndex = 1000
        TextBox2.Text = "Edit Item"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblDateAdded
        ' 
        lblDateAdded.AutoSize = True
        lblDateAdded.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblDateAdded.Location = New Point(149, 347)
        lblDateAdded.Name = "lblDateAdded"
        lblDateAdded.Size = New Size(11, 16)
        lblDateAdded.TabIndex = 18
        lblDateAdded.Text = " "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(21, 347)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 16)
        Label10.TabIndex = 17
        Label10.Text = "Last Updated : "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        lblStatus.Location = New Point(149, 314)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 16)
        lblStatus.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(21, 314)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 16)
        Label9.TabIndex = 15
        Label9.Text = "Status : "
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtPrice.Location = New Point(149, 164)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(175, 23)
        txtPrice.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(24, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 16)
        Label8.TabIndex = 13
        Label8.Text = "Price : "
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtStock.Location = New Point(149, 91)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(175, 23)
        txtStock.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(20, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 16)
        Label7.TabIndex = 11
        Label7.Text = "Stock Quantity : "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSeaGreen
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnSave)
        Panel2.Location = New Point(31, 414)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(351, 76)
        Panel2.TabIndex = 39
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(239, 19)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(96, 35)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SeaGreen
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Arial Rounded MT Bold", 9.75F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(15, 19)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(115, 35)
        btnSave.TabIndex = 7
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(24, 201)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 9
        Label6.Text = "Gender : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(21, 280)
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(24, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 16)
        Label5.TabIndex = 7
        Label5.Text = "Size : "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.Controls.Add(cboReason)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtLevel)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(txtGender)
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
        Panel1.Location = New Point(31, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(351, 431)
        Panel1.TabIndex = 38
        ' 
        ' cboReason
        ' 
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboReason.DropDownWidth = 190
        cboReason.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboReason.FormattingEnabled = True
        cboReason.Items.AddRange(New Object() {"Correction of Typographical Error", "Price Adjustment", "Size or Category Update"})
        cboReason.Location = New Point(149, 130)
        cboReason.Name = "cboReason"
        cboReason.Size = New Size(175, 22)
        cboReason.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(24, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 16)
        Label1.TabIndex = 1004
        Label1.Text = "Reason : "
        ' 
        ' txtLevel
        ' 
        txtLevel.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtLevel.Location = New Point(149, 273)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(175, 23)
        txtLevel.TabIndex = 6
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtSize.Location = New Point(149, 237)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(175, 23)
        txtSize.TabIndex = 5
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Bold)
        txtGender.Location = New Point(149, 201)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(175, 23)
        txtGender.TabIndex = 4
        ' 
        ' frmEditItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(412, 505)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmEditItems"
        Text = "frmEditItems"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents btnClear As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnBack As Button
    Private WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboReason As ComboBox
End Class
