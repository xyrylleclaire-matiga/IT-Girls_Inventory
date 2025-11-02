Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmStockManagement

    'DESIGNNN ----------------------------------------
    Private Sub CustomizeListView()
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False
        ListView1.BackColor = Color.White
        ListView1.ForeColor = Color.Black
        ListView1.Font = New Font("Arial Rounded MT Bold", 9.0F)
        ListView1.View = View.Details

        For Each col As ColumnHeader In ListView1.Columns
            col.Width = -2
        Next
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        Dim headerColor As Color = Color.FromArgb(0, 150, 136) ' Teal color
        Dim textColor As Color = Color.White

        Using brush As New SolidBrush(headerColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        Using pen As New Pen(Color.FromArgb(0, 120, 110))
            e.Graphics.DrawRectangle(pen, New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1))
        End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, ListView1.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.SingleLine)
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        e.DrawDefault = True
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

    Private Sub btnEditItems_Paint(sender As Object, e As PaintEventArgs) Handles btnEditItems.Paint
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

    Private Sub btnRemove1_Paint(sender As Object, e As PaintEventArgs) Handles btnRemove1.Paint
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

    'END OF DESIGN -----------------------------------

    Private Sub rdoAllCategory_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllCategory.CheckedChanged
        If rdoAllCategory.Checked Then
            rdoSchoolUniform.Checked = False
            rdoPEUniform.Checked = False
            rdoCorpo.Checked = False
            displayApplication()
        End If
    End Sub

    Private Sub rdoSchoolUniform_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSchoolUniform.CheckedChanged
        If rdoSchoolUniform.Checked Then
            displayApplication()
        End If
    End Sub

    Private Sub rdoPEUniform_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPEUniform.CheckedChanged
        If rdoPEUniform.Checked Then
            displayApplication()
        End If
    End Sub

    Private Sub rdoCorpo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCorpo.CheckedChanged
        If rdoCorpo.Checked Then
            displayApplication()
        End If
    End Sub

    'DISPLAYYYY APPLICATION
    Public Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView1.Items.Clear()

            If ListView1.Columns.Count = 0 Then
                ListView1.Columns.Add("Uniform ID", 0)
                ListView1.Columns.Add("Item Name", 120)
                ListView1.Columns.Add("Level", 100)
                ListView1.Columns.Add("Gender", 80)
                ListView1.Columns.Add("Size", 80)
                ListView1.Columns.Add("Stock Qty", 80)
                ListView1.Columns.Add("Price", 80)
                ListView1.Columns.Add("Status", 80)
                ListView1.Columns.Add("Date Added", 120)
            End If

            Dim sql As String = "SELECT * FROM tbluniforms WHERE 1=1"

            If rdoSchoolUniform.Checked Then
                sql &= " AND category = 'School Uniform'"
            ElseIf rdoPEUniform.Checked Then
                sql &= " AND category = 'PE Uniform'"
            ElseIf rdoCorpo.Checked Then
                sql &= " AND category = 'Corporate Attire'"
            End If

            If cboLevel.SelectedItem IsNot Nothing Then
                sql &= " AND level = @level"
            End If

            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND (item_name LIKE @search OR level LIKE @search OR gender = @exactGender)"
            End If

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

            If cboLevel.SelectedItem IsNot Nothing Then
                databaseConnection.cmd.Parameters.AddWithValue("@level", cboLevel.SelectedItem.ToString())
            End If
            If Not String.IsNullOrEmpty(searchQuery) Then
                databaseConnection.cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                databaseConnection.cmd.Parameters.AddWithValue("@exactGender", searchQuery)
            End If

            databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

            Dim rowIndex As Integer = 0
            While databaseConnection.dr.Read()
                Dim item As New ListViewItem(databaseConnection.dr("uniform_id").ToString())

                item.UseItemStyleForSubItems = False

                Dim rowBgColor As Color
                If rowIndex Mod 2 = 0 Then
                    rowBgColor = Color.White
                Else
                    rowBgColor = Color.FromArgb(245, 249, 255)
                End If

                item.SubItems.Add(databaseConnection.dr("item_name").ToString())
                item.SubItems.Add(databaseConnection.dr("level").ToString())
                item.SubItems.Add(databaseConnection.dr("gender").ToString())
                item.SubItems.Add(databaseConnection.dr("size").ToString())
                item.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
                item.SubItems.Add(databaseConnection.dr("price").ToString())

                Dim statusText As String = databaseConnection.dr("status").ToString()
                Dim statusSubItem As New ListViewItem.ListViewSubItem(item, statusText)

                'Select Case statusText.ToLower().Trim()
                '    Case "available"
                '        statusSubItem.ForeColor = Color.Green
                '        statusSubItem.BackColor = rowBgColor
                '    Case "critical"
                '        statusSubItem.ForeColor = Color.OrangeRed
                '        statusSubItem.BackColor = Color.LightYellow
                '    Case "out of stock"
                '        statusSubItem.ForeColor = Color.Red
                '        statusSubItem.BackColor = Color.MistyRose
                '    Case Else
                '        statusSubItem.BackColor = rowBgColor
                'End Select


                item.SubItems.Add(statusSubItem)
                item.SubItems.Add(databaseConnection.dr("date_added").ToString())

                For i As Integer = 0 To item.SubItems.Count - 1
                    If i <> 7 Then
                        item.SubItems(i).BackColor = rowBgColor
                    End If
                Next

                ListView1.Items.Add(item)
                rowIndex += 1
            End While

            databaseConnection.dr.Close()

            For Each item As ListViewItem In ListView1.Items
                Dim stockQty As Integer = CInt(item.SubItems(5).Text)
                Dim currentStatus As String = item.SubItems(7).Text
                Dim newStatus As String = currentStatus

                If stockQty <= 0 Then
                    newStatus = "Out of Stock"
                ElseIf stockQty <= 5 Then
                    newStatus = "Critical"
                Else
                    newStatus = "Available"
                End If

                If newStatus <> currentStatus Then
                    Dim updateQuery As String = "UPDATE tbluniforms SET status=@status WHERE uniform_id=@id"
                    Using cmd As New MySqlCommand(updateQuery, databaseConnection.cn)
                        cmd.Parameters.AddWithValue("@status", newStatus)
                        cmd.Parameters.AddWithValue("@id", item.SubItems(0).Text) ' id col = 0
                        cmd.ExecuteNonQuery()
                    End Using
                End If

                item.SubItems(7).Text = newStatus
                ApplyStatusColor(item.SubItems(7))

            Next

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.dr IsNot Nothing Then databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        End Try
    End Sub


    Private Sub ApplyStatusColor(subItem As ListViewItem.ListViewSubItem)
        Select Case subItem.Text.ToLower().Trim()
            Case "available"
                subItem.ForeColor = Color.Green
                subItem.BackColor = Color.White
            Case "critical"
                subItem.ForeColor = Color.OrangeRed
                subItem.BackColor = Color.LightYellow
            Case "out of stock"
                subItem.ForeColor = Color.Red
                subItem.BackColor = Color.MistyRose
            Case Else
                subItem.ForeColor = Color.Black
                subItem.BackColor = Color.White
        End Select
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            txtItemName.Text = selectedItem.SubItems(1).Text
            txtLevel.Text = selectedItem.SubItems(2).Text
            txtGender.Text = selectedItem.SubItems(3).Text
            txtSize.Text = selectedItem.SubItems(4).Text
            txtQuantity.Text = selectedItem.SubItems(5).Text

            Dim rawPrice As Decimal
            If Decimal.TryParse(selectedItem.SubItems(6).Text, rawPrice) Then
                txtPrice.Text = "₱ " & rawPrice.ToString("N2")
            Else
                txtPrice.Text = "₱ 0.00"
            End If

            txtStatus.Text = selectedItem.SubItems(7).Text
            txtDateAdded.Text = selectedItem.SubItems(8).Text
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSchoolUniform.CheckedChanged, rdoPEUniform.CheckedChanged, rdoCorpo.CheckedChanged
        Dim rdo As RadioButton = DirectCast(sender, RadioButton)
        If rdo.Checked Then
            displayApplication(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub

    Public parentAdminForm As frmAdmin

    Private Sub frmCorpoAttireView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.OwnerDraw = True
        displayApplication()
        CustomizeListView()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Close()
        If parentAdminForm IsNot Nothing Then
            parentAdminForm.openChildForm(New frmHomeAdmin)
        End If
    End Sub

    Private Sub clearAll()
        txtPrice.Clear()
        txtItemName.Clear()
        txtDateAdded.Clear()
        txtGender.Clear()
        txtLevel.Clear()
        txtStatus.Clear()
        txtQuantity.Clear()
        txtSize.Clear()
    End Sub

    Private Sub editItems()
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to edit", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim id As String = selectedItem.SubItems(0).Text
        Dim itemName As String = selectedItem.SubItems(1).Text
        Dim level As String = selectedItem.SubItems(2).Text
        Dim gender As String = selectedItem.SubItems(3).Text
        Dim size As String = selectedItem.SubItems(4).Text
        Dim stockQuantity As String = selectedItem.SubItems(5).Text
        Dim price As String = selectedItem.SubItems(6).Text
        Dim status As String = selectedItem.SubItems(7).Text

        Dim editForm As New frmEditItems(id, itemName, level, gender, size, stockQuantity, price, status)
        editForm.StartPosition = FormStartPosition.CenterParent
        If editForm.ShowDialog(Me) = DialogResult.OK Then
            displayApplication()
            For Each item As ListViewItem In ListView1.Items
                If item.SubItems(0).Text = id Then
                    item.Selected = True
                    item.EnsureVisible()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        remove()
    End Sub

    Private Sub remove()
        If MsgBox("Do you want to remove the record on the list?", vbQuestion + vbYesNo) = vbYes Then
            If ListView1.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
                Dim uniformId As String = selectedItem.SubItems(0).Text
                Try
                    databaseConnection.con()

                    Dim sqlGetDetails As String = "SELECT item_name, level, gender, size, stock_quantity FROM tbluniforms WHERE uniform_id=@uniform_id"
                    databaseConnection.cmd = New MySqlCommand(sqlGetDetails, databaseConnection.cn)
                    databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)
                    databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

                    Dim itemName As String = ""
                    Dim level As String = ""
                    Dim gender As String = ""
                    Dim size As String = ""
                    Dim stockQty As Integer = 0

                    If databaseConnection.dr.Read() Then
                        itemName = databaseConnection.dr("item_name").ToString()
                        level = If(IsDBNull(databaseConnection.dr("level")), "", databaseConnection.dr("level").ToString())
                        gender = If(IsDBNull(databaseConnection.dr("gender")), "", databaseConnection.dr("gender").ToString())
                        size = If(IsDBNull(databaseConnection.dr("size")), "", databaseConnection.dr("size").ToString())
                        stockQty = Convert.ToInt32(databaseConnection.dr("stock_quantity"))
                    End If

                    databaseConnection.dr.Close()

                    Dim sql As String = "DELETE FROM tbluniforms WHERE uniform_id=@uniform_id"
                    databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
                    databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)
                    Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

                    If rowsAffected > 0 AndAlso databaseConnection.currentAdminId > 0 AndAlso databaseConnection.isLoggedIn Then
                        Dim changeStr As String = "-" & stockQty.ToString()

                        Dim logSql As String = "INSERT INTO tbluniformlogs(uniform_id, action, changed_quantity, previous_quantity, new_quantity, admin_id, action_date, item_name, level, gender, size) " &
                                          "VALUES (@uniform_id, @action, @changed_qty, @previous_qty, @new_qty, @admin_id, @action_date, @item_name, @level, @gender, @size)"

                        databaseConnection.cmd = New MySqlCommand(logSql, databaseConnection.cn)
                        databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)
                        databaseConnection.cmd.Parameters.AddWithValue("@action", "Delete Item")
                        databaseConnection.cmd.Parameters.AddWithValue("@changed_qty", changeStr)
                        databaseConnection.cmd.Parameters.AddWithValue("@previous_qty", stockQty)
                        databaseConnection.cmd.Parameters.AddWithValue("@new_qty", 0)
                        databaseConnection.cmd.Parameters.AddWithValue("@admin_id", databaseConnection.currentAdminId)
                        databaseConnection.cmd.Parameters.AddWithValue("@action_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

                        databaseConnection.cmd.Parameters.AddWithValue("@item_name", itemName)
                        databaseConnection.cmd.Parameters.AddWithValue("@level", level)
                        databaseConnection.cmd.Parameters.AddWithValue("@gender", gender)
                        databaseConnection.cmd.Parameters.AddWithValue("@size", size)

                        databaseConnection.cmd.ExecuteNonQuery()
                    End If

                    ListView1.Items.Remove(selectedItem)
                    MsgBox("Item deleted successfully!", MsgBoxStyle.Information)
                    displayApplication()
                    clearAll()

                Catch ex As Exception
                    MsgBox("Error deleting item: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    If databaseConnection.dr IsNot Nothing AndAlso Not databaseConnection.dr.IsClosed Then
                        databaseConnection.dr.Close()
                    End If
                    databaseConnection.cn.Close()
                End Try
            Else
                MsgBox("No item selected", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Cancel Processed", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim popup As New frmAddItems()
        popup.StartPosition = FormStartPosition.CenterParent
        popup.ShowDialog(Me)
    End Sub

    Private Sub btnEditItems_Click(sender As Object, e As EventArgs) Handles btnEditItems.Click
        editItems()
    End Sub
End Class