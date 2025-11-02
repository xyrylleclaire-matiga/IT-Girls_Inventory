Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmSalesReport

    Private WithEvents printDoc As New PrintDocument()
    Private printPreview As New PrintPreviewDialog()
    Private printFont As New Font("Segoe UI", 9)
    Private printHeaderFont As New Font("Segoe UI", 10, FontStyle.Bold)
    Private currentPrintRow As Integer = 0
    Private printTitleFont As New Font("Segoe UI", 16, FontStyle.Bold)
    Private printData As New List(Of ListViewItem)
    Private printSmallFont As New Font("Arial", 9)
    Private currentPage As Integer = 1
    Private isFirstPage As Boolean = True


    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeListView()
        ListView2.OwnerDraw = True
        SetupListView()
        LoadSummaryReport(False) ' Default load (no filter)
        FromDateTimePicker.Format = DateTimePickerFormat.Custom
        FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
    End Sub

    ' === SETUP NG LISTVIEW ===
    Private Sub SetupListView()
        With ListView2.Columns
            .Clear()
            .Add("Category", 150)
            .Add("Size", 100)
            .Add("Gender", 100)
            .Add("Total Items", 100)
            .Add("Critical Level", 100)
            .Add("Pulled Out", 100)
            .Add("Last Updated", 150)
        End With
        ListView2.View = View.Details
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
    End Sub

    ' === LOAD SUMMARY REPORT (Main Loader) ===
    Private Sub LoadSummaryReport(Optional filterByDate As Boolean = False)
        ListView2.Items.Clear()
        chart1.Series.Clear()
        chart1.Titles.Clear()

        Try
            databaseConnection.con()

            Dim sql As String = "
                SELECT category, size, gender,
                       SUM(stock_quantity) AS totalItems,
                       COUNT(CASE WHEN stock_quantity < 10 THEN 1 END) AS criticalLevel,
                       (SELECT IFNULL(SUM(p.Quantity), 0)
                        FROM tbl_pullouts p
                        INNER JOIN tbluniforms u2 ON p.uniform_id = u2.uniform_id
                        WHERE u2.category = u.category AND u2.size = u.size AND u2.gender = u.gender) AS pulled,
                       MAX(date_updated) AS lastUpdated
                FROM tbluniforms u
                WHERE gender IS NOT NULL AND gender <> ''"

            ' === Date filter ===
            If filterByDate Then
                sql &= " AND DATE(date_updated) = @selectedDate"
            End If

            ' === Category filters ===
            If rdoUniform.Checked Then
                sql &= " AND category='School Uniform'"
            ElseIf rdoPE.Checked Then
                sql &= " AND category='PE Uniform'"
            ElseIf rdoCorporateAttire.Checked Then
                sql &= " AND category='Corporate Attire'"
            End If

            sql &= " GROUP BY category, size, gender ORDER BY category, size, gender;"

            Using cmd As New MySqlCommand(sql, databaseConnection.cn)
                If filterByDate Then
                    cmd.Parameters.AddWithValue("@selectedDate", FromDateTimePicker.Value.Date)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("category").ToString())
                        item.SubItems.Add(reader("size").ToString())
                        item.SubItems.Add(reader("gender").ToString())
                        item.SubItems.Add(reader("totalItems").ToString())
                        item.SubItems.Add(reader("criticalLevel").ToString())
                        item.SubItems.Add(reader("pulled").ToString())
                        item.SubItems.Add(
                            If(IsDBNull(reader("lastUpdated")), "—",
                            Convert.ToDateTime(reader("lastUpdated")).ToString("yyyy-MM-dd HH:mm:ss"))
                        )
                        ListView2.Items.Add(item)
                    End While
                End Using
            End Using

            LoadChart()

        Catch ex As Exception
            MsgBox("Error loading summary report: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            databaseConnection.cn.Close()
        End Try
    End Sub

    ' === LOAD CHART ===
    Private Sub LoadChart()
        chart1.Series.Clear()
        chart1.Titles.Clear()
        chart1.ChartAreas(0).AxisX.CustomLabels.Clear()

        ' === Series setup ===
        Dim series As New Series("Stock Quantity")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True
        series("PointWidth") = "0.4" ' Para magkahiwalay ang mga bars

        ' === Chart area visual setup ===
        With chart1.ChartAreas(0)
            .AxisX.Interval = 1
            .AxisX.Title = "Category"
            .AxisY.Title = "Quantity"
            .AxisX.LabelStyle.Angle = 0 ' Straight labels
            .AxisX.LabelStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .AxisY.LabelStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .AxisY.MajorGrid.LineColor = Color.LightGray
            .AxisX.MajorGrid.Enabled = False
            .Area3DStyle.Enable3D = False
            .BackColor = Color.WhiteSmoke
        End With

        chart1.BackColor = Color.White

        ' === Data containers ===
        Dim categoryTotals As New Dictionary(Of String, Integer)
        Dim pulledTotal As Integer = 0

        ' === Read ListView data ===
        For Each item As ListViewItem In ListView2.Items
            Dim category As String = item.SubItems(0).Text
            Dim totalItems As Integer = Convert.ToInt32(item.SubItems(3).Text)
            Dim pulled As Integer = Convert.ToInt32(item.SubItems(5).Text)

            pulledTotal += pulled

            If categoryTotals.ContainsKey(category) Then
                categoryTotals(category) += totalItems
            Else
                categoryTotals.Add(category, totalItems)
            End If
        Next

        ' === Add data points ===
        If rdoAllCategory.Checked Then
            Dim allTotal As Integer = categoryTotals.Values.Sum()
            Dim peTotal As Integer = If(categoryTotals.ContainsKey("PE Uniform"), categoryTotals("PE Uniform"), 0)
            Dim schoolTotal As Integer = If(categoryTotals.ContainsKey("School Uniform"), categoryTotals("School Uniform"), 0)
            Dim corpTotal As Integer = If(categoryTotals.ContainsKey("Corporate Attire"), categoryTotals("Corporate Attire"), 0)

            series.Points.AddXY("All Category", allTotal)
            series.Points.AddXY("PE Uniform", peTotal)
            series.Points.AddXY("School Uniform", schoolTotal)
            series.Points.AddXY("Corporate Attire", corpTotal)
            series.Points.AddXY("Pulled", pulledTotal)
        Else
            For Each kvp In categoryTotals
                series.Points.AddXY(kvp.Key, kvp.Value)
            Next
            series.Points.AddXY("Pulled", pulledTotal)
        End If

        ' === Bar color styling ===
        series.Color = Color.SeaGreen
        series.BorderWidth = 1
        series.BorderColor = Color.DarkGreen

        ' === Add and finalize chart ===
        chart1.Series.Add(series)
        chart1.Titles.Add("Uniform Stock Summary")
        chart1.Titles(0).Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub




    ' === SEARCH FUNCTION ===
    Private Sub SearchUniforms(keyword As String)
        ListView2.Items.Clear()
        chart1.Series.Clear()
        chart1.Titles.Clear()

        Try
            databaseConnection.con()

            Dim sql As String = "
                SELECT category, size, gender,
                       SUM(stock_quantity) AS totalItems,
                       COUNT(CASE WHEN stock_quantity < 10 THEN 1 END) AS criticalLevel,
                       (SELECT IFNULL(SUM(p.Quantity), 0)
                        FROM tbl_pullouts p
                        INNER JOIN tbluniforms u2 ON p.uniform_id = u2.uniform_id
                        WHERE u2.category = u.category AND u2.size = u.size AND u2.gender = u.gender) AS pulled,
                       MAX(date_updated) AS lastUpdated
                FROM tbluniforms u
                WHERE (category LIKE @keyword OR size LIKE @keyword OR gender LIKE @keyword)
                      AND gender IS NOT NULL AND gender <> ''"

            ' Retain category filters
            If rdoUniform.Checked Then
                sql &= " AND category='School Uniform'"
            ElseIf rdoPE.Checked Then
                sql &= " AND category='PE Uniform'"
            ElseIf rdoCorporateAttire.Checked Then
                sql &= " AND category='Corporate Attire'"
            End If

            sql &= " GROUP BY category, size, gender ORDER BY category, size, gender;"

            Using cmd As New MySqlCommand(sql, databaseConnection.cn)
                cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("category").ToString())
                        item.SubItems.Add(reader("size").ToString())
                        item.SubItems.Add(reader("gender").ToString())
                        item.SubItems.Add(reader("totalItems").ToString())
                        item.SubItems.Add(reader("criticalLevel").ToString())
                        item.SubItems.Add(reader("pulled").ToString())
                        item.SubItems.Add(
                            If(IsDBNull(reader("lastUpdated")), "—",
                            Convert.ToDateTime(reader("lastUpdated")).ToString("yyyy-MM-dd HH:mm:ss"))
                        )
                        ListView2.Items.Add(item)
                    End While
                End Using
            End Using

            LoadChart()

        Catch ex As Exception
            MsgBox("Error searching uniforms: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            databaseConnection.cn.Close()
        End Try
    End Sub

    ' === HANDLE RADIO BUTTONS ===
    Private Sub rdoUniform_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUniform.CheckedChanged, rdoPE.CheckedChanged, rdoCorporateAttire.CheckedChanged, rdoAllCategory.CheckedChanged
        LoadSummaryReport(False)
    End Sub

    ' === HANDLE DATE FILTER ===
    Private Sub FromDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FromDateTimePicker.ValueChanged
        LoadSummaryReport(True)
        FromDateTimePicker.Format = DateTimePickerFormat.Custom
        FromDateTimePicker.CustomFormat = "dd MMM yyyy"

    End Sub

    ' === HANDLE SEARCH TEXTBOX ===
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim().Length >= 1 Then
            SearchUniforms(txtSearch.Text.Trim())
        Else
            LoadSummaryReport(False)
        End If
    End Sub

    ' === EXPORT/PRINT BUTTON CLICK ===
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Check if there are records
        If ListView2.Items.Count = 0 Then
            MsgBox("No records to print.", MsgBoxStyle.Information, "Print Report")
            Exit Sub
        End If

        ' Create simple custom dialog
        Dim printDialog As New Form()
        printDialog.Text = "Print Options"
        printDialog.Size = New Size(400, 220)
        printDialog.StartPosition = FormStartPosition.CenterParent
        printDialog.FormBorderStyle = FormBorderStyle.FixedDialog
        printDialog.MaximizeBox = False
        printDialog.MinimizeBox = False

        ' Label
        Dim lblInfo As New Label()
        lblInfo.Text = $"Current display shows {ListView2.Items.Count} record(s)." & vbCrLf & "What would you like to print?"
        lblInfo.Location = New Point(20, 20)
        lblInfo.Size = New Size(350, 40)
        lblInfo.Font = New Font("Segoe UI", 9)
        printDialog.Controls.Add(lblInfo)

        ' Radio button 1
        Dim rdoDisplayed As New RadioButton()
        rdoDisplayed.Text = $"Print displayed records only ({ListView2.Items.Count} records)"
        rdoDisplayed.Location = New Point(30, 70)
        rdoDisplayed.Size = New Size(330, 25)
        rdoDisplayed.Checked = True
        rdoDisplayed.Font = New Font("Segoe UI", 9)
        printDialog.Controls.Add(rdoDisplayed)

        ' Radio button 2
        Dim rdoAll As New RadioButton()
        rdoAll.Text = "Print ALL records from database (ignore filters)"
        rdoAll.Location = New Point(30, 100)
        rdoAll.Size = New Size(330, 25)
        rdoAll.Font = New Font("Segoe UI", 9)
        printDialog.Controls.Add(rdoAll)

        ' Print button
        Dim btnPrint As New Button()
        btnPrint.Text = "Print"
        btnPrint.Size = New Size(80, 35)
        btnPrint.Location = New Point(210, 140)
        btnPrint.BackColor = Color.SeaGreen
        btnPrint.ForeColor = Color.White
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.DialogResult = DialogResult.OK
        printDialog.Controls.Add(btnPrint)

        ' Cancel button
        Dim btnCancel As New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Size = New Size(80, 35)
        btnCancel.Location = New Point(295, 140)
        btnCancel.DialogResult = DialogResult.Cancel
        printDialog.Controls.Add(btnCancel)

        printDialog.AcceptButton = btnPrint
        printDialog.CancelButton = btnCancel

        ' Show dialog
        If printDialog.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        ' Prepare data based on selection
        printData.Clear()

        If rdoDisplayed.Checked Then
            ' Print displayed only
            For Each item As ListViewItem In ListView2.Items
                printData.Add(CType(item.Clone(), ListViewItem))
            Next
        Else
            ' Print all
            LoadAllRecordsForPrint()
        End If

        If printData.Count = 0 Then
            MsgBox("No records to print.", MsgBoxStyle.Information)
            Exit Sub
        End If

        ' Setup and show print preview
        printDoc.DefaultPageSettings.Landscape = True
        currentPrintRow = 0
        currentPage = 1
        isFirstPage = True

        Try
            printPreview.Document = printDoc
            printPreview.Width = 1000
            printPreview.Height = 700
            printPreview.ShowDialog()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' === LOAD ALL RECORDS (No filters) ===
    Private Sub LoadAllRecordsForPrint()
        Try
            databaseConnection.con()

            Dim sql As String = "
            SELECT category, size, gender,
                   SUM(stock_quantity) AS totalItems,
                   COUNT(CASE WHEN stock_quantity < 10 THEN 1 END) AS criticalLevel,
                   (SELECT IFNULL(SUM(p.Quantity), 0)
                    FROM tbl_pullouts p
                    INNER JOIN tbluniforms u2 ON p.uniform_id = u2.uniform_id
                    WHERE u2.category = u.category AND u2.size = u.size AND u2.gender = u.gender) AS pulled,
                   MAX(date_updated) AS lastUpdated
            FROM tbluniforms u
            WHERE gender IS NOT NULL AND gender <> ''
            GROUP BY category, size, gender 
            ORDER BY category, size, gender;"

            Using cmd As New MySqlCommand(sql, databaseConnection.cn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("category").ToString())
                        item.SubItems.Add(reader("size").ToString())
                        item.SubItems.Add(reader("gender").ToString())
                        item.SubItems.Add(reader("totalItems").ToString())
                        item.SubItems.Add(reader("criticalLevel").ToString())
                        item.SubItems.Add(reader("pulled").ToString())
                        item.SubItems.Add(
                            If(IsDBNull(reader("lastUpdated")), "—",
                            Convert.ToDateTime(reader("lastUpdated")).ToString("yyyy-MM-dd HH:mm:ss"))
                        )
                        printData.Add(item)
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error loading records for print: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            databaseConnection.cn.Close()
        End Try
    End Sub

    ' === GET CURRENT FILTER STATE ===
    Private Function GetCurrentFilterState() As String
        Dim filterText As String = ""

        ' Category filter
        If rdoUniform.Checked Then
            filterText &= "Category: School Uniform"
        ElseIf rdoPE.Checked Then
            filterText &= "Category: PE Uniform"
        ElseIf rdoCorporateAttire.Checked Then
            filterText &= "Category: Corporate Attire"
        Else
            filterText &= "Category: All"
        End If

        ' Date filter
        If FromDateTimePicker.CustomFormat <> "MM/dd/yyyy" Then
            filterText &= " | Date: " & FromDateTimePicker.Value.ToString("MMM dd, yyyy")
        End If

        ' Search filter
        If txtSearch.Text.Trim().Length > 0 Then
            filterText &= " | Search: " & txtSearch.Text.Trim()
        End If

        Return filterText
    End Function

    ' === PRINT DOCUMENT PAGE HANDLER ===
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim yPos As Integer = 60
        Dim leftMargin As Integer = 40
        Dim rightMargin As Integer = e.PageBounds.Width - 40
        Dim lineHeight As Integer = 30
        Dim headerHeight As Integer = 35

        ' === HEADER SECTION ===
        ' Title
        Dim titleSize As SizeF = e.Graphics.MeasureString("Uniform Inventory Report", printTitleFont)
        Dim titleX As Integer = CInt((e.PageBounds.Width - titleSize.Width) / 2)
        e.Graphics.DrawString("Uniform Inventory Report",
                             printTitleFont,
                             Brushes.Black, titleX, yPos)
        yPos += 45

        ' Generated date/time
        e.Graphics.DrawString("Generated: " & DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                             printSmallFont, Brushes.Gray, leftMargin, yPos)
        yPos += 25

        ' Filters info
        Dim filterInfo As String = GetCurrentFilterState()
        If printData.Count = ListView2.Items.Count AndAlso Not String.IsNullOrEmpty(filterInfo) Then
            e.Graphics.DrawString("Filters Applied: " & filterInfo,
                                 printSmallFont, Brushes.Gray, leftMargin, yPos)
        Else
            e.Graphics.DrawString("Showing: All Records",
                                 printSmallFont, Brushes.Gray, leftMargin, yPos)
        End If
        yPos += 30

        ' Separator line
        e.Graphics.DrawLine(New Pen(Color.Black, 2), leftMargin, yPos, rightMargin, yPos)
        yPos += 25

        ' === TABLE HEADER WITH BORDERS ===
        Dim col1 As Integer = leftMargin
        Dim col2 As Integer = leftMargin + 130
        Dim col3 As Integer = leftMargin + 210
        Dim col4 As Integer = leftMargin + 280
        Dim col5 As Integer = leftMargin + 350
        Dim col6 As Integer = leftMargin + 450
        Dim col7 As Integer = leftMargin + 520
        Dim col8 As Integer = leftMargin + 630

        Dim headerY As Integer = yPos

        ' Draw header background
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(41, 128, 185)),
                                leftMargin, headerY, rightMargin - leftMargin, headerHeight)

        ' Draw header borders
        e.Graphics.DrawRectangle(New Pen(Color.Black, 1),
                                leftMargin, headerY, rightMargin - leftMargin, headerHeight)

        ' Vertical lines for header
        e.Graphics.DrawLine(Pens.Black, col2, headerY, col2, headerY + headerHeight)
        e.Graphics.DrawLine(Pens.Black, col3, headerY, col3, headerY + headerHeight)
        e.Graphics.DrawLine(Pens.Black, col4, headerY, col4, headerY + headerHeight)
        e.Graphics.DrawLine(Pens.Black, col5, headerY, col5, headerY + headerHeight)
        e.Graphics.DrawLine(Pens.Black, col6, headerY, col6, headerY + headerHeight)
        e.Graphics.DrawLine(Pens.Black, col7, headerY, col7, headerY + headerHeight)

        ' Header text
        Dim headerBrush As New SolidBrush(Color.White)
        e.Graphics.DrawString("Category", printHeaderFont, headerBrush, col1 + 5, headerY + 10)
        e.Graphics.DrawString("Size", printHeaderFont, headerBrush, col2 + 5, headerY + 10)
        e.Graphics.DrawString("Gender", printHeaderFont, headerBrush, col3 + 5, headerY + 10)
        e.Graphics.DrawString("Total", printHeaderFont, headerBrush, col4 + 5, headerY + 10)
        e.Graphics.DrawString("Critical", printHeaderFont, headerBrush, col5 + 5, headerY + 10)
        e.Graphics.DrawString("Pulled", printHeaderFont, headerBrush, col6 + 5, headerY + 10)
        e.Graphics.DrawString("Last Updated", printHeaderFont, headerBrush, col7 + 5, headerY + 10)

        yPos += headerHeight

        ' === DATA ROWS WITH BORDERS ===
        Dim rowCount As Integer = 0
        Dim alternateRow As Boolean = False

        While currentPrintRow < printData.Count
            ' Check if need new page
            If yPos + lineHeight > e.PageBounds.Height - 100 Then
                e.HasMorePages = True
                Exit Sub
            End If

            Dim item As ListViewItem = printData(currentPrintRow)

            ' Draw row background (alternating colors)
            If alternateRow Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(240, 248, 255)),
                                        leftMargin, yPos, rightMargin - leftMargin, lineHeight)
            End If

            ' Draw row borders
            e.Graphics.DrawRectangle(Pens.LightGray,
                                    leftMargin, yPos, rightMargin - leftMargin, lineHeight)

            ' Vertical lines for cells
            e.Graphics.DrawLine(Pens.LightGray, col2, yPos, col2, yPos + lineHeight)
            e.Graphics.DrawLine(Pens.LightGray, col3, yPos, col3, yPos + lineHeight)
            e.Graphics.DrawLine(Pens.LightGray, col4, yPos, col4, yPos + lineHeight)
            e.Graphics.DrawLine(Pens.LightGray, col5, yPos, col5, yPos + lineHeight)
            e.Graphics.DrawLine(Pens.LightGray, col6, yPos, col6, yPos + lineHeight)
            e.Graphics.DrawLine(Pens.LightGray, col7, yPos, col7, yPos + lineHeight)

            ' Draw cell text
            e.Graphics.DrawString(item.SubItems(0).Text, printFont, Brushes.Black, col1 + 5, yPos + 7)
            e.Graphics.DrawString(item.SubItems(1).Text, printFont, Brushes.Black, col2 + 5, yPos + 7)
            e.Graphics.DrawString(item.SubItems(2).Text, printFont, Brushes.Black, col3 + 5, yPos + 7)
            e.Graphics.DrawString(item.SubItems(3).Text, printFont, Brushes.Black, col4 + 5, yPos + 7)
            e.Graphics.DrawString(item.SubItems(4).Text, printFont, Brushes.Black, col5 + 5, yPos + 7)
            e.Graphics.DrawString(item.SubItems(5).Text, printFont, Brushes.Black, col6 + 5, yPos + 7)

            ' Last Updated (truncate if needed)
            Dim lastUpdated As String = item.SubItems(6).Text
            If lastUpdated.Length > 16 Then lastUpdated = lastUpdated.Substring(0, 16)
            e.Graphics.DrawString(lastUpdated, printFont, Brushes.Black, col7 + 5, yPos + 7)

            yPos += lineHeight
            currentPrintRow += 1
            alternateRow = Not alternateRow
            rowCount += 1
        End While

        ' === FOOTER (only on last page) ===
        If currentPrintRow >= printData.Count Then
            yPos += 15
            e.Graphics.DrawLine(New Pen(Color.Black, 2), leftMargin, yPos, rightMargin, yPos)
            yPos += 15

            ' Total records box
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(240, 240, 240)),
                                    leftMargin, yPos, 200, 30)
            e.Graphics.DrawRectangle(Pens.Black, leftMargin, yPos, 200, 30)
            e.Graphics.DrawString($"Total Records: {printData.Count}",
                                 printHeaderFont, Brushes.Black, leftMargin + 10, yPos + 8)

            ' Reset for next print job
            e.HasMorePages = False
            currentPrintRow = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles Button2.Paint
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
        Dim headerColor As Color = Color.FromArgb(0, 150, 136) ' Teal color
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

