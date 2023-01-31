<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 交易_Form
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
        Me.LabelpNo = New System.Windows.Forms.Label()
        Me.LabelProduct = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTotalP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.ButtonBuy1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelMID = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonHome = New System.Windows.Forms.RadioButton()
        Me.RadioButton711 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFM = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCOD = New System.Windows.Forms.RadioButton()
        Me.RadioButtondbcard = New System.Windows.Forms.RadioButton()
        Me.RadioButtonATM = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxProduct = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelpNo
        '
        Me.LabelpNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelpNo.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelpNo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelpNo.Location = New System.Drawing.Point(17, 244)
        Me.LabelpNo.Name = "LabelpNo"
        Me.LabelpNo.Size = New System.Drawing.Size(31, 27)
        Me.LabelpNo.TabIndex = 93
        Me.LabelpNo.Text = "no"
        Me.LabelpNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelProduct
        '
        Me.LabelProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelProduct.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelProduct.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelProduct.Location = New System.Drawing.Point(48, 244)
        Me.LabelProduct.Name = "LabelProduct"
        Me.LabelProduct.Size = New System.Drawing.Size(301, 27)
        Me.LabelProduct.TabIndex = 92
        Me.LabelProduct.Text = "商品名稱"
        Me.LabelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPrice
        '
        Me.LabelPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelPrice.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPrice.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelPrice.Location = New System.Drawing.Point(97, 286)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(82, 30)
        Me.LabelPrice.TabIndex = 91
        Me.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 30)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "$價格$"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 30)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "數量"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTotalP
        '
        Me.LabelTotalP.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelTotalP.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelTotalP.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelTotalP.Location = New System.Drawing.Point(207, 431)
        Me.LabelTotalP.Name = "LabelTotalP"
        Me.LabelTotalP.Size = New System.Drawing.Size(82, 30)
        Me.LabelTotalP.TabIndex = 97
        Me.LabelTotalP.Text = "$"
        Me.LabelTotalP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(135, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 30)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "總價 :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TextBoxAmount.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount.ForeColor = System.Drawing.Color.Black
        Me.TextBoxAmount.Location = New System.Drawing.Point(266, 287)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(83, 30)
        Me.TextBoxAmount.TabIndex = 98
        Me.TextBoxAmount.Text = "1"
        Me.TextBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonBuy1
        '
        Me.ButtonBuy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonBuy1.Enabled = False
        Me.ButtonBuy1.FlatAppearance.BorderSize = 0
        Me.ButtonBuy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuy1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonBuy1.ForeColor = System.Drawing.Color.White
        Me.ButtonBuy1.Location = New System.Drawing.Point(101, 471)
        Me.ButtonBuy1.Name = "ButtonBuy1"
        Me.ButtonBuy1.Size = New System.Drawing.Size(248, 36)
        Me.ButtonBuy1.TabIndex = 99
        Me.ButtonBuy1.Text = "確 定 團 購"
        Me.ButtonBuy1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 27)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "會員ID :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMID
        '
        Me.LabelMID.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LabelMID.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelMID.ForeColor = System.Drawing.Color.White
        Me.LabelMID.Location = New System.Drawing.Point(89, 209)
        Me.LabelMID.Name = "LabelMID"
        Me.LabelMID.Size = New System.Drawing.Size(31, 27)
        Me.LabelMID.TabIndex = 102
        Me.LabelMID.Text = "no"
        Me.LabelMID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ButtonRefresh.FlatAppearance.BorderSize = 0
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.White
        Me.ButtonRefresh.Location = New System.Drawing.Point(296, 430)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(53, 30)
        Me.ButtonRefresh.TabIndex = 105
        Me.ButtonRefresh.Text = "刷新"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 36)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "取 消"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBoxProduct)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonBuy1)
        Me.Panel1.Controls.Add(Me.LabelMID)
        Me.Panel1.Controls.Add(Me.LabelTotalP)
        Me.Panel1.Controls.Add(Me.LabelPrice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LabelProduct)
        Me.Panel1.Controls.Add(Me.LabelpNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxAmount)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 526)
        Me.Panel1.TabIndex = 107
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonHome)
        Me.GroupBox2.Controls.Add(Me.RadioButton711)
        Me.GroupBox2.Controls.Add(Me.RadioButtonFM)
        Me.GroupBox2.Location = New System.Drawing.Point(115, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 44)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        '
        'RadioButtonHome
        '
        Me.RadioButtonHome.AutoSize = True
        Me.RadioButtonHome.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButtonHome.ForeColor = System.Drawing.Color.White
        Me.RadioButtonHome.Location = New System.Drawing.Point(141, 13)
        Me.RadioButtonHome.Name = "RadioButtonHome"
        Me.RadioButtonHome.Size = New System.Drawing.Size(57, 23)
        Me.RadioButtonHome.TabIndex = 5
        Me.RadioButtonHome.Text = "宅配"
        Me.RadioButtonHome.UseVisualStyleBackColor = True
        '
        'RadioButton711
        '
        Me.RadioButton711.AutoSize = True
        Me.RadioButton711.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton711.ForeColor = System.Drawing.Color.White
        Me.RadioButton711.Location = New System.Drawing.Point(68, 13)
        Me.RadioButton711.Name = "RadioButton711"
        Me.RadioButton711.Size = New System.Drawing.Size(69, 23)
        Me.RadioButton711.TabIndex = 3
        Me.RadioButton711.Text = "7 - 11"
        Me.RadioButton711.UseVisualStyleBackColor = True
        '
        'RadioButtonFM
        '
        Me.RadioButtonFM.AutoSize = True
        Me.RadioButtonFM.Checked = True
        Me.RadioButtonFM.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButtonFM.ForeColor = System.Drawing.Color.White
        Me.RadioButtonFM.Location = New System.Drawing.Point(4, 13)
        Me.RadioButtonFM.Name = "RadioButtonFM"
        Me.RadioButtonFM.Size = New System.Drawing.Size(57, 23)
        Me.RadioButtonFM.TabIndex = 4
        Me.RadioButtonFM.TabStop = True
        Me.RadioButtonFM.Text = "全家"
        Me.RadioButtonFM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonCOD)
        Me.GroupBox1.Controls.Add(Me.RadioButtondbcard)
        Me.GroupBox1.Controls.Add(Me.RadioButtonATM)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 39)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonCOD
        '
        Me.RadioButtonCOD.AutoSize = True
        Me.RadioButtonCOD.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButtonCOD.ForeColor = System.Drawing.Color.White
        Me.RadioButtonCOD.Location = New System.Drawing.Point(141, 12)
        Me.RadioButtonCOD.Name = "RadioButtonCOD"
        Me.RadioButtonCOD.Size = New System.Drawing.Size(87, 23)
        Me.RadioButtonCOD.TabIndex = 2
        Me.RadioButtonCOD.Text = "貨到付款"
        Me.RadioButtonCOD.UseVisualStyleBackColor = True
        '
        'RadioButtondbcard
        '
        Me.RadioButtondbcard.AutoSize = True
        Me.RadioButtondbcard.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButtondbcard.ForeColor = System.Drawing.Color.White
        Me.RadioButtondbcard.Location = New System.Drawing.Point(68, 12)
        Me.RadioButtondbcard.Name = "RadioButtondbcard"
        Me.RadioButtondbcard.Size = New System.Drawing.Size(72, 23)
        Me.RadioButtondbcard.TabIndex = 1
        Me.RadioButtondbcard.Text = "信用卡"
        Me.RadioButtondbcard.UseVisualStyleBackColor = True
        '
        'RadioButtonATM
        '
        Me.RadioButtonATM.AutoSize = True
        Me.RadioButtonATM.Checked = True
        Me.RadioButtonATM.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButtonATM.ForeColor = System.Drawing.Color.White
        Me.RadioButtonATM.Location = New System.Drawing.Point(4, 12)
        Me.RadioButtonATM.Name = "RadioButtonATM"
        Me.RadioButtonATM.Size = New System.Drawing.Size(62, 23)
        Me.RadioButtonATM.TabIndex = 0
        Me.RadioButtonATM.TabStop = True
        Me.RadioButtonATM.Text = "ATM"
        Me.RadioButtonATM.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 30)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "運送方式"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 30)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "付款方式"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxProduct
        '
        Me.PictureBoxProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PictureBoxProduct.Location = New System.Drawing.Point(16, 16)
        Me.PictureBoxProduct.Name = "PictureBoxProduct"
        Me.PictureBoxProduct.Size = New System.Drawing.Size(333, 190)
        Me.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProduct.TabIndex = 89
        Me.PictureBoxProduct.TabStop = False
        '
        '交易_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(389, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "交易_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "交易_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelpNo As Label
    Friend WithEvents LabelProduct As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxProduct As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTotalP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents ButtonBuy1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelMID As Label
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonHome As RadioButton
    Friend WithEvents RadioButton711 As RadioButton
    Friend WithEvents RadioButtonFM As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonCOD As RadioButton
    Friend WithEvents RadioButtondbcard As RadioButton
    Friend WithEvents RadioButtonATM As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
End Class
