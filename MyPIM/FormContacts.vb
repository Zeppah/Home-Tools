Public Class FormContacts

#Region "*** Event Handlers ***"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSaveContactRecord.Click

        If tbxFirstName.Text = "" And tbxMiddleName.Text = "" And tbxLastName.Text = "" _
            And tbxCompany.Text = "" Then
            Dim unused = MsgBox("Must enter either a Name or Company!", vbExclamation, "Input Error")
            Dim unused1 = tbxFirstName.Focus()
            Return
        End If

        'ADD section
        If btnSaveContactRecord.Text = "Add" Then


            'Add the new record to the dtbContacts DataTable
            Dim newrow As DataRow = ContactsDataTable.NewRow

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
            newrow("Groups") = cbxGroups.Text

            Dim s = tbxNotes.Text.Replace(vbNewLine, "_\n") 'strip Newlines to be able to save .tsv

            newrow("Notes") = s
            newrow("Starred") = cbxStarred.Checked
            If tbxFirstName.Text = "" And tbxMiddleName.Text = "" And tbxLastName.Text = "" Then
                newrow("SortName") = tbxCompany.Text
            Else
                newrow("SortName") = tbxFirstName.Text & " " & tbxMiddleName.Text & " " & tbxLastName.Text
            End If
            ContactsDataTable.Rows.Add(newrow)

            'Save the DataTable
            DataTable2TSV(ContactsDataTable, ContactsFileName)

            SaveSettings()

            'Clear the input for another record
            tbxFirstName.Text = ""
            tbxMiddleName.Text = ""
            tbxLastName.Text = ""
            tbxCompany.Text = ""
            tbxAddress1.Text = ""
            tbxAddress2.Text = ""
            tbxCity.Text = ""
            cbxState.Text = ""
            mtbZipcode.Text = ""
            mtbPhone.Text = ""
            tbxEmail.Text = ""
            mtbBirthdate.Text = ""
            tbxNotes.Text = ""
            cbxStarred.Checked = False
            'tbxFirstName.Focus()

            FormMain.ContactsSort()

            Me.Close()

            'EDIT section
        ElseIf btnSaveContactRecord.Text = "Save" Then
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("First Name") = tbxFirstName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Middle Name") = tbxMiddleName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Last Name") = tbxLastName.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Company") = tbxCompany.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Address1") = tbxAddress1.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Address2") = tbxAddress2.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("City") = tbxCity.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("State") = cbxState.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Zipcode") = mtbZipcode.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Phone") = mtbPhone.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Email") = tbxEmail.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Birthdate") = mtbBirthdate.Text
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Groups") = cbxGroups.Text

            Dim s = tbxNotes.Text.Replace(vbNewLine, "_\n") 'strip Newlines to be able to save .tsv
            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Notes") = s

            ContactsDataTable.Rows.Item(ContactRowIndex).Item("Starred") = cbxStarred.Checked

            If tbxFirstName.Text = "" And tbxMiddleName.Text = "" And tbxLastName.Text = "" Then
                ContactsDataTable.Rows.Item(ContactRowIndex).Item("SortName") = tbxCompany.Text
            Else
                ContactsDataTable.Rows.Item(ContactRowIndex).Item("SortName") = tbxFirstName.Text & " " & tbxMiddleName.Text & " " & tbxLastName.Text
            End If

            'Save the DataTable
            DataTable2TSV(ContactsDataTable, ContactsFileName)

            FormMain.Enabled = True
            FormMain.ContactsSort()
            Me.Close()

        End If
    End Sub

    Private Sub FrmContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormMain.Enabled = True
        FormMain.lblContacts.Focus()

        ' FrmMain.ContactsSort()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormMain.Enabled = True
        FormMain.lblContacts.Focus()

        ' FrmMain.ContactsSort()
        Me.Close()
    End Sub

#End Region

End Class