End Class

'Imports MySql.Data.MySqlClient
'Imports System.Windows.Forms.DataVisualization

'Public Class frmSalesReport

'    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        SetupListView()
'        LoadSummaryReport() ' Load all records initially
'    End Sub

'    ' === Setup ng ListView ===
'    Private Sub SetupListView()
'        With ListView2.Columns
'            .Clear()
'            .Add("Category", 140)
'            .Add("Size", 130)
'            .Add("Gender", 120)
'            .Add("Total Items", 120)
'            .Add("CriticalLevel", 120)
'            .Add("Pulled", 120)
'            .Add("Last Updated", 140)
'        End With

'        ListView2.View = View.Details
'        ListView2.FullRowSelect = True
'        ListView2.GridLines = True
'    End Sub

'    Private Sub LoadSummaryReport(Optional filterByDate As Boolean = False)
'        ListView2.Items.Clear()
'        Dim selectedDate As Date = FromDateTimePicker.Value.Date

'        Try
'            databaseConnection.con()

'            ' === Step 1: Kunin lahat ng unique combinations ng category, size, gender (na may gender lang) ===
'            Dim uniformDetails As New List(Of (Category As String, Size As String, Gender As String))
'            Dim distinctQuery As String

'            If filterByDate Then
'                distinctQuery = "
'                    SELECT DISTINCT category, size, gender 
'                    FROM tbluniforms 
'                    WHERE DATE(date_added) = @selectedDate 
'                          AND gender IS NOT NULL AND gender <> ''
'                    ORDER BY category, size, gender"
'            Else
'                distinctQuery = "
'                    SELECT category, size, gender
'                    FROM tbluniforms
'                    WHERE gender IS NOT NULL AND gender <> ''
'                    GROUP BY category, size, gender
'                    ORDER BY category, size, gender"
'            End If

