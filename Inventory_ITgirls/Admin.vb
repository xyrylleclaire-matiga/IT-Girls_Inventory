Public Class Admin
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub btnStockManagement_Click(sender As Object, e As EventArgs) Handles btnStockManagement.Click
        Hide()
        StockManagement.Show()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Hide()
        SalesReport.Show()
    End Sub


End Class