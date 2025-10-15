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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles picSchoolUniform.Click
        Dim borderColor As Color = Color.Blue
    End Sub
End Class