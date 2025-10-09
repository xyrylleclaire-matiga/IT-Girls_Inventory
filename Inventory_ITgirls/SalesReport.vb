Public Class SalesReport


    Private Sub btnStockManagement_Click(sender As Object, e As EventArgs) Handles btnStockManagement.Click
        Hide()
        StockManagement.Show()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Hide()
        Me.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        Admin.Show()
    End Sub
End Class