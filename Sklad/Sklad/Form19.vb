Public Class Form19

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Типи_товарів". При необходимости она может быть перемещена или удалена.
        Me.Типи_товарівTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Типи_товарів)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form12.Show()
        Me.Hide()
    End Sub
End Class