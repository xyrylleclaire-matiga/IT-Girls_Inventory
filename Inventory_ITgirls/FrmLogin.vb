Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Call con()
        sql = "Select * from tblusers where user_id = @user_id AND password= @password "
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@user_id", txtStudentID.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            MsgBox("Login Success!")
            Dim role As String = dr("role").ToString()

            If role = "Student" Then
                Me.Hide()
                ' FrmUser.Show()
            End If
        Else
            MsgBox("Login Failed!")

            ' Refresh attempts from DB para sure na latest value
            Call getAttempts()

            Dim attempts As Integer = Convert.ToInt32(lblAttempts.Text)
            attempts -= 1
            lblAttempts.Text = attempts.ToString()

            Call updateAttempts()

            If attempts <= 0 Then
                MsgBox("No attempts left. Contact the Admin.")
                btnLogin.Enabled = False
                deactivateActivate()
                Exit Sub
            End If
        End If
        dr.Close()
        cn.Close()
        Me.Hide()
            Admin.Show()

    End Sub
    Private Sub deactivateActivate()
        Call con()
        sql = "UPDATE tblusers SET status = 'Inactive' WHERE user_id = @user_id"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@user_id", txtUsername.Text)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub getAttempts()
        Call con()
        sql = "Select attempts from tblusers where user_id = @user_id"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@user_id", txtUsername.Text)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            lblAttempts.Text = dr("attempts").ToString
        Else
            lblAttempts.Text = 0
        End If
        dr.Close()
        cn.Close()

    End Sub


    Private Sub updateAttempts()
        Call con()
        sql = "Update tblusers set attempts=@attempts where user_id=@user_id"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@user_id", txtUsername.Text)
        cmd.Parameters.AddWithValue("@attempts", lblAttempts.Text)
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("you have clicked this picture")
        Me.Hide()
        FrmAdminPFMO.Show()
    End Sub

End Class
