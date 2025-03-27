Public Class Admin_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1
        form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mssql As New mssql
        mssql.loadingTable(DataGridView1)
    End Sub

    Private Sub Admin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then ' Check if a valid row was clicked
            Dim selectedTableName As String = DataGridView1.Rows(e.RowIndex).Cells("TABLES").Value.ToString() ' Get the table name from the clicked row
            Dim sqlQueries As New mssql() ' Create an instance of the mssql class
            Dim tableData As DataTable = sqlQueries.GetTableData(selectedTableName) ' Call GetTableData with the clicked table name
            DataGridView1.DataSource = tableData ' Display data in DataGridView2
        End If
    End Sub
End Class