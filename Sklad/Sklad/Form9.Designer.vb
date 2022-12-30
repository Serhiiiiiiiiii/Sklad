<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Склад
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CinaLabel As System.Windows.Forms.Label
        Dim ObiemLabel As System.Windows.Forms.Label
        Dim Sposib_dostavkuLabel As System.Windows.Forms.Label
        Dim Kod_tovaryLabel As System.Windows.Forms.Label
        Dim Data_vidpravkuLabel As System.Windows.Forms.Label
        Dim Data_nadhodzennaLabel As System.Windows.Forms.Label
        Dim Data_zamovlennaLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.СкладBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СкладTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.СкладTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.ТовариTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ТовариTableAdapter()
        Me.Kod_tovaryComboBox = New System.Windows.Forms.ComboBox()
        Me.ТовариBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sposib_dostavkuTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CinaLabel = New System.Windows.Forms.Label()
        ObiemLabel = New System.Windows.Forms.Label()
        Sposib_dostavkuLabel = New System.Windows.Forms.Label()
        Kod_tovaryLabel = New System.Windows.Forms.Label()
        Data_vidpravkuLabel = New System.Windows.Forms.Label()
        Data_nadhodzennaLabel = New System.Windows.Forms.Label()
        Data_zamovlennaLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТовариBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CinaLabel
        '
        CinaLabel.BackColor = System.Drawing.Color.DarkOrange
        CinaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        CinaLabel.Location = New System.Drawing.Point(12, 341)
        CinaLabel.Name = "CinaLabel"
        CinaLabel.Size = New System.Drawing.Size(209, 25)
        CinaLabel.TabIndex = 72
        CinaLabel.Text = "Ціна:"
        CinaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ObiemLabel
        '
        ObiemLabel.BackColor = System.Drawing.Color.DarkOrange
        ObiemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        ObiemLabel.Location = New System.Drawing.Point(12, 301)
        ObiemLabel.Name = "ObiemLabel"
        ObiemLabel.Size = New System.Drawing.Size(209, 25)
        ObiemLabel.TabIndex = 71
        ObiemLabel.Text = "Об'єм:"
        ObiemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sposib_dostavkuLabel
        '
        Sposib_dostavkuLabel.BackColor = System.Drawing.Color.DarkOrange
        Sposib_dostavkuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Sposib_dostavkuLabel.Location = New System.Drawing.Point(12, 260)
        Sposib_dostavkuLabel.Name = "Sposib_dostavkuLabel"
        Sposib_dostavkuLabel.Size = New System.Drawing.Size(209, 25)
        Sposib_dostavkuLabel.TabIndex = 70
        Sposib_dostavkuLabel.Text = "Спосіб доставки:"
        Sposib_dostavkuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Kod_tovaryLabel
        '
        Kod_tovaryLabel.BackColor = System.Drawing.Color.DarkOrange
        Kod_tovaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Kod_tovaryLabel.Location = New System.Drawing.Point(12, 216)
        Kod_tovaryLabel.Name = "Kod_tovaryLabel"
        Kod_tovaryLabel.Size = New System.Drawing.Size(209, 25)
        Kod_tovaryLabel.TabIndex = 69
        Kod_tovaryLabel.Text = "Товар:"
        Kod_tovaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data_vidpravkuLabel
        '
        Data_vidpravkuLabel.BackColor = System.Drawing.Color.DarkOrange
        Data_vidpravkuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Data_vidpravkuLabel.Location = New System.Drawing.Point(12, 175)
        Data_vidpravkuLabel.Name = "Data_vidpravkuLabel"
        Data_vidpravkuLabel.Size = New System.Drawing.Size(209, 25)
        Data_vidpravkuLabel.TabIndex = 68
        Data_vidpravkuLabel.Text = "Дата відправки:"
        Data_vidpravkuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data_nadhodzennaLabel
        '
        Data_nadhodzennaLabel.BackColor = System.Drawing.Color.DarkOrange
        Data_nadhodzennaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Data_nadhodzennaLabel.Location = New System.Drawing.Point(12, 133)
        Data_nadhodzennaLabel.Name = "Data_nadhodzennaLabel"
        Data_nadhodzennaLabel.Size = New System.Drawing.Size(209, 25)
        Data_nadhodzennaLabel.TabIndex = 67
        Data_nadhodzennaLabel.Text = "Дата надходження:"
        Data_nadhodzennaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data_zamovlennaLabel
        '
        Data_zamovlennaLabel.BackColor = System.Drawing.Color.DarkOrange
        Data_zamovlennaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Data_zamovlennaLabel.Location = New System.Drawing.Point(12, 92)
        Data_zamovlennaLabel.Name = "Data_zamovlennaLabel"
        Data_zamovlennaLabel.Size = New System.Drawing.Size(209, 25)
        Data_zamovlennaLabel.TabIndex = 66
        Data_zamovlennaLabel.Text = "Дата замовлення:"
        Data_zamovlennaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СкладBindingSource
        '
        Me.СкладBindingSource.DataMember = "Склад"
        Me.СкладBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'СкладTableAdapter
        '
        Me.СкладTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗамовникиTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПостачальникиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Me.СкладTableAdapter
        Me.TableAdapterManager.Типи_товарівTableAdapter = Nothing
        Me.TableAdapterManager.ТовариTableAdapter = Me.ТовариTableAdapter
        '
        'ТовариTableAdapter
        '
        Me.ТовариTableAdapter.ClearBeforeFill = True
        '
        'Kod_tovaryComboBox
        '
        Me.Kod_tovaryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "kod_tovary", True))
        Me.Kod_tovaryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СкладBindingSource, "kod_tovary", True))
        Me.Kod_tovaryComboBox.DataSource = Me.ТовариBindingSource
        Me.Kod_tovaryComboBox.DisplayMember = "naimenyvanna"
        Me.Kod_tovaryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Kod_tovaryComboBox.FormattingEnabled = True
        Me.Kod_tovaryComboBox.Location = New System.Drawing.Point(242, 213)
        Me.Kod_tovaryComboBox.Name = "Kod_tovaryComboBox"
        Me.Kod_tovaryComboBox.Size = New System.Drawing.Size(201, 28)
        Me.Kod_tovaryComboBox.TabIndex = 7
        Me.Kod_tovaryComboBox.ValueMember = "kod_tovary"
        '
        'ТовариBindingSource
        '
        Me.ТовариBindingSource.DataMember = "Товари"
        Me.ТовариBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'Sposib_dostavkuTextBox
        '
        Me.Sposib_dostavkuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "sposib_dostavku", True))
        Me.Sposib_dostavkuTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sposib_dostavkuTextBox.Location = New System.Drawing.Point(242, 259)
        Me.Sposib_dostavkuTextBox.Name = "Sposib_dostavkuTextBox"
        Me.Sposib_dostavkuTextBox.Size = New System.Drawing.Size(201, 26)
        Me.Sposib_dostavkuTextBox.TabIndex = 9
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "data_zamovlenna", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(242, 91)
        Me.MaskedTextBox1.Mask = "0000/00/00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox1.TabIndex = 13
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "data_nadhodzenna", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(242, 132)
        Me.MaskedTextBox2.Mask = "0000/00/00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox2.TabIndex = 14
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "data_vidpravku", True))
        Me.MaskedTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(242, 174)
        Me.MaskedTextBox3.Mask = "0000/00/00"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox3.TabIndex = 15
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "obiem", True))
        Me.MaskedTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(242, 300)
        Me.MaskedTextBox4.Mask = "00000000 одиниць"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox4.TabIndex = 16
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СкладBindingSource, "cina", True))
        Me.MaskedTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(242, 340)
        Me.MaskedTextBox5.Mask = "00000000 грн"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox5.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(75, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 48)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Таблиця ""Склад"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(480, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 81
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(480, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 80
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(469, 336)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 79
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(469, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(469, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(469, 210)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 76
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(469, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(469, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(462, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Склад
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597990_16_krot_info_p_sklad_art_20
        Me.ClientSize = New System.Drawing.Size(596, 384)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CinaLabel)
        Me.Controls.Add(ObiemLabel)
        Me.Controls.Add(Sposib_dostavkuLabel)
        Me.Controls.Add(Kod_tovaryLabel)
        Me.Controls.Add(Data_vidpravkuLabel)
        Me.Controls.Add(Data_nadhodzennaLabel)
        Me.Controls.Add(Data_zamovlennaLabel)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Sposib_dostavkuTextBox)
        Me.Controls.Add(Me.Kod_tovaryComboBox)
        Me.Name = "Склад"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Склад"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТовариBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents СкладBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СкладTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.СкладTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Kod_tovaryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sposib_dostavkuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ТовариTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ТовариTableAdapter
    Friend WithEvents ТовариBindingSource As System.Windows.Forms.BindingSource
End Class
