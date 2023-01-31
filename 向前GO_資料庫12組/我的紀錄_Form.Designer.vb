<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 我的紀錄_Form
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonALL = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMy檔案 = New System.Windows.Forms.Button()
        Me.ButtonMy紀錄 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMy = New System.Windows.Forms.Button()
        Me.ButtonWish = New System.Windows.Forms.Button()
        Me.ButtonMainGo = New System.Windows.Forms.Button()
        Me.ButtonBuy1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonBuy1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.ButtonALL)
        Me.Panel1.Controls.Add(Me.ButtonMy檔案)
        Me.Panel1.Controls.Add(Me.ButtonMy紀錄)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonMy)
        Me.Panel1.Controls.Add(Me.ButtonWish)
        Me.Panel1.Controls.Add(Me.ButtonMainGo)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 483)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(152, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(534, 220)
        Me.DataGridView1.TabIndex = 107
        '
        'ButtonALL
        '
        Me.ButtonALL.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ButtonALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonALL.Enabled = False
        Me.ButtonALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonALL.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonALL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonALL.Location = New System.Drawing.Point(101, 117)
        Me.ButtonALL.Name = "ButtonALL"
        Me.ButtonALL.Size = New System.Drawing.Size(51, 220)
        Me.ButtonALL.TabIndex = 104
        Me.ButtonALL.Text = "所有訂單"
        Me.ButtonALL.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "已購買 :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ButtonMy檔案.Location = New System.Drawing.Point(717, 397)
        Me.ButtonMy檔案.Name = "ButtonMy檔案"
        Me.ButtonMy檔案.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy檔案.TabIndex = 69
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
        Me.ButtonMy紀錄.Location = New System.Drawing.Point(654, 397)
        Me.ButtonMy紀錄.Name = "ButtonMy紀錄"
        Me.ButtonMy紀錄.Size = New System.Drawing.Size(71, 65)
        Me.ButtonMy紀錄.TabIndex = 68
        Me.ButtonMy紀錄.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.向前GO_資料庫12組.My.Resources.Resources.主程式logo
        Me.PictureBox4.Location = New System.Drawing.Point(162, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(470, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.向前GO_資料庫12組.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 86)
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
        Me.ButtonMy.FlatAppearance.BorderSize = 2
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
        Me.ButtonWish.FlatAppearance.BorderSize = 0
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
        'ButtonBuy1
        '
        Me.ButtonBuy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonBuy1.FlatAppearance.BorderSize = 0
        Me.ButtonBuy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuy1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonBuy1.ForeColor = System.Drawing.Color.White
        Me.ButtonBuy1.Location = New System.Drawing.Point(267, 358)
        Me.ButtonBuy1.Name = "ButtonBuy1"
        Me.ButtonBuy1.Size = New System.Drawing.Size(281, 36)
        Me.ButtonBuy1.TabIndex = 108
        Me.ButtonBuy1.Text = "刷   新"
        Me.ButtonBuy1.UseVisualStyleBackColor = False
        '
        '我的紀錄_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "我的紀錄_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "我的紀錄_Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMy As Button
    Friend WithEvents ButtonWish As Button
    Friend WithEvents ButtonMainGo As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonMy檔案 As Button
    Friend WithEvents ButtonMy紀錄 As Button
    Friend WithEvents ButtonALL As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBuy1 As Button
End Class
