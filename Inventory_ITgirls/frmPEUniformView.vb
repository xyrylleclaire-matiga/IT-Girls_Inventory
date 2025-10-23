Imports MySql.Data.MySqlClient

Public Class frmPEUniformView
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to go back?", vbQuestion + vbYesNo) = vbYes Then
            frmAdmin.Show()
            Close()
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
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem = ListView1.SelectedItems(0)
            txtItemName.Text = selectedItem.Text
            txtLevel.Text = selectedItem.SubItems(1).Text
            txtGender.Text = selectedItem.SubItems(2).Text
            txtSize.Text = selectedItem.SubItems(3).Text
            txtStockQuantity.Text = selectedItem.SubItems(4).Text
            txtPrice.Text = selectedItem.SubItems(5).Text
            txtStatus.Text = selectedItem.SubItems(6).Text
            txtDateAdded.Text = selectedItem.SubItems(7).Text

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnModify.Click

    End Sub
    Private Sub btnModify_Paint(sender As Object, e As PaintEventArgs) Handles btnModify.Paint
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

    Private Sub btnRemove1_Paint(sender As Object, e As PaintEventArgs) Handles btnRemove1.Paint
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

    Private Sub btnSave_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint
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

    Private Sub btnBack_Paint(sender As Object, e As PaintEventArgs) Handles btnBack.Paint
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

End Class