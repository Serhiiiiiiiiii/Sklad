<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Постачальники
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
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim NaimenyvannaLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.ПостачальникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПостачальникиTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПостачальникиTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.NaimenyvannaTextBox = New System.Windows.Forms.TextBox()
        Me.AdresaTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
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
        TelefonLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        NaimenyvannaLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПостачальникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TelefonLabel
        '
        TelefonLabel.BackColor = System.Drawing.Color.DarkOrange
        TelefonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        TelefonLabel.Location = New System.Drawing.Point(41, 287)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(167, 25)
        TelefonLabel.TabIndex = 67
        TelefonLabel.Text = "Телефон:"
        TelefonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdresaLabel
        '
        AdresaLabel.BackColor = System.Drawing.Color.DarkOrange
        AdresaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        AdresaLabel.Location = New System.Drawing.Point(41, 212)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(167, 25)
        AdresaLabel.TabIndex = 57
        AdresaLabel.Text = "Адреса:"
        AdresaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NaimenyvannaLabel
        '
        NaimenyvannaLabel.BackColor = System.Drawing.Color.DarkOrange
        NaimenyvannaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NaimenyvannaLabel.Location = New System.Drawing.Point(41, 145)
        NaimenyvannaLabel.Name = "NaimenyvannaLabel"
        NaimenyvannaLabel.Size = New System.Drawing.Size(167, 25)
        NaimenyvannaLabel.TabIndex = 56
        NaimenyvannaLabel.Text = "Найменування:"
        NaimenyvannaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПостачальникиBindingSource
        '
        Me.ПостачальникиBindingSource.DataMember = "Постачальники"
        Me.ПостачальникиBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'ПостачальникиTableAdapter
        '
        Me.ПостачальникиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗамовникиTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПостачальникиTableAdapter = Me.ПостачальникиTableAdapter
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.Типи_товарівTableAdapter = Nothing
        Me.TableAdapterManager.ТовариTableAdapter = Nothing
        '
        'NaimenyvannaTextBox
        '
        Me.NaimenyvannaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПостачальникиBindingSource, "naimenyvanna", True))
        Me.NaimenyvannaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NaimenyvannaTextBox.Location = New System.Drawing.Point(239, 145)
        Me.NaimenyvannaTextBox.Name = "NaimenyvannaTextBox"
        Me.NaimenyvannaTextBox.Size = New System.Drawing.Size(201, 26)
        Me.NaimenyvannaTextBox.TabIndex = 2
        '
        'AdresaTextBox
        '
        Me.AdresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПостачальникиBindingSource, "adresa", True))
        Me.AdresaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AdresaTextBox.Location = New System.Drawing.Point(239, 212)
        Me.AdresaTextBox.Name = "AdresaTextBox"
        Me.AdresaTextBox.Size = New System.Drawing.Size(201, 26)
        Me.AdresaTextBox.TabIndex = 4
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПостачальникиBindingSource, "telefon", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(239, 287)
        Me.MaskedTextBox1.Mask = "+00(000)00-000-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(201, 26)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 48)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Таблиця ""Постачальники"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(515, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 66
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(515, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 65
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(504, 336)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(504, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(504, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(504, 210)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(504, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(504, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(497, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Постачальники
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597928_26_krot_info_p_sklad_art_37
        Me.ClientSize = New System.Drawing.Size(632, 384)
        Me.Controls.Add(TelefonLabel)
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
        Me.Controls.Add(AdresaLabel)
        Me.Controls.Add(NaimenyvannaLabel)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.AdresaTextBox)
        Me.Controls.Add(Me.NaimenyvannaTextBox)
        Me.Name = "Постачальники"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Постачальники"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПостачальникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents ПостачальникиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПостачальникиTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПостачальникиTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NaimenyvannaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
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
End Class
