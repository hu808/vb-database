<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 訂單詳情_Form
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
        Me.TextBoxTotalP = New System.Windows.Forms.TextBox()
        Me.LabelPassw = New System.Windows.Forms.Label()
        Me.LabelName2 = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelBirth = New System.Windows.Forms.Label()
        Me.DateTimePickerTD = New System.Windows.Forms.DateTimePicker()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTID = New System.Windows.Forms.TextBox()
        Me.TextBoxCanDelete = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxTotalP
        '
        Me.TextBoxTotalP.BackColor = System.Drawing.Color.White
        Me.TextBoxTotalP.Enabled = False
        Me.TextBoxTotalP.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxTotalP.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTotalP.Location = New System.Drawing.Point(377, 101)
        Me.TextBoxTotalP.Name = "TextBoxTotalP"
        Me.TextBoxTotalP.Size = New System.Drawing.Size(144, 30)
        Me.TextBoxTotalP.TabIndex = 103
        Me.TextBoxTotalP.Text = "xxx"
        '
        'LabelPassw
        '
        Me.LabelPassw.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LabelPassw.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelPassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelPassw.Location = New System.Drawing.Point(317, 101)
        Me.LabelPassw.Name = "LabelPassw"
        Me.LabelPassw.Size = New System.Drawing.Size(60, 30)
        Me.LabelPassw.TabIndex = 102
        Me.LabelPassw.Text = "總價"
        Me.LabelPassw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelName2
        '
        Me.LabelName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LabelName2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelName2.Location = New System.Drawing.Point(62, 101)
        Me.LabelName2.Name = "LabelName2"
        Me.LabelName2.Size = New System.Drawing.Size(58, 30)
        Me.LabelName2.TabIndex = 93
        Me.LabelName2.Text = "數量"
        Me.LabelName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.BackColor = System.Drawing.Color.White
        Me.TextBoxAmount.Enabled = False
        Me.TextBoxAmount.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount.ForeColor = System.Drawing.Color.Black
        Me.TextBoxAmount.Location = New System.Drawing.Point(125, 102)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(144, 30)
        Me.TextBoxAmount.TabIndex = 92
        Me.TextBoxAmount.Text = "xxx"
        '
        'LabelName
        '
        Me.LabelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LabelName.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelName.Location = New System.Drawing.Point(22, 60)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(97, 30)
        Me.LabelName.TabIndex = 91
        Me.LabelName.Text = "商品名稱"
        Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.Color.White
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxName.ForeColor = System.Drawing.Color.Black
        Me.TextBoxName.Location = New System.Drawing.Point(125, 60)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(396, 30)
        Me.TextBoxName.TabIndex = 90
        Me.TextBoxName.Text = "xxxxx"
        '
        'LabelBirth
        '
        Me.LabelBirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LabelBirth.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelBirth.Location = New System.Drawing.Point(22, 143)
        Me.LabelBirth.Name = "LabelBirth"
        Me.LabelBirth.Size = New System.Drawing.Size(98, 30)
        Me.LabelBirth.TabIndex = 100
        Me.LabelBirth.Text = "成立時間"
        Me.LabelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerTD
        '
        Me.DateTimePickerTD.Enabled = False
        Me.DateTimePickerTD.Location = New System.Drawing.Point(125, 149)
        Me.DateTimePickerTD.Name = "DateTimePickerTD"
        Me.DateTimePickerTD.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerTD.TabIndex = 104
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDelete.Location = New System.Drawing.Point(27, 205)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(494, 35)
        Me.ButtonDelete.TabIndex = 106
        Me.ButtonDelete.Text = "刪除訂單"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "訂單編號"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxTID
        '
        Me.TextBoxTID.BackColor = System.Drawing.Color.White
        Me.TextBoxTID.Enabled = False
        Me.TextBoxTID.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxTID.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTID.Location = New System.Drawing.Point(125, 18)
        Me.TextBoxTID.Name = "TextBoxTID"
        Me.TextBoxTID.Size = New System.Drawing.Size(67, 30)
        Me.TextBoxTID.TabIndex = 107
        Me.TextBoxTID.Text = "xxxxx"
        '
        'TextBoxCanDelete
        '
        Me.TextBoxCanDelete.BackColor = System.Drawing.Color.White
        Me.TextBoxCanDelete.Enabled = False
        Me.TextBoxCanDelete.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxCanDelete.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCanDelete.Location = New System.Drawing.Point(217, 18)
        Me.TextBoxCanDelete.Name = "TextBoxCanDelete"
        Me.TextBoxCanDelete.Size = New System.Drawing.Size(67, 30)
        Me.TextBoxCanDelete.TabIndex = 109
        Me.TextBoxCanDelete.Text = "0"
        Me.TextBoxCanDelete.Visible = False
        Me.TextBoxCanDelete.WordWrap = False
        '
        '訂單詳情_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 257)
        Me.Controls.Add(Me.TextBoxCanDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTID)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.DateTimePickerTD)
        Me.Controls.Add(Me.TextBoxTotalP)
        Me.Controls.Add(Me.LabelPassw)
        Me.Controls.Add(Me.LabelBirth)
        Me.Controls.Add(Me.LabelName2)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TextBoxName)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "訂單詳情_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "訂單詳情_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTotalP As TextBox
    Friend WithEvents LabelPassw As Label
    Friend WithEvents LabelName2 As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelBirth As Label
    Friend WithEvents DateTimePickerTD As DateTimePicker
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTID As TextBox
    Friend WithEvents TextBoxCanDelete As TextBox
End Class
