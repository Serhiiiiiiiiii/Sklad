Public Class Form23

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Склад)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form16.Show()
        Me.Hide()
    End Sub
End Class