Public Class frmUser
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private currentChild As Form = Nothing
    Public Sub openChildForm(child As Form)
        If currentChild IsNot Nothing Then
            currentChild.Close()
        End If

        currentChild = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        PanelUser.Controls.Clear()
        PanelUser.Controls.Add(child)
        child.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        openChildForm(New frmHomeUser)
    End Sub

    Private originalSizes As New Dictionary(Of PictureBox, Size)
    Private originalPositions As New Dictionary(Of PictureBox, Point)

    Private Sub btnPeUniform_Click(sender As Object, e As EventArgs) Handles btnPeUniform.Click
        openChildForm(New frmUserPEUniform)
    End Sub

    Private Sub btnSchoolUniform_Click(sender As Object, e As EventArgs) Handles btnSchoolUniform.Click
        openChildForm(New frmUserSchoolUniform)
    End Sub

    Private Sub btnCorporateAttire_Click(sender As Object, e As EventArgs) Handles btnCorporateAttire.Click
        openChildForm(New frmUserCorporateAttire)
    End Sub

    Private Sub PanelUser_Paint(sender As Object, e As PaintEventArgs) Handles PanelUser.Paint

    End Sub
End Class