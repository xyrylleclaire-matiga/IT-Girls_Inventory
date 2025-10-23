Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmCorpoAttireView

    Public parentAdminForm As frmAdmin

    Private Sub frmCorpoAttireView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayApplication()
        CustomizeListView()
    End Sub

    Private Sub CustomizeListView()
        ' ✨ Make ListView prettier
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False
        ListView1.BackColor = Color.White
        ListView1.ForeColor = Color.Black
        ListView1.Font = New Font("Arial Rounded MT Bold", 9.0F)

        ' Auto resize columns after data load
        For Each col As ColumnHeader In ListView1.Columns
            col.Width = -2
        Next
    End Sub

    Private Sub displayApplication(Optional searchQuery As String = "")
        Try
            databaseConnection.con()
            ListView1.Items.Clear()

            ' 🧠 Use LIKE for search if query exists
            Dim sql As String = "SELECT * FROM tbluniforms WHERE category = 'Corporate Attire'"
            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND item_name LIKE @search"
            End If

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            If Not String.IsNullOrEmpty(searchQuery) Then
                databaseConnection.cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
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

                ' 🩵 Alternate row color for clarity
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

    ' 🪄 When selecting an item
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
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

            ' Highlight the selected row in teal for ✨aesthetic vibes✨
            For Each item As ListViewItem In ListView1.Items
                item.BackColor = If(item.Index Mod 2 = 0, Color.White, Color.AliceBlue)
            Next
            ListView1.SelectedItems(0).BackColor = Color.LightSeaGreen
            ListView1.SelectedItems(0).ForeColor = Color.White
        End If
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub

    Private Sub btnRemove_Paint(sender As Object, e As PaintEventArgs) Handles btnModify.Paint
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

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

    End Sub


    Private Sub btnModify_Paint(sender As Object, e As PaintEventArgs) Handles btnModify.Paint
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

    Private Sub btnSave_Paint(sender As Object, e As PaintEventArgs) Handles btnSave1.Paint
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
End Class
