Imports System.Security.Cryptography.X509Certificates
Imports BUILD_RIGHT_HARDWERE.Form1
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class inputdeclaration
    Public Class LabelSettings
        Public Property Font As Font
        Public Property ForeColor As Color
    End Class
    'Loadform for login form
    Public Sub loadformcon(usernameLabel As Label, passwordLabel As Label)
        If usernameLabel IsNot Nothing Then
            usernameLabel.Tag = New LabelSettings With {.Font = usernameLabel.Font, .ForeColor = usernameLabel.ForeColor}
            usernameLabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            usernameLabel.ForeColor = Color.White
        End If

        If passwordLabel IsNot Nothing Then
            passwordLabel.Tag = New LabelSettings With {.Font = passwordLabel.Font, .ForeColor = passwordLabel.ForeColor}
            passwordLabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            passwordLabel.ForeColor = Color.White
        End If
    End Sub
    Public Sub inputdec(username As String, password As String, usernameLabel As Label, passwordLabel As Label)
        Dim LabelSetting As New LabelSettings
        If (username = "" AndAlso password = "") Then
            usernameLabel.ForeColor = Color.Red
            passwordLabel.ForeColor = Color.Red
            usernameLabel.Text = "Please enter your username"
            passwordLabel.Text = "Please enter your password"
        ElseIf username = "" Then
            usernameLabel.ForeColor = Color.Red
            usernameLabel.Text = "Please enter your username"
            Dim originalSettings As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings.Font
            passwordLabel.ForeColor = originalSettings.ForeColor
            passwordLabel.Text = "PASSWORD :"
        ElseIf password = "" Then
            passwordLabel.ForeColor = Color.Red
            passwordLabel.Text = "Please enter your password"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"

        Else
            ' Restore Font and ForeColor
            If usernameLabel.Tag IsNot Nothing Then
                Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
                usernameLabel.Font = originalSettings.Font
                usernameLabel.ForeColor = originalSettings.ForeColor
            End If

            If passwordLabel.Tag IsNot Nothing Then
                Dim originalSettings As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
                passwordLabel.Font = originalSettings.Font
                passwordLabel.ForeColor = originalSettings.ForeColor
            End If
            usernameLabel.Text = "USERNAME :"
            passwordLabel.Text = "PASSWORD :"
            ' ... (Your actual login validation logic here) ...
        End If
    End Sub

    'Loadform for signup form
    Public Sub loadformconSign(usernameLabel As Label, passwordLabel As Label, confirmPassLabel As Label, rolelabel As Label)
        If usernameLabel IsNot Nothing Then
            usernameLabel.Tag = New LabelSettings With {.Font = usernameLabel.Font, .ForeColor = usernameLabel.ForeColor}
            usernameLabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            usernameLabel.ForeColor = Color.White
        End If
        If passwordLabel IsNot Nothing Then
            passwordLabel.Tag = New LabelSettings With {.Font = usernameLabel.Font, .ForeColor = usernameLabel.ForeColor}
            passwordLabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            passwordLabel.ForeColor = Color.White
        End If
        If confirmPassLabel IsNot Nothing Then
            confirmPassLabel.Tag = New LabelSettings With {.Font = usernameLabel.Font, .ForeColor = usernameLabel.ForeColor}
            confirmPassLabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            confirmPassLabel.ForeColor = Color.White
        End If
        If rolelabel IsNot Nothing Then
            rolelabel.Tag = New LabelSettings With {.Font = usernameLabel.Font, .ForeColor = usernameLabel.ForeColor}
            rolelabel.Font = New Font("Sitka Banner", 8, FontStyle.Bold)
            rolelabel.ForeColor = Color.White
        End If
    End Sub

    Public Sub inputdec(username As String, password As String, confirmPass As String, role As String, usernameLabel As Label, passwordLabel As Label, confirmPassLabel As Label, rolelabel As Label)
        Dim LabelSetting As New LabelSettings
        If String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(password) AndAlso String.IsNullOrEmpty(confirmPass) AndAlso String.IsNullOrEmpty(role) Then
            usernameLabel.ForeColor = Color.Red
            passwordLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            rolelabel.Text = "Choose your role"
            usernameLabel.Text = "enter your username"
            passwordLabel.Text = "enter your password"
            confirmPassLabel.Text = "confirm your password"


        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(password) AndAlso String.IsNullOrEmpty(role) Then
            usernameLabel.ForeColor = Color.Red
            passwordLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            rolelabel.Text = "Choose your role"
            usernameLabel.Text = "enter your username"
            passwordLabel.Text = "confirm your password"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
        ElseIf String.IsNullOrEmpty(password) AndAlso String.IsNullOrEmpty(confirmPass) AndAlso String.IsNullOrEmpty(role) Then
            passwordLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            rolelabel.Text = "Choose your role"
            passwordLabel.Text = "Please enter your password"
            confirmPassLabel.Text = "confirm your password"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(confirmPass) AndAlso String.IsNullOrEmpty(role) Then
            usernameLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            rolelabel.Text = "Choose your role"
            usernameLabel.Text = "enter your username"
            confirmPassLabel.Text = "Please enter your password"
            Dim originalSettings2 As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings2.Font
            passwordLabel.ForeColor = originalSettings2.ForeColor
            passwordLabel.Text = "PASSWORD :"
        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(confirmPass) AndAlso String.IsNullOrEmpty(password) Then
            usernameLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            passwordLabel.ForeColor = Color.Red
            passwordLabel.Text = "enter your password"
            usernameLabel.Text = "enter your username"
            confirmPassLabel.Text = "confirm your password"
            Dim originalSettings2 As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings2.Font
            rolelabel.ForeColor = originalSettings2.ForeColor
            rolelabel.Text = "PASSWORD :"
            'double

        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(password) Then
            usernameLabel.ForeColor = Color.Red
            passwordLabel.ForeColor = Color.Red
            usernameLabel.Text = "enter your username"
            passwordLabel.Text = "confirm your password"
            Dim originalSettings As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings.Font
            rolelabel.ForeColor = originalSettings.ForeColor
            rolelabel.Text = "ROLE :"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
        ElseIf String.IsNullOrEmpty(password) AndAlso String.IsNullOrEmpty(confirmPass) Then
            passwordLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            passwordLabel.Text = "enter your password"
            confirmPassLabel.Text = "confirm your password"
            Dim originalSettings As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings.Font
            rolelabel.ForeColor = originalSettings.ForeColor
            rolelabel.Text = "ROLE :"
            Dim originalSettings2 As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings2.Font
            usernameLabel.ForeColor = originalSettings2.ForeColor
            usernameLabel.Text = "USERNAME :"
        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(confirmPass) Then
            usernameLabel.ForeColor = Color.Red
            confirmPassLabel.ForeColor = Color.Red
            usernameLabel.Text = "enter your username"
            confirmPassLabel.Text = "Please enter your password"
            Dim originalSettings As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings.Font
            rolelabel.ForeColor = originalSettings.ForeColor
            rolelabel.Text = "ROLE :"
            Dim originalSettings2 As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings2.Font
            passwordLabel.ForeColor = originalSettings2.ForeColor
            passwordLabel.Text = "PASSWORD :"
        ElseIf String.IsNullOrEmpty(username) AndAlso String.IsNullOrEmpty(role) Then
            usernameLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            usernameLabel.Text = "enter your username"
            rolelabel.Text = "choose your role"
            Dim originalSettings As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings.Font
            passwordLabel.ForeColor = originalSettings.ForeColor
            passwordLabel.Text = "PASSWORD :"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
        ElseIf String.IsNullOrEmpty(password) AndAlso String.IsNullOrEmpty(role) Then
            passwordLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            passwordLabel.Text = "enter your PASSWORD"
            rolelabel.Text = "choose your role"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
        ElseIf String.IsNullOrEmpty(confirmPass) AndAlso String.IsNullOrEmpty(role) Then
            confirmPassLabel.ForeColor = Color.Red
            rolelabel.ForeColor = Color.Red
            usernameLabel.Text = "confirm your password"
            rolelabel.Text = "choose your role"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
            Dim originalSettings2 As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings2.Font
            passwordLabel.ForeColor = originalSettings2.ForeColor
            passwordLabel.Text = "PASSWORD :"
            'single
        ElseIf String.IsNullOrEmpty(username) Then
            usernameLabel.ForeColor = Color.Red
            usernameLabel.Text = "enter your username"
            Dim originalSettings As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings.Font
            passwordLabel.ForeColor = originalSettings.ForeColor
            passwordLabel.Text = "PASSWORD :"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
            Dim originalSettings3 As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings2.Font
            rolelabel.ForeColor = originalSettings2.ForeColor
            rolelabel.Text = "ROLE :"
        ElseIf String.IsNullOrEmpty(password) Then
            passwordLabel.ForeColor = Color.Red
            passwordLabel.Text = "enter your password"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
            Dim originalSettings2 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            Dim originalSettings3 As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings2.Font
            rolelabel.ForeColor = originalSettings2.ForeColor
            rolelabel.Text = "ROLE :"
            confirmPassLabel.Text = "CONFIRM PASSWORD :"
        ElseIf String.IsNullOrEmpty(confirmPass) Then
            confirmPassLabel.ForeColor = Color.Red
            confirmPassLabel.Text = "enter your password"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
            Dim originalSettings2 As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings2.Font
            passwordLabel.ForeColor = originalSettings2.ForeColor
            passwordLabel.Text = "PASSWORD :"
            Dim originalSettings3 As LabelSettings = DirectCast(rolelabel.Tag, LabelSettings)
            rolelabel.Font = originalSettings2.Font
            rolelabel.ForeColor = originalSettings2.ForeColor
            rolelabel.Text = "ROLE :"
        ElseIf String.IsNullOrEmpty(role) Then
            rolelabel.ForeColor = Color.Red
            rolelabel.Text = "choose your role"
            Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
            usernameLabel.Font = originalSettings.Font
            usernameLabel.ForeColor = originalSettings.ForeColor
            usernameLabel.Text = "USERNAME :"
            Dim originalSettings2 As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
            passwordLabel.Font = originalSettings2.Font
            passwordLabel.ForeColor = originalSettings2.ForeColor
            passwordLabel.Text = "PASSWORD :"
            Dim originalSettings3 As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
            confirmPassLabel.Font = originalSettings2.Font
            confirmPassLabel.ForeColor = originalSettings2.ForeColor
            confirmPassLabel.Text = "CONFIRM PASSWORD :"

        Else
            ' Restore Font and ForeColor
            If usernameLabel.Tag IsNot Nothing Then
                Dim originalSettings As LabelSettings = DirectCast(usernameLabel.Tag, LabelSettings)
                usernameLabel.Font = originalSettings.Font
                usernameLabel.ForeColor = originalSettings.ForeColor
                usernameLabel.Text = "USERNAME :"
            End If

            If passwordLabel.Tag IsNot Nothing Then
                Dim originalSettings As LabelSettings = DirectCast(passwordLabel.Tag, LabelSettings)
                passwordLabel.Font = originalSettings.Font
                passwordLabel.ForeColor = originalSettings.ForeColor
                passwordLabel.Text = "PASSWORD :"
            End If
            If confirmPassLabel.Tag IsNot Nothing Then
                Dim originalSettings As LabelSettings = DirectCast(confirmPassLabel.Tag, LabelSettings)
                confirmPassLabel.Font = originalSettings.Font
                confirmPassLabel.ForeColor = originalSettings.ForeColor
                passwordLabel.Text = "CONFIRM PASSWORD :"
            End If
            Dim mssql As New mssql
            mssql.querySignUp(username, password, confirmPass, role)




            ' ... (Your actual login validation logic here) ...
        End If
    End Sub
End Class
