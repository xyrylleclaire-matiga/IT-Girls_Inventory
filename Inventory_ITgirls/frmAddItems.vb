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
                parentForm.displayApplication()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAll()
    End Sub

    'ADDDDDDDDDDDDDDDD
    Private Sub addItems()
        If txtItemName.Text.Trim() = "" Or txtStock.Text.Trim() = "" Or txtPrice.Text.Trim() = "" Or cboCategory.SelectedIndex = -1 Or cboGender.SelectedIndex = -1 Or cboLevel.SelectedIndex = -1 Or cboSize.SelectedIndex = -1 Then
            MsgBox("Please fill out all required fields.", vbExclamation)
            Exit Sub
        End If

        If txtItemName.Text.Trim().Length < 3 Then
            MsgBox("Item name must be at least 3 characters long.", vbExclamation)
            txtItemName.Focus()
            Exit Sub
        End If

        If txtItemName.Text.Trim().Length > 100 Then
            MsgBox("Item name is too long. Maximum 100 characters.", vbExclamation)
            txtItemName.Focus()
            Exit Sub
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text.Trim(), stock) Then
            MsgBox("Invalid stock quantity. Please enter a valid number.", vbExclamation)
            txtStock.Clear()
            txtStock.Focus()
            Exit Sub
        End If

        If stock < 0 Then
            MsgBox("Stock quantity cannot be negative.", vbExclamation)
            txtStock.Clear()
            txtStock.Focus()
            Exit Sub
        End If

        If stock > 9999 Then
            MsgBox("Stock quantity is too high. Maximum is 9999.", vbExclamation)
            txtStock.Clear()
            txtStock.Focus()
            Exit Sub
        End If

        Dim priceInput As String = txtPrice.Text.Replace("₱", "").Replace(",", "").Trim()
        Dim price As Decimal
        If Not Decimal.TryParse(priceInput, price) Then
            MsgBox("Invalid price value. Please enter a valid amount.", vbExclamation)
            txtPrice.Clear()
            txtPrice.Focus()
            Exit Sub
        End If

        If price <= 0 Then
            MsgBox("Price must be greater than zero.", vbExclamation)
            txtPrice.Clear()
            txtPrice.Focus()
            Exit Sub
        End If

        If price > 99999.99 Then
            MsgBox("Price is too high. Maximum is ₱99,999.99.", vbExclamation)
            txtPrice.Clear()
            txtPrice.Focus()
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

        If MsgBox("Are you sure you want to add this item?", vbQuestion + vbYesNo, "Confirm Add") = vbNo Then
            Exit Sub
        End If

        Try
            databaseConnection.con()
            sql = "INSERT INTO tbluniforms(item_name, category, level, gender, size, stock_quantity, price, status, date_added) VALUES (@itemName, @category, @level, @gender, @size, @stockQuantity, @price, @status, @dateAdded)"
            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@itemName", txtItemName.Text.Trim())
            databaseConnection.cmd.Parameters.AddWithValue("@category", cboCategory.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@level", cboLevel.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@gender", cboGender.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@size", cboSize.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@stockQuantity", stock)
            databaseConnection.cmd.Parameters.AddWithValue("@price", price)
            databaseConnection.cmd.Parameters.AddWithValue("@status", status)
            databaseConnection.cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                Dim lastInsertedId As Long = databaseConnection.cmd.LastInsertedId
                If databaseConnection.currentAdminId > 0 AndAlso databaseConnection.isLoggedIn Then
                    ' Fetch the item details of the newly added uniform
                    Dim fetchSql As String = "SELECT item_name, level, gender, size FROM tbluniforms WHERE uniform_id = @id"
                    Dim itemName As String = "N/A"
                    Dim level As String = "N/A"
                    Dim gender As String = "N/A"
                    Dim size As String = "N/A"

                    Using fetchCmd As New MySqlCommand(fetchSql, databaseConnection.cn)
                        fetchCmd.Parameters.AddWithValue("@id", lastInsertedId)
                        Using reader As MySqlDataReader = fetchCmd.ExecuteReader()
                            If reader.Read() Then
                                itemName = reader("item_name").ToString()
                                level = reader("level").ToString()
                                gender = reader("gender").ToString()
                                size = reader("size").ToString()
                            End If
                        End Using
                    End Using

                    ' Insert log with proper item details
                    Dim logSql As String = "INSERT INTO tbluniformlogs(uniform_id, action, item_name, level, gender, size, changed_quantity, previous_quantity, new_quantity, admin_id, action_date) " &
                           "VALUES (@uniform_id, @action, @item_name, @level, @gender, @size, @changed_quantity, @previous_qty, @new_qty, @admin_id, @action_date)"

                    databaseConnection.cmd = New MySqlCommand(logSql, databaseConnection.cn)
                    databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", lastInsertedId)
                    databaseConnection.cmd.Parameters.AddWithValue("@action", "Add Item")
                    databaseConnection.cmd.Parameters.AddWithValue("@item_name", itemName)
                    databaseConnection.cmd.Parameters.AddWithValue("@level", level)
                    databaseConnection.cmd.Parameters.AddWithValue("@gender", gender)
                    databaseConnection.cmd.Parameters.AddWithValue("@size", size)
                    databaseConnection.cmd.Parameters.AddWithValue("@changed_quantity", stock)
                    databaseConnection.cmd.Parameters.AddWithValue("@previous_qty", 0)
                    databaseConnection.cmd.Parameters.AddWithValue("@new_qty", stock)
                    databaseConnection.cmd.Parameters.AddWithValue("@admin_id", databaseConnection.currentAdminId)
                    databaseConnection.cmd.Parameters.AddWithValue("@action_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    databaseConnection.cmd.ExecuteNonQuery()
                Else
                    Console.WriteLine("Warning: No admin logged in, log entry skipped")
                End If


                MsgBox("Item added successfully!", MsgBoxStyle.Information)
                txtItemName.Clear()
                txtStock.Clear()
                txtPrice.Text = "₱ 0.00"
                cboCategory.SelectedIndex = -1
                cboLevel.SelectedIndex = -1
                cboGender.SelectedIndex = -1
                cboSize.SelectedIndex = -1

                If Me.Owner IsNot Nothing Then
                    Dim parentForm As frmStockManagement = TryCast(Me.Owner, frmStockManagement)
                    If parentForm IsNot Nothing Then
                        parentForm.displayApplication()
                    End If
                End If

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Failed to add item. Please try again.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("This item already exists in the database.", MsgBoxStyle.Exclamation)
                txtItemName.Focus()
            Else
                MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error adding item: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If databaseConnection.cn IsNot Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addItems()
    End Sub

    'for Status Color ---------------
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

    'for Status Color ---------------

    Private Sub frmAddItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateAdded.Text = DateTime.Now
        txtPrice.Text = "₱ 0.00"
    End Sub

    'for PRICEEE -------------
    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.Clear()
    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        Dim value As Decimal = 0
        If Decimal.TryParse(txtPrice.Text, value) Then
            txtPrice.Text = "₱ " & value.ToString("N2")
        Else
            txtPrice.Text = "₱ 0.00"
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    'for PRICEEE --------------


End Class