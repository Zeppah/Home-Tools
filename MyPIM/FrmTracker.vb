
'''' *** Header ***
'''' Project: Tracker Add/Edit Screen
'''' Author: Larry Benner
'''' Date: 6/17/2020
'''' Revisions:
'''' ***  End Header ***

Public Class FrmTracker

#Region "*** Event Handlers ***"

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Validate that a description was entered
        If tbxDescription.Text = "" Then
            Dim unused = MsgBox("No Description Entered", vbExclamation, "Input Error")
            Dim unused1 = tbxDescription.Focus()
            Return
        End If

        intRecordIndexNumber += 1
        strTrackerRecord(0) = intRecordIndexNumber.ToString
        strTrackerRecord(1) = tbxDescription.Text
        strTrackerRecord(2) = CStr((dtpDate.Value.Date + dtpTime.Value.TimeOfDay).Ticks)
        strTrackerRecord(3) = tbxAmount.Text
        strTrackerRecord(4) = cbxTime.Checked.ToString
        strTrackerRecord(5) = cbxAppointment.Checked.ToString
        strTrackerRecord(6) = cbxBill.Checked.ToString
        strTrackerRecord(7) = cbxBirthday.Checked.ToString
        strTrackerRecord(8) = cbxOther.Checked.ToString

        SaveSettings()
        SaveRecord()

        FrmMain.Enabled = True
        Me.Close()

    End Sub

    Private Sub CkbTime_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTime.CheckedChanged
        If cbxTime.Checked Then
            dtpTime.Show()
            dtpTime.Focus()
        Else
            dtpTime.Hide()
        End If
    End Sub

    Private Sub CkbBill_CheckChanged(sender As Object, e As EventArgs) Handles cbxBill.CheckedChanged
        If cbxBill.Checked = True Then
            lblAmount.Show()
            tbxAmount.Visible = True
            tbxAmount.Focus()
        Else
            lblAmount.Hide()
            tbxAmount.Visible = False
        End If
    End Sub

    Private Sub TbxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxAmount.KeyPress
        If Char.IsControl(e.KeyChar) Then
        ElseIf Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c Then

            If tbxAmount.TextLength = 5 And tbxAmount.Text.Contains(".") = False Then
                tbxAmount.AppendText(".")
            ElseIf e.KeyChar = "." And tbxAmount.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf Char.IsDigit(e.KeyChar) Then
                If tbxAmount.Text.IndexOf(".") <> -1 Then
                    If tbxAmount.Text.Length >= tbxAmount.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbxAmount_LostFocus(sender As Object, e As EventArgs) Handles tbxAmount.LostFocus
        If IsNumeric(tbxAmount.Text) <> True Then
            tbxAmount.Text = "0"
            MsgBox("Invalid Number", vbExclamation, "Input Error")
            tbxAmount.Focus()
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FrmMain.Enabled = True
        Me.Close()
    End Sub

#End Region

End Class