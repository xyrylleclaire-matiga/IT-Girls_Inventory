Imports MySql.Data.MySqlClient

Public Class TotalPullouts
    Private selectedUniformID As Integer
    'Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    '    lblItemName.Clear()
    '    lblDate.Clear()
    '    txtQuantity.Clear()
    '    cboPulloutReason.Text = ""
    '    Hide()
    '    Admin.Show()
    'End Sub

    Private Sub displayApplication()
        databaseConnection.con()
        ListView1.Items.Clear()
        sql = "SELECT * FROM tbluniforms"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.dr = databaseConnection.cmd.ExecuteReader
        While databaseConnection.dr.Read = True
            Dim x As New ListViewItem(databaseConnection.dr("uniform_id").ToString())
            x.SubItems.Add(databaseConnection.dr("item_name").ToString())
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            selectedUniformID = CInt(selectedItem.SubItems(0).Text)
            lblItemName.Text = selectedItem.SubItems(1).Text
            lblDate.Text = Date.Now.ToString("yyyy-MM-dd-H-m-s")
        End If
    End Sub

    Private Sub PulloutView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayApplication()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If String.IsNullOrWhiteSpace(lblDate.Text) OrElse
            String.IsNullOrWhiteSpace(cboPulloutReason.Text) OrElse
            String.IsNullOrWhiteSpace(lblItemName.Text) OrElse
            String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("Please fill out all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Please enter a numeric number.", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtQuantity.Text <= 0 Then
            MsgBox("Please enter a valid number, the enter quantity must be greater than 0.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim pulloutQty As Integer = CInt(txtQuantity.Text)

        databaseConnection.con()

        Dim sqlCheck As String = "SELECT stock_quantity FROM tbluniforms WHERE uniform_id = @uniform_id"
        Dim currentStock As Integer
        databaseConnection.cmd = New MySqlCommand(sqlCheck, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)

        Dim resultObj = databaseConnection.cmd.ExecuteScalar()
        currentStock = If(IsDBNull(resultObj), 0, CInt(resultObj))
        If pulloutQty > currentStock Then
            MessageBox.Show("You exceed the total number of stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            databaseConnection.cn.Close()
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to pull out this item?", "Confirm Pullout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim sqlInsert As String = "INSERT INTO tbl_pullouts (uniform_id, Date, Quantity, PulloutReason) VALUES (@uniform_id, @Date, @Quantity, @PulloutReason)"

            databaseConnection.cmd = New MySqlCommand(sqlInsert, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
            databaseConnection.cmd.Parameters.AddWithValue("@Date", lblDate.Text)
            databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
            databaseConnection.cmd.Parameters.AddWithValue("@PulloutReason", cboPulloutReason.Text)
            databaseConnection.cmd.ExecuteNonQuery()

            Dim sqlUpdate As String = "UPDATE tbluniforms SET stock_quantity = stock_quantity - @Quantity WHERE uniform_id = @uniform_id"

            databaseConnection.cmd = New MySqlCommand(sqlUpdate, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@Quantity", pulloutQty)
            databaseConnection.cmd.Parameters.AddWithValue("@uniform_id", selectedUniformID)
            databaseConnection.cmd.ExecuteNonQuery()

            MessageBox.Show("Pullout recorded and stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            lblItemName.Clear()
            lblDate.Clear()
            txtQuantity.Clear()
            cboPulloutReason.Text = ""
        Else
            MessageBox.Show("Cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        databaseConnection.cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblDate.Clear()
        lblItemName.Clear()
        txtQuantity.Clear()
        cboPulloutReason.Text = ""
    End Sub
End Class