'            Using cmdDistinct As New MySqlCommand(distinctQuery, databaseConnection.cn)
'                If filterByDate Then
'                    cmdDistinct.Parameters.AddWithValue("@selectedDate", selectedDate)
'                End If

'                Using reader As MySqlDataReader = cmdDistinct.ExecuteReader()
'                    While reader.Read()
'                        uniformDetails.Add((
'                            reader("category").ToString(),
'                            reader("size").ToString(),
'                            reader("gender").ToString()
'                        ))
'                    End While
'                End Using
'            End Using

'            ' === Step 2: I-loop bawat combination para makuha ang totals ===
'            Using cmd As New MySqlCommand()
'                cmd.Connection = databaseConnection.cn
'                cmd.Parameters.Add("@category", MySqlDbType.VarChar)
'                cmd.Parameters.Add("@size", MySqlDbType.VarChar)
'                cmd.Parameters.Add("@gender", MySqlDbType.VarChar)

'                If filterByDate Then
'                    cmd.Parameters.Add("@selectedDate", MySqlDbType.Date).Value = selectedDate
'                End If

'                For Each detail In uniformDetails
'                    Dim category As String = detail.Category
'                    Dim uniformSize As String = detail.Size
'                    Dim gender As String = detail.Gender
'                    Dim totalItems As Integer = 0
'                    Dim criticalLevel As Integer = 0
'                    Dim pulled As Integer = 0
'                    Dim lastUpdated As String = "—"

