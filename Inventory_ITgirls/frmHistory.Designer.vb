<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        components = New ComponentModel.Container()
        Label2 = New Label()
        Panel1 = New Panel()
        lblDeleted = New Label()
        btnPrint = New Button()
        lblPullout = New Label()
        lblUpdated = New Label()
        lblAdded = New Label()
        cboAction = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        txtSearch = New TextBox()
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
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Button5 = New Button()
        btnPreview = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(451, 38)
        Label2.TabIndex = 10
        Label2.Text = "INVENTORY HISTORY LOG"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(240), CByte(234))
        Panel1.Controls.Add(lblDeleted)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(lblPullout)
        Panel1.Controls.Add(lblUpdated)
        Panel1.Controls.Add(lblAdded)
        Panel1.Controls.Add(cboAction)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnAdded)
        Panel1.Location = New Point(12, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1014, 153)
        Panel1.TabIndex = 11
        ' 
        ' lblDeleted
        ' 
        lblDeleted.AutoSize = True
        lblDeleted.BackColor = Color.Firebrick
        lblDeleted.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDeleted.ForeColor = Color.White
        lblDeleted.Location = New Point(913, 84)
        lblDeleted.Name = "lblDeleted"
        lblDeleted.Size = New Size(25, 37)
        lblDeleted.TabIndex = 24
        lblDeleted.Text = " "
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnPrint.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrint.Location = New Point(781, 8)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(110, 32)
        btnPrint.TabIndex = 25
        btnPrint.Text = " PRINT"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblPullout
        ' 
        lblPullout.AutoSize = True
        lblPullout.BackColor = Color.SteelBlue
        lblPullout.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPullout.ForeColor = Color.White
        lblPullout.Location = New Point(660, 84)
        lblPullout.Name = "lblPullout"
        lblPullout.Size = New Size(25, 37)
        lblPullout.TabIndex = 23
        lblPullout.Text = " "
        ' 
        ' lblUpdated
        ' 
        lblUpdated.AutoSize = True
        lblUpdated.BackColor = Color.DarkGoldenrod
        lblUpdated.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUpdated.ForeColor = Color.White
        lblUpdated.Location = New Point(421, 83)
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
        lblAdded.Location = New Point(150, 83)
        lblAdded.Name = "lblAdded"
        lblAdded.Size = New Size(25, 37)
        lblAdded.TabIndex = 21
        lblAdded.Text = " "
        ' 
        ' cboAction
        ' 
        cboAction.DropDownStyle = ComboBoxStyle.DropDownList
        cboAction.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboAction.FormattingEnabled = True
        cboAction.Items.AddRange(New Object() {"Pullout", "Add Item", "Delete Item", "Update Item"})
        cboAction.Location = New Point(551, 14)
        cboAction.Name = "cboAction"
        cboAction.Size = New Size(192, 23)
        cboAction.TabIndex = 12
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(271, 14)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(217, 21)
        DateTimePicker1.TabIndex = 12
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(28, 15)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(171, 21)
        txtSearch.TabIndex = 20
        txtSearch.Text = "🔍 Search..."
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSlateGray
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Location = New Point(0, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(1014, 51)
        Button4.TabIndex = 12
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Firebrick
        Label5.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(799, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 23)
        Label5.TabIndex = 19
        Label5.Text = " 🗑️  Deleted: "
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Location = New Point(793, 64)
        Button3.Name = "Button3"
        Button3.Size = New Size(193, 77)
        Button3.TabIndex = 18
        Button3.Text = " "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.SteelBlue
        Label4.Font = New Font("Arial Rounded MT Bold", 12.75F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(559, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 23)
        Label4.TabIndex = 17
        Label4.Text = " 📦 Pullout: "
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Location = New Point(551, 64)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 77)
        Button2.TabIndex = 16
        Button2.Text = " "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(54, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 23)
        Label1.TabIndex = 15
        Label1.Text = "+ Added: "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.DarkGoldenrod
        Label3.Font = New Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(307, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 23)
        Label3.TabIndex = 14
        Label3.Text = "✏️  Updated: "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGoldenrod
        Button1.Location = New Point(295, 64)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 77)
        Button1.TabIndex = 13
        Button1.Text = " "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAdded
        ' 
        btnAdded.BackColor = Color.DarkOliveGreen
        btnAdded.Location = New Point(34, 64)
        btnAdded.Name = "btnAdded"
        btnAdded.Size = New Size(193, 77)
        btnAdded.TabIndex = 12
        btnAdded.Text = " "
        btnAdded.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        ListView1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.Location = New Point(12, 231)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1014, 265)
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
        ColumnHeader6.Text = "Changed Quantity"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Previous -> New"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Admin"
        ColumnHeader8.Width = 90
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Reason"
        ColumnHeader9.Width = 90
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkSlateGray
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Location = New Point(12, 521)
        Button5.Name = "Button5"
        Button5.Size = New Size(1014, 51)
        Button5.TabIndex = 26
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnPreview
        ' 
        btnPreview.BackColor = Color.DimGray
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreview.ForeColor = Color.White
        btnPreview.Location = New Point(66, 530)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(108, 33)
        btnPreview.TabIndex = 27
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' frmHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1101, 687)
        Controls.Add(btnPreview)
        Controls.Add(Button5)
        Controls.Add(ListView1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "frmHistory"
        Text = "frmHistory"
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboAction As ComboBox
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnPrint As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnPreview As Button
End Class
