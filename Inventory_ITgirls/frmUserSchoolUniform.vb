﻿Public Class frmUserSchoolUniform
    Private Sub btnKinderElemTop_Click(sender As Object, e As EventArgs) Handles btnKinderElemTop.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformKindergartenTopView)
        End If
    End Sub

    Private Sub btnHighschoolTop_Click(sender As Object, e As EventArgs) Handles btnHighschoolTop.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformHSTopView)
        End If
    End Sub

    Private Sub btnCollegeTop_Click(sender As Object, e As EventArgs) Handles btnCollegeTop.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformCollegeTopView)
        End If
    End Sub

    Private Sub btnKinderElemBottom_Click(sender As Object, e As EventArgs) Handles btnKinderElemBottom.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformKindergartenPantsView)
        End If
    End Sub

    Private Sub btnHighschoolBottom_Click(sender As Object, e As EventArgs) Handles btnHighschoolBottom.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformHSPantsView)
        End If
    End Sub

    Private Sub btnCollegeBottom_Click(sender As Object, e As EventArgs) Handles btnCollegeBottom.Click
        Dim parentForm As frmUser = TryCast(Me.ParentForm, frmUser)
        If parentForm IsNot Nothing Then
            parentForm.openChildForm(New frmUserUniformCollegePantsView)
        End If
    End Sub
End Class