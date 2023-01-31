<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 商品清單_Form
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBuy1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelBrand = New System.Windows.Forms.Label()
        Me.LabelSize = New System.Windows.Forms.Label()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.LabelOrigin = New System.Windows.Forms.Label()
        Me.LabelProduct = New System.Windows.Forms.Label()
        Me.LabelpNo = New System.Windows.Forms.Label()
        Me.PictureBoxProduct = New System.Windows.Forms.PictureBox()
        Me.TextBoxtry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(482, 534)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonBuy1
        '
        Me.ButtonBuy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonBuy1.Enabled = False
        Me.ButtonBuy1.FlatAppearance.BorderSize = 0
        Me.ButtonBuy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuy1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonBuy1.ForeColor = System.Drawing.Color.White
        Me.ButtonBuy1.Location = New System.Drawing.Point(28, 510)
        Me.ButtonBuy1.Name = "ButtonBuy1"
        Me.ButtonBuy1.Size = New System.Drawing.Size(281, 36)
        Me.ButtonBuy1.TabIndex = 48
        Me.ButtonBuy1.Text = "我 要 團 購"
        Me.ButtonBuy1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 50)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "品牌"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "$價格$"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 30)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "規格"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 30)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "類別"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("新細明體-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 30)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "產地"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPrice
        '
        Me.LabelPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelPrice.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPrice.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelPrice.Location = New System.Drawing.Point(134, 265)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(104, 30)
        Me.LabelPrice.TabIndex = 81
        Me.LabelPrice.Text = "$"
        Me.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBrand
        '
        Me.LabelBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelBrand.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelBrand.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelBrand.Location = New System.Drawing.Point(134, 307)
        Me.LabelBrand.Name = "LabelBrand"
        Me.LabelBrand.Size = New System.Drawing.Size(175, 50)
        Me.LabelBrand.TabIndex = 82
        Me.LabelBrand.Text = "xxx"
        Me.LabelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSize
        '
        Me.LabelSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelSize.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelSize.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelSize.Location = New System.Drawing.Point(134, 372)
        Me.LabelSize.Name = "LabelSize"
        Me.LabelSize.Size = New System.Drawing.Size(175, 30)
        Me.LabelSize.TabIndex = 84
        Me.LabelSize.Text = "xxx"
        Me.LabelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCategory
        '
        Me.LabelCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelCategory.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelCategory.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelCategory.Location = New System.Drawing.Point(134, 418)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(175, 30)
        Me.LabelCategory.TabIndex = 85
        Me.LabelCategory.Text = "xxx"
        Me.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOrigin
        '
        Me.LabelOrigin.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelOrigin.Font = New System.Drawing.Font("新細明體-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelOrigin.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelOrigin.Location = New System.Drawing.Point(134, 464)
        Me.LabelOrigin.Name = "LabelOrigin"
        Me.LabelOrigin.Size = New System.Drawing.Size(175, 30)
        Me.LabelOrigin.TabIndex = 86
        Me.LabelOrigin.Text = "xxx"
        Me.LabelOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelProduct
        '
        Me.LabelProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelProduct.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelProduct.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelProduct.Location = New System.Drawing.Point(81, 212)
        Me.LabelProduct.Name = "LabelProduct"
        Me.LabelProduct.Size = New System.Drawing.Size(221, 43)
        Me.LabelProduct.TabIndex = 87
        Me.LabelProduct.Text = "商品名稱"
        Me.LabelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelpNo
        '
        Me.LabelpNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LabelpNo.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelpNo.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LabelpNo.Location = New System.Drawing.Point(50, 212)
        Me.LabelpNo.Name = "LabelpNo"
        Me.LabelpNo.Size = New System.Drawing.Size(31, 43)
        Me.LabelpNo.TabIndex = 88
        Me.LabelpNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxProduct
        '
        Me.PictureBoxProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PictureBoxProduct.Location = New System.Drawing.Point(24, 12)
        Me.PictureBoxProduct.Name = "PictureBoxProduct"
        Me.PictureBoxProduct.Size = New System.Drawing.Size(285, 190)
        Me.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProduct.TabIndex = 39
        Me.PictureBoxProduct.TabStop = False
        '
        'TextBoxtry
        '
        Me.TextBoxtry.Location = New System.Drawing.Point(9, 510)
        Me.TextBoxtry.Name = "TextBoxtry"
        Me.TextBoxtry.Size = New System.Drawing.Size(13, 22)
        Me.TextBoxtry.TabIndex = 89
        Me.TextBoxtry.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(24, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 43)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "no"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '商品清單_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 558)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxtry)
        Me.Controls.Add(Me.LabelpNo)
        Me.Controls.Add(Me.LabelProduct)
        Me.Controls.Add(Me.LabelOrigin)
        Me.Controls.Add(Me.LabelCategory)
        Me.Controls.Add(Me.LabelSize)
        Me.Controls.Add(Me.LabelBrand)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonBuy1)
        Me.Controls.Add(Me.PictureBoxProduct)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "商品清單_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品清單_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBoxProduct As PictureBox
    Friend WithEvents ButtonBuy1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelBrand As Label
    Friend WithEvents LabelSize As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents LabelOrigin As Label
    Friend WithEvents LabelProduct As Label
    Friend WithEvents LabelpNo As Label
    Friend WithEvents TextBoxtry As TextBox
    Friend WithEvents Label6 As Label
End Class
