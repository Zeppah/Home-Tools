Public Class FormEvents

#Region "*** Event Handlers ***"

    Private dateTimeValue As New Date   'The date of the event
    Private nextAge As Integer          'Used to calculate the next birthday
    Private nextBirthDate As Date       'The next birthdate for sort and display
    Private Sub BtnAddEventRecord_Click(sender As Object, e As EventArgs) Handles BtnAddEventRecord.Click
        dateTimeValue = DtpDate.Value.Date + DtpTime.Value.TimeOfDay
        nextAge = CInt(DateDiff(DateInterval.Year, dateTimeValue, Date.Today))

        'Validate that a Title was entered
        If TxtTitle.Text = "" Then
            Dim unused = MsgBox("No Title Entered", vbExclamation, "Input Error")
            Dim unused1 = TxtTitle.Focus()
            Return
        End If

        'Validate that a Category was selected
        If ChkAppointment.Checked = False And ChkBill.Checked = False And ChkBirthday.Checked = False And ChkOther.Checked = False Then
            Dim unused = MsgBox("No Category Selected", vbExclamation, "Input Error")
            Return
        End If

        If BtnAddEventRecord.Text = "Add" Then                  'ADD Section

            'Add the new record to the Events DataTable
            Dim newrow As DataRow = EventsDataTable.NewRow

            newrow("Description") = TxtTitle.Text
            newrow("Date") = (DtpDate.Value.Date + DtpTime.Value.TimeOfDay)
            newrow("Amount") = TxtAmount.Text
            newrow("Time") = ChkTime.Checked
            newrow("Appointment") = ChkAppointment.Checked
            newrow("Bill") = ChkBill.Checked
            newrow("Birthday") = ChkBirthday.Checked
            newrow("Other") = ChkOther.Checked
            newrow("Starred") = ChkStarred.Checked

            If ChkBirthday.Checked Then
                CalculateNextBirthdate()
                newrow("SortDate") = nextBirthDate
            Else
                newrow("SortDate") = dateTimeValue
            End If

            EventsDataTable.Rows.Add(newrow)

            'Save Settings, index number has been changed
            SaveSettings()

        ElseIf BtnAddEventRecord.Text = "Save" Then             'EDIT Section

            EventsDataTable.Rows.Item(EventRowIndex).Item("Description") = TxtTitle.Text
            EventsDataTable.Rows.Item(EventRowIndex).Item("Date") = DtpDate.Value.Date + DtpTime.Value.TimeOfDay
            EventsDataTable.Rows.Item(EventRowIndex).Item("Amount") = TxtAmount.Text
            EventsDataTable.Rows.Item(EventRowIndex).Item("Time") = ChkTime.Checked
            EventsDataTable.Rows.Item(EventRowIndex).Item("Appointment") = ChkAppointment.Checked
            EventsDataTable.Rows.Item(EventRowIndex).Item("Bill") = ChkBill.Checked
            EventsDataTable.Rows.Item(EventRowIndex).Item("Birthday") = ChkBirthday.Checked
            EventsDataTable.Rows.Item(EventRowIndex).Item("Other") = ChkOther.Checked
            EventsDataTable.Rows.Item(EventRowIndex).Item("Starred") = ChkStarred.Checked

            If ChkBirthday.Checked Then
                CalculateNextBirthdate()
                EventsDataTable.Rows.Item(EventRowIndex).Item("SortDate") = nextBirthDate
            Else
                EventsDataTable.Rows.Item(EventRowIndex).Item("SortDate") = dateTimeValue
            End If

            'BtnAddEventRecord.Text = "Add"
        End If

        DataTable2TSV(EventsDataTable, EventsFileName)
        FormMain.EventsSort()
        ExitEventForm()
    End Sub

    'Calculates nextBirthDate
    Private Sub CalculateNextBirthdate()
        If (dateTimeValue.Month <= Date.Today.Month And dateTimeValue.Day < Date.Today.Day) _
                    Or dateTimeValue.Month < Date.Today.Month Then
            nextAge += 1
        End If
        If nextAge = 0 Then nextAge = 1
        nextBirthDate = DateAdd("yyyy", nextAge, dateTimeValue)
    End Sub

    'Display the Amount field when the Bill category is selected
    Private Sub CkbBill_CheckChanged(sender As Object, e As EventArgs) Handles ChkBill.CheckedChanged
        If ChkBill.Checked = True Then
            LblAmount.Show()
            TxtAmount.Visible = True
            Dim unused = TxtAmount.Focus()
        Else
            LblAmount.Hide()
            TxtAmount.Visible = False
        End If
    End Sub

    'Display the Time picker when Time is selected
    Private Sub CkbTime_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTime.CheckedChanged
        If ChkTime.Checked Then
            DtpTime.Show()
            Dim unused = DtpTime.Focus()
        Else
            DtpTime.Hide()
        End If
    End Sub

    'Only allow five whole numbers and two decimal places
    Private Sub TbxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        If Char.IsControl(e.KeyChar) Then
        ElseIf Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c Then

            If TxtAmount.TextLength = 5 And TxtAmount.Text.Contains(".") = False Then
                TxtAmount.AppendText(".")
            ElseIf e.KeyChar = "." And TxtAmount.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf Char.IsDigit(e.KeyChar) Then
                If TxtAmount.Text.IndexOf(".") <> -1 Then
                    If TxtAmount.Text.Length >= TxtAmount.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If

        Else
            e.Handled = True
        End If
    End Sub

    'Clear out pasted characters
    Private Sub TbxAmount_LostFocus(sender As Object, e As EventArgs) Handles TxtAmount.LostFocus
        If IsNumeric(TxtAmount.Text) <> True Then
            TxtAmount.Text = "0"
            Dim unused = MsgBox("Invalid Number", vbExclamation, "Input Error")
            Dim unused1 = TxtAmount.Focus()
        End If
    End Sub

    Private Sub ExitEventForm() Handles BtnExit.Click

        FormMain.Enabled = True
        Dim unused = FormMain.LblEvents.Focus()
        Close()

    End Sub

#End Region

End Class