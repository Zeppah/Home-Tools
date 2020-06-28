Public Class FormMemos

    'Add and Edit
    Private Sub BtnAddMemo_Click(sender As Object, e As EventArgs) Handles BtnAddMemo.Click

        'Validate that a Title was entered
        If TxtTitle.Text = "" Then
            Dim unused = MsgBox("No title entered.", vbExclamation, "Input Error")
            Dim unused1 = TxtTitle.Focus()
            Return
        End If

        If BtnAddMemo.Text = "Add" Then                         'ADD Section

            Dim newrow As DataRow = MemosDataTable.NewRow

            newrow("Title") = TxtTitle.Text
            newrow("Memo") = TxtMemo.Text.Replace(vbNewLine, "_\n")

            MemosDataTable.Rows.Add(newrow)

        Else                                                    'EDIT section

            'Assign the datatable row based on the selected index
            Dim dtbRow As Integer = FormMain.LstMemos.SelectedIndex

            MemosDataTable.Rows.Item(dtbRow).Item("Title") = TxtTitle.Text
            Dim s = TxtMemo.Text.Replace(vbNewLine, "_\n")
            MemosDataTable.Rows.Item(dtbRow).Item("Memo") = s

        End If

        'Sort the data table before saving and displaying
        Dim datav As DataView
        datav = MemosDataTable.DefaultView
        datav.Sort = "Title ASC"
        MemosDataTable = datav.ToTable()

        DataTable2TSV(MemosDataTable, MemosFileName)

        ExitMemoForm()
    End Sub

    'Delete
    Private Sub BtnDeleteMemo_Click(sender As Object, e As EventArgs) Handles BtnDeleteMemo.Click

        MemosDataTable.Rows.Remove(MemosDataTable.Rows(FormMain.LstMemos.SelectedIndex))
        DataTable2TSV(MemosDataTable, MemosFileName)

        ExitMemoForm()
    End Sub

    'Exit
    Private Sub ExitMemoForm() Handles BtnExitMemo.Click
        FormMain.LstMemos.Items.Clear()
        FormMain.FillMemoListBox()
        FormMain.Enabled = True
        Dim unused = FormMain.lblMemos.Focus()
        Close()
    End Sub

End Class