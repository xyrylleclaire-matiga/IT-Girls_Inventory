Imports MySql.Data.MySqlClient

Public Class TotalPullouts

    'FOR DESIGNNNNNN --------------------------------------------
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

    Private Sub btnClear_Paint(sender As Object, e As PaintEventArgs) Handles btnClear.Paint
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



    '-------------------------------------------------------------
    'BACKENDDD
    Private selectedUniformID As Integer
    'Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    '    lblItemName.Clear()
    '    lblDate.Clear()
    '    txtQuantity.Clear()
    '    cboPulloutReason.Text = ""
    '    Hide()
    '    Admin.Show()
    'End Sub

    Private Sub displayApplication(Optional searchQuery As String = "")
        databaseConnection.con()
        ListView1.Items.Clear()

        sql = "SELECT * FROM tbluniforms WHERE 1=1"

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
            x.SubItems.Add(databaseConnection.dr("category").ToString())
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
            x.SubItems(8).ForeColor = statusColor

            ListView1.Items.Add(x)
            rowIndex += 1
        End While

        databaseConnection.dr.Close()
        databaseConnection.cn.Close()
    End Sub




    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            selectedUniformID = CInt(selectedItem.SubItems(0).Text)
            lblItemName.Text = selectedItem.SubItems(1).Text
            lblDate.Text = Date.Now.ToString("yyyy-MM-dd-H-m-s")
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

    Private Sub PulloutView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.OwnerDraw = True
        displayApplication()
        CustomizeListView()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(lblDate.Text) OrElse
            String.IsNullOrWhiteSpace(cboPulloutReason.Text) OrElse
            String.IsNullOrWhiteSpace(lblItemName.Text) OrElse
            String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("Please fill out all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Please enter a numeric number.", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf CInt(txtQuantity.Text) <= 0 Then
            MsgBox("Please enter a valid number, the enter quantity must be greater than 0.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim pulloutQty As Integer = CInt(txtQuantity.Text)

        databaseConnection.con()

        Dim sqlCheck As String = "SELECT stock_quantity FROM tbluniforms WHERE uniform_id = @uniform_id"
        Dim currentStock As Integer
        databaseConnection.cmd = New MySqlCommand(sqlCheck, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)

        Dim resultObj = databaseConnection.cmd.ExecuteScalar()
        currentStock = If(IsDBNull(resultObj), 0, CInt(resultObj))
        If pulloutQty > currentStock Then
            MessageBox.Show("You exceed the total number of stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            databaseConnection.cn.Close()
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to pull out this item?", "Confirm Pullout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim sqlInsert As String = "INSERT INTO tbl_pullouts (uniform_id, Date, Quantity, PulloutReason) VALUES (@uniform_id, @Date, @Quantity, @PulloutReason)"

            databaseConnection.cmd = New MySqlCommand(sqlInsert, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
            databaseConnection.cmd.Parameters.AddWithValue("@Date", lblDate.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
            databaseConnection.cmd.Parameters.AddWithValue("@PulloutReason", cboPulloutReason.Text)
            databaseConnection.cmd.ExecuteNonQuery()

            Dim sqlUpdate As String = "UPDATE tbluniforms SET stock_quantity = stock_quantity - @Quantity WHERE uniform_id = @uniform_id"

            databaseConnection.cmd = New MySqlCommand(sqlUpdate, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
            databaseConnection.cmd.ExecuteNonQuery()

            MessageBox.Show("Pullout recorded and stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            lblItemName.Text = ""
            lblDate.Text = ""
            txtQuantity.Clear()
            cboPulloutReason.Text = ""
        Else
            MessageBox.Show("Cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        databaseConnection.cn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDate.Clear()
        lblItemName.Clear()
        txtQuantity.Clear()
        cboPulloutReason.Text = ""
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayApplication(txtSearch.Text.Trim())
    End Sub
End Class