Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmCorpoAttireView

    Public parentAdminForm As frmAdmin


    'DESIGNNNNNN -----------------------------------------------------------------

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        Dim headerColor As Color = Color.FromArgb(0, 150, 136)
        Dim textColor As Color = Color.White

        Using brush As New SolidBrush(headerColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        Dim bgColor As Color = If(e.Item.Index Mod 2 = 0, Color.White, Color.FromArgb(245, 249, 255))

        If e.Item.Selected Then
            bgColor = Color.LightSeaGreen
        End If

        Using brush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        Dim textColor As Color = If(e.Item.Selected, Color.White, Color.Black)
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    Private Sub CustomizeListView()
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False
        ListView1.BackColor = Color.White
        ListView1.ForeColor = Color.Black
        ListView1.Font = New Font("Arial Rounded MT Bold", 9.0F)

        For Each col As ColumnHeader In ListView1.Columns
            col.Width = -2
        Next
    End Sub

    Private Sub btnRemove1_Paint(sender As Object, e As PaintEventArgs) Handles btnRemove.Paint
        Dim btn = DirectCast(sender, Button)
        Dim radius = 10

        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

    Private Sub btnSave_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint
        Dim btn = DirectCast(sender, Button)
        Dim radius = 10

        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

    Private Sub btnBack1_Paint(sender As Object, e As PaintEventArgs) Handles btnBack1.Paint
        Dim btn = DirectCast(sender, Button)
        Dim radius = 10

        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
    End Sub

    '--------------------------------------------------------------------




    'BACKENDDDDD --------------------------------------------

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub

    Private Sub frmCorpoAttireView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayApplication()
        CustomizeListView()
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            txtItemName.Text = selectedItem.Text
            txtLevel.Text = selectedItem.SubItems(1).Text
            txtGender.Text = selectedItem.SubItems(2).Text
            txtSize.Text = selectedItem.SubItems(3).Text
            txtStockQuantity.Text = selectedItem.SubItems(4).Text
            txtPrice.Text = selectedItem.SubItems(5).Text
            txtStatus.Text = selectedItem.SubItems(6).Text
            txtDateAdded.Text = selectedItem.SubItems(7).Text
        End If

        For Each item As ListViewItem In ListView1.Items
            item.BackColor = If(item.Index Mod 2 = 0, Color.White, Color.AliceBlue)
            item.ForeColor = Color.Black
        Next

        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            selectedItem.BackColor = Color.LightSeaGreen
            selectedItem.ForeColor = Color.White
        End If
    End Sub

    Private Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView1.Items.Clear()

            Dim sql As String = "SELECT * FROM tbluniforms WHERE category = 'Corporate Attire'"
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

                Dim x As New ListViewItem(databaseConnection.dr("item_name").ToString())
                x.SubItems.Add(databaseConnection.dr("level").ToString())
                x.SubItems.Add(databaseConnection.dr("gender").ToString())
                x.SubItems.Add(databaseConnection.dr("size").ToString())
                x.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
                x.SubItems.Add(databaseConnection.dr("price").ToString())
                x.SubItems.Add(statusText)
                x.SubItems.Add(databaseConnection.dr("date_added").ToString())

                ' alternate row color
                If rowIndex Mod 2 = 0 Then
                    x.BackColor = Color.White
                Else
                    x.BackColor = Color.AliceBlue
                End If

                x.UseItemStyleForSubItems = False
                x.SubItems(6).ForeColor = statusColor

                ListView1.Items.Add(x)
                rowIndex += 1
            End While

            ' ✅ this should be OUTSIDE the loop
            ListView1.OwnerDraw = True

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.dr IsNot Nothing Then databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        End Try
    End Sub


    ' ✅ Drawing logic
    Private Sub ListView2_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
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

            e.Graphics.DrawString(text, ListView1.Font, New SolidBrush(color), e.Bounds, sf)
        Else
            e.DrawDefault = True
        End If
    End Sub


    'Public Sub openChildForm(child As Form)
    '    child.TopLevel = False
    '    child.FormBorderStyle = FormBorderStyle.None
    '    child.Dock = DockStyle.Fill
    '    Me.Controls.Add(child)
    '    Me.Tag = child
    '    child.BringToFront()
    '    child.Show()
    'End Sub

    'Private Sub btnBack_Click(sender As Object, e As EventArgs)
    '    Close
    '    If parentAdminForm IsNot Nothing Then
    '        parentAdminForm.openChildForm(New frmHomeAdmin)
    '    End If
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub clearAll()
        txtPrice.Clear()
        txtItemName.Clear()
        txtDateAdded.Clear()
        txtGender.Clear()
        txtLevel.Clear()
        txtStatus.Clear()
        txtDateAdded.Clear()
        txtStockQuantity.Clear()
    End Sub
    Private Sub save()
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to update", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim currentItemName As String = selectedItem.Text
        Dim currentLevel As String = selectedItem.SubItems(1).Text
        Dim currentGender As String = selectedItem.SubItems(2).Text
        Dim currentSize As String = selectedItem.SubItems(3).Text

        databaseConnection.con()
        Dim sql As String = "UPDATE tbluniforms SET stock_quantity=@quantity, price=@price " &
                            "WHERE item_name=@itemName AND level=@level AND gender=@gender AND size=@size"

        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

        databaseConnection.cmd.Parameters.AddWithValue("@quantity", txtStockQuantity.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@price", txtPrice.Text)

        databaseConnection.cmd.Parameters.AddWithValue("@itemName", txtItemName.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@level", txtLevel.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@gender", txtGender.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@size", txtSize.Text)

        databaseConnection.cmd.ExecuteNonQuery()

        MsgBox("Item updated successfully", MsgBoxStyle.Information)
        displayApplication()
        clearAll()
    End Sub





End Class
