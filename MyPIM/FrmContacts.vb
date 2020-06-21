Public Class FrmContacts

#Region "*** Event Handlers ***"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If tbxFirstName.Text = "" And tbxMiddleName.Text = "" And tbxLastName.Text = "" _
            And tbxCompany.Text = "" Then
            Dim unused = MsgBox("Must enter either a Name or Company!", vbExclamation, "Input Error")
            Dim unused1 = tbxFirstName.Focus()
            Return
        End If

        'Add the new record to the dtbContacts DataTable
        Dim newrow As DataRow = dtbContacts.NewRow

        newrow("id") = intTrackerRecordIndexNumber
        newrow("First Name") = tbxFirstName.Text
        newrow("Middle Name") = tbxMiddleName.Text
        newrow("Last Name") = tbxLastName.Text
        newrow("Company") = tbxCompany.Text
        newrow("Address1") = tbxAddress1.Text
        newrow("Address2") = tbxAddress2.Text
        newrow("City") = tbxCity.Text
        newrow("State") = cbxState.Text
        newrow("Zipcode") = mtbZipcode.Text
        newrow("Phone") = mtbPhone.Text
        newrow("Email") = tbxEmail.Text
        newrow("Birthdate") = mtbBirthdate.Text
        newrow("Notes") = tbxNotes.Text
        dtbContacts.Rows.Add(newrow)

        'Save the DataTable
        DataTable2CSV(dtbContacts, strDataPath & "\" & strContactsFile)

        SaveSettings()

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
        mtbBirthdate.Text = ""
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