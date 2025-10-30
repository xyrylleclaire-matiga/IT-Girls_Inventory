Public Class frmUserCorporateAttire
    Private Sub frmUserCorporateAttire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCCScorpo_Click(sender As Object, e As EventArgs) Handles btnCCScorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCCSView)
        End If
    End Sub

    Private Sub btnCOAcorpo_Click(sender As Object, e As EventArgs) Handles btnCOAcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCOAView)
        End If
    End Sub

    Private Sub btnBusinessAdCorpo_Click(sender As Object, e As EventArgs) Handles btnBusinessAdCorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoBusAdView)
        End If
    End Sub

    Private Sub btnCOEcorpo_Click(sender As Object, e As EventArgs) Handles btnCOEcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCOEView)
        End If
    End Sub

    Private Sub btnCAScorpo_Click(sender As Object, e As EventArgs) Handles btnCAScorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCASView)
        End If
    End Sub

    Private Sub btnHMcorpo_Click(sender As Object, e As EventArgs) Handles btnHMcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoHMView)
        End If
    End Sub

    Private Sub btnToursimCorpo_Click(sender As Object, e As EventArgs) Handles btnToursimCorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoTMView)
        End If
    End Sub

    Private Sub btnCOEDcorpo_Click(sender As Object, e As EventArgs) Handles btnCOEDcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCOEDView)
        End If
    End Sub

    Private Sub btnCustomsAdcorpo_Click(sender As Object, e As EventArgs) Handles btnCustomsAdcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCUSADView)
        End If
    End Sub

    Private Sub btnCCJcorpo_Click(sender As Object, e As EventArgs) Handles btnCCJcorpo.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserCorpoCCJView)
        End If
    End Sub
End Class