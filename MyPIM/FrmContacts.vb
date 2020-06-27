Public Class FrmContacts

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

            intContactRecordIndexNumber += 1 'increment the id number for new record

            'Add the new record to the dtbContacts DataTable
            Dim newrow As DataRow = dtbContacts.NewRow

            newrow("id") = intContactRecordIndexNumber
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

            FrmMain.ContactsSort()

            Me.Close()

            'EDIT section
        ElseIf btnSaveContactRecord.Text = "Save" Then
            dtbContacts.Rows.Item(intContactEditRow).Item("First Name") = tbxFirstName.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Middle Name") = tbxMiddleName.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Last Name") = tbxLastName.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Company") = tbxCompany.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Address1") = tbxAddress1.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Address2") = tbxAddress2.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("City") = tbxCity.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("State") = cbxState.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Zipcode") = mtbZipcode.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Phone") = mtbPhone.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Email") = tbxEmail.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Birthdate") = mtbBirthdate.Text
            dtbContacts.Rows.Item(intContactEditRow).Item("Groups") = cbxGroups.Text

            Dim s = tbxNotes.Text.Replace(vbNewLine, "_\n") 'strip Newlines to be able to save .tsv
            dtbContacts.Rows.Item(intContactEditRow).Item("Notes") = s

            dtbContacts.Rows.Item(intContactEditRow).Item("Starred") = cbxStarred.Checked

            If tbxFirstName.Text = "" And tbxMiddleName.Text = "" And tbxLastName.Text = "" Then
                dtbContacts.Rows.Item(intContactEditRow).Item("SortName") = tbxCompany.Text
            Else
                dtbContacts.Rows.Item(intContactEditRow).Item("SortName") = tbxFirstName.Text & " " & tbxMiddleName.Text & " " & tbxLastName.Text
            End If

            'Save the DataTable
            DataTable2CSV(dtbContacts, strDataPath & "\" & strContactsFile)

            FrmMain.Enabled = True
            FrmMain.ContactsSort()
            Me.Close()

        End If
    End Sub

    Private Sub FrmContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
        FrmMain.lblContacts.Focus()

        ' FrmMain.ContactsSort()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FrmMain.Enabled = True
        FrmMain.lblContacts.Focus()

        ' FrmMain.ContactsSort()
        Me.Close()
    End Sub

#End Region

End Class