Public Class SIGNUP
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputdec As New inputdeclaration
        inputdec.inputdec(TextBox1.Text, TextBox2.Text, TextBox4.Text, ComboBox1.Text, Label2, Label3, Label6, Label5)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SIGNUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inputdec As New inputdeclaration
        inputdec.loadformconSign(Label2, Label3, Label6, Label5)
    End Sub
End Class