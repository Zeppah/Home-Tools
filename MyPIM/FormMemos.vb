Imports System.IO

Public Class FormMemos

    Private Sub BtnAddMemoRecord_Click(sender As Object, e As EventArgs) Handles btnAddMemoRecord.Click
        'Validate that a description was entered
        If tbxHeading.Text = "" Then
            Dim unused = MsgBox("No Header Entered", vbExclamation, "Input Error")
            Dim unused1 = tbxHeading.Focus()
            Return
        End If

        'The ADD section
        If btnAddMemoRecord.Text = "Add" Then
            'Add the new record to the dtbMemos DataTable
            Dim newrow As DataRow = MemosDataTable.NewRow
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            newrow("Header") = tbxHeading.Text
            newrow("Memo") = s

            MemosDataTable.Rows.Add(newrow)
            tbxHeading.Focus()
            tbxHeading.Text = ""
            tbxMemo.Text = ""
        Else 'The EDIT section
            btnAddMemoRecord.Text = "Add"
            'Define the datatable row based on the selected index
            Dim dtbRow As Integer = FormMain.cboMemos.SelectedIndex
            If dtbRow > 0 Then dtbRow = CInt(dtbRow / 2)


            MemosDataTable.Rows.Item(dtbRow).Item("Header") = tbxHeading.Text
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            MemosDataTable.Rows.Item(dtbRow).Item("Memo") = s
            DataTable2CSV(MemosDataTable, UserDataPath & "\" & strMemosFile)
            MemosDataTable.Clear()
            CSV2DataTable(MemosDataTable, UserDataPath & "\" & strMemosFile)
            FormMain.cboMemos.Items.Clear()
            FormMain.FillMemoListBox()
            btnDeleteMemo.Visible = False

            FormMain.cboMemos.Text = ""
            FormMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
            Me.Close()
        End If

        'Sort the data table before saving and displaying
        Dim datav As DataView
        datav = MemosDataTable.DefaultView
        datav.Sort = "Header ASC" 'or DESC, or anything just search for dataview.
        MemosDataTable = datav.ToTable()

        DataTable2CSV(MemosDataTable, UserDataPath & "\" & strMemosFile)
        MemosDataTable.Clear()
        CSV2DataTable(MemosDataTable, UserDataPath & "\" & strMemosFile)
        FormMain.cboMemos.Items.Clear()
        FormMain.FillMemoListBox()
        Me.Close()
    End Sub

    Private Sub BtnDeleteMemo_Click(sender As Object, e As EventArgs) Handles btnDeleteMemo.Click
        'Define the datatable row based on the selected index
        Dim dtbRow As Integer = FormMain.cboMemos.SelectedIndex
        If dtbRow > 0 Then dtbRow = CInt(dtbRow / 2)

        MemosDataTable.Rows.Remove(MemosDataTable.Rows(dtbRow))
        DataTable2CSV(MemosDataTable, UserDataPath & "\" & strMemosFile)
        MemosDataTable.Clear()
        CSV2DataTable(MemosDataTable, UserDataPath & "\" & strMemosFile)
        FormMain.cboMemos.Items.Clear()
        FormMain.FillMemoListBox()
        FormMain.cboMemos.Text = ""
        btnDeleteMemo.Visible = False

        FormMain.cboMemos.Text = ""
        FormMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
        FormMain.lblMemos.Focus()

        Me.Close()

    End Sub

    Private Sub FrmMemos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormMain.Enabled = True
        FormMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
        FormMain.lblMemos.Focus()
    End Sub

    Private Sub BtnMemoExit_Click(sender As Object, e As EventArgs) Handles btnMemoExit.Click
        FormMain.Enabled = True
        FormMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
        FormMain.lblMemos.Focus()
        Me.Close()
    End Sub

End Class