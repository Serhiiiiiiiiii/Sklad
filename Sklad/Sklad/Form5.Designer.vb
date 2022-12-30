<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Типи_товарів
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
        Dim OsobluvostiLabel As System.Windows.Forms.Label
        Dim OpusLabel As System.Windows.Forms.Label
        Dim NaimenyvannaLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.Типи_товарівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Типи_товарівTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.Типи_товарівTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.NaimenyvannaTextBox = New System.Windows.Forms.TextBox()
        Me.OpusTextBox = New System.Windows.Forms.TextBox()
        Me.OsobluvostiTextBox = New System.Windows.Forms.TextBox()
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
        OsobluvostiLabel = New System.Windows.Forms.Label()
        OpusLabel = New System.Windows.Forms.Label()
        NaimenyvannaLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Типи_товарівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OsobluvostiLabel
        '
        OsobluvostiLabel.BackColor = System.Drawing.Color.DarkOrange
        OsobluvostiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        OsobluvostiLabel.Location = New System.Drawing.Point(11, 268)
        OsobluvostiLabel.Name = "OsobluvostiLabel"
        OsobluvostiLabel.Size = New System.Drawing.Size(172, 28)
        OsobluvostiLabel.TabIndex = 61
        OsobluvostiLabel.Text = "Особливості:"
        OsobluvostiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpusLabel
        '
        OpusLabel.BackColor = System.Drawing.Color.DarkOrange
        OpusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        OpusLabel.Location = New System.Drawing.Point(11, 200)
        OpusLabel.Name = "OpusLabel"
        OpusLabel.Size = New System.Drawing.Size(172, 28)
        OpusLabel.TabIndex = 60
        OpusLabel.Text = "Опис:"
        OpusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NaimenyvannaLabel
        '
        NaimenyvannaLabel.BackColor = System.Drawing.Color.DarkOrange
        NaimenyvannaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        NaimenyvannaLabel.Location = New System.Drawing.Point(11, 137)
        NaimenyvannaLabel.Name = "NaimenyvannaLabel"
        NaimenyvannaLabel.Size = New System.Drawing.Size(172, 28)
        NaimenyvannaLabel.TabIndex = 59
        NaimenyvannaLabel.Text = "Найменування:"
        NaimenyvannaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Типи_товарівBindingSource
        '
        Me.Типи_товарівBindingSource.DataMember = "Типи товарів"
        Me.Типи_товарівBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'Типи_товарівTableAdapter
        '
        Me.Типи_товарівTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Типи_товарівTableAdapter = Me.Типи_товарівTableAdapter
        Me.TableAdapterManager.ТовариTableAdapter = Nothing
        '
        'NaimenyvannaTextBox
        '
        Me.NaimenyvannaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Типи_товарівBindingSource, "naimenyvanna", True))
        Me.NaimenyvannaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NaimenyvannaTextBox.Location = New System.Drawing.Point(205, 140)
        Me.NaimenyvannaTextBox.Name = "NaimenyvannaTextBox"
        Me.NaimenyvannaTextBox.Size = New System.Drawing.Size(220, 26)
        Me.NaimenyvannaTextBox.TabIndex = 2
        '
        'OpusTextBox
        '
        Me.OpusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Типи_товарівBindingSource, "opus", True))
        Me.OpusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OpusTextBox.Location = New System.Drawing.Point(205, 202)
        Me.OpusTextBox.Name = "OpusTextBox"
        Me.OpusTextBox.Size = New System.Drawing.Size(220, 26)
        Me.OpusTextBox.TabIndex = 4
        '
        'OsobluvostiTextBox
        '
        Me.OsobluvostiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Типи_товарівBindingSource, "osobluvosti", True))
        Me.OsobluvostiTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OsobluvostiTextBox.Location = New System.Drawing.Point(205, 270)
        Me.OsobluvostiTextBox.Name = "OsobluvostiTextBox"
        Me.OsobluvostiTextBox.Size = New System.Drawing.Size(220, 26)
        Me.OsobluvostiTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 45)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Таблиця ""Типи товарів"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(476, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 57
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(476, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 56
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(465, 337)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 55
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(465, 295)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 54
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(465, 253)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 53
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(465, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(465, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(465, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(458, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Типи_товарів
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597897_17_krot_info_p_sklad_art_21
        Me.ClientSize = New System.Drawing.Size(593, 373)
        Me.Controls.Add(OsobluvostiLabel)
        Me.Controls.Add(OpusLabel)
        Me.Controls.Add(NaimenyvannaLabel)
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
        Me.Controls.Add(Me.OsobluvostiTextBox)
        Me.Controls.Add(Me.OpusTextBox)
        Me.Controls.Add(Me.NaimenyvannaTextBox)
        Me.Name = "Типи_товарів"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Типи товарів"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Типи_товарівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents Типи_товарівBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Типи_товарівTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.Типи_товарівTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NaimenyvannaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OsobluvostiTextBox As System.Windows.Forms.TextBox
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