'                    cmd.Parameters("@category").Value = category
'                    cmd.Parameters("@size").Value = uniformSize
'                    cmd.Parameters("@gender").Value = gender

'                    ' === TOTAL ITEMS ===
'                    If filterByDate Then
'                        cmd.CommandText = "
'                            SELECT IFNULL(SUM(stock_quantity), 0)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender
'                                  AND DATE(date_added) = @selectedDate"
'                    Else
'                        cmd.CommandText = "
'                            SELECT IFNULL(SUM(stock_quantity), 0)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender"
'                    End If
'                    totalItems = Convert.ToInt32(cmd.ExecuteScalar())

'                    ' === CRITICAL LEVEL ===
'                    If filterByDate Then
'                        cmd.CommandText = "
'                            SELECT COUNT(*)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender
'                                  AND stock_quantity <= 0
'                                  AND DATE(date_added) = @selectedDate"
'                    Else
'                        cmd.CommandText = "
'                            SELECT COUNT(*)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender
'                                  AND stock_quantity < 10"
'                    End If
'                    criticalLevel = Convert.ToInt32(cmd.ExecuteScalar())

'                    ' === PULLED ===
'                    If filterByDate Then
'                        cmd.CommandText = "
'                            SELECT IFNULL(SUM(p.Quantity), 0)
'                            FROM tbl_pullouts p
'                            INNER JOIN tbluniforms u ON p.uniform_id = u.uniform_id
'                            WHERE u.category=@category AND u.size=@size AND u.gender=@gender
'                                  AND DATE(p.pullout_date) = @selectedDate"
'                    Else
'                        cmd.CommandText = "
'                            SELECT IFNULL(SUM(p.Quantity), 0)
'                            FROM tbl_pullouts p
'                            INNER JOIN tbluniforms u ON p.uniform_id = u.uniform_id
'                            WHERE u.category=@category AND u.size=@size AND u.gender=@gender"
'                    End If
'                    pulled = Convert.ToInt32(cmd.ExecuteScalar())

