Imports MySql.Data.MySqlClient

Public Class frmPEUniformView

    'DESIGNNN ----------------------------------------
    Private Sub CustomizeListView()
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView2.HideSelection = False
        ListView2.MultiSelect = False
        ListView2.BackColor = Color.White
        ListView2.ForeColor = Color.Black
        ListView2.Font = New Font("Arial Rounded MT Bold", 9.0F)
        ListView2.View = View.Details

        For Each col As ColumnHeader In ListView2.Columns
            col.Width = -2
        Next
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView2.DrawColumnHeader
        Dim headerColor As Color = Color.FromArgb(0, 150, 136)
        Dim textColor As Color = Color.White

        Using brush As New SolidBrush(headerColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        Using pen As New Pen(Color.FromArgb(0, 120, 110))
            e.Graphics.DrawRectangle(pen, New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1))
        End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, ListView2.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.SingleLine)
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView2.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView2.DrawSubItem
        e.DrawDefault = True
    End Sub
    '----------------------------------------------------



    'BACKENDDDDDDDDDDDDDDDDDDDDDD-------------------------------
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)

            txtItemName.Text = selectedItem.SubItems(1).Text
            txtLevel.Text = selectedItem.SubItems(2).Text
            txtGender.Text = selectedItem.SubItems(3).Text
            txtSize1.Text = selectedItem.SubItems(4).Text
            txtQuantity.Text = selectedItem.SubItems(5).Text
            txtPrice.Text = selectedItem.SubItems(6).Text
            txtStatus1.Text = selectedItem.SubItems(7).Text
            txtDateAdded.Text = selectedItem.SubItems(8).Text
        End If

        For Each item As ListViewItem In ListView2.Items
            item.BackColor = If(item.Index Mod 2 = 0, Color.White, Color.AliceBlue)
            item.ForeColor = Color.Black
        Next

        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            selectedItem.BackColor = Color.LightSeaGreen
            selectedItem.ForeColor = Color.White
        End If
    End Sub

    'FOR DISPLAYYYYY NG DATA
    Private Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView2.Items.Clear()

            Dim sql As String = "SELECT * FROM tbluniforms WHERE category = 'PE Uniform'"
            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND (item_name LIKE @search OR level LIKE @search OR gender = @exactGender)"
            End If

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            If Not String.IsNullOrEmpty(searchQuery) Then
                databaseConnection.cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
                databaseConnection.cmd.Parameters.AddWithValue("@exactGender", searchQuery)
            End If

            databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

            Dim rowIndex As Integer = 0
            While databaseConnection.dr.Read()
                Dim stckQty As Integer = Convert.ToInt32(databaseConnection.dr("stock_quantity"))

                Dim statusText As String
                Dim statusColor As Color

                If stckQty = 0 Then
                    statusText = "Out of Stock"
                    statusColor = Color.Red
                ElseIf stckQty < 10 And stckQty > 0 Then
                    statusText = "Critical"
                    statusColor = Color.Orange
                Else
                    statusText = "Available"
                    statusColor = Color.Green
                End If

                Dim x As New ListViewItem(databaseConnection.dr("uniform_id").ToString())
                x.SubItems.Add(databaseConnection.dr("item_name").ToString())
                x.SubItems.Add(databaseConnection.dr("level").ToString())
                x.SubItems.Add(databaseConnection.dr("gender").ToString())
                x.SubItems.Add(databaseConnection.dr("size").ToString())
                x.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
                x.SubItems.Add(databaseConnection.dr("price").ToString())
                x.SubItems.Add(statusText)
                x.SubItems.Add(databaseConnection.dr("date_added").ToString())

                If rowIndex Mod 2 = 0 Then
                    x.BackColor = Color.White
                Else
                    x.BackColor = Color.AliceBlue
                End If

                x.UseItemStyleForSubItems = False
                x.SubItems(7).ForeColor = statusColor

                ListView2.Items.Add(x)
                rowIndex += 1
            End While

            ListView2.OwnerDraw = False

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.dr IsNot Nothing Then databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        End Try
    End Sub

    Private Sub ListView2_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView2.DrawSubItem
        If e.ColumnIndex = 6 Then
            e.DrawBackground()
            Dim text = e.SubItem.Text
            Dim color As Color

            Select Case text
                Case "Out of Stock"
                    color = Color.Red
                Case "Critical"
                    color = Color.Orange
                Case Else
                    color = Color.Green
            End Select

            Dim sf As New StringFormat()
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Near

            e.Graphics.DrawString(text, ListView2.Font, New SolidBrush(color), e.Bounds, sf)
        Else
            e.DrawDefault = True
        End If
    End Sub



    Private Sub PEUniformView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayApplication()
        CustomizeListView()
        ListView2.OwnerDraw = True
    End Sub

    Private Sub clearAll()
        txtPrice.Clear()
        txtItemName.Clear()
        txtDateAdded.Clear()
        txtGender.Clear()
        txtLevel.Clear()
        txtStatus1.Clear()
        txtDateAdded.Clear()
        txtQuantity.Clear()
        txtSize1.Clear()
    End Sub


    Private Sub save()
        Try
            If ListView2.SelectedItems.Count = 0 Then
                MsgBox("Please select an item to update", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim currentItemName As String = selectedItem.Text
            Dim currentLevel As String = selectedItem.SubItems(1).Text
            Dim currentGender As String = selectedItem.SubItems(2).Text
            Dim currentSize As String = selectedItem.SubItems(3).Text

            Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to update this item?",
            "Confirm update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                MessageBox.Show("Cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            databaseConnection.con()
            Dim sql As String =
            "UPDATE tbluniforms SET stock_quantity=@quantity, price=@price " &
            "WHERE item_name=@itemName AND level=@level AND gender=@gender AND size=@size"

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@itemName", txtItemName.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@level", txtLevel.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@gender", txtGender.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@size", txtSize1.Text)

            Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                displayApplication()
                clearAll()
            Else
                MessageBox.Show("No record updated. Please check your item details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.cn IsNot Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub


    Private Sub remove()
        Try
            If ListView2.SelectedItems.Count = 0 Then
                MsgBox("Please select an item to delete.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show(
            "Do you want to remove this record from the list?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                MsgBox("Cancelled.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim uniformId As String = selectedItem.SubItems(0).Text

            databaseConnection.con()
            Dim sql As String = "DELETE FROM tbluniforms WHERE uniform_id = @uniform_id"
            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)

            Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                ListView2.Items.Remove(selectedItem)
                MsgBox("Item deleted successfully!", MsgBoxStyle.Information)
                displayApplication()
                clearAll()
            Else
                MsgBox("No item deleted. Check if the ID exists in the database.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If databaseConnection.cn IsNot Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        remove()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim parentForm As Form = Me.ParentForm

        While parentForm IsNot Nothing AndAlso Not TypeOf parentForm Is frmAdmin
            parentForm = parentForm.ParentForm
        End While

        If parentForm IsNot Nothing Then
            CType(parentForm, frmAdmin).openChildForm(New frmHomeAdmin)
        Else
            MessageBox.Show("Cannot find the Admin form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class