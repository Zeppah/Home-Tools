Imports System.IO

Public Class FrmMemos

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
            Dim newrow As DataRow = dtbMemos.NewRow
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            newrow("Header") = tbxHeading.Text
            newrow("Memo") = s

            dtbMemos.Rows.Add(newrow)
            tbxHeading.Focus()
            tbxHeading.Text = ""
            tbxMemo.Text = ""
        Else 'The EDIT section
            btnAddMemoRecord.Text = "Add"
            'Define the datatable row based on the selected index
            Dim dtbRow As Integer = FrmMain.cboMemos.SelectedIndex
            If dtbRow > 0 Then dtbRow = CInt(dtbRow / 2)


            dtbMemos.Rows.Item(dtbRow).Item("Header") = tbxHeading.Text
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            dtbMemos.Rows.Item(dtbRow).Item("Memo") = s
            DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
            dtbMemos.Clear()
            CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
            FrmMain.cboMemos.Items.Clear()
            FrmMain.FillMemoListBox()
            btnDeleteMemo.Visible = False

            FrmMain.cboMemos.Text = ""
            FrmMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
            Me.Close()
        End If

        'Sort the data table before saving and displaying
        Dim datav As DataView
        datav = dtbMemos.DefaultView
        datav.Sort = "Header ASC" 'or DESC, or anything just search for dataview.
        dtbMemos = datav.ToTable()

        DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
        dtbMemos.Clear()
        CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
        FrmMain.cboMemos.Items.Clear()
        FrmMain.FillMemoListBox()
        Me.Close()
    End Sub

    Private Sub BtnDeleteMemo_Click(sender As Object, e As EventArgs) Handles btnDeleteMemo.Click
        'Define the datatable row based on the selected index
        Dim dtbRow As Integer = FrmMain.cboMemos.SelectedIndex
        If dtbRow > 0 Then dtbRow = CInt(dtbRow / 2)

        dtbMemos.Rows.Remove(dtbMemos.Rows(dtbRow))
        DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
        dtbMemos.Clear()
        CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
        FrmMain.cboMemos.Items.Clear()
        FrmMain.FillMemoListBox()
        FrmMain.cboMemos.Text = ""
        btnDeleteMemo.Visible = False

        FrmMain.cboMemos.Text = ""
        FrmMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index

        Me.Close()

    End Sub

    Private Sub FrmMemos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
        FrmMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
    End Sub

    Private Sub BtnMemoExit_Click(sender As Object, e As EventArgs) Handles btnMemoExit.Click
        FrmMain.Enabled = True
        FrmMain.cboMemos.SelectedIndex = -1 'take the focus off the selected index
        Me.Close()
    End Sub

End Class