<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Retailer_OrderForm
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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAddOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAmount_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxAmount_2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAmount_3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAmount_4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAmount_5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCancel.Location = New System.Drawing.Point(51, 453)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(251, 56)
        Me.ButtonCancel.TabIndex = 14
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonAddOrder
        '
        Me.ButtonAddOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ButtonAddOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddOrder.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonAddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddOrder.Location = New System.Drawing.Point(51, 369)
        Me.ButtonAddOrder.Name = "ButtonAddOrder"
        Me.ButtonAddOrder.Size = New System.Drawing.Size(251, 56)
        Me.ButtonAddOrder.TabIndex = 13
        Me.ButtonAddOrder.Text = "確認訂單"
        Me.ButtonAddOrder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 45)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "品項"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(464, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 45)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "數量"
        '
        'TextBoxAmount_1
        '
        Me.TextBoxAmount_1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount_1.Location = New System.Drawing.Point(466, 131)
        Me.TextBoxAmount_1.Name = "TextBoxAmount_1"
        Me.TextBoxAmount_1.Size = New System.Drawing.Size(88, 36)
        Me.TextBoxAmount_1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 31)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "第一項:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "第二項:"
        '
        'TextBoxAmount_2
        '
        Me.TextBoxAmount_2.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount_2.Location = New System.Drawing.Point(466, 213)
        Me.TextBoxAmount_2.Name = "TextBoxAmount_2"
        Me.TextBoxAmount_2.Size = New System.Drawing.Size(88, 36)
        Me.TextBoxAmount_2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 31)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "第三項:"
        '
        'TextBoxAmount_3
        '
        Me.TextBoxAmount_3.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount_3.Location = New System.Drawing.Point(466, 283)
        Me.TextBoxAmount_3.Name = "TextBoxAmount_3"
        Me.TextBoxAmount_3.Size = New System.Drawing.Size(88, 36)
        Me.TextBoxAmount_3.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 31)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "第四項:"
        '
        'TextBoxAmount_4
        '
        Me.TextBoxAmount_4.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount_4.Location = New System.Drawing.Point(466, 357)
        Me.TextBoxAmount_4.Name = "TextBoxAmount_4"
        Me.TextBoxAmount_4.Size = New System.Drawing.Size(88, 36)
        Me.TextBoxAmount_4.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 31)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "第五項:"
        '
        'TextBoxAmount_5
        '
        Me.TextBoxAmount_5.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxAmount_5.Location = New System.Drawing.Point(466, 434)
        Me.TextBoxAmount_5.Name = "TextBoxAmount_5"
        Me.TextBoxAmount_5.Size = New System.Drawing.Size(88, 36)
        Me.TextBoxAmount_5.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(62, 285)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(181, 46)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 45)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "總額:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 12)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "我會顯示今天日期"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(296, 38)
        Me.ComboBox1.TabIndex = 42
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(145, 211)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(296, 38)
        Me.ComboBox2.TabIndex = 43
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(145, 283)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(296, 38)
        Me.ComboBox3.TabIndex = 43
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(145, 357)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(296, 38)
        Me.ComboBox4.TabIndex = 43
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(145, 428)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(296, 38)
        Me.ComboBox5.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(554, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 45)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "件"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(554, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 45)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "件"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(554, 282)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 45)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "件"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(554, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 45)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "件"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(554, 431)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 45)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "件"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 45)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "店家名稱:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(62, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(231, 46)
        Me.TextBox1.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(377, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 12)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(377, 196)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 12)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Label17"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(377, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 12)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Label18"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(377, 342)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 12)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Label19"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(377, 413)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 12)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Label20"
        Me.Label20.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(39, 34)
        Me.DataGridView1.TabIndex = 54
        Me.DataGridView1.Visible = False
        '
        'CheckButton
        '
        Me.CheckButton.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckButton.Location = New System.Drawing.Point(327, 496)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(114, 56)
        Me.CheckButton.TabIndex = 55
        Me.CheckButton.Text = "確認品項"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(465, 496)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(89, 56)
        Me.CalculateButton.TabIndex = 58
        Me.CalculateButton.Text = "小計"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.ButtonAddOrder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(671, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 653)
        Me.Panel1.TabIndex = 59
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("微軟正黑體", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.Location = New System.Drawing.Point(249, 283)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 45)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "元"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(162, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 12)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Label22"
        Me.Label22.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(235, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 32)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "一鍵輸入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Retailer_OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1017, 653)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxAmount_5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAmount_4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxAmount_3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxAmount_2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxAmount_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Retailer_OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonAddOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAmount_1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxAmount_2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAmount_3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAmount_4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAmount_5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button1 As Button
End Class
