Imports MySql.Data.MySqlClient

Public Class frmCA_ScorpoView
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

            ' Palaging i-reset at i-enable lahat ng buttons sa simula
            rdoM.Enabled = True
            rdoF.Enabled = True
            rdoU.Enabled = True

            rdoM.Checked = False
            rdoF.Checked = False
            rdoU.Checked = False

            Select Case selectedItem
                Case "skirt"
                    ' Skirt = Female lang
                    rdoM.Enabled = False
                    rdoU.Enabled = False
                    rdoF.Checked = True

                Case "slacks"
                    ' Slacks = Unisex lang
                    rdoM.Enabled = False
                    rdoF.Enabled = False
                    rdoU.Checked = True

                Case "blouse"
                    ' Blouse = MALE o FEMALE lang (Hindi kasama ang Unisex)
                    rdoU.Enabled = False
                ' Walang naka-check na default, hahayaan ang user na pumili sa M o F.

                Case "blazer" ' Assuming Blazer is still M and F optional
                    rdoU.Enabled = False

                Case Else
                    ' Default reset is already done sa simula.
            End Select

            ' Tiyakin na ang tamang radio button event handler lang ang tatawag sa UniformView
            If cmbSizes.Text.Trim() <> "" Then
                ' Kung Skirt (F) o Slacks (U) ang pinili, tinawag na ang UniformView sa pag-check ng rdo
                ' Kung Blouse/Blazer, kailangan i-check kung may naka-check na gender bago tumawag
                If rdoM.Checked Or rdoF.Checked Or rdoU.Checked Then
                    UniformView()
                End If
            End If
        End If
    End Sub

    ' ***************************************************************
    ' IDAGDAG MO RIN ITO (para gumana ang Slacks)
    Private Sub rdoU_CheckedChanged(sender As Object, e As EventArgs) Handles rdoU.CheckedChanged
        If rdoU.Checked And cmbItemName.Text <> "" And cmbSizes.Text <> "" Then
            UniformView()
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