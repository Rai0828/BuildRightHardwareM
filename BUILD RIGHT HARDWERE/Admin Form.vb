Public Class Admin_Form
    Private selectedUser As String ' Store the selected user (username)
    Private selectedColumn As String
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
        If e.RowIndex >= 0 Then ' Check if a valid row was clicked
            Dim selectedTableName = DataGridView1.Rows(e.RowIndex).Cells("TABLES").Value.ToString ' Get the table name from the clicked row
            Dim sqlQueries As New mssql ' Create an instance of the mssql class
            Dim tableData = sqlQueries.GetTableData(selectedTableName) ' Call GetTableData with the clicked table name
            DataGridView1.Hide()
            DataGridView2.Show()
            DataGridView2.DataSource = tableData ' Display data in DataGridView2
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
            ' Assuming that the "Username" column exists in DataGridView2
            selectedUser = DataGridView2.Rows(e.RowIndex).Cells("Username").Value.ToString() ' Access the Username from the data of the table
            selectedColumn = DataGridView2.Columns(e.ColumnIndex).Name ' Store the column name of the clicked cell
            TextBoxUpdate.Text = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' Show current value in textbox for updating
            Panel6.Visible = True ' Show the update panel for modifying the value
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim newValue As String = TextBoxUpdate.Text.Trim() ' Get the new value from the TextBox

        If Not String.IsNullOrEmpty(newValue) Then
            ' Call the method from mssql class to update the database
            Dim sqlQueries As New mssql

            ' Update the DataGridView with the new value   
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim colIndex As Integer = DataGridView1.CurrentCell.ColumnIndex
            DataGridView1.Rows(rowIndex).Cells(colIndex).Value = newValue

            ' Call updateQuery to update the database
            sqlQueries.updateQuery(selectedUser, selectedColumn, newValue)
            Panel6.Visible = False ' Hide the panel after saving
        Else
            MessageBox.Show("Please enter a value to update.")
        End If

    End Sub
End Class