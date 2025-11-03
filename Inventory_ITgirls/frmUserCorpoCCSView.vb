Imports MySql.Data.MySqlClient

Public Class frmUserCorpoCCSView
    Private Sub UniformView()
        Try
            databaseConnection.con()

            Dim selectedGender As String = ""
            If rdoM.Checked Then
                selectedGender = "Male"
            ElseIf rdoF.Checked Then
                selectedGender = "Female"
            End If

            ' Gagamit pa rin tayo ng IN operator, assuming 'Junior High' is the value for High School
            Dim sql As String = "SELECT * FROM tbluniforms WHERE item_name=@item_name AND gender=@gender AND size=@size AND level='College' AND category='Corporate Attire' AND Course IN ('Bachelor of Science in Information Technology', 'Bachelor of Science in Computer Science')"

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
                lblStatus.Text = "Incomplete field."
                lblStatus.ForeColor = Color.Gray
            End If

            databaseConnection.dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.Text <> "" Then
            Dim selectedItem As String = cmbItemName.Text.Trim().ToLower()

            rdoM.Enabled = True
            rdoF.Enabled = True

            Select Case selectedItem
                Case "skirt"
                    rdoM.Enabled = False
                    rdoF.Checked = True
                    rdoM.Checked = False

                Case "slacks"
                    rdoF.Enabled = False
                    rdoM.Checked = True
                    rdoF.Checked = False

                Case "blazer"
                    ' Optional: walang restriction, both enabled
                    rdoM.Checked = False
                    rdoF.Checked = False

                Case Else
                    ' Default reset
                    rdoM.Checked = False
                    rdoF.Checked = False
            End Select

            If cmbSizes.Text.Trim() <> "" Then
                UniformView()
            End If
        End If
    End Sub
    ' ***************************************************************

    Private Sub cmbSizes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSizes.SelectedIndexChanged
        If cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            UniformView()
        End If
    End Sub

    Private Sub rdoM_CheckedChanged(sender As Object, e As EventArgs) Handles rdoM.CheckedChanged
        ' Ensure we only call UniformView if rdoM is the one that was just checked
        If rdoM.Checked And cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            UniformView()
        End If
    End Sub

    Private Sub rdoF_CheckedChanged(sender As Object, e As EventArgs) Handles rdoF.CheckedChanged
        ' Ensure we only call UniformView if rdoF is the one that was just checked
        If rdoF.Checked And cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            UniformView()
        End If
    End Sub

    Private Sub frmUserUniformHSPantsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class