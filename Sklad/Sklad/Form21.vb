Public Class Form21

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
        Me.ПостачальникиTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Постачальники)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form14.Show()
        Me.Hide()
    End Sub
End Class