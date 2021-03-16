<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kouman_DeliveryOrderItemsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kouman_DeliveryOrderItemsForm))
        Me.OrderIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.Total_Label = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Order_Label = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.amount_2 = New System.Windows.Forms.Label()
        Me.amount_3 = New System.Windows.Forms.Label()
        Me.amount_4 = New System.Windows.Forms.Label()
        Me.amount_5 = New System.Windows.Forms.Label()
        Me.amount_1 = New System.Windows.Forms.Label()
        Me.item_2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.item_5 = New System.Windows.Forms.Label()
        Me.item_4 = New System.Windows.Forms.Label()
        Me.item_3 = New System.Windows.Forms.Label()
        Me.item_1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderIDLabel
        '
        Me.OrderIDLabel.AutoSize = True
        Me.OrderIDLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OrderIDLabel.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OrderIDLabel.Location = New System.Drawing.Point(184, 126)
        Me.OrderIDLabel.Name = "OrderIDLabel"
        Me.OrderIDLabel.Size = New System.Drawing.Size(140, 31)
        Me.OrderIDLabel.TabIndex = 57
        Me.OrderIDLabel.Text = "                     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 31)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "訂單ID:"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCancel.Location = New System.Drawing.Point(615, 586)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(158, 50)
        Me.ButtonCancel.TabIndex = 55
        Me.ButtonCancel.Text = "先在緩緩"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ButtonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddStudent.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddStudent.Location = New System.Drawing.Point(427, 586)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(158, 50)
        Me.ButtonAddStudent.TabIndex = 54
        Me.ButtonAddStudent.Text = "進行出貨"
        Me.ButtonAddStudent.UseVisualStyleBackColor = False
        '
        'Total_Label
        '
        Me.Total_Label.AutoSize = True
        Me.Total_Label.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Total_Label.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Total_Label.Location = New System.Drawing.Point(238, 596)
        Me.Total_Label.Name = "Total_Label"
        Me.Total_Label.Size = New System.Drawing.Size(140, 31)
        Me.Total_Label.TabIndex = 53
        Me.Total_Label.Text = "                     "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 596)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 31)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "總金額:"
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Date_Label.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Date_Label.Location = New System.Drawing.Point(533, 86)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(140, 31)
        Me.Date_Label.TabIndex = 51
        Me.Date_Label.Text = "                     "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label22.Location = New System.Drawing.Point(382, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 31)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "訂購日期:"
        '
        'Order_Label
        '
        Me.Order_Label.AutoSize = True
        Me.Order_Label.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Order_Label.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Order_Label.Location = New System.Drawing.Point(184, 74)
        Me.Order_Label.Name = "Order_Label"
        Me.Order_Label.Size = New System.Drawing.Size(140, 31)
        Me.Order_Label.TabIndex = 50
        Me.Order_Label.Text = "                     "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label21.Location = New System.Drawing.Point(46, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 31)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "訂購店家:"
        '
        'amount_2
        '
        Me.amount_2.AutoSize = True
        Me.amount_2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.amount_2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.amount_2.Location = New System.Drawing.Point(547, 294)
        Me.amount_2.Name = "amount_2"
        Me.amount_2.Size = New System.Drawing.Size(80, 31)
        Me.amount_2.TabIndex = 47
        Me.amount_2.Text = "           "
        '
        'amount_3
        '
        Me.amount_3.AutoSize = True
        Me.amount_3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.amount_3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.amount_3.Location = New System.Drawing.Point(547, 365)
        Me.amount_3.Name = "amount_3"
        Me.amount_3.Size = New System.Drawing.Size(80, 31)
        Me.amount_3.TabIndex = 46
        Me.amount_3.Text = "           "
        '
        'amount_4
        '
        Me.amount_4.AutoSize = True
        Me.amount_4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.amount_4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.amount_4.Location = New System.Drawing.Point(547, 439)
        Me.amount_4.Name = "amount_4"
        Me.amount_4.Size = New System.Drawing.Size(80, 31)
        Me.amount_4.TabIndex = 45
        Me.amount_4.Text = "           "
        '
        'amount_5
        '
        Me.amount_5.AutoSize = True
        Me.amount_5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.amount_5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.amount_5.Location = New System.Drawing.Point(547, 513)
        Me.amount_5.Name = "amount_5"
        Me.amount_5.Size = New System.Drawing.Size(80, 31)
        Me.amount_5.TabIndex = 44
        Me.amount_5.Text = "           "
        '
        'amount_1
        '
        Me.amount_1.AutoSize = True
        Me.amount_1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.amount_1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.amount_1.Location = New System.Drawing.Point(547, 218)
        Me.amount_1.Name = "amount_1"
        Me.amount_1.Size = New System.Drawing.Size(80, 31)
        Me.amount_1.TabIndex = 43
        Me.amount_1.Text = "           "
        '
        'item_2
        '
        Me.item_2.AutoSize = True
        Me.item_2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.item_2.Location = New System.Drawing.Point(264, 294)
        Me.item_2.Name = "item_2"
        Me.item_2.Size = New System.Drawing.Size(140, 31)
        Me.item_2.TabIndex = 42
        Me.item_2.Text = "                     "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(274, 560)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 31)
        Me.Label13.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(378, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 31)
        Me.Label12.TabIndex = 40
        '
        'item_5
        '
        Me.item_5.AutoSize = True
        Me.item_5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.item_5.Location = New System.Drawing.Point(264, 513)
        Me.item_5.Name = "item_5"
        Me.item_5.Size = New System.Drawing.Size(140, 31)
        Me.item_5.TabIndex = 39
        Me.item_5.Text = "                     "
        '
        'item_4
        '
        Me.item_4.AutoSize = True
        Me.item_4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.item_4.Location = New System.Drawing.Point(264, 439)
        Me.item_4.Name = "item_4"
        Me.item_4.Size = New System.Drawing.Size(140, 31)
        Me.item_4.TabIndex = 38
        Me.item_4.Text = "                     "
        '
        'item_3
        '
        Me.item_3.AutoSize = True
        Me.item_3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.item_3.Location = New System.Drawing.Point(264, 365)
        Me.item_3.Name = "item_3"
        Me.item_3.Size = New System.Drawing.Size(140, 31)
        Me.item_3.TabIndex = 37
        Me.item_3.Text = "                     "
        '
        'item_1
        '
        Me.item_1.AutoSize = True
        Me.item_1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.item_1.Location = New System.Drawing.Point(264, 218)
        Me.item_1.Name = "item_1"
        Me.item_1.Size = New System.Drawing.Size(140, 31)
        Me.item_1.TabIndex = 36
        Me.item_1.Text = "                     "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 31)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "名稱"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(558, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 31)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "數量"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 31)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "品項五:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "品項四:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 31)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "品項三:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "品項二:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "品項一:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 55)
        Me.Panel1.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(794, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(202, 55)
        Me.Panel2.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(29, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 40)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "訂單明細"
        '
        'Kouman_DeliveryOrderItemsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 672)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OrderIDLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.Total_Label)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Date_Label)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Order_Label)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.amount_2)
        Me.Controls.Add(Me.amount_3)
        Me.Controls.Add(Me.amount_4)
        Me.Controls.Add(Me.amount_5)
        Me.Controls.Add(Me.amount_1)
        Me.Controls.Add(Me.item_2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.item_5)
        Me.Controls.Add(Me.item_4)
        Me.Controls.Add(Me.item_3)
        Me.Controls.Add(Me.item_1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kouman_DeliveryOrderItemsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AcceptOrderItemsForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents Total_Label As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Date_Label As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Order_Label As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents amount_2 As Label
    Friend WithEvents amount_3 As Label
    Friend WithEvents amount_4 As Label
    Friend WithEvents amount_5 As Label
    Friend WithEvents amount_1 As Label
    Friend WithEvents item_2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents item_5 As Label
    Friend WithEvents item_4 As Label
    Friend WithEvents item_3 As Label
    Friend WithEvents item_1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
End Class
