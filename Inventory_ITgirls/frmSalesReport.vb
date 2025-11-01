Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
' Siguraduhin na may reference ka sa System.Windows.Forms.DataVisualization sa project mo
' Siguraduhin na mayroon kang public Shared databaseConnection As New DatabaseConnection() na may .con at .cn
' at mayroon kang Chart control na pinangalanang Chart1, FromDateTimePicker, btnApply, at btnClear

Public Class frmSalesReport

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadSummaryReport() ' Load all records initially
    End Sub

    ' === Setup ng ListView ===
    Private Sub SetupListView()
        With ListView2.Columns
            .Clear()
            .Add("Category", 140)
            .Add("Size", 130)
            .Add("Gender", 120)
            .Add("Total Items", 120) ' Index 3
            .Add("CriticalLevel", 120)
            .Add("Pulled", 120)       ' Index 5
            .Add("Last Updated", 140)
        End With

        ListView2.View = View.Details
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
    End Sub

    Private Sub LoadSummaryReport(Optional filterByDate As Boolean = False)
        ListView2.Items.Clear()
        Dim selectedDate As Date = FromDateTimePicker.Value.Date
        Dim summaryDataLoaded As Boolean = False

        Try
            databaseConnection.con()

            ' === Step 1: Kunin lahat ng unique combinations ng category, size, gender ===
            Dim uniformDetails As New List(Of (Category As String, Size As String, Gender As String))
            Dim distinctQuery As String

            If filterByDate Then
                distinctQuery = "
                    SELECT DISTINCT category, size, gender 
                    FROM tbluniforms 
                    WHERE DATE(date_added) = @selectedDate 
                          AND gender IS NOT NULL AND gender <> ''
                    ORDER BY category, size, gender"
            Else
                distinctQuery = "
                    SELECT category, size, gender
                    FROM tbluniforms
                    WHERE gender IS NOT NULL AND gender <> ''
                    GROUP BY category, size, gender
                    ORDER BY category, size, gender"
            End If

            Using cmdDistinct As New MySqlCommand(distinctQuery, databaseConnection.cn)
                If filterByDate Then
                    cmdDistinct.Parameters.AddWithValue("@selectedDate", selectedDate)
                End If

                Using reader As MySqlDataReader = cmdDistinct.ExecuteReader()
                    While reader.Read()
                        uniformDetails.Add((
                            reader("category").ToString(),
                            reader("size").ToString(),
                            reader("gender").ToString()
                        ))
                    End While
                End Using
            End Using

            ' === Step 2: I-loop bawat combination para makuha ang totals ===
            Using cmd As New MySqlCommand()
                cmd.Connection = databaseConnection.cn
                cmd.Parameters.Add("@category", MySqlDbType.VarChar)
                cmd.Parameters.Add("@size", MySqlDbType.VarChar)
                cmd.Parameters.Add("@gender", MySqlDbType.VarChar)

                If filterByDate Then
                    cmd.Parameters.Add("@selectedDate", MySqlDbType.Date).Value = selectedDate
                End If

                For Each detail In uniformDetails
                    Dim category As String = detail.Category
                    Dim uniformSize As String = detail.Size
                    Dim gender As String = detail.Gender
                    Dim totalItems As Integer = 0
                    Dim criticalLevel As Integer = 0
                    Dim pulled As Integer = 0
                    Dim lastUpdated As String = "—"

                    cmd.Parameters("@category").Value = category
                    cmd.Parameters("@size").Value = uniformSize
                    cmd.Parameters("@gender").Value = gender

                    ' === TOTAL ITEMS (Stock) ===
                    If filterByDate Then
                        cmd.CommandText = "
                            SELECT IFNULL(SUM(stock_quantity), 0)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender
                                  AND DATE(date_added) = @selectedDate"
                    Else
                        cmd.CommandText = "
                            SELECT IFNULL(SUM(stock_quantity), 0)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender"
                    End If
                    totalItems = Convert.ToInt32(cmd.ExecuteScalar())

                    ' === CRITICAL LEVEL ===
                    If filterByDate Then
                        cmd.CommandText = "
                            SELECT COUNT(*)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender
                                  AND stock_quantity < 10
                                  AND DATE(date_added) = @selectedDate"
                    Else
                        cmd.CommandText = "
                            SELECT COUNT(*)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender
                                  AND stock_quantity < 10"
                    End If
                    criticalLevel = Convert.ToInt32(cmd.ExecuteScalar())

                    ' === PULLED ===
                    If filterByDate Then
                        cmd.CommandText = "
                            SELECT IFNULL(SUM(p.Quantity), 0)
                            FROM tbl_pullouts p
                            INNER JOIN tbluniforms u ON p.uniform_id = u.uniform_id
                            WHERE u.category=@category AND u.size=@size AND u.gender=@gender
                                  AND DATE(p.pullout_date) = @selectedDate"
                    Else
                        cmd.CommandText = "
                            SELECT IFNULL(SUM(p.Quantity), 0)
                            FROM tbl_pullouts p
                            INNER JOIN tbluniforms u ON p.uniform_id = u.uniform_id
                            WHERE u.category=@category AND u.size=@size AND u.gender=@gender"
                    End If
                    pulled = Convert.ToInt32(cmd.ExecuteScalar())

                    ' === LAST UPDATED ===
                    If filterByDate Then
                        cmd.CommandText = "
                            SELECT MAX(date_updated)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender
                                  AND date_updated IS NOT NULL
                                  AND DATE(date_updated) = @selectedDate"
                    Else
                        cmd.CommandText = "
                            SELECT MAX(date_updated)
                            FROM tbluniforms
                            WHERE category=@category AND size=@size AND gender=@gender
                                  AND date_updated IS NOT NULL"
                    End If

                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                        lastUpdated = Convert.ToDateTime(result).ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    ' === ADD TO LISTVIEW (No Filter) ===
                    ' Idagdag lahat ng categories na nahanap, kahit zero ang stocks/pulled.
                    Dim item As New ListViewItem(category)
                    item.SubItems.Add(uniformSize)
                    item.SubItems.Add(gender)
                    item.SubItems.Add(totalItems.ToString())
                    item.SubItems.Add(criticalLevel.ToString())
                    item.SubItems.Add(pulled.ToString())
                    item.SubItems.Add(lastUpdated)
                    ListView2.Items.Add(item)

                Next
            End Using

            If ListView2.Items.Count > 0 Then
                summaryDataLoaded = True
            End If

            ' Optional: walang result
            If ListView2.Items.Count = 0 Then
                If filterByDate Then
                    MsgBox("No records found for " & selectedDate.ToString("yyyy-MM-dd"), MsgBoxStyle.Information)
                Else
                    MsgBox("No records found in database", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error loading summary: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            databaseConnection.cn.Close()
            ' === TAMANG PAG-CALL NG CHART FUNCTION ===
            If summaryDataLoaded Then
                LoadChart() ' I-load ang chart kapag may data
            Else
                chart1.Series.Clear() ' I-clear ang chart kung walang data
                chart1.Titles.Clear()
            End If
        End Try
    End Sub


    ' === REVISED CHART FUNCTION: Nagpapakita ng Stocks at Pulled kada Category ===
    Private Sub LoadChart()
        ' I-clear muna ang lumang data
        chart1.Series.Clear()
        chart1.Titles.Clear()

        ' I-set up ang Chart Area
        chart1.ChartAreas(0).AxisX.Interval = 1
        chart1.ChartAreas(0).AxisX.Title = "Category / Item Type"
        chart1.ChartAreas(0).AxisY.Title = "Quantity"

        ' Tiyakin na naka-reset ang chart area
        chart1.ChartAreas(0).AxisX.CustomLabels.Clear()

        ' === SERIES 1: TOTAL STOCKS (Total_Items) ===
        Dim stocksSeries As New Series("Total Stocks")
        stocksSeries.ChartType = SeriesChartType.Column ' Bar chart (Side-by-Side)
        stocksSeries.Color = Color.Blue
        stocksSeries.IsValueShownAsLabel = True         ' Ipakita ang value sa taas ng bar
        stocksSeries.Points.Clear()                     ' Tiyakin na walang lumang data points

        ' === SERIES 2: PULLED ITEMS (Pulled) ===
        Dim pulledSeries As New Series("Pulled / Sales")
        pulledSeries.ChartType = SeriesChartType.Column
        pulledSeries.Color = Color.Red
        pulledSeries.IsValueShownAsLabel = True
        pulledSeries.Points.Clear()                     ' Tiyakin na walang lumang data points

        ' Idagdag ang Series sa Chart
        chart1.Series.Add(stocksSeries)
        chart1.Series.Add(pulledSeries)

        ' === Data Aggregation (I-grupo ang data ayon sa Category) ===
        ' Gumagamit ng Dictionary para pagsama-samahin ang stocks at pulled para sa bawat CATEGORY
        Dim categoryData As New Dictionary(Of String, (Stocks As Integer, Pulled As Integer))

        For Each item As ListViewItem In ListView2.Items
            ' Ang data ay kinuha mula sa ListView:
            ' 0: Category, 3: Total Items (Stocks), 5: Pulled

            Dim categoryKey As String = item.SubItems(0).Text
            ' Gumamit ng CInt o TryParse para maiwasan ang error kung hindi integer ang laman
            Dim currentStocks As Integer = 0
            Integer.TryParse(item.SubItems(3).Text, currentStocks)

            Dim currentPulled As Integer = 0
            Integer.TryParse(item.SubItems(5).Text, currentPulled)

            If categoryData.ContainsKey(categoryKey) Then
                ' Idagdag sa existing total
                Dim existingData = categoryData(categoryKey)
                categoryData(categoryKey) = (existingData.Stocks + currentStocks, existingData.Pulled + currentPulled)
            Else
                ' Bagong entry
                categoryData.Add(categoryKey, (currentStocks, currentPulled))
            End If
        Next

        ' === I-Populate ang Chart gamit ang Aggregated Data ===
        For Each kvp In categoryData.OrderBy(Function(k) k.Key) ' I-sort ayon sa Category Name
            Dim categoryName As String = kvp.Key
            Dim totalStocks As Integer = kvp.Value.Stocks
            Dim totalPulled As Integer = kvp.Value.Pulled

            ' Idagdag ang Data Point para sa Stocks at Pulled
            stocksSeries.Points.AddXY(categoryName, totalStocks)
            pulledSeries.Points.AddXY(categoryName, totalPulled)
        Next

        ' Title ng Chart
        chart1.Titles.Add("Inventory Stocks vs. Items Pulled by Category")

    End Sub

    ' === CLICK NG Apply Button (filter by date) ===
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        LoadSummaryReport(True)
    End Sub

    ' === CLICK NG Clear Button (clear date filter) ===
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        FromDateTimePicker.Value = Date.Now
        LoadSummaryReport(False)
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