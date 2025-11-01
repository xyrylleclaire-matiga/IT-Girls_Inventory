Imports MySql.Data.MySqlClient

Public Class TotalPullouts

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
        Dim headerColor As Color = Color.FromArgb(0, 150, 136)
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

    '--------------------------------------

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
        savePullout()
    End Sub

    Private Sub savePullout()
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select an item from the list first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(lblDate.Text) OrElse
           String.IsNullOrWhiteSpace(cboPulloutReason.Text) OrElse
           String.IsNullOrWhiteSpace(lblItemName.Text) OrElse
           String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("Please fill out all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim pulloutQty As Integer
        If Not Integer.TryParse(txtQuantity.Text.Trim(), pulloutQty) Then
            MsgBox("Please enter a valid numeric quantity.", MsgBoxStyle.Exclamation)
            txtQuantity.Clear()
            txtQuantity.Focus()
            Exit Sub
        End If

        If pulloutQty <= 0 Then
            MsgBox("Quantity must be greater than 0.", MsgBoxStyle.Exclamation)
            txtQuantity.Clear()
            txtQuantity.Focus()
            Exit Sub
        End If

        If pulloutQty > 9999 Then
            MsgBox("Quantity is too high. Maximum is 9999.", MsgBoxStyle.Exclamation)
            txtQuantity.Clear()
            txtQuantity.Focus()
            Exit Sub
        End If

        Try
            databaseConnection.con()

            Dim sqlCheck As String = "SELECT stock_quantity FROM tbluniforms WHERE uniform_id = @uniform_id"
            databaseConnection.cmd = New MySqlCommand(sqlCheck, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)

            Dim resultObj = databaseConnection.cmd.ExecuteScalar()

            If resultObj Is Nothing OrElse IsDBNull(resultObj) Then
                MessageBox.Show("Item not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim currentStock As Integer = CInt(resultObj)

            If pulloutQty > currentStock Then
                MessageBox.Show($"Insufficient stock. Available: {currentStock}, Requested: {pulloutQty}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtQuantity.Clear()
                txtQuantity.Focus()
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to pull out {pulloutQty} item(s)?{vbCrLf}" &
            $"Item: {lblItemName.Text}{vbCrLf}" &
            $"Reason: {cboPulloutReason.Text}",
            "Confirm Pullout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim sqlInsert As String = "INSERT INTO tbl_pullouts (uniform_id, Date, Quantity, PulloutReason) VALUES (@uniform_id, @Date, @Quantity, @PulloutReason)"
                databaseConnection.cmd = New MySqlCommand(sqlInsert, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
                databaseConnection.cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
                databaseConnection.cmd.Parameters.AddWithValue("@PulloutReason", cboPulloutReason.Text.Trim())
                databaseConnection.cmd.ExecuteNonQuery()

                Dim sqlUpdate As String = "UPDATE tbluniforms SET stock_quantity = stock_quantity - @Quantity WHERE uniform_id = @uniform_id"
                databaseConnection.cmd = New MySqlCommand(sqlUpdate, databaseConnection.cn)
                databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
                databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
                Dim rowsAffected As Integer = databaseConnection.cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    If databaseConnection.currentAdminId > 0 AndAlso databaseConnection.isLoggedIn Then
                        Dim newStock As Integer = currentStock - pulloutQty
                        Dim changeStr As String = "-" & pulloutQty.ToString()

                        Dim logSql As String = "INSERT INTO tbluniformlogs(uniform_id, action, Reason, changed_quantity, previous_quantity, new_quantity, admin_id, action_date) VALUES (@uniform_id, @action, @reason, @quantity_change, @previous_qty, @new_qty, @admin_id, @action_date)"
                        databaseConnection.cmd = New MySqlCommand(logSql, databaseConnection.cn)
                        databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
                        databaseConnection.cmd.Parameters.AddWithValue("@action", "Pullout")
                        databaseConnection.cmd.Parameters.AddWithValue("@reason", cboPulloutReason.Text)
                        databaseConnection.cmd.Parameters.AddWithValue("@quantity_change", changeStr)  ' "-10"
                        databaseConnection.cmd.Parameters.AddWithValue("@previous_qty", currentStock)  ' 50
                        databaseConnection.cmd.Parameters.AddWithValue("@new_qty", newStock)  ' 40
                        databaseConnection.cmd.Parameters.AddWithValue("@admin_id", databaseConnection.currentAdminId)
                        databaseConnection.cmd.Parameters.AddWithValue("@action_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        databaseConnection.cmd.ExecuteNonQuery()
                    End If

                    MessageBox.Show("Pullout recorded and stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lblItemName.Text = ""
                    lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy")
                    txtQuantity.Clear()
                    cboPulloutReason.SelectedIndex = -1

                    displayApplication()

                    If Me.Owner IsNot Nothing Then
                        Dim parentForm As frmStockManagement = TryCast(Me.Owner, frmStockManagement)
                        If parentForm IsNot Nothing Then
                            parentForm.displayApplication()
                        End If
                    End If
                Else
                    MessageBox.Show("Failed to update stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Pullout cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Invalid data type encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If databaseConnection.cn IsNot Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
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