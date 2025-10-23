Imports MySql.Data.MySqlClient

Public Class frmSalesReport

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pullouts()
        Stocks()
    End Sub

    Private Sub Pullouts()
        databaseConnection.con()
        Dim sql As String = "SELECT SUM(Quantity) FROM tbl_pullouts"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        Dim total As Object = databaseConnection.cmd.ExecuteScalar()
        If IsDBNull(total) Then
            lblTotalPullouts.Text = "0"
        Else
            lblTotalPullouts.Text = total.ToString()
        End If
        databaseConnection.cn.Close()
    End Sub

    Private Sub Stocks()
        Try
            databaseConnection.con()
            Dim sql As String = "SELECT SUM(stock_quantity) FROM tbluniforms"
            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)

            Dim total As Object = databaseConnection.cmd.ExecuteScalar()

            If IsDBNull(total) Then
                lblTotalStocks.Text = "0"
            Else
                lblTotalStocks.Text = total.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Stocks Error: " & ex.Message, "Database Issue", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblTotalStocks.Text = "ERROR"

        Finally
            If Not databaseConnection.cn Is Nothing AndAlso databaseConnection.cn.State = ConnectionState.Open Then
                databaseConnection.cn.Close()
            End If
        End Try
    End Sub
End Class