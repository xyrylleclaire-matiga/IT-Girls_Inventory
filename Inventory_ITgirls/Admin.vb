Public Class Admin
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnStockManagement_Click(sender As Object, e As EventArgs) Handles btnStockManagement.Click
        Hide()
        StockManagement.Show()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Hide
        SalesReport.Show
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles picSchoolUniform.Click
        Dim borderColor As Color = Color.Blue
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPeUniform.Click
        PEUniformView.Show()
        Me.Hide()
    End Sub

End Class