'                    ' === LAST UPDATED ===
'                    If filterByDate Then
'                        cmd.CommandText = "
'                            SELECT MAX(date_updated)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender
'                                  AND date_updated IS NOT NULL
'                                  AND DATE(date_updated) = @selectedDate"
'                    Else
'                        cmd.CommandText = "
'                            SELECT MAX(date_updated)
'                            FROM tbluniforms
'                            WHERE category=@category AND size=@size AND gender=@gender
'                                  AND date_updated IS NOT NULL"
'                    End If

'                    Dim result = cmd.ExecuteScalar()
'                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
'                        lastUpdated = Convert.ToDateTime(result).ToString("yyyy-MM-dd HH:mm:ss")
'                        ' Populate chart after ListView
'                        LoadChart()

'                    End If

'                    ' === ADD TO LISTVIEW ===
'                    Dim item As New ListViewItem(category)
'                    item.SubItems.Add(uniformSize)
'                    item.SubItems.Add(gender)
'                    item.SubItems.Add(totalItems.ToString())
'                    item.SubItems.Add(criticalLevel.ToString())
'                    item.SubItems.Add(pulled.ToString())
'                    item.SubItems.Add(lastUpdated)
'                    ListView2.Items.Add(item)
'                Next
'            End Using

'            ' Optional: walang result
'            If ListView2.Items.Count = 0 Then
'                If filterByDate Then
'                    MsgBox("No records found for " & selectedDate.ToString("yyyy-MM-dd"), MsgBoxStyle.Information)
'                Else
'                    MsgBox("No records found in database", MsgBoxStyle.Information)
'                End If
'            End If

