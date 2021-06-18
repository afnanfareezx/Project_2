Imports MySql.Data.MySqlClient
Public Class FrmOrder
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strBrand As String = txtOrderBrand.Text
        Dim strColour As String = txtBoxOrderColour.Text
        Dim strPrice As String = TxtBoxOrderPrice.Text
        Dim intQuantity As String = NudOrderQuantity.Value
        MySQL_Connection.ConnectionString = conn
        'coding untuk update data dan simpan di database
        MySQL_Command.CommandText = "UPDATE sport_shop SET brand='" & strBrand & "',colour='" & strColour & "',price='" & strPrice & "' ,quantity='" & intQuantity & "' WHERE brand= '" & strBrand & "'"
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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strBrand As String = txtOrderBrand.Text
        Dim strColour As String = txtBoxOrderColour.Text
        Dim strPrice As String = TxtBoxOrderPrice.Text
        Dim intQuantity As Integer = NudOrderQuantity.Value
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