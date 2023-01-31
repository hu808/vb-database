<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 許願池_Form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Labeluser = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonMy紀錄 = New System.Windows.Forms.Button()
        Me.ButtonMy檔案 = New System.Windows.Forms.Button()
        Me.TextBoxPrice1 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBoxProduct1 = New System.Windows.Forms.TextBox()
        Me.ButtonBuy1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMy = New System.Windows.Forms.Button()
        Me.ButtonWish = New System.Windows.Forms.Button()
        Me.ButtonMainGo = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.許願池背景
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Labeluser)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.ButtonMy紀錄)
        Me.Panel1.Controls.Add(Me.ButtonMy檔案)
        Me.Panel1.Controls.Add(Me.TextBoxPrice1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.TextBoxProduct1)
        Me.Panel1.Controls.Add(Me.ButtonBuy1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonMy)
        Me.Panel1.Controls.Add(Me.ButtonWish)
        Me.Panel1.Controls.Add(Me.ButtonMainGo)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 483)
        Me.Panel1.TabIndex = 0
        '
        'Labeluser
        '
        Me.Labeluser.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labeluser.ForeColor = System.Drawing.Color.White
        Me.Labeluser.Location = New System.Drawing.Point(17, 260)
        Me.Labeluser.Name = "Labeluser"
        Me.Labeluser.Size = New System.Drawing.Size(72, 32)
        Me.Labeluser.TabIndex = 72
        Me.Labeluser.Text = "1"
        Me.Labeluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 71
        '
        'ButtonMy紀錄
        '
        Me.ButtonMy紀錄.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonMy紀錄.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.我的紀錄
        Me.ButtonMy紀錄.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMy紀錄.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMy紀錄.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonMy紀錄.FlatAppearance.BorderSize = 0
        Me.ButtonMy紀錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMy紀錄.Location = New System.Drawing.Point(658, 374)
        Me.ButtonMy紀錄.Name = "ButtonMy紀錄"
        Me.ButtonMy紀錄.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy紀錄.TabIndex = 70
        Me.ButtonMy紀錄.UseVisualStyleBackColor = False
        '
        'ButtonMy檔案
        '
        Me.ButtonMy檔案.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonMy檔案.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.我的檔案
        Me.ButtonMy檔案.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMy檔案.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMy檔案.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonMy檔案.FlatAppearance.BorderSize = 0
        Me.ButtonMy檔案.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMy檔案.Location = New System.Drawing.Point(726, 374)
        Me.ButtonMy檔案.Name = "ButtonMy檔案"
        Me.ButtonMy檔案.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy檔案.TabIndex = 69
        Me.ButtonMy檔案.UseVisualStyleBackColor = False
        '
        'TextBoxPrice1
        '
        Me.TextBoxPrice1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TextBoxPrice1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrice1.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxPrice1.Location = New System.Drawing.Point(478, 318)
        Me.TextBoxPrice1.Name = "TextBoxPrice1"
        Me.TextBoxPrice1.Size = New System.Drawing.Size(144, 35)
        Me.TextBoxPrice1.TabIndex = 63
        Me.TextBoxPrice1.Text = "$ 期望價格"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.向前GO_資料庫12組.My.Resources.Resources.wish_logo
        Me.PictureBox4.Location = New System.Drawing.Point(173, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(470, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'TextBoxProduct1
        '
        Me.TextBoxProduct1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TextBoxProduct1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProduct1.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBoxProduct1.Location = New System.Drawing.Point(173, 318)
        Me.TextBoxProduct1.Name = "TextBoxProduct1"
        Me.TextBoxProduct1.Size = New System.Drawing.Size(266, 35)
        Me.TextBoxProduct1.TabIndex = 60
        Me.TextBoxProduct1.Text = "商品名稱"
        '
        'ButtonBuy1
        '
        Me.ButtonBuy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonBuy1.FlatAppearance.BorderSize = 0
        Me.ButtonBuy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuy1.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonBuy1.ForeColor = System.Drawing.Color.White
        Me.ButtonBuy1.Location = New System.Drawing.Point(250, 365)
        Me.ButtonBuy1.Name = "ButtonBuy1"
        Me.ButtonBuy1.Size = New System.Drawing.Size(298, 45)
        Me.ButtonBuy1.TabIndex = 58
        Me.ButtonBuy1.Text = "許     願"
        Me.ButtonBuy1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.向前GO_資料庫12組.My.Resources.Resources.wish
        Me.PictureBox2.Location = New System.Drawing.Point(256, 76)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(292, 232)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.向前GO_資料庫12組.My.Resources.Resources.許願池logo
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'ButtonMy
        '
        Me.ButtonMy.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonMy.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.我的底
        Me.ButtonMy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonMy.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonMy.FlatAppearance.BorderSize = 0
        Me.ButtonMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMy.Location = New System.Drawing.Point(533, 421)
        Me.ButtonMy.Name = "ButtonMy"
        Me.ButtonMy.Size = New System.Drawing.Size(266, 61)
        Me.ButtonMy.TabIndex = 54
        Me.ButtonMy.UseVisualStyleBackColor = False
        '
        'ButtonWish
        '
        Me.ButtonWish.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonWish.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.許願底
        Me.ButtonWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonWish.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonWish.FlatAppearance.BorderSize = 2
        Me.ButtonWish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWish.Location = New System.Drawing.Point(267, 421)
        Me.ButtonWish.Name = "ButtonWish"
        Me.ButtonWish.Size = New System.Drawing.Size(266, 61)
        Me.ButtonWish.TabIndex = 53
        Me.ButtonWish.UseVisualStyleBackColor = False
        '
        'ButtonMainGo
        '
        Me.ButtonMainGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonMainGo.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.團go底
        Me.ButtonMainGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonMainGo.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonMainGo.FlatAppearance.BorderSize = 0
        Me.ButtonMainGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMainGo.Location = New System.Drawing.Point(1, 421)
        Me.ButtonMainGo.Name = "ButtonMainGo"
        Me.ButtonMainGo.Size = New System.Drawing.Size(266, 61)
        Me.ButtonMainGo.TabIndex = 52
        Me.ButtonMainGo.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Tomato
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Snow
        Me.ButtonClose.Location = New System.Drawing.Point(731, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(57, 37)
        Me.ButtonClose.TabIndex = 51
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        '許願池_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "許願池_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "許願池_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxPrice1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBoxProduct1 As TextBox
    Friend WithEvents ButtonBuy1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMy As Button
    Friend WithEvents ButtonWish As Button
    Friend WithEvents ButtonMainGo As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonMy檔案 As Button
    Friend WithEvents ButtonMy紀錄 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Labeluser As Label
End Class
