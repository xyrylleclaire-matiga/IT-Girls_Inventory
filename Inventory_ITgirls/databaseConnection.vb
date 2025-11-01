Imports MySql.Data.MySqlClient
Module databaseConnection
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public currentAdminId As Integer = 0
    Public currentUserId As Integer = 0
    Public currentUsername As String = ""
    Public currentFullName As String = ""
    Public currentUserRole As String = "" ' "Admin" or "User"
    Public isLoggedIn As Boolean = False

    Public sql As String
    Public Sub con()
        cn.Close()
        cn.ConnectionString = "server=localhost; password =; user=root; database=inventory_db "
        cn.Open()
        'MsgBox("Connection Success!")
    End Sub
End Module
