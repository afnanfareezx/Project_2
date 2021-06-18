Imports MySql.Data.MySqlClient
Public Class FrmInsert
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strBrand As String = TxtBoxBrand.Text
        Dim strColour As String = TxtBoxColour.Text
        Dim strPrice As String = txtBoxPrice.Text
        Dim intQuantity As Integer = NudQuantity.Value
        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "INSERT INTO sport_shop VALUES (NULL, '" & strBrand & "', '" & strColour & "', '" & strPrice & "' , '" & intQuantity & "' )"
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()


        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strBrand As String = TxtBoxBrand.Text
        Dim strColour As String = TxtBoxColour.Text
        Dim strPrice As String = txtBoxPrice.Text
        Dim intQuantity As Integer = NudQuantity.Value
        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "DELETE FROM sport_shop WHERE brand=('" & strBrand & "')"
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()


        Form1.Show()
        Me.Close()
    End Sub
End Class