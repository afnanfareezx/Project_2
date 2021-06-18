Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "SELECT * FROM sport_shop "
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()
        MySQL_Connection = Nothing
        Reader = Nothing


        Dim row As DataRow
        For Each row In table.Rows
            dgvSport.Rows.Add(row("brand"), row("colour"), row("price"), row("quantity"))
        Next
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        FrmInsert.Show()
        Me.Hide()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim exitShop As DialogResult = MessageBox.Show("Are you sure?", "D.A.N SPORTS SHOP",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitShop = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub dgvSport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSport.CellContentClick
        Dim conn As String
        conn = "server=localhost;userid=root;password=;Database=Project2"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand

        Dim strBrand As String
        If e.RowIndex < 0 Then Exit Sub
        strBrand = dgvSport.Item(0, e.RowIndex).Value.ToString()
        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "SELECT * FROM sport_shop WHERE brand = '" + strBrand + "'"
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()
        MySQL_Connection = Nothing
        Reader = Nothing

        Dim row As DataRow
        For Each row In table.Rows
            lblBrand.Text = "Brand : " + row("brand").ToString
            lblBrandcolour.Text = "Brand Colour : " + row("colour").ToString
            lblBrnadprice.Text = "Brand Price : (RM)" + row("price").ToString
            lblQuantity.Text = "Brand Quantity : " + row("quantity").ToString
        Next

        For Each row In table.Rows
            FrmOrder.Show()
            FrmOrder.txtOrderBrand.Text = row("brand").ToString
            FrmOrder.txtBoxOrderColour.Text = row("colour").ToString
            FrmOrder.TxtBoxOrderPrice.Text = row("price").ToString
            FrmOrder.NudOrderQuantity.Value = row("quantity").ToString
        Next
    End Sub

End Class
