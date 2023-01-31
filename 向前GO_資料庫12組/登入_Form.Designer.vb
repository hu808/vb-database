<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 登入_Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxEM = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.CheckBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.LabelGoToSignUp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Tomato
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Snow
        Me.ButtonClose.Location = New System.Drawing.Point(454, 8)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(33, 33)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogin.FlatAppearance.BorderSize = 0
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(124, 287)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(248, 33)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "登  入"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'TextBoxEM
        '
        Me.TextBoxEM.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEM.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxEM.Location = New System.Drawing.Point(144, 172)
        Me.TextBoxEM.Name = "TextBoxEM"
        Me.TextBoxEM.Size = New System.Drawing.Size(248, 33)
        Me.TextBoxEM.TabIndex = 3
        Me.TextBoxEM.Text = "email"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxPassword.Location = New System.Drawing.Point(144, 211)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(248, 33)
        Me.TextBoxPassword.TabIndex = 4
        Me.TextBoxPassword.Text = "password"
        '
        'CheckBoxShowPass
        '
        Me.CheckBoxShowPass.AutoSize = True
        Me.CheckBoxShowPass.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxShowPass.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxShowPass.Location = New System.Drawing.Point(144, 250)
        Me.CheckBoxShowPass.Name = "CheckBoxShowPass"
        Me.CheckBoxShowPass.Size = New System.Drawing.Size(72, 16)
        Me.CheckBoxShowPass.TabIndex = 10
        Me.CheckBoxShowPass.Text = "顯示密碼"
        Me.CheckBoxShowPass.UseVisualStyleBackColor = False
        '
        'LabelGoToSignUp
        '
        Me.LabelGoToSignUp.AutoSize = True
        Me.LabelGoToSignUp.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoToSignUp.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelGoToSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.LabelGoToSignUp.Location = New System.Drawing.Point(245, 326)
        Me.LabelGoToSignUp.Name = "LabelGoToSignUp"
        Me.LabelGoToSignUp.Size = New System.Drawing.Size(73, 17)
        Me.LabelGoToSignUp.TabIndex = 11
        Me.LabelGoToSignUp.Text = "快去註冊吧"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(180, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "不是會員?"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.向前GO_資料庫12組.My.Resources.Resources.密碼
        Me.PictureBox3.Location = New System.Drawing.Point(107, 211)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.向前GO_資料庫12組.My.Resources.Resources.帳號
        Me.PictureBox2.Location = New System.Drawing.Point(107, 172)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        '登入_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.登入背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelGoToSignUp)
        Me.Controls.Add(Me.CheckBoxShowPass)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEM)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.ButtonClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "登入_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxEM As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents LabelGoToSignUp As Label
    Friend WithEvents Label1 As Label
End Class
