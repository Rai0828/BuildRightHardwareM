<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        Button6 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        ButtonUpdate = New Button()
        TextBoxUpdate = New TextBox()
        DataGridView2 = New DataGridView()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        Panel4 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 450)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(69), CByte(130), CByte(180))
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(12, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(145, 426)
        Panel3.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Silver
        Button6.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(31, 314)
        Button6.Name = "Button6"
        Button6.Size = New Size(78, 29)
        Button6.TabIndex = 14
        Button6.Text = "LOGOUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Banner", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(37, 232)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 16)
        Label7.TabIndex = 7
        Label7.Text = "SUPPLIERS"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Banner", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(19, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 17)
        Label6.TabIndex = 6
        Label6.Text = "VIEW OF SALES"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Banner", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(37, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 16)
        Label5.TabIndex = 5
        Label5.Text = "ACCOUNTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources._472425569_624959366748789_5266003239934004959_n
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(31, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 82)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(163, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(637, 450)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(69), CByte(130), CByte(180))
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(DataGridView2)
        Panel5.Controls.Add(Button5)
        Panel5.Controls.Add(Button4)
        Panel5.Controls.Add(Button3)
        Panel5.Controls.Add(Button2)
        Panel5.Controls.Add(DataGridView1)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(11, 168)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(614, 270)
        Panel5.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel6.Controls.Add(ButtonUpdate)
        Panel6.Controls.Add(TextBoxUpdate)
        Panel6.Location = New Point(252, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(199, 231)
        Panel6.TabIndex = 11
        ' 
        ' ButtonUpdate
        ' 
        ButtonUpdate.BackColor = Color.Silver
        ButtonUpdate.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonUpdate.Location = New Point(60, 101)
        ButtonUpdate.Name = "ButtonUpdate"
        ButtonUpdate.Size = New Size(78, 29)
        ButtonUpdate.TabIndex = 15
        ButtonUpdate.Text = "UPDATE"
        ButtonUpdate.UseVisualStyleBackColor = False
        ' 
        ' TextBoxUpdate
        ' 
        TextBoxUpdate.Location = New Point(42, 37)
        TextBoxUpdate.Name = "TextBoxUpdate"
        TextBoxUpdate.Size = New Size(114, 23)
        TextBoxUpdate.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.Silver
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(118, 34)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(481, 222)
        DataGridView2.TabIndex = 17
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Silver
        Button5.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(21, 217)
        Button5.Name = "Button5"
        Button5.Size = New Size(78, 29)
        Button5.TabIndex = 16
        Button5.Text = "ARCHIVE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Silver
        Button4.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(21, 158)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 29)
        Button4.TabIndex = 15
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(21, 94)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 29)
        Button3.TabIndex = 14
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(21, 34)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 29)
        Button2.TabIndex = 13
        Button2.Text = "LOAD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Silver
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(118, 34)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(481, 222)
        DataGridView1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(307, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 31)
        Label4.TabIndex = 11
        Label4.Text = "ACCOUNTS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(69), CByte(130), CByte(180))
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(ComboBox1)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(TextBox2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Location = New Point(11, 12)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(614, 139)
        Panel4.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(220, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 31)
        Label1.TabIndex = 10
        Label1.Text = "CREATE ACCOUNT"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(334, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 29)
        Button1.TabIndex = 9
        Button1.Text = "CREATE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(321, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(143, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(47, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 7
        Label3.Text = "PASSWORD :"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Banner", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(47, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 16)
        Label2.TabIndex = 4
        Label2.Text = "USERNAME : "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(47, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(149, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Admin_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Admin_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_Form"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBoxUpdate As TextBox
    Friend WithEvents ButtonUpdate As Button
End Class
