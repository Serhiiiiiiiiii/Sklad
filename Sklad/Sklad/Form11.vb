Public Class Form11

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Посади". При необходимости она может быть перемещена или удалена.
        Me.ПосадиTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Посади)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
        End Select
        If RadioButton1.Checked Then
            ПосадиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ПосадиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПосадиBindingSource.Filter = "naimenyvanna_posadu='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПосадиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ПосадиDataGridView.ColumnCount - 1
            For j = 0 To ПосадиDataGridView.RowCount - 1
                ПосадиDataGridView.Item(i, j).Style.BackColor = Color.White
                ПосадиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ПосадиDataGridView.ColumnCount - 1
            For j = 0 To ПосадиDataGridView.RowCount - 1
                If InStr(ПосадиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ПосадиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ПосадиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Посади.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form18.Show()
        Me.Hide()
    End Sub
End Class