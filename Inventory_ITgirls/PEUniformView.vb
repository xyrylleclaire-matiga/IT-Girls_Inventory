Imports MySql.Data.MySqlClient

Public Class PEUniformView
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MsgBox("Are you sure you want to go back?", vbQuestion + vbYesNo) = vbYes Then
            Admin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub displayApplication()
        databaseConnection.con()
        ListView1.Items.Clear()
        sql = "Select * from tbluniforms where category= 'PE Uniform'"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.dr = databaseConnection.cmd.ExecuteReader

        While databaseConnection.dr.Read = True
            Dim x As New ListViewItem(databaseConnection.dr("item_name").ToString())
            x.SubItems.Add(databaseConnection.dr("category").ToString())
            x.SubItems.Add(databaseConnection.dr("level").ToString())
            x.SubItems.Add(databaseConnection.dr("gender").ToString())
            x.SubItems.Add(databaseConnection.dr("size").ToString())
            x.SubItems.Add(databaseConnection.dr("stock_quantity").ToString())
            x.SubItems.Add(databaseConnection.dr("price").ToString())
            x.SubItems.Add(databaseConnection.dr("status").ToString())
            x.SubItems.Add(databaseConnection.dr("date_added").ToString())

            ListView1.Items.Add(x)
        End While
        databaseConnection.dr.Close()
    End Sub

    Private Sub PEUniformView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayApplication()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            txtItemName.Text = selectedItem.Text
            txtCategory.Text = selectedItem.SubItems(1).Text
            txtLevel.Text = selectedItem.SubItems(2).Text
            txtGender.Text = selectedItem.SubItems(3).Text
            txtSize.Text = selectedItem.SubItems(4).Text
            txtStockQuantity.Text = selectedItem.SubItems(5).Text
            txtPrice.Text = selectedItem.SubItems(6).Text
            txtStatus.Text = selectedItem.SubItems(7).Text
            txtDateAdded.Text = selectedItem.SubItems(8).Text

        End If
    End Sub
End Class