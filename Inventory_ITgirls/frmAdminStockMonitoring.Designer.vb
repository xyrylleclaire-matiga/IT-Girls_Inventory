<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminStockMonitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminStockMonitoring))
        Label2 = New Label()
        Panel1 = New Panel()
        chkFilterByDate = New CheckBox()
        rdoDelete = New RadioButton()
        rdoPullout = New RadioButton()
        rdoAdd = New RadioButton()
        rdoUpdate = New RadioButton()
        rdoAllRecord = New RadioButton()
        btnPrint = New Button()
        lblDeleted = New Label()
        lblPullout = New Label()
        dtDate = New DateTimePicker()
        txtSearch = New TextBox()
        lblUpdated = New Label()
        lblAdded = New Label()
        Button4 = New Button()
        Label5 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        Button2 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        btnAdded = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        Button5 = New Button()
        btnPreview = New Button()
        Button6 = New Button()
        Label6 = New Label()
        lblTotalRecords = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gadugi", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(59, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(428, 40)
        Label2.TabIndex = 10
        Label2.Text = "INVENTORY HISTORY LOG"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel1.Controls.Add(chkFilterByDate)
        Panel1.Controls.Add(rdoDelete)
        Panel1.Controls.Add(rdoPullout)
        Panel1.Controls.Add(rdoAdd)
        Panel1.Controls.Add(rdoUpdate)
        Panel1.Controls.Add(rdoAllRecord)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(lblDeleted)
        Panel1.Controls.Add(lblPullout)
        Panel1.Controls.Add(dtDate)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(lblUpdated)
        Panel1.Controls.Add(lblAdded)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnAdded)
        Panel1.Location = New Point(58, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1014, 207)
        Panel1.TabIndex = 11
        ' 
        ' chkFilterByDate
        ' 
        chkFilterByDate.AutoSize = True
        chkFilterByDate.Location = New Point(765, 15)
        chkFilterByDate.Name = "chkFilterByDate"
        chkFilterByDate.Size = New Size(15, 14)
        chkFilterByDate.TabIndex = 36
        chkFilterByDate.UseVisualStyleBackColor = True
        ' 
        ' rdoDelete
        ' 
        rdoDelete.AutoSize = True
        rdoDelete.BackColor = Color.DarkSlateGray
        rdoDelete.Font = New Font("Arial Rounded MT Bold", 11.25F)
        rdoDelete.ForeColor = Color.White
        rdoDelete.Location = New Point(699, 58)
        rdoDelete.Name = "rdoDelete"
        rdoDelete.Size = New Size(117, 21)
        rdoDelete.TabIndex = 35
        rdoDelete.TabStop = True
        rdoDelete.Text = "Delete Items"
        rdoDelete.UseVisualStyleBackColor = False
        ' 
        ' rdoPullout
        ' 
        rdoPullout.AutoSize = True
        rdoPullout.BackColor = Color.DarkSlateGray
        rdoPullout.Font = New Font("Arial Rounded MT Bold", 11.25F)
        rdoPullout.ForeColor = Color.White
        rdoPullout.Location = New Point(551, 58)
        rdoPullout.Name = "rdoPullout"
        rdoPullout.Size = New Size(76, 21)
        rdoPullout.TabIndex = 34
        rdoPullout.TabStop = True
        rdoPullout.Text = "Pullout"
        rdoPullout.UseVisualStyleBackColor = False
        ' 
        ' rdoAdd
        ' 
        rdoAdd.AutoSize = True
        rdoAdd.BackColor = Color.DarkSlateGray
        rdoAdd.Font = New Font("Arial Rounded MT Bold", 11.25F)
        rdoAdd.ForeColor = Color.White
        rdoAdd.Location = New Point(220, 58)
        rdoAdd.Name = "rdoAdd"
        rdoAdd.Size = New Size(99, 21)
        rdoAdd.TabIndex = 33
        rdoAdd.TabStop = True
        rdoAdd.Text = "Add Items"
        rdoAdd.UseVisualStyleBackColor = False
        ' 
        ' rdoUpdate
        ' 
        rdoUpdate.AutoSize = True
        rdoUpdate.BackColor = Color.DarkSlateGray
        rdoUpdate.Font = New Font("Arial Rounded MT Bold", 11.25F)
        rdoUpdate.ForeColor = Color.White
        rdoUpdate.Location = New Point(374, 58)
        rdoUpdate.Name = "rdoUpdate"
        rdoUpdate.Size = New Size(114, 21)
        rdoUpdate.TabIndex = 32
        rdoUpdate.TabStop = True
        rdoUpdate.Text = "Update Item"
        rdoUpdate.UseVisualStyleBackColor = False
        ' 
        ' rdoAllRecord
        ' 
        rdoAllRecord.AutoSize = True
        rdoAllRecord.BackColor = Color.DarkSlateGray
        rdoAllRecord.Font = New Font("Arial Rounded MT Bold", 11.25F)
        rdoAllRecord.ForeColor = Color.White
        rdoAllRecord.Location = New Point(64, 57)
        rdoAllRecord.Name = "rdoAllRecord"
        rdoAllRecord.Size = New Size(111, 21)
        rdoAllRecord.TabIndex = 31
        rdoAllRecord.TabStop = True
        rdoAllRecord.Text = "All Records"
        rdoAllRecord.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.SeaGreen
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(897, 52)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 34)
        btnPrint.TabIndex = 30
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblDeleted
        ' 
        lblDeleted.AutoSize = True
        lblDeleted.BackColor = Color.Firebrick
        lblDeleted.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDeleted.ForeColor = Color.White
        lblDeleted.Location = New Point(913, 131)
        lblDeleted.Name = "lblDeleted"
        lblDeleted.Size = New Size(25, 37)
        lblDeleted.TabIndex = 24
        lblDeleted.Text = " "
        ' 
        ' lblPullout
        ' 
        lblPullout.AutoSize = True
        lblPullout.BackColor = Color.SteelBlue
        lblPullout.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPullout.ForeColor = Color.White
        lblPullout.Location = New Point(660, 131)
        lblPullout.Name = "lblPullout"
        lblPullout.Size = New Size(25, 37)
        lblPullout.TabIndex = 23
        lblPullout.Text = " "
        ' 
        ' dtDate
        ' 
        dtDate.CalendarFont = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtDate.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtDate.Location = New Point(786, 12)
        dtDate.Name = "dtDate"
        dtDate.Size = New Size(217, 21)
        dtDate.TabIndex = 12
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(34, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(171, 21)
        txtSearch.TabIndex = 20
        txtSearch.Text = "🔍 Search..."
        ' 
        ' lblUpdated
        ' 
        lblUpdated.AutoSize = True
        lblUpdated.BackColor = Color.DarkGoldenrod
        lblUpdated.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUpdated.ForeColor = Color.White
        lblUpdated.Location = New Point(421, 130)
        lblUpdated.Name = "lblUpdated"
        lblUpdated.Size = New Size(25, 37)
        lblUpdated.TabIndex = 22
        lblUpdated.Text = " "
        ' 
        ' lblAdded
        ' 
        lblAdded.AutoSize = True
        lblAdded.BackColor = Color.DarkOliveGreen
        lblAdded.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdded.ForeColor = Color.White
        lblAdded.Location = New Point(150, 130)
        lblAdded.Name = "lblAdded"
        lblAdded.Size = New Size(25, 37)
        lblAdded.TabIndex = 21
        lblAdded.Text = " "
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Location = New Point(0, 43)
        Button4.Name = "Button4"
        Button4.Size = New Size(1014, 53)
        Button4.TabIndex = 12
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Firebrick
        Label5.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(799, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 25)
        Label5.TabIndex = 19
        Label5.Text = " 🗑️  Deleted: "
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Location = New Point(793, 110)
        Button3.Name = "Button3"
        Button3.Size = New Size(193, 82)
        Button3.TabIndex = 18
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.SteelBlue
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(559, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 17
        Label4.Text = " 📦 Pullout: "
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Location = New Point(551, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 82)
        Button2.TabIndex = 16
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(54, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 15
        Label1.Text = "+ Added: "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.DarkGoldenrod
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(307, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 14
        Label3.Text = "✏️  Updated: "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGoldenrod
        Button1.Location = New Point(295, 110)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 82)
        Button1.TabIndex = 13
        Button1.Text = " "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAdded
        ' 
        btnAdded.BackColor = Color.DarkOliveGreen
        btnAdded.Location = New Point(34, 110)
        btnAdded.Name = "btnAdded"
        btnAdded.Size = New Size(193, 82)
        btnAdded.TabIndex = 12
        btnAdded.Text = " "
        btnAdded.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.Location = New Point(58, 340)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1014, 282)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Log ID"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Date/ Time"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Action"
        ColumnHeader3.Width = 90
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Item Name"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Level/ Gender/ Size"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Previous Quantity"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Changed Quantity"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "New Quantity"
        ColumnHeader8.Width = 90
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Admin"
        ColumnHeader9.Width = 90
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Reason"
        ColumnHeader10.Width = 90
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkSlateGray
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Location = New Point(58, 665)
        Button5.Name = "Button5"
        Button5.Size = New Size(1014, 54)
        Button5.TabIndex = 26
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnPreview
        ' 
        btnPreview.BackColor = Color.Maroon
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreview.ForeColor = Color.White
        btnPreview.Location = New Point(901, 586)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(108, 27)
        btnPreview.TabIndex = 27
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(67, 672)
        Button6.Name = "Button6"
        Button6.Size = New Size(994, 37)
        Button6.TabIndex = 28
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(82, 683)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 17)
        Label6.TabIndex = 26
        Label6.Text = " 📊 Total Records:"
        ' 
        ' lblTotalRecords
        ' 
        lblTotalRecords.AutoSize = True
        lblTotalRecords.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalRecords.Location = New Point(219, 683)
        lblTotalRecords.Name = "lblTotalRecords"
        lblTotalRecords.Size = New Size(16, 17)
        lblTotalRecords.TabIndex = 29
        lblTotalRecords.Text = "  "
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' frmAdminStockMonitoring
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1122, 749)
        Controls.Add(btnPreview)
        Controls.Add(lblTotalRecords)
        Controls.Add(Label6)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ListView1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Font = New Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "frmAdminStockMonitoring"
        Text = "frmStockMonitoring"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdded As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents lblAdded As Label
    Friend WithEvents lblUpdated As Label
    Friend WithEvents lblPullout As Label
    Friend WithEvents lblDeleted As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPrint As Button
    Friend WithEvents rdoUpdate As RadioButton
    Friend WithEvents rdoAllRecord As RadioButton
    Friend WithEvents rdoAdd As RadioButton
    Friend WithEvents rdoDelete As RadioButton
    Friend WithEvents rdoPullout As RadioButton
    Friend WithEvents chkFilterByDate As CheckBox
End Class
