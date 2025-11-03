Imports MySql.Data.MySqlClient

Public Class frmUserCorpoCOEView
    Private Sub UniformView()
        Try
            databaseConnection.con()

            Dim selectedGender As String = ""

            If rdoU.Checked Then
                selectedGender = "Unisex"
            End If

            If cmbItemName.Text.Trim() = "" Or cmbSizes.Text.Trim() = "" Then
                lblPrice.Text = "—"
                lblStatus.Text = "Pumili ng Item at Size"
                lblStatus.ForeColor = Color.Blue
                databaseConnection.cn.Close()
                Exit Sub
            End If
            Dim sql As String = "SELECT * FROM tbluniforms WHERE item_name=@item_name AND gender=@gender AND size=@size AND level='College' AND category='Corporate Attire' AND Course = 'Bachelor of Science in Engineering'"

            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@item_name", cmbItemName.Text.Trim())
            databaseConnection.cmd.Parameters.AddWithValue("@gender", selectedGender)
            databaseConnection.cmd.Parameters.AddWithValue("@size", cmbSizes.Text.Trim())

            databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

            If databaseConnection.dr.Read() Then

                lblPrice.Text = "₱" & databaseConnection.dr("price").ToString()

                Dim qty As Integer = 0
                If Not IsDBNull(databaseConnection.dr("stock_quantity")) Then
                    qty = Convert.ToInt32(databaseConnection.dr("stock_quantity"))
                End If

                If qty >= 10 Then
                    lblStatus.Text = "Available"
                    lblStatus.ForeColor = Color.Green
                ElseIf qty > 0 And qty < 10 Then
                    lblStatus.Text = "Low Stock"
                    lblStatus.ForeColor = Color.Orange
                Else
                    lblStatus.Text = "Out of Stock"
                    lblStatus.ForeColor = Color.Red
                End If
            Else
                lblPrice.Text = "—"
                lblStatus.Text = "No Record Found"
                lblStatus.ForeColor = Color.Red
            End If

            databaseConnection.dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.Text <> "" Then
            Dim selectedItem As String = cmbItemName.Text.Trim().ToLower()

            rdoU.Enabled = True
            rdoU.Checked = False

            Select Case selectedItem
                Case "blazer", "slacks"
                    rdoU.Checked = True

                Case Else

                    rdoU.Checked = True
            End Select

            If cmbSizes.Text.Trim() <> "" Then
                If rdoU.Checked Then
                    UniformView()
                End If
            End If
        End If
    End Sub

    Private Sub rdoU_CheckedChanged(sender As Object, e As EventArgs) Handles rdoU.CheckedChanged
        If rdoU.Checked And cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            UniformView()
        End If
    End Sub

    Private Sub cmbSizes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSizes.SelectedIndexChanged
        If cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            If rdoU.Checked Then
                UniformView()
            End If
        End If
    End Sub
    Private Sub frmUserCorpoCOEView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class