'        Catch ex As Exception
'            MsgBox("Error loading summary: " & ex.Message, MsgBoxStyle.Critical)
'        Finally
'            databaseConnection.cn.Close()
'        End Try
'    End Sub



'    ' === CLICK NG Apply Button (filter by date) ===
'    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
'        LoadSummaryReport(True)
'    End Sub

'    ' === CLICK NG Clear Button (clear date filter) ===
'    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
'        FromDateTimePicker.Value = Date.Now
'        LoadSummaryReport(False)
'    End Sub

'End Class




''Imports MySql.Data.MySqlClient

''Public Class frmSalesReport

''    'Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
''    '    Pullouts()
''    '    Stocks()
''    'End Sub

''    'Private Sub Pullouts()
''    '    databaseConnection.con()
''    '    Dim sql As String = "SELECT SUM(Quantity) FROM tbl_pullouts"
''    '    databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
''    '    Dim total As Object = databaseConnection.cmd.ExecuteScalar()
''    '    If IsDBNull(total) Then
''    '        lblTotalPullouts.Text = "0"
''    '    Else
''    '        lblTotalPullouts.Text = total.ToString()
''    '    End If
''    '    databaseConnection.cn.Close()
''    'End Sub

''    'Private Sub Stocks()
''    '    Try
''    '        databaseConnection.con()
''    '        Dim sql As String = "SELECT SUM(stock_quantity) FROM tbluniforms"
''    '        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

''    '        Dim total As Object = databaseConnection.cmd.ExecuteScalar()

''    '        If IsDBNull(total) Then
''    '            lblTotalStocks.Text = "0"
''    '        Else
''    '            lblTotalStocks.Text = total.ToString()
''    '        End If

''    '    Catch ex As Exception
''    '        MessageBox.Show("Stocks Error: " & ex.Message, "Database Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
''    '        lblTotalStocks.Text = "ERROR"

''    '    Finally
''    '        If Not databaseConnection.cn Is Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
''    '            databaseConnection.cn.Close()
''    '        End If
''    '    End Try
''    'End Sub
''End Class