<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 註冊_Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TextBoxRealname = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelRN = New System.Windows.Forms.Label()
        Me.TextBoxName2 = New System.Windows.Forms.TextBox()
        Me.LabelN2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEM = New System.Windows.Forms.Label()
        Me.LabelPass1 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.LabelPass2 = New System.Windows.Forms.Label()
        Me.LabelPH = New System.Windows.Forms.Label()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.CheckBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelGoToSignIn = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.LabelAD = New System.Windows.Forms.Label()
        Me.LabelBirth = New System.Windows.Forms.Label()
        Me.DateTimePickerBirth = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxUserPicture = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Location = New System.Drawing.Point(143, 523)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(335, 49)
        Me.ButtonRegister.TabIndex = 18
        Me.ButtonRegister.Text = "註  冊"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'TextBoxRealname
        '
        Me.TextBoxRealname.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxRealname.ForeColor = System.Drawing.Color.Black
        Me.TextBoxRealname.Location = New System.Drawing.Point(113, 181)
        Me.TextBoxRealname.Name = "TextBoxRealname"
        Me.TextBoxRealname.Size = New System.Drawing.Size(190, 33)
        Me.TextBoxRealname.TabIndex = 19
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPassword.Location = New System.Drawing.Point(113, 392)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(180, 33)
        Me.TextBoxPassword.TabIndex = 20
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'LabelRN
        '
        Me.LabelRN.AutoSize = True
        Me.LabelRN.BackColor = System.Drawing.Color.Transparent
        Me.LabelRN.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelRN.ForeColor = System.Drawing.Color.White
        Me.LabelRN.Location = New System.Drawing.Point(110, 163)
        Me.LabelRN.Name = "LabelRN"
        Me.LabelRN.Size = New System.Drawing.Size(80, 16)
        Me.LabelRN.TabIndex = 21
        Me.LabelRN.Text = "*真實姓名"
        '
        'TextBoxName2
        '
        Me.TextBoxName2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxName2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxName2.Location = New System.Drawing.Point(321, 181)
        Me.TextBoxName2.Name = "TextBoxName2"
        Me.TextBoxName2.Size = New System.Drawing.Size(180, 33)
        Me.TextBoxName2.TabIndex = 22
        '
        'LabelN2
        '
        Me.LabelN2.AutoSize = True
        Me.LabelN2.BackColor = System.Drawing.Color.Transparent
        Me.LabelN2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelN2.ForeColor = System.Drawing.Color.White
        Me.LabelN2.Location = New System.Drawing.Point(318, 163)
        Me.LabelN2.Name = "LabelN2"
        Me.LabelN2.Size = New System.Drawing.Size(48, 16)
        Me.LabelN2.TabIndex = 23
        Me.LabelN2.Text = "*綽號"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxEmail.ForeColor = System.Drawing.Color.Black
        Me.TextBoxEmail.Location = New System.Drawing.Point(113, 232)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(388, 33)
        Me.TextBoxEmail.TabIndex = 26
        '
        'LabelEM
        '
        Me.LabelEM.AutoSize = True
        Me.LabelEM.BackColor = System.Drawing.Color.Transparent
        Me.LabelEM.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelEM.ForeColor = System.Drawing.Color.White
        Me.LabelEM.Location = New System.Drawing.Point(110, 215)
        Me.LabelEM.Name = "LabelEM"
        Me.LabelEM.Size = New System.Drawing.Size(60, 16)
        Me.LabelEM.TabIndex = 27
        Me.LabelEM.Text = "* Email:"
        '
        'LabelPass1
        '
        Me.LabelPass1.AutoSize = True
        Me.LabelPass1.BackColor = System.Drawing.Color.Transparent
        Me.LabelPass1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPass1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelPass1.Location = New System.Drawing.Point(110, 373)
        Me.LabelPass1.Name = "LabelPass1"
        Me.LabelPass1.Size = New System.Drawing.Size(52, 16)
        Me.LabelPass1.TabIndex = 28
        Me.LabelPass1.Text = "* 密碼"
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(321, 395)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(180, 33)
        Me.TextBoxConfirmPassword.TabIndex = 29
        Me.TextBoxConfirmPassword.UseSystemPasswordChar = True
        '
        'LabelPass2
        '
        Me.LabelPass2.AutoSize = True
        Me.LabelPass2.BackColor = System.Drawing.Color.Transparent
        Me.LabelPass2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPass2.ForeColor = System.Drawing.Color.White
        Me.LabelPass2.Location = New System.Drawing.Point(318, 376)
        Me.LabelPass2.Name = "LabelPass2"
        Me.LabelPass2.Size = New System.Drawing.Size(116, 16)
        Me.LabelPass2.TabIndex = 30
        Me.LabelPass2.Text = "* 再次輸入密碼"
        '
        'LabelPH
        '
        Me.LabelPH.AutoSize = True
        Me.LabelPH.BackColor = System.Drawing.Color.Transparent
        Me.LabelPH.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPH.ForeColor = System.Drawing.Color.White
        Me.LabelPH.Location = New System.Drawing.Point(110, 267)
        Me.LabelPH.Name = "LabelPH"
        Me.LabelPH.Size = New System.Drawing.Size(52, 16)
        Me.LabelPH.TabIndex = 25
        Me.LabelPH.Text = "* 手機"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxPhone.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPhone.Location = New System.Drawing.Point(113, 284)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(388, 33)
        Me.TextBoxPhone.TabIndex = 24
        '
        'CheckBoxShowPass
        '
        Me.CheckBoxShowPass.AutoSize = True
        Me.CheckBoxShowPass.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxShowPass.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxShowPass.Location = New System.Drawing.Point(168, 375)
        Me.CheckBoxShowPass.Name = "CheckBoxShowPass"
        Me.CheckBoxShowPass.Size = New System.Drawing.Size(72, 16)
        Me.CheckBoxShowPass.TabIndex = 31
        Me.CheckBoxShowPass.Text = "顯示密碼"
        Me.CheckBoxShowPass.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Tomato
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Snow
        Me.ButtonClose.Location = New System.Drawing.Point(558, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(45, 45)
        Me.ButtonClose.TabIndex = 32
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(242, 578)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "不是會員?"
        '
        'LabelGoToSignIn
        '
        Me.LabelGoToSignIn.AutoSize = True
        Me.LabelGoToSignIn.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoToSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoToSignIn.Font = New System.Drawing.Font("微軟正黑體", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelGoToSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.LabelGoToSignIn.Location = New System.Drawing.Point(314, 578)
        Me.LabelGoToSignIn.Name = "LabelGoToSignIn"
        Me.LabelGoToSignIn.Size = New System.Drawing.Size(73, 17)
        Me.LabelGoToSignIn.TabIndex = 35
        Me.LabelGoToSignIn.Text = "快去登入吧"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.TextBoxAddress.ForeColor = System.Drawing.Color.Black
        Me.TextBoxAddress.Location = New System.Drawing.Point(113, 336)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(388, 33)
        Me.TextBoxAddress.TabIndex = 36
        '
        'LabelAD
        '
        Me.LabelAD.AutoSize = True
        Me.LabelAD.BackColor = System.Drawing.Color.Transparent
        Me.LabelAD.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelAD.ForeColor = System.Drawing.Color.White
        Me.LabelAD.Location = New System.Drawing.Point(110, 319)
        Me.LabelAD.Name = "LabelAD"
        Me.LabelAD.Size = New System.Drawing.Size(52, 16)
        Me.LabelAD.TabIndex = 37
        Me.LabelAD.Text = "* 地址"
        '
        'LabelBirth
        '
        Me.LabelBirth.AutoSize = True
        Me.LabelBirth.BackColor = System.Drawing.Color.Transparent
        Me.LabelBirth.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelBirth.ForeColor = System.Drawing.Color.White
        Me.LabelBirth.Location = New System.Drawing.Point(110, 428)
        Me.LabelBirth.Name = "LabelBirth"
        Me.LabelBirth.Size = New System.Drawing.Size(52, 16)
        Me.LabelBirth.TabIndex = 38
        Me.LabelBirth.Text = "* 生日"
        '
        'DateTimePickerBirth
        '
        Me.DateTimePickerBirth.CustomFormat = "dd//MM/yyyy"
        Me.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerBirth.Location = New System.Drawing.Point(113, 447)
        Me.DateTimePickerBirth.Name = "DateTimePickerBirth"
        Me.DateTimePickerBirth.Size = New System.Drawing.Size(189, 22)
        Me.DateTimePickerBirth.TabIndex = 40
        '
        'PictureBoxUserPicture
        '
        Me.PictureBoxUserPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBoxUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserPicture.Location = New System.Drawing.Point(321, 434)
        Me.PictureBoxUserPicture.Name = "PictureBoxUserPicture"
        Me.PictureBoxUserPicture.Size = New System.Drawing.Size(100, 83)
        Me.PictureBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUserPicture.TabIndex = 41
        Me.PictureBoxUserPicture.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "上傳頭像"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '註冊_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.註冊背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxUserPicture)
        Me.Controls.Add(Me.DateTimePickerBirth)
        Me.Controls.Add(Me.LabelBirth)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.LabelAD)
        Me.Controls.Add(Me.LabelGoToSignIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.CheckBoxShowPass)
        Me.Controls.Add(Me.TextBoxPhone)
        Me.Controls.Add(Me.LabelPH)
        Me.Controls.Add(Me.LabelPass2)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.LabelPass1)
        Me.Controls.Add(Me.LabelEM)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.LabelN2)
        Me.Controls.Add(Me.TextBoxName2)
        Me.Controls.Add(Me.LabelRN)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxRealname)
        Me.Controls.Add(Me.ButtonRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "註冊_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "註冊_Form"
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents TextBoxRealname As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelRN As Label
    Friend WithEvents TextBoxName2 As TextBox
    Friend WithEvents LabelN2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEM As Label
    Friend WithEvents LabelPass1 As Label
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents LabelPass2 As Label
    Friend WithEvents LabelPH As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelGoToSignIn As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents LabelAD As Label
    Friend WithEvents LabelBirth As Label
    Friend WithEvents DateTimePickerBirth As DateTimePicker
    Friend WithEvents PictureBoxUserPicture As PictureBox
    Friend WithEvents Button1 As Button
End Class
