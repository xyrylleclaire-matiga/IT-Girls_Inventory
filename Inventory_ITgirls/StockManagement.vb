Public Class StockManagement

    Private Sub btnStockManagement_Click(sender As Object, e As EventArgs)
        Hide()
        Show()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs)
        Hide()
        SalesReport.Show()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnStockManagement_Click_1(sender As Object, e As EventArgs) Handles btnStockManagement.Click

    End Sub
End Class