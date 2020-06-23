﻿
#Region "*** Imports ***"

Imports System.IO
Imports System.Text

#End Region

''' <HEADER>
''' Project: My Personal Information Manager
''' Author: Larry Benner
''' Date: 6/17/2020
''' Revisions:
''' </HEADER>
''' 

Public Class FrmMain

#Region "*** Start ***"

    'Indicates current tracker panel to add controls to
    Private CurrentTrackerPanelName As String = Nothing

    'Indicates current contact panel to add controls to
    Private CurrentContactPanelName As String = Nothing


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()
        TmrClock.Start()
        DefineTrackerDataTable()
        CSV2DataTable(dtbTracker, strDataPath & "\" & strTrackersFile)
        DefineContactsDataTable()
        CSV2DataTable(dtbContacts, strDataPath & "\" & strContactsFile)

        DisplayTrackers()
        DisplayContacts()
    End Sub

#End Region

#Region "*** Tracker Panels Display ***"

    Sub DisplayTrackers() Handles cboTracker.SelectedIndexChanged

        flpTracker.Controls.Clear()
        TrackerPanelsAddedCount = 0

        Dim row As DataRow
        Dim strDetail As String
        For Each row In dtbTracker.Rows
            TrackerPanelsAddedCount += 1
            Select Case cboTracker.SelectedIndex
                Case 0 'All Selected
                    CreateTrackerPanel()
                    CreateTrackerNameLabel(CurrentTrackerPanelName, row("Description").ToString)
                    CreateTrackerDateLabel(CurrentTrackerPanelName, Format(row("Date"), "MM/dd/yyyy"))
                    If row("Time").ToString = "True" And row("Bill").ToString = "False" Then
                        CreateTrackerTimeLabel(CurrentTrackerPanelName, Format(row("Date"), "HH:mm tt"))
                    ElseIf row("Bill").ToString = "True" Then
                        CreateTrackerTimeLabel(CurrentTrackerPanelName, "$ " & row("Amount").ToString)
                    End If
                    If row("Appointment").ToString = "True" Then
                        Dim g As New Panel
                        g = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.LightGreen
                    ElseIf row("Bill").ToString = "True" Then
                        Dim g As New Panel
                        g = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.Pink
                    ElseIf row("Other").ToString = "True" Then
                        Dim g As New Panel
                        g = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.Bisque
                    End If

                    CreateTrackerEditButton(CurrentTrackerPanelName)
                    CreateTrackerDeleteButton(CurrentTrackerPanelName)

                Case 1 'Appointment Selected
                    strDetail = row("Appointment").ToString
                    If strDetail = "True" Then
                        CreateTrackerPanel()
                        CreateTrackerNameLabel(CurrentTrackerPanelName, row("Description").ToString)
                        CreateTrackerDateLabel(CurrentTrackerPanelName, Format(row("Date"), "MM/dd/yyyy"))
                        CreateTrackerTimeLabel(CurrentTrackerPanelName, Format(row("Date"), "HH:mm tt"))
                        CreateTrackerEditButton(CurrentTrackerPanelName)
                        CreateTrackerDeleteButton(CurrentTrackerPanelName)
                        Dim g As New Panel
                        g = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.LightGreen


                    End If

                Case 2 'Bill Selected
                    strDetail = row("Bill").ToString
                    If strDetail = "True" Then
                        CreateTrackerPanel()
                        CreateTrackerNameLabel(CurrentTrackerPanelName, row("Description").ToString)
                        CreateTrackerDateLabel(CurrentTrackerPanelName, Format(row("Date"), "MM/dd/yyyy"))
                        CreateTrackerTimeLabel(CurrentTrackerPanelName, "$ " & row("Amount").ToString)
                        CreateTrackerEditButton(CurrentTrackerPanelName)
                        CreateTrackerDeleteButton(CurrentTrackerPanelName)
                        Dim g As New Panel
                        g = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.Pink
                    End If

                Case 3 'Birthday Selected
                    strDetail = row("Birthday").ToString
                    If strDetail = "True" Then
                        CreateTrackerPanel()
                        CreateTrackerNameLabel(CurrentTrackerPanelName, row("Description").ToString)
                        CreateTrackerDateLabel(CurrentTrackerPanelName, Format(row("Date"), "MM/dd/yyyy"))
                        If row("Time").ToString = "True" Then
                            CreateTrackerTimeLabel(CurrentTrackerPanelName, Format(row("Date"), "HH:mm tt"))
                        End If
                        CreateTrackerEditButton(CurrentTrackerPanelName)
                        CreateTrackerDeleteButton(CurrentTrackerPanelName)

                    End If

                Case Else 'Other Selected
                    strDetail = row("Other").ToString
                    If strDetail = "True" Then
                        CreateTrackerPanel()
                        CreateTrackerNameLabel(CurrentTrackerPanelName, row("Description").ToString)
                        CreateTrackerDateLabel(CurrentTrackerPanelName, Format(row("Date"), "MM/dd/yyyy")) 'HH:mm:ss")) '.ToString).Format("d")
                        If row("Time").ToString = "True" And row("Bill").ToString = "False" Then
                            CreateTrackerTimeLabel(CurrentTrackerPanelName, Format(row("Date"), "HH:mm tt"))
                        ElseIf row("Bill").ToString = "True" Then
                            CreateTrackerTimeLabel(CurrentTrackerPanelName, "$ " & row("Amount").ToString)
                        End If
                        CreateTrackerEditButton(CurrentTrackerPanelName)
                        CreateTrackerDeleteButton(CurrentTrackerPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpTracker.Controls(CurrentTrackerPanelName), Panel)
                        g.BackColor = Color.Bisque


                    End If
            End Select
        Next row

        btnAdd.Focus() 'Take the focus off the listbox, keep it from being highlighted

    End Sub

    Public Sub CreateTrackerPanel()

        Dim contactPanel As Panel
        contactPanel = New Panel()

        'Set panel properties
        With contactPanel
            .BorderStyle = CType(1, BorderStyle)
            .BackColor = Color.LightBlue
            .Size = New Size(420, 75)
            .Name = "pnlTracker" + (TrackerPanelsAddedCount + 1).ToString
        End With

        'Add panel to flow layout panel
        flpTracker.Controls.Add(contactPanel)

        'Update panel variables
        CurrentTrackerPanelName = contactPanel.Name

    End Sub

    Public Sub CreateTrackerNameLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactNameLabel As Label
        contactNameLabel = New Label

        'Set Properties
        With contactNameLabel
            .AutoSize = True
            .Location = New Point(10, 8)
            .Name = "lblContactName" + TrackerPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateTrackerDateLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactPhoneLabel As Label
        contactPhoneLabel = New Label

        'Set Properties
        With contactPhoneLabel
            .AutoSize = True
            .Location = New Point(10, 28)
            .Name = "lblContactName" + TrackerPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactPhoneLabel)
            End If
        Next
    End Sub

    Public Sub CreateTrackerTimeLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactTimeLabel As Label
        contactTimeLabel = New Label

        'Set Properties
        With contactTimeLabel
            .AutoSize = True
            .Location = New Point(10, 48)
            .Name = "lblContactName" + TrackerPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactTimeLabel)
            End If
        Next
    End Sub

    Public Sub CreateTrackerEditButton(ByVal panelName As String)
        Dim TrackerEditButton As Button
        TrackerEditButton = New Button

        'Set Properties
        With TrackerEditButton
            .AutoSize = True
            .BackColor = Color.LightBlue
            .Location = New Point(330, 5)
            .Name = "btnEdit" + TrackerPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Edit"
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(TrackerEditButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler TrackerEditButton.Click, AddressOf DynamicEditButton_Click
    End Sub

    Sub DynamicEditButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'Dim parentPanelName As String
        'parentPanelName = Nothing

        For Each controlObject As Control In flpTracker.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    ' Get the datatable row number to edit 
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then

                            intTrackerEditRow = CInt(MyString) - 1 'Used to edit Tracker row

                            ' copy data from datatable to textboxes
                            FrmTracker.tbxDescription.Text = dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Description").ToString
                            FrmTracker.dtpDate.Text = dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Date").ToString

                            If dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Time").ToString = "True" Then
                                FrmTracker.cbxTime.Checked = True
                                FrmTracker.dtpTime.Text = Format(dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Date"), "HH:mm tt")
                            End If

                            If dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Bill").ToString = "True" Then
                                FrmTracker.cbxBill.Checked = True
                                FrmTracker.tbxAmount.Text = dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Amount").ToString
                            End If

                            If dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Appointment").ToString = "True" Then
                                FrmTracker.cbxAppointment.Checked = True
                            End If

                            If dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Birthday").ToString = "True" Then
                                FrmTracker.cbxBirthday.Checked = True
                            End If

                            If dtbTracker.Rows.Item(CInt(MyString) - 1).Item("Other").ToString = "True" Then
                                FrmTracker.cbxOther.Checked = True
                            End If

                            Exit For 'I put "Exit For" in here because once a number is found It should stop testing ***************
                        End If

                    Next
                End If
            Next
        Next

        FrmTracker.btnAddTrackerRecord.Text = "Save"
        Enabled = False
        FrmTracker.Show()

    End Sub

    Public Sub CreateTrackerDeleteButton(ByVal panelName As String)
        Dim contactDeleteButton As Button
        contactDeleteButton = New Button

        'Set Properties
        With contactDeleteButton
            .AutoSize = True
            .BackColor = Color.LightPink
            .Location = New Point(330, 38)
            .Name = "btnDelete" + TrackerPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Delete"
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactDeleteButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler contactDeleteButton.Click, AddressOf DynamicDeleteButton_Click
    End Sub

    Sub DynamicDeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim parentPanelName As String
        parentPanelName = Nothing

        'Remove Handler from Sender
        For Each controlObject As Control In flpTracker.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    'Get the datatable row number to delete
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then
                            Dim intTrackerDeleteRow = CInt(MyString) - 1 'Used to edit Tracker row

                            dtbTracker.Rows.Remove(dtbTracker.Rows(CInt(MyString) - 1))

                            Exit For
                        End If

                    Next

                    RemoveHandler childControlObject.Click, AddressOf DynamicDeleteButton_Click
                    parentPanelName = childControlObject.Parent.Name
                End If

            Next

        Next

        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = parentPanelName Then
                flpTracker.Controls.Remove(controlObject)
                controlObject.Dispose()
            End If
        Next

        'Save the DataTable
        DataTable2CSV(dtbTracker, strDataPath & "\" & strTrackersFile)
        DisplayTrackers()

    End Sub

    Private Sub BtnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        If strTrackerSortOrder = "A" Then
            dtbTracker.DefaultView.Sort = "Date ASC"
            dtbTracker = dtbTracker.DefaultView.ToTable
            strTrackerSortOrder = "D"
        Else
            dtbTracker.DefaultView.Sort = "Date DESC"
            dtbTracker = dtbTracker.DefaultView.ToTable
            strTrackerSortOrder = "A"
        End If

        DataTable2CSV(dtbTracker, strDataPath & "\" & strTrackersFile)
        SaveSettings()
        DisplayTrackers()

    End Sub


#End Region

#Region "*** Contact Panels Display ***"

    Sub DisplayContacts() Handles cboContact.SelectedIndexChanged

        flpContact.Controls.Clear()
        ContactPanelsAddedCount = 0

        Dim row As DataRow
        For Each row In dtbContacts.Rows
            ContactPanelsAddedCount += 1
            Select Case cboContact.SelectedIndex
                Case 0 'All Selected
                    CreateContactPanel()
                    Dim strFullName As String
                    strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                    If strFullName = "  " Then
                        strFullName = row("Company").ToString
                    End If
                    CreateContactNameLabel(CurrentContactPanelName, strFullName)
                    CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                    CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                    CreateContactEditButton(CurrentContactPanelName)
                    CreateContactDeleteButton(CurrentContactPanelName)
                    Select Case row("Groups").ToString
                        Case "Acquaintance"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.LightGreen
                        Case "Family"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.LightBlue
                        Case "Friend"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.Beige
                        Case "Business"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.Gray
                        Case "Other"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.Bisque
                    End Select
                Case 1 'Acquaintance Selected
                    If row("Groups").ToString = "Acquaintance" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactEditButton(CurrentContactPanelName)
                        CreateContactDeleteButton(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.LightGreen
                    End If
                Case 2 'Business Selected
                    If row("Groups").ToString = "Business" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactEditButton(CurrentContactPanelName)
                        CreateContactDeleteButton(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.Gray
                    End If
                Case 3 'Family Selected
                    If row("Groups").ToString = "Family" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactEditButton(CurrentContactPanelName)
                        CreateContactDeleteButton(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.LightBlue
                    End If
                Case 4 'Friend Selected
                    If row("Groups").ToString = "Friend" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactEditButton(CurrentContactPanelName)
                        CreateContactDeleteButton(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.Beige
                    End If
                Case Else 'Other Selected
                    If row("Groups").ToString = "Other" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactEditButton(CurrentContactPanelName)
                        CreateContactDeleteButton(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(flpContact.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.Bisque
                    End If
            End Select
        Next row

        'DisplayContacts()
        BtnAddContact.Focus() 'Take the focus off the listbox, keep it from being highlighted

    End Sub

    Public Sub CreateContactPanel()

        Dim contactPanel As Panel
        contactPanel = New Panel()

        'Set panel properties
        With contactPanel
            .BorderStyle = CType(1, BorderStyle)
            .BackColor = Color.LightBlue
            .Size = New Size(420, 75)
            .Name = "pnlContact" + (ContactPanelsAddedCount + 1).ToString
        End With

        'Add panel to flow layout panel
        flpContact.Controls.Add(contactPanel)

        'Update panel variables
        CurrentContactPanelName = contactPanel.Name

    End Sub

    Public Sub CreateContactNameLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactNameLabel As Label
        contactNameLabel = New Label

        'Set Properties
        With contactNameLabel
            .AutoSize = True
            .Location = New Point(10, 8)
            .Name = "lblContactName" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpContact.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateContactPhoneLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactNameLabel As Label
        contactNameLabel = New Label

        'Set Properties
        With contactNameLabel
            .AutoSize = True
            .Location = New Point(10, 28)
            .Name = "lblPhoneName" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpContact.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateContactEmailLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim contactNameLabel As Label
        contactNameLabel = New Label

        'Set Properties
        With contactNameLabel
            .AutoSize = True
            .Location = New Point(10, 48)
            .Name = "lblEmailName" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpContact.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateContactEditButton(ByVal panelName As String)
        Dim ContactEditButton As Button
        ContactEditButton = New Button

        'Set Properties
        With ContactEditButton
            .AutoSize = True
            .BackColor = Color.LightBlue
            .Location = New Point(330, 5)
            .Name = "btnEdit" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Edit"
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpContact.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(ContactEditButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler ContactEditButton.Click, AddressOf DynamicContactEditButton_Click
    End Sub

    Sub DynamicContactEditButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'Dim parentPanelName As String
        'parentPanelName = Nothing

        For Each controlObject As Control In flpContact.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    ' Get the datatable row number to edit 
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)
                        If IsNumeric(MyString) Then

                            intContactEditRow = CInt(MyString) - 1 'Used to edit Contact row

                            ' copy data from datatable to textboxes
                            FrmContacts.tbxFirstName.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("First Name").ToString
                            FrmContacts.tbxMiddleName.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Middle Name").ToString
                            FrmContacts.tbxLastName.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Last Name").ToString
                            FrmContacts.tbxCompany.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Company").ToString
                            FrmContacts.tbxAddress1.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Address1").ToString
                            FrmContacts.tbxAddress2.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Address2").ToString
                            FrmContacts.tbxCity.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("City").ToString
                            FrmContacts.cbxState.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("State").ToString
                            FrmContacts.mtbZipcode.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Zipcode").ToString
                            FrmContacts.mtbPhone.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Phone").ToString
                            FrmContacts.tbxEmail.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Email").ToString
                            FrmContacts.mtbBirthdate.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Birthdate").ToString
                            FrmContacts.cbxGroups.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Groups").ToString
                            FrmContacts.tbxNotes.Text = dtbContacts.Rows.Item(CInt(MyString) - 1).Item("Notes").ToString

                            Exit For 'I put "Exit For" in here because once a number is found It should stop testing ***************

                        End If
                    Next
                End If
            Next
        Next

        FrmContacts.btnSaveContactRecord.Text = "Save"
        Enabled = False
        FrmContacts.Show()

    End Sub

    Public Sub CreateContactDeleteButton(ByVal panelName As String)
        Dim contactDeleteButton As Button
        contactDeleteButton = New Button

        'Set Properties
        With contactDeleteButton
            .AutoSize = True
            .BackColor = Color.LightPink
            .Location = New Point(330, 38)
            .Name = "btnContactDelete" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Delete"
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In flpContact.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactDeleteButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler contactDeleteButton.Click, AddressOf DynamicContactDeleteButton_Click
    End Sub

    Sub DynamicContactDeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim parentPanelName As String
        parentPanelName = Nothing

        'Remove Handler from Sender
        For Each controlObject As Control In flpContact.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    'Get the datatable row number to delete
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then
                            Dim intContactDeleteRow = CInt(MyString) - 1 'Used to edit Contact row

                            dtbContacts.Rows.Remove(dtbContacts.Rows(CInt(MyString) - 1))

                            Exit For
                        End If

                    Next

                    RemoveHandler childControlObject.Click, AddressOf DynamicContactDeleteButton_Click
                    parentPanelName = childControlObject.Parent.Name
                End If

            Next

        Next

        For Each controlObject As Control In flpTracker.Controls
            If controlObject.Name = parentPanelName Then
                flpTracker.Controls.Remove(controlObject)
                controlObject.Dispose()
            End If
        Next

        'Save the DataTable
        DataTable2CSV(dtbContacts, strDataPath & "\" & strContactsFile)
        DisplayContacts()

    End Sub

    Private Sub BtnContactSort_Click(sender As Object, e As EventArgs) Handles btnContactSort.Click

        If strContactSortOrder = "A" Then
            dtbContacts.DefaultView.Sort = "First Name ASC"
            dtbContacts = dtbContacts.DefaultView.ToTable
            strContactSortOrder = "D"
        Else
            dtbContacts.DefaultView.Sort = "First Name DESC"
            dtbContacts = dtbContacts.DefaultView.ToTable
            strContactSortOrder = "A"
        End If

        DataTable2CSV(dtbContacts, strDataPath & "\" & strContactsFile)
        SaveSettings()
        DisplayContacts()

    End Sub

#End Region

#Region "*** Event Procedures ***"

    Private Sub MnuContacts_Click(sender As Object, e As EventArgs) Handles Form1ToolStripMenuItem.Click, BtnAddContact.Click
        Me.Enabled = False
        FrmContacts.Show()
    End Sub

    Private Sub MnuTracker_Click(sender As Object, e As EventArgs) Handles miTracker.Click, btnAdd.Click
        Me.Enabled = False
        FrmTracker.Show()
    End Sub

    Private Sub TmrClock_Tick(sender As Object, e As EventArgs) Handles TmrClock.Tick
        lblClock.Text = Format(Date.Now, $"dddd: MMMM d, yyyy                  hh:mm:ss tt ")
    End Sub

    Private Sub MnuExit(sender As Object, e As EventArgs) Handles miExit.Click
        SaveSettings()
        Application.Exit()
    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveSettings()
    End Sub

#End Region

#Region "*** Calendar Events ***"
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        'Show the Event Picker if a date is selected
        cbxEventPicker.Visible = True
        cbxEventPicker.DroppedDown = True
        cbxEventPicker.SelectedIndex = 0
        lblSelectTrackerEvent.Show()

    End Sub

    Private Sub CbxEventPicker_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxEventPicker.SelectionChangeCommitted

        'Set the defaults for the Tracker Screen
        FrmTracker.dtpDate.Value = MonthCalendar1.SelectionRange.Start.Date

        Select Case cbxEventPicker.SelectedIndex
            Case 0
                FrmTracker.cbxAppointment.Checked = True
            Case 1
                FrmTracker.cbxBill.Checked = True
            Case 2
                FrmTracker.cbxBirthday.Checked = True
            Case 3
                FrmTracker.cbxOther.Checked = True
            Case Else

        End Select

        cbxEventPicker.Visible = False
        cbxEventPicker.DroppedDown = False
        lblSelectTrackerEvent.Hide()

        Me.Enabled = False
        FrmTracker.Show()

    End Sub

    Private Sub CbxEventPicker_DropDownClosed(sender As Object, e As EventArgs) Handles cbxEventPicker.DropDownClosed

        'Hide the EventPicker and label if focus is lost
        cbxEventPicker.Visible = False
        lblSelectTrackerEvent.Hide()

    End Sub

#End Region

#Region "***** Browser Section *****"

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Process.Start("http://www.google.com/#hl=en&q=" & txbSearch.Text.Replace(" ", "+"))
        txbSearch.Text = ""
        txbSearch.Focus()
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeatherToolStripMenuItem.Click
        Process.Start("https://forecast.weather.gov")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        Process.Start("https://youtube.com")
    End Sub

    Private Sub NewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click
        Process.Start("https://news.google.com")
    End Sub

    Private Sub CoronavirusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoronavirusToolStripMenuItem.Click
        Process.Start("https://ncov2019.live/")
    End Sub

    Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click
        Process.Start("https://www.jango.com/")
    End Sub

    Private Sub MailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailToolStripMenuItem.Click
        Process.Start("https://Mail.google.com")
    End Sub

    Private Sub BtnNotePad_Click(sender As Object, e As EventArgs) Handles btnNotePad.Click
        System.Diagnostics.Process.Start("Notepad++")
    End Sub

#End Region

End Class
