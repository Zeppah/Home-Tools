Public Class FrmContacts

#Region "*** Event Handlers ***"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Store input in the TrackerRecord array for saving the record
        intContactRecordIndexNumber += 1
        strContactRecord(0) = intContactRecordIndexNumber.ToString
        strContactRecord(1) = tbxFirstName.Text
        strContactRecord(2) = tbxMiddleName.Text
        strContactRecord(3) = tbxLastName.Text
        strContactRecord(4) = tbxCompany.Text
        strContactRecord(5) = tbxAddress1.Text
        strContactRecord(6) = tbxAddress2.Text
        strContactRecord(7) = tbxCity.Text
        strContactRecord(8) = cbxState.Text
        strContactRecord(9) = mtbZipcode.Text
        strContactRecord(10) = mtbPhone.Text
        strContactRecord(11) = tbxEmail.Text
        strContactRecord(12) = mtbBirthday.Text
        strContactRecord(13) = tbxNotes.Text

        SaveSettings()
        SaveContactRecord()

        'Clear the input for another record
        tbxFirstName.Text = ""
        tbxMiddleName.Text = ""
        tbxLastName.Text = ""
        tbxCompany.Text = ""
        tbxAddress1.Text = ""
        tbxAddress1.Text = ""
        tbxCity.Text = ""
        cbxState.Text = ""
        mtbZipcode.Text = ""
        mtbPhone.Text = ""
        tbxEmail.Text = ""
        mtbBirthday.Text = ""
        tbxNotes.Text = ""

    End Sub

    Private Sub FrmContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FrmMain.Enabled = True
        Me.Close()
    End Sub

#End Region

End Class