Public Class Типи_товарів

    Private Sub Типи_товарівBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Типи_товарівBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Склад_продуктових_товарівDataSet)

    End Sub

    Private Sub Типи_товарів_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Типи_товарів". При необходимости она может быть перемещена или удалена.
        Me.Типи_товарівTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Типи_товарів)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Таблиці.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.Типи_товарівBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Склад_продуктових_товарівDataSet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Типи_товарівBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Типи_товарівBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Типи_товарівBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Типи_товарівBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Типи_товарівBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Типи_товарівBindingSource.MovePrevious()
    End Sub
End Class