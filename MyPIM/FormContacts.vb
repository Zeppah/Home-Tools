Public Class FormContacts

#Region "*** Event Handlers ***"
    Private Sub BtnAddContact_Click(sender As Object, e As EventArgs) Handles BtnAddContact.Click

        'Validate Name or Company was entered
        If TxtFirstName.Text = "" And TxTMiddleName.Text = "" And TxtLastName.Text = "" _
            And TxtCompany.Text = "" Then
            Dim unused = MsgBox("Must enter either a Name or Company!", vbExclamation, "Input Error")
            Dim unused1 = TxtFirstName.Focus()
            Return
        End If

        If BtnAddContact.Text = "Add" Then                      'ADD Section

            'Add the new record to the dtbContacts DataTable
            Dim newrow As DataRow = ContactsDataTable.NewRow

            newrow("First Name") = TxtFirstName.Text
            newrow("Middle Name") = TxTMiddleName.Text
            newrow("Last Name") = TxtLastName.Text
            newrow("Company") = TxtCompany.Text
            newrow("Address1") = TxtAddress1.Text
            newrow("Address2") = TxtAddress2.Text
            newrow("City") = TxtCity.Text
            newrow("State") = CboState.Text
            newrow("Zipcode") = TxtZipcode.Text
            newrow("Phone") = TxtPhone.Text
            newrow("Email") = TxtEmail.Text
            newrow("Birthdate") = TxtBirthdate.Text
            newrow("Groups") = CboGroups.Text
            Dim s = TxtNotes.Text.Replace(vbNewLine, "_\n") 'strip Newlines to be able to save .tsv
            newrow("Notes") = s
            newrow("Starred") = ChkStarred.Checked
            If TxtFirstName.Text = "" And TxTMiddleName.Text = "" And TxtLastName.Text = "" Then
                newrow("SortName") = TxtCompany.Text
            Else
                newrow("SortName") = TxtFirstName.Text & " " & TxTMiddleName.Text & " " & TxtLastName.Text
            End If
            ContactsDataTable.Rows.Add(newrow)

        ElseIf BtnAddContact.Text = "Save" Then                 'EDIT Section

            ContactsDataTable.Rows.Item(ContactRowIndex).Item("First Name") = TxtFirstName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Middle Name") = TxTMiddleName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Last Name") = TxtLastName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Company") = TxtCompany.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Address1") = TxtAddress1.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Address2") = TxtAddress2.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("City") = TxtCity.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("State") = CboState.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Zipcode") = TxtZipcode.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Phone") = TxtPhone.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Email") = TxtEmail.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Birthdate") = TxtBirthdate.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Groups") = CboGroups.Text
            Dim s = TxtNotes.Text.Replace(vbNewLine, "_\n") 'strip Newlines to be able to save .tsv
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Notes") = s
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Starred") = ChkStarred.Checked
            If TxtFirstName.Text = "" And TxTMiddleName.Text = "" And TxtLastName.Text = "" Then
                ContactsDataTable.Rows.Item(ContactRowIndex).Item("SortName") = TxtCompany.Text
            Else
                ContactsDataTable.Rows.Item(ContactRowIndex).Item("SortName") = TxtFirstName.Text & " " & TxTMiddleName.Text & " " & TxtLastName.Text
            End If
        End If

        FormMain.ContactsSort()
        DataTable2TSV(ContactsDataTable, ContactsFileName)
        ExitContacts()
    End Sub

    Private Sub ExitContacts() Handles BtnExitContact.Click
        FormMain.Enabled = True
        Dim unused = FormMain.lblContacts.Focus()
        Close()
    End Sub
#End Region

End Class