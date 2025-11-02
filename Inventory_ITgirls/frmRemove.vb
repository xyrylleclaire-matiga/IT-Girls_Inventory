Imports MySql.Data.MySqlClient

Public Class frmRemove
    Private id As String
    Private itemName As String
    Private level As String
    Private gender As String
    Private size As String
    Private reason As String
    Private stockQuantity As String
    Private price As String
    Private status As String

    Public Sub New(id As String, name As String, lvl As String, gen As String, sz As String, qty As String, prc As String, stat As String, reason As String)
        InitializeComponent()

        Me.id = id
        Me.itemName = name
        Me.level = lvl
        Me.gender = gen
        Me.size = sz
        Me.stockQuantity = qty
        Me.price = prc
        Me.status = stat
        Me.reason = reason

        txtItemName.Text = name        ' ← Gamitin directly yung parameter
        txtLevel.Text = lvl
        txtGender.Text = gen
        txtSize.Text = sz
        txtStock.Text = qty
        txtPrice.Text = prc
        lblStatus.Text = stat

        If Not String.IsNullOrEmpty(reason) Then
            cboReason.Text = reason
        End If

        ' DEBUG: Verify na may laman
        Debug.WriteLine($"Form loaded - Name: {txtItemName.Text}, Level: {txtLevel.Text}")

    End Sub

    Private Sub clearAll()
        txtGender.Clear()
        txtItemName.Clear()
        txtLevel.Clear()
        txtPrice.Text = "₱ 0.00"
        txtSize.Clear()
        txtStock.Clear()
        cboReason.SelectedIndex = -1
    End Sub



    Private Sub remove()
        If MsgBox("Are you sure you want to delete this item?", vbQuestion + vbYesNo, "Confirm Delete") = vbNo Then
            Exit Sub
        End If

        Try
            databaseConnection.con()

            If databaseConnection.currentAdminId > 0 AndAlso databaseConnection.isLoggedIn Then

                Dim oldItemName As String = Me.itemName
                Dim oldLevel As String = Me.level
                Dim oldGender As String = Me.gender
                Dim oldSize As String = Me.size
                Dim oldPrice As String = Me.price
                Dim oldStatus As String = Me.status

                Dim sqlGetOld As String = "SELECT stock_quantity FROM tbluniforms WHERE uniform_id = @uniform_id"
                databaseConnection.cmd = New MySqlCommand(sqlGetOld, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", Me.id)
                Dim oldStock As Integer = Convert.ToInt32(databaseConnection.cmd.ExecuteScalar())

                Dim sql As String = "DELETE FROM tbluniforms WHERE uniform_id = @uniform_id"
                databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", Me.id)
                Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    Dim deleteReason As String = If(cboReason.SelectedIndex <> -1, cboReason.SelectedItem.ToString(), "No reason selected")

                    Dim changedQty As String = "-" & oldStock.ToString()

                    Dim logSql As String = "INSERT INTO tbluniformlogs(uniform_id, action, changed_quantity, previous_quantity, new_quantity, admin_id, action_date, reason, item_name, level, gender, size) " &
                                   "VALUES (@uniform_id, @action, @changed_quantity, @previous_qty, @new_qty, @admin_id, @action_date, @reason, @item_name, @level, @gender, @size)"

                    databaseConnection.cmd = New MySqlCommand(logSql, databaseConnection.cn)
                    databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", Me.id)
                    databaseConnection.cmd.Parameters.AddWithValue("@action", "Delete Item")
                    databaseConnection.cmd.Parameters.AddWithValue("@changed_quantity", changedQty)
                    databaseConnection.cmd.Parameters.AddWithValue("@previous_qty", oldStock)
                    databaseConnection.cmd.Parameters.AddWithValue("@new_qty", 0)
                    databaseConnection.cmd.Parameters.AddWithValue("@admin_id", databaseConnection.currentAdminId)
                    databaseConnection.cmd.Parameters.AddWithValue("@action_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    databaseConnection.cmd.Parameters.AddWithValue("@reason", deleteReason)

                    databaseConnection.cmd.Parameters.AddWithValue("@item_name", oldItemName)
                    databaseConnection.cmd.Parameters.AddWithValue("@level", oldLevel)
                    databaseConnection.cmd.Parameters.AddWithValue("@gender", oldGender)
                    databaseConnection.cmd.Parameters.AddWithValue("@size", oldSize)

                    databaseConnection.cmd.ExecuteNonQuery()

                    MsgBox("Item deleted successfully!", MsgBoxStyle.Information)
                Else
                    MsgBox("No matching record found to delete!", MsgBoxStyle.Exclamation)
                End If

                If Me.Owner IsNot Nothing Then
                    Dim parentForm As frmStockManagement = TryCast(Me.Owner, frmStockManagement)
                    If parentForm IsNot Nothing Then
                        parentForm.displayApplication()
                    End If
                End If

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error deleting record: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        remove()
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
End Class