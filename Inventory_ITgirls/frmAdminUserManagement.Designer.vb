<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminUserManagement))
        Panel1 = New Panel()
        Button1 = New Button()
        btnRemoveUser = New Button()
        ListView2 = New ListView()
        AdminID = New ColumnHeader()
        username = New ColumnHeader()
        LastName = New ColumnHeader()
        FirstName = New ColumnHeader()
        MiddleName = New ColumnHeader()
        Password = New ColumnHeader()
        Role = New ColumnHeader()
        txtSearch = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DateCreated = New ColumnHeader()
        DateTimePicker1 = New DateTimePicker()
        CheckedListBox1 = New CheckedListBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        lblStaffNumber = New Label()
        lblAdminNumber = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(ListView2)
        Panel1.Location = New Point(38, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1052, 506)
        Panel1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(735, 666)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 31)
        Button1.TabIndex = 132
        Button1.Text = "ADD USER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveUser
        ' 
        btnRemoveUser.BackColor = Color.IndianRed
        btnRemoveUser.FlatStyle = FlatStyle.Flat
        btnRemoveUser.Font = New Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemoveUser.ForeColor = Color.White
        btnRemoveUser.Location = New Point(931, 666)
        btnRemoveUser.Name = "btnRemoveUser"
        btnRemoveUser.Size = New Size(159, 31)
        btnRemoveUser.TabIndex = 131
        btnRemoveUser.Text = "REMOVE USER"
        btnRemoveUser.UseVisualStyleBackColor = False
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {AdminID, username, LastName, FirstName, MiddleName, Password, DateCreated, Role})
        ListView2.ForeColor = SystemColors.InactiveCaptionText
        ListView2.Location = New Point(21, 23)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(1002, 463)
        ListView2.TabIndex = 19
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' AdminID
        ' 
        AdminID.Text = "Admin ID"
        AdminID.Width = 120
        ' 
        ' username
        ' 
        username.Text = "Username"
        username.Width = 120
        ' 
        ' LastName
        ' 
        LastName.Text = "Last Name"
        LastName.Width = 120
        ' 
        ' FirstName
        ' 
        FirstName.Text = "First Name"
        FirstName.Width = 120
        ' 
        ' MiddleName
        ' 
        MiddleName.Text = "MiddleName"
        MiddleName.Width = 120
        ' 
        ' Password
        ' 
        Password.Text = "Password"
        Password.Width = 120
        ' 
        ' Role
        ' 
        Role.DisplayIndex = 6
        Role.Text = "Role"
        Role.Width = 120
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.DarkSeaGreen
        txtSearch.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(36, 93)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(235, 24)
        txtSearch.TabIndex = 21
        txtSearch.Text = "🔍 Search..."
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' DateCreated
        ' 
        DateCreated.DisplayIndex = 7
        DateCreated.Text = "Date Created"
        DateCreated.Width = 120
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(330, 92)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(210, 23)
        DateTimePicker1.TabIndex = 23
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.BackColor = Color.LightCyan
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"."})
        CheckedListBox1.Location = New Point(308, 93)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(20, 22)
        CheckedListBox1.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Gadugi", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(30, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(339, 38)
        Label2.TabIndex = 17
        Label2.Text = "USER MANAGEMENT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(725, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 81)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 133
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(918, 31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(84, 81)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 134
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(935, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 17)
        Label1.TabIndex = 135
        Label1.Text = "ADMIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(747, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 136
        Label3.Text = "STAFF"
        ' 
        ' lblStaffNumber
        ' 
        lblStaffNumber.AutoSize = True
        lblStaffNumber.BackColor = Color.Transparent
        lblStaffNumber.Font = New Font("Gadugi", 24F, FontStyle.Bold)
        lblStaffNumber.ForeColor = Color.DarkSlateGray
        lblStaffNumber.Location = New Point(839, 59)
        lblStaffNumber.Name = "lblStaffNumber"
        lblStaffNumber.Size = New Size(30, 38)
        lblStaffNumber.TabIndex = 137
        lblStaffNumber.Text = "-"
        ' 
        ' lblAdminNumber
        ' 
        lblAdminNumber.AutoSize = True
        lblAdminNumber.BackColor = Color.Transparent
        lblAdminNumber.Font = New Font("Gadugi", 24F, FontStyle.Bold)
        lblAdminNumber.ForeColor = Color.DarkSlateGray
        lblAdminNumber.Location = New Point(1029, 59)
        lblAdminNumber.Name = "lblAdminNumber"
        lblAdminNumber.Size = New Size(30, 38)
        lblAdminNumber.TabIndex = 138
        lblAdminNumber.Text = "-"
        ' 
        ' frmAdminUserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1122, 709)
        Controls.Add(lblAdminNumber)
        Controls.Add(lblStaffNumber)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(btnRemoveUser)
        Controls.Add(CheckedListBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "frmAdminUserManagement"
        Text = "frmAdminUserManagement"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents AdminID As ColumnHeader
    Friend WithEvents username As ColumnHeader
    Friend WithEvents LastName As ColumnHeader
    Friend WithEvents FirstName As ColumnHeader
    Friend WithEvents MiddleName As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents Role As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRemoveUser As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DateCreated As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStaffNumber As Label
    Friend WithEvents lblAdminNumber As Label
End Class
