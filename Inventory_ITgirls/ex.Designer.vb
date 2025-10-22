Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ex
    Inherits Form

    Private panelSidebar As Panel
    Private btnStockManagement As Button
    Private btnSalesReport As Button
    Private btnBack As Button
    Private Label2 As Label
    Private TextBox2 As TextBox
    Private ListView1 As ListView
    Private TextBox1, TextBox3, TextBox7, TextBox8, TextBox10 As TextBox
    Private Label6, Label7, Label11, Label12, Label14 As Label
    Private btnModify, Button1, Button2 As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()

        ' ===== FORM =====
        Me.ClientSize = New Size(1100, 600)
        Me.Text = "Inventory Management"
        Me.BackColor = Color.WhiteSmoke
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        ' ===== LEFT SIDEBAR =====
        panelSidebar = New Panel()
        panelSidebar.BackColor = Color.DarkSlateGray
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Width = 200
        panelSidebar.BorderStyle = BorderStyle.None
        Me.Controls.Add(panelSidebar)

        ' ===== SIDEBAR BUTTONS =====
        btnStockManagement = New Button()
        btnStockManagement.Text = "STOCK"
        btnStockManagement.ForeColor = Color.White
        btnStockManagement.BackColor = Color.DarkSlateGray
        btnStockManagement.FlatStyle = FlatStyle.Flat
        btnStockManagement.Font = New Font("Arial Rounded MT Bold", 10)
        btnStockManagement.Size = New Size(180, 40)
        btnStockManagement.Location = New Point(10, 120)
        btnStockManagement.FlatAppearance.BorderSize = 0
        panelSidebar.Controls.Add(btnStockManagement)

        btnSalesReport = New Button()
        btnSalesReport.Text = "REPORTS"
        btnSalesReport.ForeColor = Color.White
        btnSalesReport.BackColor = Color.DarkSlateGray
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Arial Rounded MT Bold", 10)
        btnSalesReport.Size = New Size(180, 40)
        btnSalesReport.Location = New Point(10, 170)
        btnSalesReport.FlatAppearance.BorderSize = 0
        panelSidebar.Controls.Add(btnSalesReport)

        btnBack = New Button()
        btnBack.Text = "LOGOUT"
        btnBack.ForeColor = Color.White
        btnBack.BackColor = Color.Teal
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 10)
        btnBack.Size = New Size(180, 40)
        btnBack.Location = New Point(10, 520)
        btnBack.FlatAppearance.BorderSize = 0
        panelSidebar.Controls.Add(btnBack)

        ' ===== HEADER =====
        Label2 = New Label()
        Label2.Text = "INVENTORY MANAGEMENT"
        Label2.Font = New Font("Arial Rounded MT Bold", 18)
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(220, 20)
        Label2.AutoSize = True
        Me.Controls.Add(Label2)

        TextBox2 = New TextBox()
        TextBox2.PlaceholderText = "Search item..."
        TextBox2.Font = New Font("Segoe UI", 10)
        TextBox2.Location = New Point(750, 25)
        TextBox2.Size = New Size(200, 25)
        Me.Controls.Add(TextBox2)

        ' ===== LISTVIEW =====
        ListView1 = New ListView()
        ListView1.Location = New Point(220, 70)
        ListView1.Size = New Size(650, 450)
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.BackColor = Color.White
        ListView1.BorderStyle = BorderStyle.FixedSingle
        ' Columns (you can remove these if you want it totally empty)
        ListView1.Columns.Add("Item ID", 80)
        ListView1.Columns.Add("Item Name", 150)
        ListView1.Columns.Add("Category", 100)
        ListView1.Columns.Add("Qty", 60)
        ListView1.Columns.Add("Price", 80)
        ListView1.Columns.Add("Date Added", 100)
        ListView1.Columns.Add("Status", 80)
        Me.Controls.Add(ListView1)

        ' ===== ITEM DETAILS PANEL =====
        Dim pnlDetails As New Panel()
        pnlDetails.BackColor = Color.White
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Location = New Point(890, 70)
        pnlDetails.Size = New Size(200, 350)
        Me.Controls.Add(pnlDetails)

        Dim lblTitle As New Label()
        lblTitle.Text = "Item Details"
        lblTitle.Font = New Font("Arial Rounded MT Bold", 11)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(10, 10)
        lblTitle.AutoSize = True
        pnlDetails.Controls.Add(lblTitle)

        Label6 = New Label()
        Label6.Text = "Item Name:"
        Label6.Location = New Point(10, 50)
        pnlDetails.Controls.Add(Label6)

        TextBox1 = New TextBox()
        TextBox1.Location = New Point(10, 70)
        TextBox1.Width = 170
        pnlDetails.Controls.Add(TextBox1)

        Label7 = New Label()
        Label7.Text = "Category:"
        Label7.Location = New Point(10, 100)
        pnlDetails.Controls.Add(Label7)

        TextBox3 = New TextBox()
        TextBox3.Location = New Point(10, 120)
        TextBox3.Width = 170
        pnlDetails.Controls.Add(TextBox3)

        Label11 = New Label()
        Label11.Text = "Quantity:"
        Label11.Location = New Point(10, 150)
        pnlDetails.Controls.Add(Label11)

        TextBox7 = New TextBox()
        TextBox7.Location = New Point(10, 170)
        TextBox7.Width = 170
        pnlDetails.Controls.Add(TextBox7)

        Label12 = New Label()
        Label12.Text = "Price:"
        Label12.Location = New Point(10, 200)
        pnlDetails.Controls.Add(Label12)

        TextBox8 = New TextBox()
        TextBox8.Location = New Point(10, 220)
        TextBox8.Width = 170
        pnlDetails.Controls.Add(TextBox8)

        Label14 = New Label()
        Label14.Text = "Date Added:"
        Label14.Location = New Point(10, 250)
        pnlDetails.Controls.Add(Label14)

        TextBox10 = New TextBox()
        TextBox10.Location = New Point(10, 270)
        TextBox10.Width = 170
        pnlDetails.Controls.Add(TextBox10)

        ' ===== ACTION BUTTONS =====
        btnModify = New Button()
        btnModify.Text = "Modify"
        btnModify.BackColor = Color.Teal
        btnModify.ForeColor = Color.White
        btnModify.FlatStyle = FlatStyle.Flat
        btnModify.Font = New Font("Arial Rounded MT Bold", 9)
        btnModify.Location = New Point(890, 440)
        btnModify.Size = New Size(90, 35)
        btnModify.FlatAppearance.BorderSize = 0
        Me.Controls.Add(btnModify)

        Button1 = New Button()
        Button1.Text = "Remove"
        Button1.BackColor = Color.IndianRed
        Button1.ForeColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9)
        Button1.Location = New Point(1000, 440)
        Button1.Size = New Size(90, 35)
        Button1.FlatAppearance.BorderSize = 0
        Me.Controls.Add(Button1)

        Button2 = New Button()
        Button2.Text = "Save"
        Button2.BackColor = Color.SeaGreen
        Button2.ForeColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 9)
        Button2.Location = New Point(945, 485)
        Button2.Size = New Size(90, 35)
        Button2.FlatAppearance.BorderSize = 0
        Me.Controls.Add(Button2)

        Me.ResumeLayout(False)
    End Sub
End Class
