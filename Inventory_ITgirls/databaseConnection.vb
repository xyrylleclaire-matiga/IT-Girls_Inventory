Imports MySql.Data.MySqlClient
Module databaseConnection
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public sql As String
    Public Sub con()
        cn.Close()
        cn.ConnectionString = "server=localhost; password =; user=root; database=inventory_db "
        cn.Open()
        'MsgBox("Connection Success!")
    End Sub
End Module
