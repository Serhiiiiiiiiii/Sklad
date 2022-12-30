<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Працівники
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
        Dim Pasportni_daniLabel As System.Windows.Forms.Label
        Dim Kod_posaduLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim StatLabel As System.Windows.Forms.Label
        Dim VikLabel As System.Windows.Forms.Label
        Dim PibLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.ПрацівникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПрацівникиTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПрацівникиTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.PibTextBox = New System.Windows.Forms.TextBox()
        Me.VikTextBox = New System.Windows.Forms.TextBox()
        Me.StatComboBox = New System.Windows.Forms.ComboBox()
        Me.AdresaTextBox = New System.Windows.Forms.TextBox()
        Me.Kod_posaduComboBox = New System.Windows.Forms.ComboBox()
        Me.ПрацівникиBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПосадиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ПосадиTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПосадиTableAdapter()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Pasportni_daniLabel = New System.Windows.Forms.Label()
        Kod_posaduLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        StatLabel = New System.Windows.Forms.Label()
        VikLabel = New System.Windows.Forms.Label()
        PibLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрацівникиBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pasportni_daniLabel
        '
        Pasportni_daniLabel.BackColor = System.Drawing.Color.DarkOrange
        Pasportni_daniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Pasportni_daniLabel.Location = New System.Drawing.Point(31, 329)
        Pasportni_daniLabel.Name = "Pasportni_daniLabel"
        Pasportni_daniLabel.Size = New System.Drawing.Size(113, 50)
        Pasportni_daniLabel.TabIndex = 40
        Pasportni_daniLabel.Text = "Паспортні дані:"
        Pasportni_daniLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Kod_posaduLabel
        '
        Kod_posaduLabel.BackColor = System.Drawing.Color.DarkOrange
        Kod_posaduLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Kod_posaduLabel.Location = New System.Drawing.Point(34, 289)
        Kod_posaduLabel.Name = "Kod_posaduLabel"
        Kod_posaduLabel.Size = New System.Drawing.Size(110, 25)
        Kod_posaduLabel.TabIndex = 39
        Kod_posaduLabel.Text = "Посада:"
        Kod_posaduLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TelefonLabel
        '
        TelefonLabel.BackColor = System.Drawing.Color.DarkOrange
        TelefonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        TelefonLabel.Location = New System.Drawing.Point(34, 251)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(110, 25)
        TelefonLabel.TabIndex = 38
        TelefonLabel.Text = "Телефон:"
        TelefonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdresaLabel
        '
        AdresaLabel.BackColor = System.Drawing.Color.DarkOrange
        AdresaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        AdresaLabel.Location = New System.Drawing.Point(34, 212)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(110, 25)
        AdresaLabel.TabIndex = 37
        AdresaLabel.Text = "Адреса:"
        AdresaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatLabel
        '
        StatLabel.BackColor = System.Drawing.Color.DarkOrange
        StatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        StatLabel.Location = New System.Drawing.Point(34, 173)
        StatLabel.Name = "StatLabel"
        StatLabel.Size = New System.Drawing.Size(110, 25)
        StatLabel.TabIndex = 36
        StatLabel.Text = "Стать:"
        StatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VikLabel
        '
        VikLabel.BackColor = System.Drawing.Color.DarkOrange
        VikLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        VikLabel.Location = New System.Drawing.Point(34, 134)
        VikLabel.Name = "VikLabel"
        VikLabel.Size = New System.Drawing.Size(110, 25)
        VikLabel.TabIndex = 35
        VikLabel.Text = "Вік:"
        VikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PibLabel
        '
        PibLabel.BackColor = System.Drawing.Color.DarkOrange
        PibLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        PibLabel.Location = New System.Drawing.Point(34, 98)
        PibLabel.Name = "PibLabel"
        PibLabel.Size = New System.Drawing.Size(110, 25)
        PibLabel.TabIndex = 34
        PibLabel.Text = "ПІБ:"
        PibLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПрацівникиBindingSource
        '
        Me.ПрацівникиBindingSource.DataMember = "Працівники"
        Me.ПрацівникиBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'ПрацівникиTableAdapter
        '
        Me.ПрацівникиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗамовникиTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПостачальникиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Me.ПрацівникиTableAdapter
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.Типи_товарівTableAdapter = Nothing
        Me.TableAdapterManager.ТовариTableAdapter = Nothing
        '
        'PibTextBox
        '
        Me.PibTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "pib", True))
        Me.PibTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PibTextBox.Location = New System.Drawing.Point(162, 97)
        Me.PibTextBox.Name = "PibTextBox"
        Me.PibTextBox.Size = New System.Drawing.Size(175, 26)
        Me.PibTextBox.TabIndex = 2
        '
        'VikTextBox
        '
        Me.VikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "vik", True))
        Me.VikTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VikTextBox.Location = New System.Drawing.Point(162, 133)
        Me.VikTextBox.Name = "VikTextBox"
        Me.VikTextBox.Size = New System.Drawing.Size(175, 26)
        Me.VikTextBox.TabIndex = 4
        '
        'StatComboBox
        '
        Me.StatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "stat", True))
        Me.StatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StatComboBox.FormattingEnabled = True
        Me.StatComboBox.Items.AddRange(New Object() {"Чоловік", "Жінка"})
        Me.StatComboBox.Location = New System.Drawing.Point(162, 170)
        Me.StatComboBox.Name = "StatComboBox"
        Me.StatComboBox.Size = New System.Drawing.Size(175, 28)
        Me.StatComboBox.TabIndex = 6
        '
        'AdresaTextBox
        '
        Me.AdresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "adresa", True))
        Me.AdresaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AdresaTextBox.Location = New System.Drawing.Point(162, 211)
        Me.AdresaTextBox.Name = "AdresaTextBox"
        Me.AdresaTextBox.Size = New System.Drawing.Size(175, 26)
        Me.AdresaTextBox.TabIndex = 8
        '
        'Kod_posaduComboBox
        '
        Me.Kod_posaduComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "kod_posadu", True))
        Me.Kod_posaduComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ПрацівникиBindingSource1, "kod_posadu", True))
        Me.Kod_posaduComboBox.DataSource = Me.ПосадиBindingSource
        Me.Kod_posaduComboBox.DisplayMember = "naimenyvanna_posadu"
        Me.Kod_posaduComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Kod_posaduComboBox.FormattingEnabled = True
        Me.Kod_posaduComboBox.Location = New System.Drawing.Point(162, 286)
        Me.Kod_posaduComboBox.Name = "Kod_posaduComboBox"
        Me.Kod_posaduComboBox.Size = New System.Drawing.Size(175, 28)
        Me.Kod_posaduComboBox.TabIndex = 13
        Me.Kod_posaduComboBox.ValueMember = "kod_posadu"
        '
        'ПрацівникиBindingSource1
        '
        Me.ПрацівникиBindingSource1.DataMember = "Працівники"
        Me.ПрацівникиBindingSource1.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'ПосадиBindingSource
        '
        Me.ПосадиBindingSource.DataMember = "Посади"
        Me.ПосадиBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 45)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Таблиця ""Працівники"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(481, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(481, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(470, 376)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(470, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(470, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(470, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(470, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(470, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(463, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ПосадиTableAdapter
        '
        Me.ПосадиTableAdapter.ClearBeforeFill = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "telefon", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(162, 250)
        Me.MaskedTextBox1.Mask = "+00(000)00-000-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(175, 26)
        Me.MaskedTextBox1.TabIndex = 41
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрацівникиBindingSource, "pasportni_dani", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(162, 338)
        Me.MaskedTextBox2.Mask = "0000-0000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(175, 26)
        Me.MaskedTextBox2.TabIndex = 42
        '
        'Працівники
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597981_49_krot_info_p_sklad_art_67
        Me.ClientSize = New System.Drawing.Size(598, 425)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Pasportni_daniLabel)
        Me.Controls.Add(Kod_posaduLabel)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(AdresaLabel)
        Me.Controls.Add(StatLabel)
        Me.Controls.Add(VikLabel)
        Me.Controls.Add(PibLabel)
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
        Me.Controls.Add(Me.Kod_posaduComboBox)
        Me.Controls.Add(Me.AdresaTextBox)
        Me.Controls.Add(Me.StatComboBox)
        Me.Controls.Add(Me.VikTextBox)
        Me.Controls.Add(Me.PibTextBox)
        Me.Name = "Працівники"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Працівники"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрацівникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрацівникиBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents ПрацівникиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПрацівникиTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПрацівникиTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PibTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AdresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kod_posaduComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents ПосадиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПосадиTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПосадиTableAdapter
    Friend WithEvents ПрацівникиBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
End Class
