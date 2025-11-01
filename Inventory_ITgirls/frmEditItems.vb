﻿Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmEditItems
    'FOR DESIGNNNNNNNNNNNNNNN -----------
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

    Private Sub btnSave_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint
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
    'END OF DESIGNNN --------------------


    'BACKEND --------------------
    Private id As String
    Private itemName As String
    Private level As String
    Private gender As String
    Private size As String
    Private stockQuantity As String
    Private price As String
    Private status As String

    Public Sub New(id As String, name As String, lvl As String, gen As String, sz As String, qty As String, prc As String, stat As String)
        InitializeComponent()

        Me.id = id
        Me.itemName = name
        Me.level = lvl
        Me.gender = gen
        Me.size = sz
        Me.stockQuantity = qty
        Me.price = prc
        Me.status = stat

        txtItemName.Text = Me.itemName
        txtLevel.Text = Me.level
        txtGender.Text = Me.gender
        txtSize.Text = Me.size
        txtStock.Text = Me.stockQuantity
        txtPrice.Text = Me.price
        lblStatus.Text = Me.status
    End Sub

    Private Sub saveChanges()
        If txtStock.Text.Trim() = "" Or txtPrice.Text.Trim() = "" Then
            MsgBox("Please fill out all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text.Trim(), stock) Then
            MsgBox("Invalid stock quantity.", vbExclamation)
            txtStock.Clear()
            txtStock.Focus()
            Exit Sub
        End If

        Dim priceInput As String = txtPrice.Text.Replace("₱", "").Trim()
        Dim price As Decimal
        If Not Decimal.TryParse(priceInput, price) Then
            MsgBox("Invalid price value.", vbExclamation)
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

        If MsgBox("Are you sure you want to save changes?", vbQuestion + vbYesNo, "Confirm Save") = vbNo Then
            Exit Sub
        End If

        Try
            databaseConnection.con()

            If databaseConnection.currentAdminId > 0 AndAlso databaseConnection.isLoggedIn Then
                Dim sqlGetOld As String = "SELECT stock_quantity FROM tbluniforms WHERE uniform_id=@uniform_id"
                databaseConnection.cmd = New MySqlCommand(sqlGetOld, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", id)
                Dim oldStock As Integer = Convert.ToInt32(databaseConnection.cmd.ExecuteScalar())

                Dim change As Integer = stock - oldStock
                Dim changeSign As String = If(change >= 0, "+", "")

                Dim quantityDesc As String = $"{oldStock} → {stock} ({changeSign}{change})"

                Dim updated_quantity = oldStock + change
                Dim changeStr As String = If(change >= 0, "+" & change.ToString(), change.ToString())

                Dim sql As String = "UPDATE tbluniforms SET stock_quantity=@quantity, price=@price, status=@status WHERE uniform_id=@uniform_id"
                databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@quantity", stock)
                databaseConnection.cmd.Parameters.AddWithValue("@price", price)
                databaseConnection.cmd.Parameters.AddWithValue("@status", status)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", id)
                Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    Dim logSql As String = "INSERT INTO tbluniformlogs(uniform_id, action, changed_quantity, previous_quantity, new_quantity, admin_id, action_date) VALUES (@uniform_id, @action, @changed_quantity, @previous_qty, @new_qty, @admin_id, @action_date)"
                    databaseConnection.cmd = New MySqlCommand(logSql, databaseConnection.cn)
                    databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", id)
                    databaseConnection.cmd.Parameters.AddWithValue("@action", "Update Item")
                    databaseConnection.cmd.Parameters.AddWithValue("@changed_quantity", changeStr)
                    databaseConnection.cmd.Parameters.AddWithValue("@previous_qty", oldStock)
                    databaseConnection.cmd.Parameters.AddWithValue("@new_qty", stock)
                    databaseConnection.cmd.Parameters.AddWithValue("@admin_id", databaseConnection.currentAdminId)
                    databaseConnection.cmd.Parameters.AddWithValue("@action_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    databaseConnection.cmd.ExecuteNonQuery()

                    MsgBox("Item updated successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("No matching record found to update!", MsgBoxStyle.Exclamation)
                End If
            Else
                Dim sql As String = "UPDATE tbluniforms SET stock_quantity=@quantity, price=@price, status=@status WHERE uniform_id=@uniform_id"
                databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@quantity", stock)
                databaseConnection.cmd.Parameters.AddWithValue("@price", price)
                databaseConnection.cmd.Parameters.AddWithValue("@status", status)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", id)
                Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Item updated successfully!", MsgBoxStyle.Information)
                    Console.WriteLine("Warning: No admin logged in, log entry skipped")
                Else
                    MsgBox("No matching record found to update!", MsgBoxStyle.Exclamation)
                End If
            End If

            txtItemName.Clear()
            txtStock.Clear()
            txtPrice.Text = "₱ 0.00"
            txtLevel.Clear()
            txtGender.Clear()
            txtSize.Clear()

            If Me.Owner IsNot Nothing Then
                Dim parentForm As frmStockManagement = TryCast(Me.Owner, frmStockManagement)
                If parentForm IsNot Nothing Then
                    parentForm.displayApplication()
                End If
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If MsgBox("Are you sure you want to save changes?", vbQuestion + vbYesNo) = vbYes Then
        saveChanges()
        'Me.DialogResult = DialogResult.OK
        'Me.Close()
        'Else
        'End If
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        statusColor()
    End Sub

    Private Sub lblDateAdded_Click(sender As Object, e As EventArgs) Handles lblDateAdded.Click
        lblDateAdded.Text = DateTime.Now
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

    Private Sub frmEditItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateAdded.Text = DateTime.Now
    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        Dim value As Decimal = 0
        If Decimal.TryParse(txtPrice.Text, value) Then
            txtPrice.Text = "₱ " & value.ToString("N2")
        Else
            txtPrice.Text = "₱ 0.00"
        End If
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.Clear()
    End Sub


End Class