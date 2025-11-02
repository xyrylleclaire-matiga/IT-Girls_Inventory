Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class frmHistory
    'DESIGNNN ----------------------------------------
    Private Sub CustomizeListView()
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False
        ListView1.BackColor = Color.White
        ListView1.ForeColor = Color.Black
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

        'Using pen As New Pen(Color.FromArgb(0, 120, 110))
        '    e.Graphics.DrawRectangle(pen, New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1))
        'End Using

        TextRenderer.DrawText(e.Graphics, e.Header.Text, ListView1.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.SingleLine)
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        e.DrawDefault = True
    End Sub

    Private Sub btnPrint_Paint(sender As Object, e As PaintEventArgs) Handles btnPrint.Paint
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    End Sub

    Public Sub displayHistoryLogs(Optional searchQuery As String = "", Optional filterByDate As Boolean = False)
        Try
            databaseConnection.con()
            ListView1.BeginUpdate()
            ListView1.Items.Clear()

            Dim sql As String = "SELECT 
                                l.log_id,
                                l.uniform_id,
                                l.action_date,
                                l.action,
                                COALESCE(l.item_name, u.item_name) as item_name,
                                COALESCE(l.level, u.level) as level,
                                COALESCE(l.gender, u.gender) as gender,
                                COALESCE(l.size, u.size) as size,
                                l.changed_quantity,
                                l.previous_quantity,
                                l.new_quantity,
                                a.username,
                                l.Reason
                                FROM tbluniformlogs l
                                LEFT JOIN tbluniforms u ON l.uniform_id = u.uniform_id
                                LEFT JOIN tbladmin_users a ON l.admin_id = a.admin_id
                                WHERE 1=1"

            If filterByDate Then
                sql &= " AND DATE(l.action_date) = @selectedDate"
            End If

            If cboAction.SelectedItem IsNot Nothing AndAlso cboAction.SelectedItem.ToString() <> "All" Then
                sql &= " AND l.action = @action"
            End If

            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND (COALESCE(l.item_name, u.item_name) LIKE @search OR a.username LIKE @search OR l.action LIKE @search)"
            End If

            sql &= " ORDER BY l.action_date DESC"

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

            If filterByDate Then
                databaseConnection.cmd.Parameters.AddWithValue("@selectedDate", DateTimePicker1.Value.Date)
            End If

            If cboAction.SelectedItem IsNot Nothing AndAlso cboAction.SelectedItem.ToString() <> "All" Then
                databaseConnection.cmd.Parameters.AddWithValue("@action", cboAction.SelectedItem.ToString())
            End If

            If Not String.IsNullOrEmpty(searchQuery) Then
                databaseConnection.cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
            End If

            databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

            While databaseConnection.dr.Read()
                Dim item As New ListViewItem(databaseConnection.dr("log_id").ToString())
                item.UseItemStyleForSubItems = False

                item.SubItems.Add(databaseConnection.dr("action_date").ToString())

                Dim actionText As String = databaseConnection.dr("action").ToString()
                Dim actionSubItem As New ListViewItem.ListViewSubItem(item, actionText)

                Select Case actionText.ToLower()
                    Case "add item"
                        actionSubItem.ForeColor = Color.FromArgb(22, 163, 74)
                        actionSubItem.BackColor = Color.FromArgb(220, 252, 231)
                    Case "update item"
                        actionSubItem.ForeColor = Color.FromArgb(37, 99, 235)
                        actionSubItem.BackColor = Color.FromArgb(219, 234, 254)
                    Case "pullout"
                        actionSubItem.ForeColor = Color.FromArgb(234, 88, 12)
                        actionSubItem.BackColor = Color.FromArgb(254, 243, 199)
                    Case "delete item"
                        actionSubItem.ForeColor = Color.FromArgb(220, 38, 38)
                        actionSubItem.BackColor = Color.FromArgb(254, 226, 226)
                End Select

                item.SubItems.Add(actionSubItem)

                item.SubItems.Add(If(IsDBNull(databaseConnection.dr("item_name")), "N/A", databaseConnection.dr("item_name").ToString()))

                Dim details As String = ""
                If Not IsDBNull(databaseConnection.dr("level")) Then
                    details = databaseConnection.dr("level").ToString() & " / "
                End If
                If Not IsDBNull(databaseConnection.dr("gender")) Then
                    details &= databaseConnection.dr("gender").ToString() & " / "
                End If
                If Not IsDBNull(databaseConnection.dr("size")) Then
                    details &= databaseConnection.dr("size").ToString()
                End If
                item.SubItems.Add(details.TrimEnd(" /".ToCharArray()))

                Dim changedQty As String = databaseConnection.dr("changed_quantity").ToString()
                Dim changedQtySubItem As New ListViewItem.ListViewSubItem(item, changedQty)

                If changedQty.StartsWith("+") Then
                    changedQtySubItem.ForeColor = Color.Green
                    'changedQtySubItem.Font = New Font(ListView1.Font, FontStyle.Bold)
                ElseIf changedQty.StartsWith("-") Then
                    changedQtySubItem.ForeColor = Color.Red
                    'changedQtySubItem.Font = New Font(ListView1.Font, FontStyle.Bold)
                End If

                item.SubItems.Add(changedQtySubItem)

                Dim prevQty As String = databaseConnection.dr("previous_quantity").ToString()
                Dim newQty As String = databaseConnection.dr("new_quantity").ToString()
                item.SubItems.Add($"{prevQty} → {newQty}")

                item.SubItems.Add(If(IsDBNull(databaseConnection.dr("username")), "N/A", databaseConnection.dr("username").ToString()))

                item.SubItems.Add(If(IsDBNull(databaseConnection.dr("reason")), "", databaseConnection.dr("reason").ToString()))

                ListView1.Items.Add(item)
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ListView1.EndUpdate()
            If databaseConnection.dr IsNot Nothing Then databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        End Try
    End Sub

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.OwnerDraw = True
        displayHistoryLogs()
        CustomizeListView()
        countDisplay()
        lblTotalRecords.Text = ListView1.Items.Count.ToString()
    End Sub

    Private Sub cboAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAction.SelectedIndexChanged
        displayHistoryLogs(txtSearch.Text.Trim())
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        displayHistoryLogs(txtSearch.Text.Trim())
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        txtSearch.Clear()
    End Sub

    Private Sub countDisplay()
        databaseConnection.con()
        Dim queryAdd As String = "SELECT COUNT(*) FROM tbluniformlogs WHERE action = 'Add Item'"
        databaseConnection.cmd = New MySqlCommand(queryAdd, databaseConnection.cn)
        Dim countAdd As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblAdded.Text = countAdd.ToString()

        Dim queryUpdated As String = "SELECT COUNT(*) FROM tbluniformlogs WHERE action = 'Update Item'"
        databaseConnection.cmd = New MySqlCommand(queryUpdated, databaseConnection.cn)
        Dim countUpdated As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblUpdated.Text = countUpdated.ToString()

        Dim queryPullout As String = "SELECT COUNT(*) FROM tbluniformlogs WHERE action = 'Pullout'"
        databaseConnection.cmd = New MySqlCommand(queryPullout, databaseConnection.cn)
        Dim countPullout As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblPullout.Text = countPullout.ToString()

        Dim queryDeleted As String = "SELECT COUNT(*) FROM tbluniformlogs WHERE action = 'Delete Item'"
        databaseConnection.cmd = New MySqlCommand(queryDeleted, databaseConnection.cn)
        Dim countDeleted As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        lblDeleted.Text = countDeleted.ToString()


    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        preview()
    End Sub

    Private Sub preview()
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Please select a record to view", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
        Dim log_id As String = selectedItem.SubItems(0).Text
        Dim DateTime As String = selectedItem.SubItems(1).Text
        Dim Action As String = selectedItem.SubItems(2).Text
        Dim itemName As String = selectedItem.SubItems(3).Text
        Dim levGenSize As String = selectedItem.SubItems(4).Text
        Dim changedQuan As String = selectedItem.SubItems(5).Text
        Dim prevNew As String = selectedItem.SubItems(6).Text
        Dim admin As String = selectedItem.SubItems(7).Text
        Dim reason As String = selectedItem.SubItems(8).Text

        Dim uniformID As String = ""
        Dim adminID As String = ""

        Try
            databaseConnection.con()
            Dim sql As String = "SELECT l.uniform_id, l.admin_id 
                             FROM tbluniformlogs l 
                             WHERE l.log_id = @log_id"
            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@log_id", log_id)
            databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

            If databaseConnection.dr.Read() Then
                uniformID = If(IsDBNull(databaseConnection.dr("uniform_id")), "", databaseConnection.dr("uniform_id").ToString())
                adminID = If(IsDBNull(databaseConnection.dr("admin_id")), "", databaseConnection.dr("admin_id").ToString())
            End If

            databaseConnection.dr.Close()
            databaseConnection.cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Dim previewForm As New frmPrintPreview(log_id, itemName, DateTime, Action, levGenSize, changedQuan, prevNew, admin, reason, adminID, uniformID)

        previewForm.StartPosition = FormStartPosition.CenterParent
        If previewForm.ShowDialog(Me) = DialogResult.OK Then
            displayHistoryLogs()
            For Each item As ListViewItem In ListView1.Items
                If item.SubItems(0).Text = log_id Then
                    item.Selected = True
                    item.EnsureVisible()
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        displayHistoryLogs(txtSearch.Text.Trim(), True)
    End Sub
End Class