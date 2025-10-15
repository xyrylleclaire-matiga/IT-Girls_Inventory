Public Class PEUniformView
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MsgBox("Are you sure you want to go back?", vbQuestion + vbYesNo) = vbYes Then
            Admin.Show()
            Me.Close()
        End If
    End Sub
End Class