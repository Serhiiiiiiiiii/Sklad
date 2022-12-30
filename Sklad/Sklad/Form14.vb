Public Class Form14

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Склад_продуктових_товарівDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
        Me.ПостачальникиTableAdapter.Fill(Me.Склад_продуктових_товарівDataSet.Постачальники)

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
        End Select
        If RadioButton1.Checked Then
            ПостачальникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ПостачальникиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ПостачальникиBindingSource.Filter = "naimenyvanna='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ПостачальникиBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ПостачальникиDataGridView.ColumnCount - 1
            For j = 0 To ПостачальникиDataGridView.RowCount - 1
                ПостачальникиDataGridView.Item(i, j).Style.BackColor = Color.White
                ПостачальникиDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ПостачальникиDataGridView.ColumnCount - 1
            For j = 0 To ПостачальникиDataGridView.RowCount - 1
                If InStr(ПостачальникиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ПостачальникиDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    ПостачальникиDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Постачальники.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form21.Show()
        Me.Hide()
    End Sub
End Class