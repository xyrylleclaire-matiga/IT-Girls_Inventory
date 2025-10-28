Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmStockManagement


    Public parentAdminForm As frmAdmin

    Private Sub frmCorpoAttireView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.OwnerDraw = True

        displayApplication()
        CustomizeListView()
    End Sub



    'DESIGNNNN
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


    Private Sub rdoAllCategory_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllCategory.CheckedChanged
        If rdoAllCategory.Checked Then
            rdoSchoolUniform.Checked = False
            rdoPEUniform.Checked = False
            rdoCorpo.Checked = False
            displayApplication() ' ← THIS LINE IS IMPORTANT
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



    'DISPLAYYYY
    Private Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView1.Items.Clear()

            ' Define columns if not already set
            If ListView1.Columns.Count = 0 Then
                ListView1.Columns.Add("Uniform ID", 0) ' hidden
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

            ' Filter by category
            If rdoSchoolUniform.Checked Then
                sql &= " AND category = 'School Uniform'"
            ElseIf rdoPEUniform.Checked Then
                sql &= " AND category = 'PE Uniform'"
            ElseIf rdoCorpo.Checked Then
                sql &= " AND category = 'Corporate Attire'"
            End If
            ' (AllCategory = no filter, so we skip it)

            ' Filter by level
            If cboLevel.SelectedItem IsNot Nothing Then
                sql &= " AND level = @level"
            End If

            ' Search
            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND (item_name LIKE @search OR level LIKE @search OR gender = @exactGender)"
            End If

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

            ' Add params if needed
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
                item.SubItems.Add(databaseConnection.dr("item_name").ToString())
                item.SubItems.Add(databaseConnection.dr("level").ToString())
                item.SubItems.Add(databaseConnection.dr("gender").ToString())
                item.SubItems.Add(databaseConnection.dr("size").ToString())
                item.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
                item.SubItems.Add(databaseConnection.dr("price").ToString())
                item.SubItems.Add(databaseConnection.dr("status").ToString())
                item.SubItems.Add(databaseConnection.dr("date_added").ToString())

                ' alternate row color
                If rowIndex Mod 2 = 0 Then
                    item.BackColor = Color.White
                Else
                    item.BackColor = Color.AliceBlue
                End If

                ListView1.Items.Add(item)
                rowIndex += 1
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.dr IsNot Nothing Then databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        End Try
    End Sub


    'DISPLAYTT SA TEXTBOX
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            txtItemName.Text = selectedItem.SubItems(1).Text
            txtLevel.Text = selectedItem.SubItems(2).Text
            txtGender.Text = selectedItem.SubItems(3).Text
            txtSize.Text = selectedItem.SubItems(4).Text
            txtQuantity.Text = selectedItem.SubItems(5).Text
            txtPrice.Text = selectedItem.SubItems(6).Text
            txtStatus.Text = selectedItem.SubItems(7).Text
            txtDateAdded.Text = selectedItem.SubItems(8).Text

        End If

        ' Reset alternating row colors first
        For Each item As ListViewItem In ListView1.Items
            item.BackColor = If(item.Index Mod 2 = 0, Color.White, Color.AliceBlue)
            item.ForeColor = Color.Black
        Next

        ' Highlight the currently selected item
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            selectedItem.BackColor = Color.LightSeaGreen
            selectedItem.ForeColor = Color.White
        End If
    End Sub

    'RADIO BUTTONS
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSchoolUniform.CheckedChanged, rdoPEUniform.CheckedChanged, rdoCorpo.CheckedChanged
        Dim rdo As RadioButton = DirectCast(sender, RadioButton)
        If rdo.Checked Then
            displayApplication(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
        If cboLevel.SelectedItem = "Kindergarten" Then
            displayApplication(txtSearch.Text.Trim())
        ElseIf cboLevel.SelectedItem = "Elementary" Then
            displayApplication(txtSearch.Text.Trim())
        ElseIf cboLevel.SelectedItem = "Junior High" Then
            displayApplication(txtSearch.Text.Trim())
        ElseIf cboLevel.SelectedItem = "Senior High" Then
            displayApplication(txtSearch.Text.Trim())
        ElseIf cboLevel.SelectedItem = "College" Then
            displayApplication(txtSearch.Text.Trim())


        End If
    End Sub


    ' 🎨 Draw the column headers
    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        Dim headerColor As Color = Color.FromArgb(0, 150, 136) ' 💅 Material-style teal
        ' 💙 Example: blue tone (change as needed)
        Dim textColor As Color = Color.White

        Using brush As New SolidBrush(headerColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    ' 🧩 Draw each item (row) - FINAL MODIFICATION
    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem

        Dim bgColor As Color

        If e.Item.Selected Then
            ' Highlight color when selected
            bgColor = Color.LightSeaGreen
        Else
            ' Alternating row color
            bgColor = If(e.Item.Index Mod 2 = 0, Color.White, Color.FromArgb(245, 249, 255))
        End If

        ' Draw the background
        Using brush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using

        ' Ito ang importante: I-draw ang focus rectangle kung focused
        If e.Item.Focused Then
            e.DrawFocusRectangle()
        End If

    End Sub

    ' 🧾 Draw subitems (columns)
    ' 🧾 Draw subitems (columns) - MODIFIED FOR STATUS COLOR CODING AND TEXT DRAWING
    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem

        Dim textColor As Color = If(e.Item.Selected, Color.White, Color.Black)
        Dim cellBGColor As Color = e.Item.BackColor ' Kunin ang row color na dinrow sa DrawItem

        ' === STATUS COLOR CODING LOGIC (Column Index 7) ===
        ' Tiyaking ang column index 7 (Status) ang dine-draw mo
        If e.ColumnIndex = 7 Then
            Dim statusText As String = e.SubItem.Text.ToLower().Trim()

            ' Set specific text color based on status
            If statusText = "available" Then
                textColor = If(e.Item.Selected, Color.White, Color.Green)
            ElseIf statusText = "low stock" Then
                textColor = If(e.Item.Selected, Color.White, Color.OrangeRed) ' Para sa low stock
            ElseIf statusText = "out of stock" Then
                textColor = If(e.Item.Selected, Color.White, Color.Red)
            End If

            ' Optionally, change the background color of the status cell when not selected
            If Not e.Item.Selected Then
                If statusText = "low stock" Then
                    cellBGColor = Color.LightYellow ' Light yellow background for low stock
                ElseIf statusText = "out of stock" Then
                    cellBGColor = Color.MistyRose ' Light pink background for out of stock
                End If
            End If
        End If

        ' === DRAW THE CELL BACKGROUND ===
        ' **ITO ANG SUSI PARA HINDI MAG-DISAPPEAR ANG CELL KAPAG HINDI SELECTED ANG ROW**
        If Not e.Item.Selected Then
            Using bgBrush As New SolidBrush(cellBGColor)
                e.Graphics.FillRectangle(bgBrush, e.Bounds)
            End Using
        End If

        ' === DRAW THE TEXT ===
        ' Draw the text (with the determined textColor)
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)

    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Close
        If parentAdminForm IsNot Nothing Then
            parentAdminForm.openChildForm(New frmHomeAdmin)
        End If
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

    Private Sub btnBack_Paint(sender As Object, e As PaintEventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim radius = 10

        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseFigure

        btn.Region = New Region(path)
    End Sub
    Private Sub clearAll()
        txtPrice.Clear()
        txtItemName.Clear()
        txtDateAdded.Clear()
        txtGender.Clear()
        txtLevel.Clear()
        txtStatus.Clear()
        txtDateAdded.Clear()
        txtQuantity.Clear()
        txtSize.Clear()
    End Sub
    Private Sub save()
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to update", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim uniformId As String = selectedItem.SubItems(0).Text ' get the hidden ID

        databaseConnection.con()

        Dim sql As String = "UPDATE tbluniforms SET stock_quantity=@quantity, price=@price WHERE uniform_id=@uniform_id"

        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@price", txtPrice.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)

        Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Item updated successfully!", MsgBoxStyle.Information)
            displayApplication()
            clearAll()
        Else
            MsgBox("No matching record found to update!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        remove()
    End Sub

    Private Sub remove()
        If MsgBox("Do you want to remove the record on the list?", vbQuestion + vbYesNo) = vbYes Then
            If ListView1.SelectedItems.Count > 0 Then
                ' Kunin muna yung selected item bago mo siya i-remove
                Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
                Dim uniformId As String = selectedItem.SubItems(0).Text ' assuming uniform_id is in the first column

                ' Then saka mo i-delete sa database
                databaseConnection.con()
                Dim sql As String = "DELETE FROM tbluniforms WHERE uniform_id=@uniform_id"
                databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", uniformId)
                databaseConnection.cmd.ExecuteNonQuery()

                ' Then remove from ListView after database deletion
                ListView1.Items.Remove(selectedItem)

                MsgBox("Item deleted successfully!", MsgBoxStyle.Information)
                displayApplication()
                clearAll()
            Else
                MsgBox("No item selected", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Cancel Processed", MsgBoxStyle.Information)
        End If
    End Sub

End Class