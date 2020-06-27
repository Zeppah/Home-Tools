
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

        If cbxAppointment.Checked = False And cbxBill.Checked = False And cbxBirthday.Checked = False And cbxOther.Checked = False Then
            Dim unused = MsgBox("No Category Selected", vbExclamation, "Input Error")
            Return
        End If

        'ADD section
        If btnAddTrackerRecord.Text = "Add" Then
            intTrackerRecordIndexNumber += 1 'increment the id number for new record

            'Add the new record to the dtbTracker DataTable
            Dim newrow As DataRow = dtbTracker.NewRow

            newrow("id") = intTrackerRecordIndexNumber
            newrow("Description") = tbxDescription.Text
            newrow("Date") = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
            newrow("Amount") = tbxAmount.Text
            newrow("Time") = cbxTime.Checked
            newrow("Appointment") = cbxAppointment.Checked
            newrow("Bill") = cbxBill.Checked
            newrow("Birthday") = cbxBirthday.Checked
            newrow("Other") = cbxOther.Checked
            newrow("Starred") = cbxStarred.Checked

            ''Insert "SortDate" here
            If cbxBirthday.Checked Then

                Dim Birthdate As Date = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
                Dim Age As Integer
                Age = CInt(DateDiff(DateInterval.Year, Birthdate, Date.Today))
                If Age = 0 Then Age = 1
                If Birthdate.Month <= Date.Today.Month And Birthdate.Day < Date.Today.Day _
                    Or Birthdate.Month < Date.Today.Month Then
                    Age += 1
                End If

                Dim NextBirthDate As Date = DateAdd("yyyy", Age, Birthdate)
                    newrow("SortDate") = NextBirthDate
                Else
                    newrow("SortDate") = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
            End If

            dtbTracker.Rows.Add(newrow)
            'Save the DataTable
            DataTable2CSV(dtbTracker, strDataPath & "\" & strTrackersFile)
            'Save the settings, index number has been changed
            SaveSettings()
            Me.Close()
            'EDIT Section
        ElseIf btnAddTrackerRecord.Text = "Save" Then

            dtbTracker.Rows.Item(intTrackerEditRow).Item("Description") = tbxDescription.Text
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Date") = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Amount") = tbxAmount.Text
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Time") = cbxTime.Checked
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Appointment") = cbxAppointment.Checked
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Bill") = cbxBill.Checked
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Birthday") = cbxBirthday.Checked
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Other") = cbxOther.Checked
            dtbTracker.Rows.Item(intTrackerEditRow).Item("Starred") = cbxStarred.Checked

            If cbxBirthday.Checked Then

                Dim Birthdate As Date = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
                Dim Age As Integer
                Age = CInt(DateDiff(DateInterval.Year, Birthdate, Date.Today))
                If Age = 0 Then Age = 1
                If Birthdate.Month <= Date.Today.Month And Birthdate.Day < Date.Today.Day _
                    Or Birthdate.Month < Date.Today.Month Then
                    Age += 1
                End If

                Dim NextBirthDate As Date = DateAdd("yyyy", Age, Birthdate)
                dtbTracker.Rows.Item(intTrackerEditRow).Item("SortDate") = NextBirthDate
            Else
                dtbTracker.Rows.Item(intTrackerEditRow).Item("SortDate") = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay)
            End If

            btnAddTrackerRecord.Text = "Add"
            FrmMain.Enabled = True

            Me.Close()

        End If

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
        cbxStarred.Checked = False
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
        FrmMain.TrackerSort()
        Me.Close()

    End Sub

    Private Sub FrmTracker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        FrmMain.Enabled = True
        FrmMain.TrackerSort()

    End Sub

#End Region

End Class