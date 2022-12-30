Public Class Form17

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Працівники". При необходимости она может быть перемещена или удалена.
        Me.ПрацівникиTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Працівники)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Show()
        Me.Hide()
    End Sub
End Class