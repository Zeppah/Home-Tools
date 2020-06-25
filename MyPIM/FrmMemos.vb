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

        'Add the new record to the dtbMemos DataTable
        Dim newrow As DataRow = dtbMemos.NewRow
        Dim s = tbxMemo.Text.Replace(vbNewLine, "_\n")
        newrow("Header") = tbxHeading.Text
        newrow("Memo") = s

        dtbMemos.Rows.Add(newrow)

        tbxHeading.Text = ""
        tbxMemo.Text = ""

        DataTable2CSV(dtbMemos, strDataPath & "\" & strMemosFile)
        dtbMemos.Clear()
        CSV2DataTable(dtbMemos, strDataPath & "\" & strMemosFile)
        FrmMain.cboMemos.Items.Clear()
        FrmMain.FillMemoListBox()

    End Sub

End Class