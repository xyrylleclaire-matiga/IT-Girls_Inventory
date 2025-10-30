Public Class frmUserPEUniform
    Private Sub btnKindergartenShirt_Click(sender As Object, e As EventArgs) Handles btnKindergartenShirt.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPEKindergartenShirtView)
        End If
    End Sub

    Private Sub btnElemHighShirt_Click(sender As Object, e As EventArgs) Handles btnElemHighShirt.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPEHSShirtView)
        End If
    End Sub

    Private Sub btnCollegeShirt_Click(sender As Object, e As EventArgs) Handles btnCollegeShirt.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPECollegeShirtView)
        End If
    End Sub

    Private Sub btnKindergartenPants_Click(sender As Object, e As EventArgs) Handles btnKindergartenPants.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPEKindergartenPantsView)
        End If
    End Sub

    Private Sub btnElemHighPants_Click(sender As Object, e As EventArgs) Handles btnElemHighPants.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPEHSpantsView)
        End If
    End Sub

    Private Sub btnCollegePants_Click(sender As Object, e As EventArgs) Handles btnCollegePants.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserPECollegePantsView)
        End If
    End Sub
End Class