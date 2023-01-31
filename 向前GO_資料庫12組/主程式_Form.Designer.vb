<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 主程式_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNowPage = New System.Windows.Forms.Label()
        Me.LabelTotalPge = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Labelp1 = New System.Windows.Forms.Label()
        Me.Labelp2 = New System.Windows.Forms.Label()
        Me.Labelname1 = New System.Windows.Forms.Label()
        Me.Labelmoney1 = New System.Windows.Forms.Label()
        Me.Labelname2 = New System.Windows.Forms.Label()
        Me.Labelmoney2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labeluser = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonMy檔案 = New System.Windows.Forms.Button()
        Me.ButtonMy紀錄 = New System.Windows.Forms.Button()
        Me.ButtonAfter = New System.Windows.Forms.Button()
        Me.ButtonBefore = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProduct2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProduct1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMy = New System.Windows.Forms.Button()
        Me.ButtonWish = New System.Windows.Forms.Button()
        Me.ButtonMainGo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ButtonClose.Location = New System.Drawing.Point(731, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(57, 37)
        Me.ButtonClose.TabIndex = 33
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 30)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "/"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNowPage
        '
        Me.LabelNowPage.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelNowPage.ForeColor = System.Drawing.Color.White
        Me.LabelNowPage.Location = New System.Drawing.Point(333, 376)
        Me.LabelNowPage.Name = "LabelNowPage"
        Me.LabelNowPage.Size = New System.Drawing.Size(55, 37)
        Me.LabelNowPage.TabIndex = 53
        Me.LabelNowPage.Text = "1"
        Me.LabelNowPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTotalPge
        '
        Me.LabelTotalPge.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelTotalPge.ForeColor = System.Drawing.Color.White
        Me.LabelTotalPge.Location = New System.Drawing.Point(427, 376)
        Me.LabelTotalPge.Name = "LabelTotalPge"
        Me.LabelTotalPge.Size = New System.Drawing.Size(55, 37)
        Me.LabelTotalPge.TabIndex = 54
        Me.LabelTotalPge.Text = "10"
        Me.LabelTotalPge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(7, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "商品清單"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Labelp1
        '
        Me.Labelp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labelp1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelp1.ForeColor = System.Drawing.Color.White
        Me.Labelp1.Location = New System.Drawing.Point(97, 90)
        Me.Labelp1.Name = "Labelp1"
        Me.Labelp1.Size = New System.Drawing.Size(55, 37)
        Me.Labelp1.TabIndex = 56
        Me.Labelp1.Text = "1"
        Me.Labelp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelp2
        '
        Me.Labelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labelp2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelp2.ForeColor = System.Drawing.Color.White
        Me.Labelp2.Location = New System.Drawing.Point(422, 90)
        Me.Labelp2.Name = "Labelp2"
        Me.Labelp2.Size = New System.Drawing.Size(55, 37)
        Me.Labelp2.TabIndex = 57
        Me.Labelp2.Text = "2"
        Me.Labelp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Labelname1
        '
        Me.Labelname1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Labelname1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelname1.ForeColor = System.Drawing.Color.DarkGray
        Me.Labelname1.Location = New System.Drawing.Point(105, 297)
        Me.Labelname1.Name = "Labelname1"
        Me.Labelname1.Size = New System.Drawing.Size(154, 55)
        Me.Labelname1.TabIndex = 58
        Me.Labelname1.Text = "商品名稱"
        Me.Labelname1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Labelmoney1
        '
        Me.Labelmoney1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Labelmoney1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelmoney1.ForeColor = System.Drawing.Color.DarkGray
        Me.Labelmoney1.Location = New System.Drawing.Point(265, 297)
        Me.Labelmoney1.Name = "Labelmoney1"
        Me.Labelmoney1.Size = New System.Drawing.Size(119, 55)
        Me.Labelmoney1.TabIndex = 59
        Me.Labelmoney1.Text = "$價格"
        Me.Labelmoney1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Labelname2
        '
        Me.Labelname2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Labelname2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelname2.ForeColor = System.Drawing.Color.DarkGray
        Me.Labelname2.Location = New System.Drawing.Point(430, 297)
        Me.Labelname2.Name = "Labelname2"
        Me.Labelname2.Size = New System.Drawing.Size(154, 55)
        Me.Labelname2.TabIndex = 60
        Me.Labelname2.Text = "商品名稱"
        Me.Labelname2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Labelmoney2
        '
        Me.Labelmoney2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Labelmoney2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labelmoney2.ForeColor = System.Drawing.Color.DarkGray
        Me.Labelmoney2.Location = New System.Drawing.Point(590, 297)
        Me.Labelmoney2.Name = "Labelmoney2"
        Me.Labelmoney2.Size = New System.Drawing.Size(119, 55)
        Me.Labelmoney2.TabIndex = 61
        Me.Labelmoney2.Text = "$價格"
        Me.Labelmoney2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(445, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 37)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Hi~"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Labeluser
        '
        Me.Labeluser.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Labeluser.ForeColor = System.Drawing.Color.White
        Me.Labeluser.Location = New System.Drawing.Point(527, 23)
        Me.Labeluser.Name = "Labeluser"
        Me.Labeluser.Size = New System.Drawing.Size(149, 37)
        Me.Labeluser.TabIndex = 63
        Me.Labeluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(308, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(200, 10)
        Me.DataGridView1.TabIndex = 64
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
        Me.ButtonMy檔案.Location = New System.Drawing.Point(717, 374)
        Me.ButtonMy檔案.Name = "ButtonMy檔案"
        Me.ButtonMy檔案.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy檔案.TabIndex = 52
        Me.ButtonMy檔案.UseVisualStyleBackColor = False
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
        Me.ButtonMy紀錄.Location = New System.Drawing.Point(654, 374)
        Me.ButtonMy紀錄.Name = "ButtonMy紀錄"
        Me.ButtonMy紀錄.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy紀錄.TabIndex = 51
        Me.ButtonMy紀錄.UseVisualStyleBackColor = False
        '
        'ButtonAfter
        '
        Me.ButtonAfter.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonAfter.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.下一頁
        Me.ButtonAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAfter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAfter.FlatAppearance.BorderSize = 0
        Me.ButtonAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAfter.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonAfter.ForeColor = System.Drawing.Color.White
        Me.ButtonAfter.Location = New System.Drawing.Point(668, 363)
        Me.ButtonAfter.Name = "ButtonAfter"
        Me.ButtonAfter.Size = New System.Drawing.Size(121, 53)
        Me.ButtonAfter.TabIndex = 50
        Me.ButtonAfter.UseVisualStyleBackColor = False
        '
        'ButtonBefore
        '
        Me.ButtonBefore.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonBefore.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.上一頁
        Me.ButtonBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBefore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBefore.FlatAppearance.BorderSize = 0
        Me.ButtonBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBefore.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonBefore.ForeColor = System.Drawing.Color.White
        Me.ButtonBefore.Location = New System.Drawing.Point(12, 362)
        Me.ButtonBefore.Name = "ButtonBefore"
        Me.ButtonBefore.Size = New System.Drawing.Size(121, 53)
        Me.ButtonBefore.TabIndex = 49
        Me.ButtonBefore.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.向前GO_資料庫12組.My.Resources.Resources.主程式logo
        Me.PictureBox4.Location = New System.Drawing.Point(162, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(470, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'PictureBoxProduct2
        '
        Me.PictureBoxProduct2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PictureBoxProduct2.Location = New System.Drawing.Point(430, 102)
        Me.PictureBoxProduct2.Name = "PictureBoxProduct2"
        Me.PictureBoxProduct2.Size = New System.Drawing.Size(279, 190)
        Me.PictureBoxProduct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProduct2.TabIndex = 39
        Me.PictureBoxProduct2.TabStop = False
        '
        'PictureBoxProduct1
        '
        Me.PictureBoxProduct1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PictureBoxProduct1.Location = New System.Drawing.Point(105, 102)
        Me.PictureBoxProduct1.Name = "PictureBoxProduct1"
        Me.PictureBoxProduct1.Size = New System.Drawing.Size(279, 190)
        Me.PictureBoxProduct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProduct1.TabIndex = 38
        Me.PictureBoxProduct1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.向前GO_資料庫12組.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
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
        Me.ButtonMy.TabIndex = 36
        Me.ButtonMy.UseVisualStyleBackColor = False
        '
        'ButtonWish
        '
        Me.ButtonWish.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonWish.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.許願底
        Me.ButtonWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonWish.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonWish.FlatAppearance.BorderSize = 0
        Me.ButtonWish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWish.Location = New System.Drawing.Point(267, 421)
        Me.ButtonWish.Name = "ButtonWish"
        Me.ButtonWish.Size = New System.Drawing.Size(266, 61)
        Me.ButtonWish.TabIndex = 35
        Me.ButtonWish.UseVisualStyleBackColor = False
        '
        'ButtonMainGo
        '
        Me.ButtonMainGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonMainGo.BackgroundImage = Global.向前GO_資料庫12組.My.Resources.Resources.團go底
        Me.ButtonMainGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonMainGo.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonMainGo.FlatAppearance.BorderSize = 2
        Me.ButtonMainGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMainGo.Location = New System.Drawing.Point(1, 421)
        Me.ButtonMainGo.Name = "ButtonMainGo"
        Me.ButtonMainGo.Size = New System.Drawing.Size(266, 61)
        Me.ButtonMainGo.TabIndex = 34
        Me.ButtonMainGo.UseVisualStyleBackColor = False
        '
        '主程式_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Labeluser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelmoney2)
        Me.Controls.Add(Me.Labelname2)
        Me.Controls.Add(Me.Labelmoney1)
        Me.Controls.Add(Me.Labelname1)
        Me.Controls.Add(Me.Labelp2)
        Me.Controls.Add(Me.Labelp1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelTotalPge)
        Me.Controls.Add(Me.LabelNowPage)
        Me.Controls.Add(Me.ButtonMy檔案)
        Me.Controls.Add(Me.ButtonMy紀錄)
        Me.Controls.Add(Me.ButtonAfter)
        Me.Controls.Add(Me.ButtonBefore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBoxProduct2)
        Me.Controls.Add(Me.PictureBoxProduct1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonMy)
        Me.Controls.Add(Me.ButtonWish)
        Me.Controls.Add(Me.ButtonMainGo)
        Me.Controls.Add(Me.ButtonClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "主程式_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "主程式_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProduct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProduct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonMainGo As Button
    Friend WithEvents ButtonWish As Button
    Friend WithEvents ButtonMy As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxProduct1 As PictureBox
    Friend WithEvents PictureBoxProduct2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAfter As Button
    Friend WithEvents ButtonBefore As Button
    Friend WithEvents ButtonMy紀錄 As Button
    Friend WithEvents ButtonMy檔案 As Button
    Friend WithEvents LabelNowPage As Label
    Friend WithEvents LabelTotalPge As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Labelp1 As Label
    Friend WithEvents Labelp2 As Label
    Friend WithEvents Labelname1 As Label
    Friend WithEvents Labelmoney1 As Label
    Friend WithEvents Labelname2 As Label
    Friend WithEvents Labelmoney2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Labeluser As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
