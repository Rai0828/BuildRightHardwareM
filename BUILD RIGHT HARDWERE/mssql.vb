Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports SqlCommand = Microsoft.Data.SqlClient.SqlCommand

Public Class mssql

    Public SqlCon As New Microsoft.Data.SqlClient.SqlConnection With {.ConnectionString = "Server=DESKTOP-5PTEBQH\SQLEXPRESS01;Database=BRH_DB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True"}

    Friend ReadOnly Property UpdateDatabase(selectedUser As String, selectedColumn As String, newValue As String) As Object
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub queryLogin(txt1 As String, txt2 As String)
        Try
            Dim q As String = "SELECT COUNT(*) FROM loginTB WHERE Username = @Username AND Password = @Password"
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(q, SqlCon)
                SqlCon.Open()
                cmd.Parameters.AddWithValue("@Username", txt1)
                cmd.Parameters.AddWithValue("@Password", txt2)
                Dim adminCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If adminCount = 0 Then
                    MsgBox("INVALID ACCOUNT!!! SIGN UP FIRST")
                Else
                    Dim q1 As String = "SELECT Role FROM loginTB WHERE Username = @Username AND Password = @Password"
                    Using cmd1 As New Microsoft.Data.SqlClient.SqlCommand(q1, SqlCon)
                        cmd1.Parameters.AddWithValue("@Username", txt1)
                        cmd1.Parameters.AddWithValue("@Password", txt2)

                        Using dr As Microsoft.Data.SqlClient.SqlDataReader = cmd1.ExecuteReader()
                            If dr.Read() Then  ' Move to the first row
                                Dim userRole As String = dr("Role").ToString() ' Get the role value

                                If userRole = "Admin" Then
                                    Dim adminF As New Admin_Form
                                    adminF.Show()
                                    Dim form1 As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
                                    If form1 IsNot Nothing Then
                                        form1.Hide() ' Close Form1
                                    End If
                                ElseIf userRole = "Staff" Then
                                    ' Dim staffF As New Staff_Form
                                    'staffF.Show()
                                ElseIf userRole = "Customer" Then
                                    ' Dim customerF As New Customer_Form
                                    ' customerF.Show()
                                Else
                                    MsgBox("Unknown role detected!")
                                End If
                            Else
                                MsgBox("User role not found!")
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message) ' Display any SQL errors
        End Try


    End Sub


    Public Sub querySignUp(txt1 As String, txt2 As String, txt3 As String, txt4 As String)
        Try
            SqlCon.Open()

            ' Check if an admin already exists
            Dim adminExists As Boolean = False
            Dim q1 As String = "SELECT COUNT(*) FROM loginTB WHERE Role = 'Admin'"

            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(q1, SqlCon)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                adminExists = (count > 0) ' If count > 0, an admin already exists
            End Using

            ' If user selects Admin but one already exists, prevent creation
            If adminExists AndAlso txt4 = "Admin" Then
                MsgBox("There is already an admin, please choose 'Staff' or 'Customer'.")
                Exit Sub
            End If

            ' Check if passwords match
            If txt2 <> txt3 Then
                MsgBox("Passwords do not match.")
                Exit Sub
            End If

            ' Insert new account
            Dim q2 As String = "INSERT INTO loginTB (Username, Password, Role) VALUES (@Username, @Password, @Role)"
            Using cmd1 As New Microsoft.Data.SqlClient.SqlCommand(q2, SqlCon)
                cmd1.Parameters.AddWithValue("@Username", txt1)
                cmd1.Parameters.AddWithValue("@Password", txt2)
                cmd1.Parameters.AddWithValue("@Role", txt4) ' Allow user to choose Staff/Customer/Admin

                cmd1.ExecuteNonQuery()
                MsgBox("Successfully created account with role: " & txt4)
            End Using

        Catch ex As Exception
            Console.WriteLine("Error in query: " & ex.Message)
        Finally
            SqlCon.Close()
        End Try
    End Sub

    Public Sub loadingTable(DataGridView1 As DataGridView) ' Pass the DataGridView as a parameter
        Dim q As String = "SELECT TABLE_NAME AS TABLES FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'" 'Added where clause
        Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(q, SqlCon)
        Dim da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd) ' Use SqlDataAdapter
        Dim dt As New DataTable() ' Create a DataTable

        Try
            SqlCon.Open()
            da.Fill(dt) ' Fill the DataTable with the results
            DataGridView1.DataSource = dt ' Set the DataGridView's DataSource
        Catch ex As Exception
            MessageBox.Show("Error loading tables: " & ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()
            End If
        End Try

    End Sub

    Public Function GetTableData(tableName As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            SqlCon.Open()
            Dim query As String = "SELECT * FROM [" & tableName & "]"
            Using adapter As New Microsoft.Data.SqlClient.SqlDataAdapter(query, SqlCon)
                adapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading table data: " & ex.Message)
        Finally
            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()
            End If
        End Try

        Return dataTable
    End Function

    Public Sub updateQuery(selectedUser As String, selectedColumn As String, newValue As String)

        Try
            Dim query As String = "UPDATE loginTB SET " & selectedColumn & " = @newValue WHERE Username = @userName"
            Using cmd As New SqlCommand(query, SqlCon)
                SqlCon.Open()
                cmd.Parameters.AddWithValue("@newValue", newValue)
                cmd.Parameters.AddWithValue("@userName", selectedUser)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Update successful!")
                Else
                    MessageBox.Show("Update failed!")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SqlCon.Close()
        End Try
    End Sub






End Class