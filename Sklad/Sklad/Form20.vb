Public Class Form20

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Товари". При необходимости она может быть перемещена или удалена.
        Me.ТовариTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Товари)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class