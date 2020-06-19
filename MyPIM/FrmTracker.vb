
'''' <HEADER>
'''' Project: Tracker Add Record Screen
'''' Author: Larry Benner
'''' Date: 6/17/2020
'''' Revisions:
'''' </HEADER>

Public Class FrmTracker

#Region "*** Event Handlers ***"

    Private Sub BtnAddTrackerRecord_Click(sender As Object, e As EventArgs) Handles btnAddTrackerRecord.Click

        'Validate that a description was entered
        If tbxDescription.Text = "" Then
            Dim unused = MsgBox("No Description Entered", vbExclamation, "Input Error")
            Dim unused1 = tbxDescription.Focus()
            Return
        End If

        'Store input in the TrackerRecord array for saving the record
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

        'Clear the input to add another record
        tbxDescription.Text = ""
        dtpDate.Value = Date.Now
        dtpTime.Value = Date.Now
        tbxAmount.Text = "0"
        cbxTime.Checked = False
        cbxAppointment.Checked = False
        cbxBill.Checked = False
        cbxBirthday.Checked = False
        cbxOther.Checked = False

    End Sub

    Private Sub CkbBill_CheckChanged(sender As Object, e As EventArgs) Handles cbxBill.CheckedChanged
        'Display the Amount field when the Bill category is selected
        If cbxBill.Checked = True Then
            lblAmount.Show()
            tbxAmount.Visible = True
            tbxAmount.Focus()
        Else
            lblAmount.Hide()
            tbxAmount.Visible = False
        End If
    End Sub

    Private Sub CkbTime_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTime.CheckedChanged
        'Display the Time picker when Time is selected
        If cbxTime.Checked Then
            dtpTime.Show()
            dtpTime.Focus()
        Else
            dtpTime.Hide()
        End If
    End Sub

    Private Sub TbxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxAmount.KeyPress
        'Only allow five whole numbers and two decimal places
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
        'Clear out pasted characters
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

    Private Sub FrmTracker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Enabled = True
    End Sub

#End Region

End Class