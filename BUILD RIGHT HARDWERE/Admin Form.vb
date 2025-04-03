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
        DataGridView1.Show()
        DataGridView2.Hide()
        Panel6.Hide()
        mssql.loadingTable(DataGridView1)

    End Sub

    Private Sub Admin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Ensure a valid cell is clicked\

            TextBoxUpdate.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' Copy cell value to textbox
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
            Dim oldUsername As String = row.Cells(0).Value.ToString() ' Get clicked usernam
            TextBoxUpdate.Text = oldUsername
            oldUsername = TextBoxUpdate.Text

        End If


    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then ' Check if a valid row was clicked
            Dim selectedTableName = DataGridView1.Rows(e.RowIndex).Cells("TABLES").Value.ToString ' Get the table name from the clicked row
            Dim sqlQueries As New mssql ' Create an instance of the mssql class
            Dim tableData = sqlQueries.GetTableData(selectedTableName) ' Call GetTableData with the clicked table name
            DataGridView1.Hide()
            DataGridView2.Show()
            DataGridView2.DataSource = tableData ' Display data in DataGridView2
        End If
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel6.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            TextBoxUpdate.Text = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' Use DataGridView1
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click


    End Sub
End Class