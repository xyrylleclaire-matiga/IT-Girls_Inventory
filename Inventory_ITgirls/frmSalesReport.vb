Imports MySql.Data.MySqlClient

Public Class frmSalesReport

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub LoadReport()
        ListView2.Items.Clear()

        Try
            databaseConnection.con()

            ' 1️⃣ Get all distinct categories first (CLOSE reader before reusing connection)
            Dim categories As New List(Of String)
            Using cmd As New MySqlCommand("SELECT DISTINCT category FROM tbluniforms", databaseConnection.cn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        categories.Add(reader("category").ToString())
                    End While
                End Using
            End Using

            ' 2️⃣ Loop each category and run your calculations
            For Each category As String In categories
                Dim totalItems As Integer = 0
                Dim lowStock As Integer = 0
                Dim pulled As Integer = 0
                Dim lastUpdated As String = "—"

                ' === TOTAL ITEMS ===
                Using cmdTotal As New MySqlCommand("SELECT SUM(stock_quantity) FROM tbluniforms WHERE category=@category", databaseConnection.cn)
                    cmdTotal.Parameters.AddWithValue("@category", category)
                    Dim result = cmdTotal.ExecuteScalar()
                    totalItems = If(IsDBNull(result), 0, Convert.ToInt32(result))
                End Using

                ' === LOW STOCK ===
                Using cmdLow As New MySqlCommand("SELECT COUNT(*) FROM tbluniforms WHERE category=@category AND stock_quantity < 10", databaseConnection.cn)
                    cmdLow.Parameters.AddWithValue("@category", category)
                    Dim result = cmdLow.ExecuteScalar()
                    lowStock = If(IsDBNull(result), 0, Convert.ToInt32(result))
                End Using

                ' === PULLED ===
                Using cmdPulled As New MySqlCommand("
                    SELECT SUM(p.Quantity)
                    FROM tbl_pullouts p
                    INNER JOIN tbluniforms u ON p.uniform_id = u.uniform_id
                    WHERE u.category = @category", databaseConnection.cn)

                    cmdPulled.Parameters.AddWithValue("@category", category)
                    Dim result = cmdPulled.ExecuteScalar()
                    pulled = If(IsDBNull(result), 0, Convert.ToInt32(result))
                End Using


                ' === LAST UPDATED ===
                Using cmdUpdated As New MySqlCommand("SELECT MAX(date_added) FROM tbluniforms WHERE category=@category", databaseConnection.cn)
                    cmdUpdated.Parameters.AddWithValue("@category", category)
                    Dim result = cmdUpdated.ExecuteScalar()
                    lastUpdated = If(IsDBNull(result) OrElse result Is Nothing, "—", Convert.ToDateTime(result).ToString("yyyy-MM-dd"))
                End Using

                ' === ADD TO LISTVIEW ===
                Dim item As New ListViewItem(category)
                item.SubItems.Add(totalItems.ToString())
                item.SubItems.Add(lowStock.ToString())
                item.SubItems.Add(pulled.ToString())
                item.SubItems.Add(lastUpdated)
                ListView2.Items.Add(item)
            Next

        Catch ex As Exception
            MsgBox("Error loading report: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            databaseConnection.cn.Close()
        End Try
    End Sub

End Class
'Imports MySql.Data.MySqlClient

'Public Class frmSalesReport

'    'Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    '    Pullouts()
'    '    Stocks()
'    'End Sub

'    'Private Sub Pullouts()
'    '    databaseConnection.con()
'    '    Dim sql As String = "SELECT SUM(Quantity) FROM tbl_pullouts"
'    '    databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
'    '    Dim total As Object = databaseConnection.cmd.ExecuteScalar()
'    '    If IsDBNull(total) Then
'    '        lblTotalPullouts.Text = "0"
'    '    Else
'    '        lblTotalPullouts.Text = total.ToString()
'    '    End If
'    '    databaseConnection.cn.Close()
'    'End Sub

'    'Private Sub Stocks()
'    '    Try
'    '        databaseConnection.con()
'    '        Dim sql As String = "SELECT SUM(stock_quantity) FROM tbluniforms"
'    '        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

'    '        Dim total As Object = databaseConnection.cmd.ExecuteScalar()

'    '        If IsDBNull(total) Then
'    '            lblTotalStocks.Text = "0"
'    '        Else
'    '            lblTotalStocks.Text = total.ToString()
'    '        End If

'    '    Catch ex As Exception
'    '        MessageBox.Show("Stocks Error: " & ex.Message, "Database Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    '        lblTotalStocks.Text = "ERROR"

'    '    Finally
'    '        If Not databaseConnection.cn Is Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
'    '            databaseConnection.cn.Close()
'    '        End If
'    '    End Try
'    'End Sub
'End Class