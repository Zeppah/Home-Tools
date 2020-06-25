Imports System.IO

Public Class FrmMemos
    Private Sub FrmMemos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmMemos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
    End Sub

    Private Sub BtnMemoExit_Click(sender As Object, e As EventArgs) Handles btnMemoExit.Click
        FrmMain.Enabled = True
        Me.Close()
    End Sub

    Private Sub BtnAddMemoRecord_Click(sender As Object, e As EventArgs) Handles btnAddMemoRecord.Click
        'Validate that a description was entered
        If tbxHeading.Text = "" Then
            Dim unused = MsgBox("No Header Entered", vbExclamation, "Input Error")
            Dim unused1 = tbxHeading.Focus()
            Return
        End If

        If btnAddMemoRecord.Text = "Add" Then
            'Add the new record to the dtbMemos DataTable
            Dim newrow As DataRow = dtbMemos.NewRow
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            newrow("Header") = tbxHeading.Text
            newrow("Memo") = s

            dtbMemos.Rows.Add(newrow)

            tbxHeading.Text = ""
            tbxMemo.Text = ""
        Else
            btnAddMemoRecord.Text = "Add"
            dtbMemos.Rows.Item(FrmMain.cboMemos.SelectedIndex).Item("Header") = tbxHeading.Text
            Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
            dtbMemos.Rows.Item(FrmMain.cboMemos.SelectedIndex).Item("Memo") = s
            DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
            dtbMemos.Clear()
            CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
            FrmMain.cboMemos.Items.Clear()
            FrmMain.FillMemoListBox()
            btnDeleteMemo.Visible = False
            Me.Close()
        End If
        DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
        dtbMemos.Clear()
        CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
        FrmMain.cboMemos.Items.Clear()
        FrmMain.FillMemoListBox()

    End Sub

    Private Sub BtnDeleteMemo_Click(sender As Object, e As EventArgs) Handles btnDeleteMemo.Click
        dtbMemos.Rows.Remove(dtbMemos.Rows(FrmMain.cboMemos.SelectedIndex))
        DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
        dtbMemos.Clear()
        CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
        FrmMain.cboMemos.Items.Clear()
        FrmMain.FillMemoListBox()
        FrmMain.cboMemos.Text = ""
        btnDeleteMemo.Visible = False
        Me.Close()

    End Sub
End Class