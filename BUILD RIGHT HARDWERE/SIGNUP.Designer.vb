<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._9e201700_c475_40f8_84d2_823606831535___Copy
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(464, 450)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources._472425569_624959366748789_5266003239934004959_n
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(130, 64)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(192, 179)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(92, 141)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(92, 249)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(138, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(92, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 73)
        Label1.TabIndex = 2
        Label1.Text = "BUILD RIGHT HARDWERE"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(92, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 16)
        Label2.TabIndex = 3
        Label2.Text = "USERNAME : "
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Sitka Banner Semibold", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(206), CByte(200))
        Label4.Location = New Point(124, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 5
        Label4.Text = "LOG IN"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(92, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 16)
        Label3.TabIndex = 6
        Label3.Text = "PASSWORD :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("Sitka Banner Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(111, 343)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 39)
        Button1.TabIndex = 7
        Button1.Text = "SIGN UP"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(92, 303)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(138, 23)
        TextBox4.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(92, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 16)
        Label6.TabIndex = 11
        Label6.Text = "CONFIRM PASSWORD :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(69), CByte(130), CByte(180))
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(470, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 450)
        Panel1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Staff", "Customer"})
        ComboBox1.Location = New Point(92, 190)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(92, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 16)
        Label5.TabIndex = 13
        Label5.Text = "ROLE  :"
        ' 
        ' SIGNUP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "SIGNUP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGNUP"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
