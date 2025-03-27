<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button1 = New Button()
        passwordLabel = New Label()
        Label4 = New Label()
        usernameLabel = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(69), CByte(130), CByte(180))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(passwordLabel)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(usernameLabel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(470, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 450)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("Sitka Banner Semibold", 9.749999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(116, 275)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 39)
        Button1.TabIndex = 7
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' passwordLabel
        ' 
        passwordLabel.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passwordLabel.ForeColor = SystemColors.ButtonHighlight
        passwordLabel.Location = New Point(92, 203)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(138, 25)
        passwordLabel.TabIndex = 6
        passwordLabel.Text = "PASSWORD :"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Sitka Banner Semibold", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(206), CByte(200))
        Label4.Location = New Point(125, 357)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 5
        Label4.Text = "SIGN UP"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLabel.ForeColor = SystemColors.ButtonHighlight
        usernameLabel.Location = New Point(92, 137)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(138, 25)
        usernameLabel.TabIndex = 3
        usernameLabel.Text = "USERNAME : "
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(92, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 73)
        Label1.TabIndex = 2
        Label1.Text = "BUILD RIGHT HARDWERE"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(92, 231)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(138, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(92, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(471, 450)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources._472425569_624959366748789_5266003239934004959_n
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(132, 64)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(192, 179)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._9e201700_c475_40f8_84d2_823606831535___Copy
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(464, 450)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MaximumSize = New Size(1440, 1024)
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents Button1 As Button

End Class
