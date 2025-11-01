Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        userLogin()

    End Sub

    Private Sub userLogin()
        databaseConnection.con()
        sql = "SELECT * FROM tblusers WHERE user_id = @user_id AND password = @password AND status = 'Active' AND attempts > 0"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

        If databaseConnection.dr.Read = True Then
            Dim role As String = databaseConnection.dr("role").ToString()

            databaseConnection.currentUserId = Convert.ToInt32(databaseConnection.dr("user_id"))
            databaseConnection.currentUsername = databaseConnection.dr("user_id").ToString()
            databaseConnection.currentUserRole = role
            databaseConnection.isLoggedIn = True

            databaseConnection.dr.Close()
            databaseConnection.cn.Close()
            Call getAttempts()
            frmUser.Show()
            Me.Hide()
            txtID.Clear()
            txtPassword.Clear()
            Exit Sub
        End If

        databaseConnection.dr.Close()
        databaseConnection.cn.Close()

        databaseConnection.con()
        sql = "SELECT * FROM tbladmin_users WHERE admin_id = @user_id AND password = @password"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

        If databaseConnection.dr.Read() Then
            Dim role As String = "Admin"

            databaseConnection.currentAdminId = Convert.ToInt32(databaseConnection.dr("admin_id"))
            databaseConnection.currentUsername = databaseConnection.dr("username").ToString()

            Dim firstName As String = If(IsDBNull(databaseConnection.dr("FirstName")), "", databaseConnection.dr("FirstName").ToString())
            Dim middleName As String = If(IsDBNull(databaseConnection.dr("Middle_Name")), "", databaseConnection.dr("Middle_Name").ToString())
            Dim lastName As String = If(IsDBNull(databaseConnection.dr("LastName")), "", databaseConnection.dr("LastName").ToString())
            databaseConnection.currentFullName = (firstName & " " & middleName & " " & lastName).Trim()

            databaseConnection.currentUserRole = role
            databaseConnection.isLoggedIn = True

            databaseConnection.dr.Close()
            databaseConnection.cn.Close()

            frmAdmin.Show()
            Me.Hide()
            txtID.Clear()
            txtPassword.Clear()
            Exit Sub
        End If

        databaseConnection.dr.Close()
        databaseConnection.cn.Close()

        databaseConnection.con()
        sql = "Select Count(*) from tblusers where user_id=@user_id"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        Dim isUser As Integer = Convert.ToInt32(databaseConnection.cmd.ExecuteScalar())
        databaseConnection.cn.Close()

        databaseConnection.con()
        sql = "Select Count(*) from tbladmin_users where admin_id=@user_id"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        Dim isAdmin As Integer = Convert.ToInt32(databaseConnection.cmd.ExecuteScalar())
        databaseConnection.cn.Close()

        MsgBox("Login Failed, Invalid user ID or password", MsgBoxStyle.Exclamation)

        If isUser > 0 Then
            databaseConnection.con()
            sql = "SELECT attempts FROM tblusers WHERE user_id=@user_id"
            databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
            databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
            Dim currAttempts As Integer = Convert.ToInt32(databaseConnection.cmd.ExecuteScalar())
            databaseConnection.cn.Close()

            If currAttempts > 0 Then
                callAttempts()
                getAttempts()
                MsgBox("Attempts remaining: " & lblAttempts.Text, MsgBoxStyle.Information)
            Else
                MsgBox("Account already deactivated or no attempts left.", MsgBoxStyle.Critical)
            End If
        ElseIf isAdmin > 0 Then
            Exit Sub
        End If
    End Sub



    Private Sub callAttempts()
        getAttempts()
        Dim attempts As Integer = Convert.ToInt32(lblAttempts.Text)

        If attempts <= 0 Then
            MsgBox("Account already deactivated. Contact the Admin.")
            deactivateActivate()
            Exit Sub
        End If

        attempts -= 1
        lblAttempts.Text = attempts.ToString()
        updateAttempts()

        If attempts <= 0 Then
            MsgBox("No attempts left. Contact the Admin.")
            deactivateActivate()
            Exit Sub
        End If
    End Sub


    Private Sub deactivateActivate()
        databaseConnection.con()
        sql = "UPDATE tblusers SET status = 'Deactivated' WHERE user_id = @user_id"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        databaseConnection.cmd.ExecuteNonQuery()
        databaseConnection.cn.Close()
    End Sub



    Private Sub getAttempts()
        'GET ATTEMPTS LANG AND THEN DISPLAY
        databaseConnection.con()
        sql = "Select attempts from tblusers where user_id = @user_id"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        databaseConnection.dr = databaseConnection.cmd.ExecuteReader()

        If databaseConnection.dr.Read = True Then
            lblAttempts.Text = databaseConnection.dr("attempts").ToString()
        Else
            lblAttempts.Text = 0
        End If
        databaseConnection.dr.Close()
        databaseConnection.cn.Close()

    End Sub


    Private Sub updateAttempts()
        'UPDATE SA DATABASE
        databaseConnection.con()
        sql = "Update tblusers set attempts=@attempts where user_id=@user_id"
        databaseConnection.cmd = New MySqlCommand(sql, databaseConnection.cn)
        databaseConnection.cmd.Parameters.AddWithValue("@user_id", txtID.Text)
        databaseConnection.cmd.Parameters.AddWithValue("@attempts", lblAttempts.Text)
        databaseConnection.cmd.ExecuteNonQuery()
        databaseConnection.cn.Close()

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

End Class
