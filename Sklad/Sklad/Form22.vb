Public Class Form22

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Замовники". При необходимости она может быть перемещена или удалена.
        Me.ЗамовникиTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Замовники)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form15.Show()
        Me.Hide()
    End Sub
End Class