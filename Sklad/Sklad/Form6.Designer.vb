<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Товари
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
        Dim Termin_prudatnostiLabel As System.Windows.Forms.Label
        Dim Ymovu_zberigannaLabel As System.Windows.Forms.Label
        Dim YpakovkaLabel As System.Windows.Forms.Label
        Dim NaimenyvannaLabel As System.Windows.Forms.Label
        Dim VurobnukLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.ТовариBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТовариTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ТовариTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.NaimenyvannaTextBox = New System.Windows.Forms.TextBox()
        Me.VurobnukTextBox = New System.Windows.Forms.TextBox()
        Me.Ymovu_zberigannaTextBox = New System.Windows.Forms.TextBox()
        Me.YpakovkaTextBox = New System.Windows.Forms.TextBox()
        Me.Termin_prudatnostiTextBox = New System.Windows.Forms.TextBox()
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
        Termin_prudatnostiLabel = New System.Windows.Forms.Label()
        Ymovu_zberigannaLabel = New System.Windows.Forms.Label()
        YpakovkaLabel = New System.Windows.Forms.Label()
        NaimenyvannaLabel = New System.Windows.Forms.Label()
        VurobnukLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТовариBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ТовариBindingSource
        '
        Me.ТовариBindingSource.DataMember = "Товари"
        Me.ТовариBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'ТовариTableAdapter
        '
        Me.ТовариTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗамовникиTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Nothing
        Me.TableAdapterManager.ПостачальникиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.Типи_товарівTableAdapter = Nothing
        Me.TableAdapterManager.ТовариTableAdapter = Me.ТовариTableAdapter
        '
        'NaimenyvannaTextBox
        '
        Me.NaimenyvannaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТовариBindingSource, "naimenyvanna", True))
        Me.NaimenyvannaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NaimenyvannaTextBox.Location = New System.Drawing.Point(250, 128)
        Me.NaimenyvannaTextBox.Name = "NaimenyvannaTextBox"
        Me.NaimenyvannaTextBox.Size = New System.Drawing.Size(181, 26)
        Me.NaimenyvannaTextBox.TabIndex = 2
        '
        'VurobnukTextBox
        '
        Me.VurobnukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТовариBindingSource, "vurobnuk", True))
        Me.VurobnukTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VurobnukTextBox.Location = New System.Drawing.Point(250, 183)
        Me.VurobnukTextBox.Name = "VurobnukTextBox"
        Me.VurobnukTextBox.Size = New System.Drawing.Size(181, 26)
        Me.VurobnukTextBox.TabIndex = 4
        '
        'Ymovu_zberigannaTextBox
        '
        Me.Ymovu_zberigannaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТовариBindingSource, "ymovu_zberiganna", True))
        Me.Ymovu_zberigannaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Ymovu_zberigannaTextBox.Location = New System.Drawing.Point(250, 239)
        Me.Ymovu_zberigannaTextBox.Name = "Ymovu_zberigannaTextBox"
        Me.Ymovu_zberigannaTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Ymovu_zberigannaTextBox.TabIndex = 6
        '
        'YpakovkaTextBox
        '
        Me.YpakovkaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТовариBindingSource, "ypakovka", True))
        Me.YpakovkaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.YpakovkaTextBox.Location = New System.Drawing.Point(250, 294)
        Me.YpakovkaTextBox.Name = "YpakovkaTextBox"
        Me.YpakovkaTextBox.Size = New System.Drawing.Size(181, 26)
        Me.YpakovkaTextBox.TabIndex = 8
        '
        'Termin_prudatnostiTextBox
        '
        Me.Termin_prudatnostiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ТовариBindingSource, "termin_prudatnosti", True))
        Me.Termin_prudatnostiTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Termin_prudatnostiTextBox.Location = New System.Drawing.Point(250, 351)
        Me.Termin_prudatnostiTextBox.Name = "Termin_prudatnostiTextBox"
        Me.Termin_prudatnostiTextBox.Size = New System.Drawing.Size(181, 26)
        Me.Termin_prudatnostiTextBox.TabIndex = 10
        '
        'Termin_prudatnostiLabel
        '
        Termin_prudatnostiLabel.BackColor = System.Drawing.Color.DarkOrange
        Termin_prudatnostiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Termin_prudatnostiLabel.Location = New System.Drawing.Point(12, 345)
        Termin_prudatnostiLabel.Name = "Termin_prudatnostiLabel"
        Termin_prudatnostiLabel.Size = New System.Drawing.Size(214, 31)
        Termin_prudatnostiLabel.TabIndex = 75
        Termin_prudatnostiLabel.Text = "Термін придатності:"
        Termin_prudatnostiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ymovu_zberigannaLabel
        '
        Ymovu_zberigannaLabel.BackColor = System.Drawing.Color.DarkOrange
        Ymovu_zberigannaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Ymovu_zberigannaLabel.Location = New System.Drawing.Point(12, 233)
        Ymovu_zberigannaLabel.Name = "Ymovu_zberigannaLabel"
        Ymovu_zberigannaLabel.Size = New System.Drawing.Size(214, 31)
        Ymovu_zberigannaLabel.TabIndex = 74
        Ymovu_zberigannaLabel.Text = "Умови зберігання:"
        Ymovu_zberigannaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YpakovkaLabel
        '
        YpakovkaLabel.BackColor = System.Drawing.Color.DarkOrange
        YpakovkaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        YpakovkaLabel.Location = New System.Drawing.Point(12, 288)
        YpakovkaLabel.Name = "YpakovkaLabel"
        YpakovkaLabel.Size = New System.Drawing.Size(214, 31)
        YpakovkaLabel.TabIndex = 73
        YpakovkaLabel.Text = "Упаковка:"
        YpakovkaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NaimenyvannaLabel
        '
        NaimenyvannaLabel.BackColor = System.Drawing.Color.DarkOrange
        NaimenyvannaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NaimenyvannaLabel.Location = New System.Drawing.Point(12, 122)
        NaimenyvannaLabel.Name = "NaimenyvannaLabel"
        NaimenyvannaLabel.Size = New System.Drawing.Size(214, 31)
        NaimenyvannaLabel.TabIndex = 72
        NaimenyvannaLabel.Text = "Найменування:"
        NaimenyvannaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VurobnukLabel
        '
        VurobnukLabel.BackColor = System.Drawing.Color.DarkOrange
        VurobnukLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        VurobnukLabel.Location = New System.Drawing.Point(12, 177)
        VurobnukLabel.Name = "VurobnukLabel"
        VurobnukLabel.Size = New System.Drawing.Size(214, 31)
        VurobnukLabel.TabIndex = 71
        VurobnukLabel.Text = "Виробник:"
        VurobnukLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(81, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 54)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Таблиця ""Товари"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(494, 41)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 69
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(494, -1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 68
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(462, 343)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 67
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(462, 301)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 66
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(462, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 65
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(462, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(462, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(462, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(455, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Товари
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597914_29_krot_info_p_sklad_art_40
        Me.ClientSize = New System.Drawing.Size(611, 404)
        Me.Controls.Add(Termin_prudatnostiLabel)
        Me.Controls.Add(Ymovu_zberigannaLabel)
        Me.Controls.Add(YpakovkaLabel)
        Me.Controls.Add(NaimenyvannaLabel)
        Me.Controls.Add(VurobnukLabel)
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
        Me.Controls.Add(Me.Termin_prudatnostiTextBox)
        Me.Controls.Add(Me.YpakovkaTextBox)
        Me.Controls.Add(Me.Ymovu_zberigannaTextBox)
        Me.Controls.Add(Me.VurobnukTextBox)
        Me.Controls.Add(Me.NaimenyvannaTextBox)
        Me.Name = "Товари"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Товари"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТовариBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents ТовариBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ТовариTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ТовариTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NaimenyvannaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VurobnukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ymovu_zberigannaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YpakovkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Termin_prudatnostiTextBox As System.Windows.Forms.TextBox
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
