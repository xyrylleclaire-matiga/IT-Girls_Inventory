Imports MySql.Data.MySqlClient
Public Class frmAddItems
    Private Sub btnClear_Paint(sender As Object, e As PaintEventArgs) Handles btnClear.Paint
        Dim btn As Button = DirectCast(sender, Button)
        Dim radius As Integer = 10

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

    Private Sub btnAdd_Paint(sender As Object, e As PaintEventArgs) Handles btnAdd.Paint
        Dim btn As Button = DirectCast(sender, Button)
        Dim radius As Integer = 10

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

    Private Sub btnBack_Paint(sender As Object, e As PaintEventArgs) Handles btnBack.Paint
        Dim btn As Button = DirectCast(sender, Button)
        Dim radius As Integer = 10

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub





    '-----------------------------------------
    'BACKEND 

    Private Sub clearAll()
        txtItemName.Clear()
        txtPrice.Clear()
        cboCategory.SelectedIndex = -1
        cboGender.SelectedIndex = -1
        cboLevel.SelectedIndex = -1
        cboSize.SelectedIndex = -1
        lblStatus.Text = " "
        txtStock.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Me.Owner IsNot Nothing Then
            Dim parentForm As frmStockManagement = TryCast(Me.Owner, frmStockManagement)
            If parentForm IsNot Nothing Then
                parentForm.displayApplication() ' or any refresh function mo
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAll()
    End Sub

    Private Sub addItems()

        If txtItemName.Text.Trim() = "" Or txtStock.Text.Trim() = "" Or txtPrice.Text.Trim() = "" Or cboCategory.SelectedIndex = -1 Or cboGender.SelectedIndex = -1 Or cboLevel.SelectedIndex = -1 Or cboSize.SelectedIndex = -1 Then
            MsgBox("Please fill out all required fields.", vbExclamation)
            Exit Sub
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) Then
            MsgBox("Invalid stock quantity.", vbExclamation)
            Exit Sub
        End If

        Dim status As String
        If stock <= 0 Then
            status = "Out of Stock"
        ElseIf stock <= 5 Then
            status = "Low Stock"
        Else
            status = "Available"
        End If

        databaseConnection.con()
        sql = "INSERT INTO tbluniforms(item_name, category, level, gender, size, stock_quantity, price, status, date_added) VALUES (@itemName, @category, @level, @gender, @size, @stockQuantity, @price, @status, @dateAdded)"

        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@itemName", txtItemName.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@category", cboCategory.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@level", cboLevel.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@gender", cboGender.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@size", cboSize.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@stockQuantity", txtStock.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@price", txtPrice.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@status", "Available")
        databaseConnection.cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

        databaseConnection.cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MsgBox("Are you sure you want to add items?", vbQuestion + vbYesNo) = vbYes Then
            addItems()
            clearAll()
        End If
    End Sub

    Private Sub statusColor()
        If txtStock.Text.Trim() = "" Or Not IsNumeric(txtStock.Text) Then
            lblStatus.Text = "Invalid Input"
            lblStatus.ForeColor = Color.Black
            Exit Sub
        End If

        Dim stock As Integer = CInt(txtStock.Text)
        Dim status As String = ""

        If stock <= 0 Then
            status = "Out of Stock"
            lblStatus.ForeColor = Color.Red
        ElseIf stock <= 5 Then
            status = "Low Stock"
            lblStatus.ForeColor = Color.Orange
        Else
            status = "Available"
            lblStatus.ForeColor = Color.Green
        End If

        lblStatus.Text = status
    End Sub


    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        statusColor()
    End Sub

    Private Sub frmAddItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateAdded.Text = DateTime.Now
    End Sub
End Class