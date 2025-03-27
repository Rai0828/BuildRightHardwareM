Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputdec As New inputdeclaration
        inputdec.inputdec(TextBox1.Text, TextBox2.Text, usernameLabel, passwordLabel)
        Dim mssql As New mssql
        mssql.queryLogin(TextBox1.Text, TextBox2.Text)

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim signupForm As New SIGNUP()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inputdec As New inputdeclaration
        inputdec.loadformcon(usernameLabel, passwordLabel)


    End Sub
End Class
