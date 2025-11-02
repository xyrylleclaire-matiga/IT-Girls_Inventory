Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient


Public Class frmHistory

    Private printDoc As New PrintDocument()
    Private itemsToPrint As List(Of ListViewItem)
    Private currentPage As Integer = 0
    Private rowsPerPage As Integer = 0

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

        TextRenderer.DrawText(e.Graphics, e.Header.Text, ListView1.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left Or TextFormatFlags.SingleLine)
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        e.DrawDefault = True
    End Sub

    'Private Sub btnPrint_Paint(sender As Object, e As PaintEventArgs) Handles btnPrint.Paint
    '    Dim btn As Button = DirectCast(sender, Button)
    '    Dim radius As Integer = 10

    '    Dim path As New Drawing2D.GraphicsPath()
    '    path.StartFigure()
    '    path.AddArc(0, 0, radius, radius, 180, 90)
    '    path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
    '    path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
    '    path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
    '    path.CloseFigure()

    '    btn.Region = New Region(path)
    'End Sub

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

            If rdoAdd.Checked Then
                sql &= " AND LOWER(TRIM(l.action)) = 'add item'"
            ElseIf rdoUpdate.Checked Then
                sql &= " AND LOWER(TRIM(l.action)) = 'update item'"
            ElseIf rdoPullout.Checked Then
                sql &= " AND LOWER(TRIM(l.action)) = 'pullout'"
            ElseIf rdoDelete.Checked Then
                sql &= " AND LOWER(TRIM(l.action)) = 'delete item'"
            End If

            If Not String.IsNullOrEmpty(searchQuery) Then
                sql &= " AND (COALESCE(l.item_name, u.item_name) LIKE @search OR a.username LIKE @search OR l.action LIKE @search)"
            End If

            sql &= " ORDER BY l.action_date DESC"

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

            If filterByDate Then
                databaseConnection.cmd.Parameters.AddWithValue("@selectedDate", dtDate.Value.Date)
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

                Select Case actionText.ToLower().Trim()
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

                Dim prevQty As String = databaseConnection.dr("previous_quantity").ToString()
                Dim newQty As String = databaseConnection.dr("new_quantity").ToString()

                Dim prevQtyInt As Integer = 0
                Integer.TryParse(prevQty, prevQtyInt)
                Dim newQtyInt As Integer = If(Integer.TryParse(newQty, Nothing), CInt(newQty), 0)
                Dim changedQtyInt As Integer = newQtyInt - prevQtyInt

                Dim changedQtyDisplay As String = If(changedQtyInt > 0, "+" & changedQtyInt.ToString(), changedQtyInt.ToString())
                Dim changedQtySubItem As New ListViewItem.ListViewSubItem(item, changedQtyDisplay)

                If changedQtyDisplay.StartsWith("+") Then
                    changedQtySubItem.ForeColor = Color.Green
                ElseIf changedQtyDisplay.StartsWith("-") Then
                    changedQtySubItem.ForeColor = Color.Red
                End If

                item.SubItems.Add(prevQty)
                item.SubItems.Add(changedQtySubItem)
                item.SubItems.Add(newQty)

                item.SubItems.Add(If(IsDBNull(databaseConnection.dr("username")), "N/A", databaseConnection.dr("username").ToString()))
                item.SubItems.Add(If(IsDBNull(databaseConnection.dr("reason")), "", databaseConnection.dr("reason").ToString()))

                ListView1.Items.Add(item)
            End While

            If lblTotalRecords IsNot Nothing Then
                lblTotalRecords.Text = ListView1.Items.Count.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ListView1.EndUpdate()
            If databaseConnection.dr IsNot Nothing AndAlso Not databaseConnection.dr.IsClosed Then
                databaseConnection.dr.Close()
            End If
            If databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.OwnerDraw = True
        displayHistoryLogs()
        rdoAllRecord.Checked = True
        CustomizeListView()
        countDisplay()
        lblTotalRecords.Text = ListView1.Items.Count.ToString()
        dtDate.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub rdoAllRecord_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllRecord.CheckedChanged
        If rdoAllRecord.Checked Then
            displayHistoryLogs()
        End If
    End Sub

    Private Sub rdoAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAdd.CheckedChanged
        If rdoAdd.Checked Then
            displayHistoryLogs()
        End If
    End Sub

    Private Sub rdoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUpdate.CheckedChanged
        If rdoUpdate.Checked Then
            displayHistoryLogs()
        End If
    End Sub

    Private Sub rdoPullout_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPullout.CheckedChanged
        If rdoPullout.Checked Then
            displayHistoryLogs()
        End If
    End Sub

    Private Sub rdoDelete_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDelete.CheckedChanged
        If rdoDelete.Checked Then
            displayHistoryLogs()
        End If
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
        Dim prevNew As String = selectedItem.SubItems(5).Text
        Dim changedQuan As String = selectedItem.SubItems(6).Text
        Dim newQuan As String = selectedItem.SubItems(7).Text
        Dim admin As String = selectedItem.SubItems(8).Text
        Dim reason As String = selectedItem.SubItems(9).Text


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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtDate.ValueChanged
        displayHistoryLogs("", True)
    End Sub



    'FOR PRINTINGGGGGGGGGGGGG --------------------------------------------
    ' -------------------------------------------------
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim result As DialogResult = MessageBox.Show(
    "Do you want to print ALL records?" & vbCrLf & vbCrLf &
    "YES - Print all records" & vbCrLf &
    "NO - Choose specific records/filters" & vbCrLf &
    "CANCEL - Cancel printing",
    "Print Options",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Yes
                PrintAllRecords()
            Case DialogResult.No
                ShowCustomPrintOptions()
            Case DialogResult.Cancel
        End Select
    End Sub

    Private Sub ShowCustomPrintOptions()
        Dim optionsForm As New Form()
        optionsForm.Text = "Custom Print Options"
        optionsForm.Size = New System.Drawing.Size(500, 400)
        optionsForm.StartPosition = FormStartPosition.CenterParent
        optionsForm.FormBorderStyle = FormBorderStyle.FixedDialog
        optionsForm.MaximizeBox = False
        optionsForm.MinimizeBox = False

        Dim lblTitle As New Label()
        lblTitle.Text = "Select what you want to print:"
        lblTitle.Location = New System.Drawing.Point(20, 20)
        lblTitle.Size = New System.Drawing.Size(450, 25)
        lblTitle.Font = New System.Drawing.Font("Arial", 11, FontStyle.Bold)

        Dim rdoPrintByAction As New RadioButton()
        rdoPrintByAction.Text = "Print by Action Type (Add, Update, Pullout, Delete)"
        rdoPrintByAction.Location = New System.Drawing.Point(30, 60)
        rdoPrintByAction.Size = New System.Drawing.Size(440, 25)
        rdoPrintByAction.Checked = True
        rdoPrintByAction.Font = New System.Drawing.Font("Arial", 10)

        Dim rdoPrintByIds As New RadioButton()
        rdoPrintByIds.Text = "Print by specific Log IDs"
        rdoPrintByIds.Location = New System.Drawing.Point(30, 90)
        rdoPrintByIds.Size = New System.Drawing.Size(440, 25)
        rdoPrintByIds.Font = New System.Drawing.Font("Arial", 10)

        Dim rdoPrintByDateRange As New RadioButton()
        rdoPrintByDateRange.Text = "Print by Date Range"
        rdoPrintByDateRange.Location = New System.Drawing.Point(30, 120)
        rdoPrintByDateRange.Size = New System.Drawing.Size(440, 25)
        rdoPrintByDateRange.Font = New System.Drawing.Font("Arial", 10)

        Dim pnlActionType As New Panel()
        pnlActionType.Location = New System.Drawing.Point(50, 155)
        pnlActionType.Size = New System.Drawing.Size(420, 120)
        pnlActionType.BorderStyle = BorderStyle.FixedSingle

        Dim lblActionType As New Label()
        lblActionType.Text = "Select Action Type:"
        lblActionType.Location = New System.Drawing.Point(10, 10)
        lblActionType.Size = New System.Drawing.Size(200, 20)
        lblActionType.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold)

        Dim chkAdd As New CheckBox()
        chkAdd.Text = "Add Items"
        chkAdd.Location = New System.Drawing.Point(20, 35)
        chkAdd.Size = New System.Drawing.Size(180, 20)
        chkAdd.Checked = True

        Dim chkUpdate As New CheckBox()
        chkUpdate.Text = "Update Items"
        chkUpdate.Location = New System.Drawing.Point(20, 60)
        chkUpdate.Size = New System.Drawing.Size(180, 20)
        chkUpdate.Checked = True

        Dim chkPullout As New CheckBox()
        chkPullout.Text = "Pullout"
        chkPullout.Location = New System.Drawing.Point(220, 35)
        chkPullout.Size = New System.Drawing.Size(180, 20)
        chkPullout.Checked = True

        Dim chkDelete As New CheckBox()
        chkDelete.Text = "Delete Items"
        chkDelete.Location = New System.Drawing.Point(220, 60)
        chkDelete.Size = New System.Drawing.Size(180, 20)
        chkDelete.Checked = True

        pnlActionType.Controls.AddRange({lblActionType, chkAdd, chkUpdate, chkPullout, chkDelete})

        Dim pnlLogIds As New Panel()
        pnlLogIds.Location = New System.Drawing.Point(50, 155)
        pnlLogIds.Size = New System.Drawing.Size(420, 120)
        pnlLogIds.BorderStyle = BorderStyle.FixedSingle
        pnlLogIds.Visible = False

        Dim lblLogIds As New Label()
        lblLogIds.Text = "Enter Log IDs (comma-separated):"
        lblLogIds.Location = New System.Drawing.Point(10, 10)
        lblLogIds.Size = New System.Drawing.Size(400, 20)
        lblLogIds.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold)

        Dim txtLogIds As New TextBox()
        txtLogIds.Location = New System.Drawing.Point(10, 35)
        txtLogIds.Size = New System.Drawing.Size(400, 25)
        txtLogIds.Font = New System.Drawing.Font("Arial", 10)

        Dim lblAvailableIds As New Label()
        lblAvailableIds.Text = "Available: " & GetAvailableLogIds()
        lblAvailableIds.Location = New System.Drawing.Point(10, 70)
        lblAvailableIds.Size = New System.Drawing.Size(400, 40)
        lblAvailableIds.Font = New System.Drawing.Font("Arial", 8)
        lblAvailableIds.ForeColor = Color.Gray

        pnlLogIds.Controls.AddRange({lblLogIds, txtLogIds, lblAvailableIds})

        Dim pnlDateRange As New Panel()
        pnlDateRange.Location = New System.Drawing.Point(50, 155)
        pnlDateRange.Size = New System.Drawing.Size(420, 120)
        pnlDateRange.BorderStyle = BorderStyle.FixedSingle
        pnlDateRange.Visible = False

        Dim lblDateFrom As New Label()
        lblDateFrom.Text = "From Date:"
        lblDateFrom.Location = New System.Drawing.Point(10, 15)
        lblDateFrom.Size = New System.Drawing.Size(80, 20)

        Dim dtpFrom As New DateTimePicker()
        dtpFrom.Location = New System.Drawing.Point(100, 12)
        dtpFrom.Size = New System.Drawing.Size(300, 25)
        dtpFrom.Format = DateTimePickerFormat.Short

        Dim lblDateTo As New Label()
        lblDateTo.Text = "To Date:"
        lblDateTo.Location = New System.Drawing.Point(10, 50)
        lblDateTo.Size = New System.Drawing.Size(80, 20)

        Dim dtpTo As New DateTimePicker()
        dtpTo.Location = New System.Drawing.Point(100, 47)
        dtpTo.Size = New System.Drawing.Size(300, 25)
        dtpTo.Format = DateTimePickerFormat.Short

        pnlDateRange.Controls.AddRange({lblDateFrom, dtpFrom, lblDateTo, dtpTo})

        AddHandler rdoPrintByAction.CheckedChanged, Sub(s, ev)
                                                        pnlActionType.Visible = rdoPrintByAction.Checked
                                                        pnlLogIds.Visible = False
                                                        pnlDateRange.Visible = False
                                                    End Sub

        AddHandler rdoPrintByIds.CheckedChanged, Sub(s, ev)
                                                     pnlActionType.Visible = False
                                                     pnlLogIds.Visible = rdoPrintByIds.Checked
                                                     pnlDateRange.Visible = False
                                                 End Sub

        AddHandler rdoPrintByDateRange.CheckedChanged, Sub(s, ev)
                                                           pnlActionType.Visible = False
                                                           pnlLogIds.Visible = False
                                                           pnlDateRange.Visible = rdoPrintByDateRange.Checked
                                                       End Sub

        Dim btnPrint As New Button()
        btnPrint.Text = "Print"
        btnPrint.Location = New System.Drawing.Point(290, 310)
        btnPrint.Size = New System.Drawing.Size(90, 35)
        btnPrint.DialogResult = DialogResult.OK

        Dim btnCancel As New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Location = New System.Drawing.Point(390, 310)
        btnCancel.Size = New System.Drawing.Size(90, 35)
        btnCancel.DialogResult = DialogResult.Cancel

        optionsForm.Controls.AddRange({lblTitle, rdoPrintByAction, rdoPrintByIds, rdoPrintByDateRange,
                                   pnlActionType, pnlLogIds, pnlDateRange, btnPrint, btnCancel})

        optionsForm.AcceptButton = btnPrint
        optionsForm.CancelButton = btnCancel

        If optionsForm.ShowDialog() = DialogResult.OK Then
            If rdoPrintByAction.Checked Then
                PrintByActionType(chkAdd.Checked, chkUpdate.Checked, chkPullout.Checked, chkDelete.Checked)
            ElseIf rdoPrintByIds.Checked Then
                PrintByLogIds(txtLogIds.Text.Trim())
            ElseIf rdoPrintByDateRange.Checked Then
                PrintByDateRange(dtpFrom.Value, dtpTo.Value)
            End If
        End If
    End Sub

    Private Sub PrintByActionType(includeAdd As Boolean, includeUpdate As Boolean, includePullout As Boolean, includeDelete As Boolean)
        Try
            If Not (includeAdd Or includeUpdate Or includePullout Or includeDelete) Then
                MessageBox.Show("Please select at least one action type!", "Invalid Selection",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            itemsToPrint = New List(Of ListViewItem)

            For Each item As ListViewItem In ListView1.Items
                Dim action As String = item.SubItems(2).Text.ToLower().Trim()

                Dim shouldInclude As Boolean = False
                If includeAdd AndAlso action = "add item" Then shouldInclude = True
                If includeUpdate AndAlso action = "update item" Then shouldInclude = True
                If includePullout AndAlso action = "pullout" Then shouldInclude = True
                If includeDelete AndAlso action = "delete item" Then shouldInclude = True

                If shouldInclude Then
                    itemsToPrint.Add(item)
                End If
            Next

            If itemsToPrint.Count = 0 Then
                MessageBox.Show("No records found matching the selected action types!", "No Records",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ShowPrintPreview()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintByLogIds(logIdsInput As String)
        Try
            If String.IsNullOrEmpty(logIdsInput) Then
                MessageBox.Show("Please enter at least one Log ID!", "Invalid Input",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim logIds As New List(Of String)
            Dim invalidIds As New List(Of String)

            For Each id As String In logIdsInput.Split(","c)
                Dim trimmedId As String = id.Trim()
                If Not String.IsNullOrEmpty(trimmedId) Then
                    Dim found As Boolean = False
                    For Each item As ListViewItem In ListView1.Items
                        If item.SubItems(0).Text = trimmedId Then
                            found = True
                            Exit For
                        End If
                    Next

                    If found Then
                        logIds.Add(trimmedId)
                    Else
                        invalidIds.Add(trimmedId)
                    End If
                End If
            Next

            If invalidIds.Count > 0 Then
                Dim warningMsg As String = "The following Log IDs were not found:" & vbCrLf &
                                  String.Join(", ", invalidIds)
                MessageBox.Show(warningMsg, "Invalid Log IDs", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If logIds.Count = 0 Then
                MessageBox.Show("No valid Log IDs to print!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            itemsToPrint = New List(Of ListViewItem)
            For Each logId As String In logIds
                For Each item As ListViewItem In ListView1.Items
                    If item.SubItems(0).Text = logId Then
                        itemsToPrint.Add(item)
                        Exit For
                    End If
                Next
            Next

            ShowPrintPreview()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintByDateRange(dateFrom As Date, dateTo As Date)
        Try
            If dateFrom > dateTo Then
                MessageBox.Show("'From Date' cannot be later than 'To Date'!", "Invalid Date Range",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            itemsToPrint = New List(Of ListViewItem)

            For Each item As ListViewItem In ListView1.Items
                Dim dateText As String = item.SubItems(1).Text
                Dim itemDate As Date

                If Date.TryParse(dateText, itemDate) Then
                    If itemDate.Date >= dateFrom.Date AndAlso itemDate.Date <= dateTo.Date Then
                        itemsToPrint.Add(item)
                    End If
                End If
            Next

            If itemsToPrint.Count = 0 Then
                MessageBox.Show("No records found in the selected date range!", "No Records",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ShowPrintPreview()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetAvailableLogIds() As String
        Dim logIds As New List(Of String)

        Dim count As Integer = 0
        For Each item As ListViewItem In ListView1.Items
            If count >= 10 Then Exit For
            logIds.Add(item.SubItems(0).Text)
            count += 1
        Next

        Dim result As String = String.Join(", ", logIds)
        If ListView1.Items.Count > 10 Then
            result &= "..."
        End If

        Return result
    End Function

    Private Sub PrintAllRecords()
        Try
            If ListView1.Items.Count = 0 Then
                MessageBox.Show("No records to print!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            itemsToPrint = New List(Of ListViewItem)
            For Each item As ListViewItem In ListView1.Items
                itemsToPrint.Add(item)
            Next

            ShowPrintPreview()

        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowPrintPreview()
        currentPage = 0
        rowsPerPage = 0

        printDoc.DefaultPageSettings.Landscape = True

        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

        Dim previewDialog As New PrintPreviewDialog()
        previewDialog.Document = printDoc
        previewDialog.Width = 1000
        previewDialog.Height = 700
        previewDialog.StartPosition = FormStartPosition.CenterParent

        previewDialog.ShowDialog()

        RemoveHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub


    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            Dim startX As Integer = 50
            Dim startY As Integer = 50
            Dim offsetY As Integer = 0

            Dim titleFont As New System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold)
            Dim headerFont As New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
            Dim cellFont As New System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular)
            Dim dateFont As New System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Italic)

            Dim title As String = "Uniform History Report"
            Dim titleSize As System.Drawing.SizeF = e.Graphics.MeasureString(title, titleFont)
            e.Graphics.DrawString(title, titleFont, System.Drawing.Brushes.Black,
                            CSng((e.PageBounds.Width - titleSize.Width) / 2), CSng(startY))
            offsetY += CInt(titleSize.Height) + 10

            Dim dateGenerated As String = "Generated: " & DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt")
            e.Graphics.DrawString(dateGenerated, dateFont, System.Drawing.Brushes.Gray,
                            CSng(startX), CSng(startY + offsetY))
            offsetY += 30

            Dim headers() As String = {"ID", "Date/Time", "Action", "Item", "Details",
                                   "Prev", "Changed", "New", "Admin", "Reason"}
            Dim columnWidths() As Integer = {40, 120, 80, 100, 120, 50, 60, 50, 80, 100}

            Dim headerRect As New System.Drawing.Rectangle(startX, startY + offsetY, 800, 25)
            e.Graphics.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 150, 136)), headerRect)

            Dim xPos As Integer = startX
            For i As Integer = 0 To headers.Length - 1
                e.Graphics.DrawString(headers(i), headerFont, System.Drawing.Brushes.White,
                                CSng(xPos + 5), CSng(startY + offsetY + 5))

                e.Graphics.DrawLine(System.Drawing.Pens.White, xPos, startY + offsetY,
                              xPos, startY + offsetY + 25)
                xPos += columnWidths(i)
            Next
            offsetY += 30

            If rowsPerPage = 0 Then
                Dim availableHeight As Integer = e.PageBounds.Height - startY - offsetY - 50
                rowsPerPage = availableHeight \ 20
            End If

            Dim startIndex As Integer = currentPage * rowsPerPage
            Dim endIndex As Integer = Math.Min(startIndex + rowsPerPage, itemsToPrint.Count)

            For idx As Integer = startIndex To endIndex - 1
                Dim item As ListViewItem = itemsToPrint(idx)
                xPos = startX

                If idx Mod 2 = 0 Then
                    Dim rowRect As New System.Drawing.Rectangle(startX, startY + offsetY, 800, 20)
                    e.Graphics.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(240, 240, 240)), rowRect)
                End If

                For i As Integer = 0 To 9
                    Dim cellText As String = If(i < item.SubItems.Count, item.SubItems(i).Text, "")
                    Dim textBrush As System.Drawing.Brush = System.Drawing.Brushes.Black

                    If i = 6 Then
                        If cellText.StartsWith("+") Then
                            textBrush = System.Drawing.Brushes.Green
                        ElseIf cellText.StartsWith("-") Then
                            textBrush = System.Drawing.Brushes.Red
                        End If
                    End If

                    If cellText.Length > 15 Then
                        cellText = cellText.Substring(0, 12) & "..."
                    End If

                    e.Graphics.DrawString(cellText, cellFont, textBrush,
                                    CSng(xPos + 5), CSng(startY + offsetY + 2))
                    xPos += columnWidths(i)
                Next

                offsetY += 20
            Next

            Dim pageNumber As String = $"Page {currentPage + 1}"
            Dim pageNumSize As System.Drawing.SizeF = e.Graphics.MeasureString(pageNumber, dateFont)
            e.Graphics.DrawString(pageNumber, dateFont, System.Drawing.Brushes.Gray,
                            CSng((e.PageBounds.Width - pageNumSize.Width) / 2),
                            CSng(e.PageBounds.Height - 40))

            currentPage += 1
            e.HasMorePages = (endIndex < itemsToPrint.Count)

            If Not e.HasMorePages Then
                currentPage = 0
                rowsPerPage = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error during printing: " & ex.Message, "Print Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.HasMorePages = False
        End Try
    End Sub

    Private Sub chkFilterByDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByDate.CheckedChanged
        If chkFilterByDate.Checked Then
            displayHistoryLogs("", True)
        Else
            displayHistoryLogs()
        End If
    End Sub
End Class