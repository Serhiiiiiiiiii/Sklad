<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Посади
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
        Dim VumoguLabel As System.Windows.Forms.Label
        Dim OboviazkuLabel As System.Windows.Forms.Label
        Dim OkladLabel As System.Windows.Forms.Label
        Dim Naimenyvanna_posaduLabel As System.Windows.Forms.Label
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.ПосадиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПосадиTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПосадиTableAdapter()
        Me.TableAdapterManager = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager()
        Me.Naimenyvanna_posaduTextBox = New System.Windows.Forms.TextBox()
        Me.OkladTextBox = New System.Windows.Forms.TextBox()
        Me.OboviazkuTextBox = New System.Windows.Forms.TextBox()
        Me.VumoguTextBox = New System.Windows.Forms.TextBox()
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
        VumoguLabel = New System.Windows.Forms.Label()
        OboviazkuLabel = New System.Windows.Forms.Label()
        OkladLabel = New System.Windows.Forms.Label()
        Naimenyvanna_posaduLabel = New System.Windows.Forms.Label()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VumoguLabel
        '
        VumoguLabel.BackColor = System.Drawing.Color.DarkOrange
        VumoguLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        VumoguLabel.Location = New System.Drawing.Point(85, 343)
        VumoguLabel.Name = "VumoguLabel"
        VumoguLabel.Size = New System.Drawing.Size(120, 25)
        VumoguLabel.TabIndex = 57
        VumoguLabel.Text = "Вимоги:"
        VumoguLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OboviazkuLabel
        '
        OboviazkuLabel.BackColor = System.Drawing.Color.DarkOrange
        OboviazkuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        OboviazkuLabel.Location = New System.Drawing.Point(85, 269)
        OboviazkuLabel.Name = "OboviazkuLabel"
        OboviazkuLabel.Size = New System.Drawing.Size(120, 25)
        OboviazkuLabel.TabIndex = 56
        OboviazkuLabel.Text = "Обов'язки:"
        OboviazkuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OkladLabel
        '
        OkladLabel.BackColor = System.Drawing.Color.DarkOrange
        OkladLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        OkladLabel.Location = New System.Drawing.Point(85, 207)
        OkladLabel.Name = "OkladLabel"
        OkladLabel.Size = New System.Drawing.Size(120, 25)
        OkladLabel.TabIndex = 55
        OkladLabel.Text = "Оклад:"
        OkladLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Naimenyvanna_posaduLabel
        '
        Naimenyvanna_posaduLabel.BackColor = System.Drawing.Color.DarkOrange
        Naimenyvanna_posaduLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Naimenyvanna_posaduLabel.Location = New System.Drawing.Point(85, 141)
        Naimenyvanna_posaduLabel.Name = "Naimenyvanna_posaduLabel"
        Naimenyvanna_posaduLabel.Size = New System.Drawing.Size(120, 25)
        Naimenyvanna_posaduLabel.TabIndex = 54
        Naimenyvanna_posaduLabel.Text = "Посада:"
        Naimenyvanna_posaduLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПосадиBindingSource
        '
        Me.ПосадиBindingSource.DataMember = "Посади"
        Me.ПосадиBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'ПосадиTableAdapter
        '
        Me.ПосадиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗамовникиTableAdapter = Nothing
        Me.TableAdapterManager.ПосадиTableAdapter = Me.ПосадиTableAdapter
        Me.TableAdapterManager.ПостачальникиTableAdapter = Nothing
        Me.TableAdapterManager.ПрацівникиTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.Типи_товарівTableAdapter = Nothing
        Me.TableAdapterManager.ТовариTableAdapter = Nothing
        '
        'Naimenyvanna_posaduTextBox
        '
        Me.Naimenyvanna_posaduTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "naimenyvanna_posadu", True))
        Me.Naimenyvanna_posaduTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Naimenyvanna_posaduTextBox.Location = New System.Drawing.Point(224, 139)
        Me.Naimenyvanna_posaduTextBox.Name = "Naimenyvanna_posaduTextBox"
        Me.Naimenyvanna_posaduTextBox.Size = New System.Drawing.Size(153, 26)
        Me.Naimenyvanna_posaduTextBox.TabIndex = 2
        '
        'OkladTextBox
        '
        Me.OkladTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "oklad", True))
        Me.OkladTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OkladTextBox.Location = New System.Drawing.Point(224, 205)
        Me.OkladTextBox.Name = "OkladTextBox"
        Me.OkladTextBox.Size = New System.Drawing.Size(153, 26)
        Me.OkladTextBox.TabIndex = 4
        '
        'OboviazkuTextBox
        '
        Me.OboviazkuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "oboviazku", True))
        Me.OboviazkuTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OboviazkuTextBox.Location = New System.Drawing.Point(224, 267)
        Me.OboviazkuTextBox.Name = "OboviazkuTextBox"
        Me.OboviazkuTextBox.Size = New System.Drawing.Size(153, 26)
        Me.OboviazkuTextBox.TabIndex = 6
        '
        'VumoguTextBox
        '
        Me.VumoguTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПосадиBindingSource, "vumogu", True))
        Me.VumoguTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VumoguTextBox.Location = New System.Drawing.Point(224, 342)
        Me.VumoguTextBox.Name = "VumoguTextBox"
        Me.VumoguTextBox.Size = New System.Drawing.Size(153, 26)
        Me.VumoguTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 45)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Таблиця ""Посади"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button9.Location = New System.Drawing.Point(415, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 36)
        Me.Button9.TabIndex = 52
        Me.Button9.Text = "Таблиця"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkOrange
        Me.Button8.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button8.Location = New System.Drawing.Point(415, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 36)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Закрити"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Location = New System.Drawing.Point(404, 376)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Зберегти"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Location = New System.Drawing.Point(404, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 36)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Видалити"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(404, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Додати"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Location = New System.Drawing.Point(404, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 36)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Остання"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(404, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 36)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Перша"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Location = New System.Drawing.Point(404, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 36)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Наступна"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(397, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Попередня"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Посади
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sklad.My.Resources.Resources._1642597885_4_krot_info_p_sklad_art_6
        Me.ClientSize = New System.Drawing.Size(532, 422)
        Me.Controls.Add(VumoguLabel)
        Me.Controls.Add(OboviazkuLabel)
        Me.Controls.Add(OkladLabel)
        Me.Controls.Add(Naimenyvanna_posaduLabel)
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
        Me.Controls.Add(Me.VumoguTextBox)
        Me.Controls.Add(Me.OboviazkuTextBox)
        Me.Controls.Add(Me.OkladTextBox)
        Me.Controls.Add(Me.Naimenyvanna_posaduTextBox)
        Me.Name = "Посади"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Посади"
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПосадиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents ПосадиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПосадиTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.ПосадиTableAdapter
    Friend WithEvents TableAdapterManager As Sklad.Склад_продуктових_товарівDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Naimenyvanna_posaduTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OkladTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OboviazkuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VumoguTextBox As System.Windows.Forms.TextBox
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
