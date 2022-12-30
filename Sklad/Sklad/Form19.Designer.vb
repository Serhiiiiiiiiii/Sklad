<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Типи_товарівBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Склад_продуктових_товарівDataSet = New Sklad.Склад_продуктових_товарівDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Типи_товарівTableAdapter = New Sklad.Склад_продуктових_товарівDataSetTableAdapters.Типи_товарівTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Типи_товарівBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Типи_товарівBindingSource
        '
        Me.Типи_товарівBindingSource.DataMember = "Типи товарів"
        Me.Типи_товарівBindingSource.DataSource = Me.Склад_продуктових_товарівDataSet
        '
        'Склад_продуктових_товарівDataSet
        '
        Me.Склад_продуктових_товарівDataSet.DataSetName = "Склад_продуктових_товарівDataSet"
        Me.Склад_продуктових_товарівDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(495, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "З а к р и т и"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Типи_товарівTableAdapter
        '
        Me.Типи_товарівTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.Типи_товарівBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sklad.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(494, 400)
        Me.ReportViewer1.TabIndex = 12
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form19"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Звіт ""Типи товарів"""
        CType(Me.Типи_товарівBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Склад_продуктових_товарівDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Типи_товарівBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Склад_продуктових_товарівDataSet As Sklad.Склад_продуктових_товарівDataSet
    Friend WithEvents Типи_товарівTableAdapter As Sklad.Склад_продуктових_товарівDataSetTableAdapters.Типи_товарівTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
