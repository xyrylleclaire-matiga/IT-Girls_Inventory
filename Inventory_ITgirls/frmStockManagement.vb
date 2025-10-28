Imports MySql.Data.MySqlClient
Imports System.Drawing

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


    'DISPLAYYYY
    Private Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView1.Items.Clear()

            Dim sql As String = "SELECT * FROM tbluniforms WHERE 1=1"

            If rdoSchoolUniform.Checked Then
                sql &= " AND category = 'School Uniform'"
            ElseIf rdoPEUniform.Checked Then
                sql &= " AND category = 'PE Uniform'"
            ElseIf rdoCorpo.Checked Then
                sql &= " AND category = 'Corporate Attire'"
            End If

            If cboLevel.SelectedItem = "Kindergarten" Then
                sql &= " AND level = 'Kindergarten'"
            ElseIf cboLevel.SelectedItem = "Elementary" Then
                sql &= " AND level = 'Elementary'"
            ElseIf cboLevel.SelectedItem = "Junior High" Then
                sql &= " AND level = 'Junior High'"
            ElseIf cboLevel.SelectedItem = "Senior High" Then
                sql &= " AND level = 'Senior High'"
            ElseIf cboLevel.SelectedItem = "College" Then
                sql &= " AND level = 'College'"
            End If

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
                Dim x As New ListViewItem(databaseConnection.dr("item_name").ToString())
                x.SubItems.Add(databaseConnection.dr("level").ToString())
                x.SubItems.Add(databaseConnection.dr("gender").ToString())
                x.SubItems.Add(databaseConnection.dr("size").ToString())
                x.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
                x.SubItems.Add(databaseConnection.dr("price").ToString())
                x.SubItems.Add(databaseConnection.dr("status").ToString())
                x.SubItems.Add(databaseConnection.dr("date_added").ToString())

                If rowIndex Mod 2 = 0 Then
                    x.BackColor = Color.White
                Else
                    x.BackColor = Color.AliceBlue
                End If

                ListView1.Items.Add(x)
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

            ' Fill the textboxes
            txtItemName.Text = selectedItem.Text
            txtLevel.Text = selectedItem.SubItems(1).Text
            txtGender.Text = selectedItem.SubItems(2).Text
            txtSize.Text = selectedItem.SubItems(3).Text
            txtStockQuantity.Text = selectedItem.SubItems(4).Text
            txtPrice.Text = selectedItem.SubItems(5).Text
            txtStatus.Text = selectedItem.SubItems(6).Text
            txtDateAdded.Text = selectedItem.SubItems(7).Text
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

    ' 🧩 Draw each item (row)
    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        ' Background color alternation
        Dim bgColor As Color = If(e.Item.Index Mod 2 = 0, Color.White, Color.FromArgb(245, 249, 255))

        ' Highlight color when selected
        If e.Item.Selected Then
            bgColor = Color.LightSeaGreen
        End If

        Using brush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using
    End Sub

    ' 🧾 Draw subitems (columns)
    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        Dim textColor As Color = If(e.Item.Selected, Color.White, Color.Black)
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class