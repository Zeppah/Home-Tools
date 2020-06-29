
''' <HEADER>
''' Project: My Personal Information Manager
''' Author: Larry Benner
''' Date: 6/17/2020
''' Revisions:
''' </HEADER>
''' 

Public Class FormMain

#Region "*** Start ***"

    'Indicates current Event panel to add controls to
    Private CurrentEventsPanelName As String = Nothing

    'Indicates current contact panel to add controls to
    Private CurrentContactPanelName As String = Nothing


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()
        TmrClock.Start()
        AddEventsDataTableColumns()
        TSV2DataTable(EventsDataTable, EventsFileName)
        AddContactsDataTableColumns()
        TSV2DataTable(ContactsDataTable, ContactsFileName)
        AddMemosDataTableColumns()
        TSV2DataTable(MemosDataTable, MemosFileName)
        DisplayEvents()
        DisplayContacts()
        FillMemoListBox()

    End Sub

#End Region

#Region "*** Event Panels Display ***"

    Sub DisplayEvents() Handles CboEventList.SelectedIndexChanged, CboEventTime.SelectedIndexChanged

        FlpEvents.Controls.Clear()
        EventPanelsAddedCount = 0
        Dim timeperiod As Integer
        Dim row As DataRow
        Dim strDetail As String
        Dim EndDate As Date
        Dim result As Integer



        For Each row In EventsDataTable.Rows
            EventPanelsAddedCount += 1 ' This counts the rows to name the buttons to corraspond to the DataTable record

            'Set the time period to display Event panels
            Select Case CboEventTime.SelectedIndex
                Case 0 'All
                    result = -1
                Case 1 'Today
                    timeperiod = 0
                    EndDate = Today.AddDays(timeperiod)
                    result = DateTime.Compare(CDate(row("SortDate")), EndDate)
                Case 2 '7 Days
                    timeperiod = 7
                    EndDate = Today.AddDays(timeperiod)
                    result = DateTime.Compare(CDate(row("SortDate")), EndDate)
                Case 3 '30 days
                    timeperiod = 30
                    EndDate = Today.AddDays(timeperiod)
                    result = DateTime.Compare(CDate(row("SortDate")), EndDate)
                Case 4 '365 days
                    timeperiod = 365
                    EndDate = Today.AddDays(timeperiod)
                    result = DateTime.Compare(CDate(row("SortDate")), EndDate)
            End Select

            If result <= 0 Then 'The row SortDate is before or equal to the EndDate selected.

                Select Case CboEventList.SelectedIndex
                    Case 0 'All Selected
                        CreateEventsPanel()
                        CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)
                        If row("Time").ToString = "True" And row("Bill").ToString = "False" And row("Birthday").ToString = "False" Then
                            CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                        ElseIf row("Bill").ToString = "True" Then
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, "$ " & row("Amount").ToString)
                        ElseIf row("Birthday").ToString = "True" Then
                            Dim Birthdate As Date = CDate(row("Date"))  ' Birthdate
                            Dim Age As Integer
                            Age = CInt(DateDiff(DateInterval.Year, Birthdate, Date.Today))
                            If Age = 0 Then Age = 1
                            If Birthdate.Month <= Date.Today.Month And Birthdate.Day < Date.Today.Day Or Birthdate.Month < Date.Today.Month Then
                                Age += 1
                            End If

                            Dim NextBirthDate As Date = DateAdd("yyyy", Age, Birthdate)

                            CreateEventDateLabel(CurrentEventsPanelName, Format(NextBirthDate, "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, Age.ToString)
                        ElseIf row("Appointment").ToString = "True" Then
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                        ElseIf row("Other").ToString = "True" Then
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                        End If

                        If row("Appointment").ToString = "True" Then
                            Dim g As New Panel
                            g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.LightGreen
                        ElseIf row("Bill").ToString = "True" Then
                            Dim g As New Panel
                            g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.Pink
                        ElseIf row("Other").ToString = "True" Then
                            Dim g As New Panel
                            g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.Bisque
                        End If

                        CreateEventsPanelButtons(CurrentEventsPanelName)

                    Case 1 'Appointment Selected
                        strDetail = row("Appointment").ToString
                        If strDetail = "True" Then
                            CreateEventsPanel()
                            CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                            CreateEventsPanelButtons(CurrentEventsPanelName)
                            Dim g As New Panel
                            g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.LightGreen


                        End If

                    Case 2 'Bill Selected
                        strDetail = row("Bill").ToString
                        If strDetail = "True" Then
                            CreateEventsPanel()
                            CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, "$ " & row("Amount").ToString)
                            CreateEventsPanelButtons(CurrentEventsPanelName)
                            Dim g As New Panel
                            g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.Pink
                        End If

                    Case 3 'Birthday Selected
                        strDetail = row("Birthday").ToString
                        If strDetail = "True" Then
                            CreateEventsPanel()
                            CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)

                            Dim Birthdate As Date = CDate(row("Date"))  ' Birthdate
                            Dim Age As Integer
                            Age = CInt(DateDiff(DateInterval.Year, Birthdate, Date.Today))
                            If Birthdate.Month <= Date.Today.Month And Birthdate.Day < Date.Today.Day _
                    Or Birthdate.Month < Date.Today.Month Then
                                Age += 1
                            End If
                            Dim NextBirthDate As Date = DateAdd("yyyy", Age, Birthdate)

                            CreateEventDateLabel(CurrentEventsPanelName, Format(NextBirthDate, "MM/dd/yyyy"))
                            CreateEventTimeLabel(CurrentEventsPanelName, Age.ToString)

                            CreateEventsPanelButtons(CurrentEventsPanelName)

                        End If

                    Case 4 'Other Selected
                        strDetail = row("Other").ToString
                        If strDetail = "True" Then
                            CreateEventsPanel()
                            CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)
                            CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy")) 'HH:mm:ss")) '.ToString).Format("d")
                            If row("Time").ToString = "True" And row("Bill").ToString = "False" Then
                                CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                            ElseIf row("Bill").ToString = "True" Then
                                CreateEventTimeLabel(CurrentEventsPanelName, "$ " & row("Amount").ToString)
                            End If
                            CreateEventsPanelButtons(CurrentEventsPanelName)
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                            g.BackColor = Color.Bisque


                        End If
                    Case 5 'Starred Item
                        strDetail = row("Starred").ToString
                        If strDetail = "True" Then
                            CreateEventsPanel()
                            CreateEventNameLabel(CurrentEventsPanelName, row("Description").ToString)
                            If row("Time").ToString = "True" And row("Bill").ToString = "False" And row("Birthday").ToString = "False" Then
                                CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                            ElseIf row("Bill").ToString = "True" Then
                                CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                                CreateEventTimeLabel(CurrentEventsPanelName, "$ " & row("Amount").ToString)
                            ElseIf row("Birthday").ToString = "True" Then
                                Dim Birthdate As Date = CDate(row("Date"))  ' Birthdate
                                Dim Age As Integer
                                Age = CInt(DateDiff(DateInterval.Year, Birthdate, Date.Today))
                                If Age = 0 Then Age = 1
                                If Birthdate.Month <= Date.Today.Month And Birthdate.Day < Date.Today.Day Or Birthdate.Month < Date.Today.Month Then
                                    Age += 1
                                End If

                                Dim NextBirthDate As Date = DateAdd("yyyy", Age, Birthdate)

                                CreateEventDateLabel(CurrentEventsPanelName, Format(NextBirthDate, "MM/dd/yyyy"))
                                CreateEventTimeLabel(CurrentEventsPanelName, Age.ToString)
                            ElseIf row("Appointment").ToString = "True" Then
                                CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                                CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                            ElseIf row("Other").ToString = "True" Then
                                CreateEventDateLabel(CurrentEventsPanelName, Format(row("Date"), "MM/dd/yyyy"))
                                CreateEventTimeLabel(CurrentEventsPanelName, Format(row("Date"), "HH:mm tt"))
                            End If

                            If row("Appointment").ToString = "True" Then
                                Dim g As Panel
                                g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                                g.BackColor = Color.LightGreen
                            ElseIf row("Bill").ToString = "True" Then
                                Dim g As Panel
                                g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                                g.BackColor = Color.Pink
                            ElseIf row("Other").ToString = "True" Then
                                Dim g As Panel
                                g = DirectCast(FlpEvents.Controls(CurrentEventsPanelName), Panel)
                                g.BackColor = Color.Bisque
                            End If

                            CreateEventsPanelButtons(CurrentEventsPanelName)
                        End If

                End Select
            End If
        Next row

        LblEvents.Focus() 'Take the focus off the listbox, keep it from being highlighted

    End Sub

    Public Sub CreateEventsPanel()

        Dim eventPanel As Panel
        eventPanel = New Panel()

        'Set panel properties
        With eventPanel
            .BorderStyle = CType(1, BorderStyle)
            .BackColor = Color.LightBlue
            .Size = New Size(420, 75)
            .Name = "PnlEvent" + (EventPanelsAddedCount + 1).ToString
        End With

        'Add panel to flow layout panel
        FlpEvents.Controls.Add(eventPanel)

        'Update panel variables
        CurrentEventsPanelName = eventPanel.Name

    End Sub

    Public Sub CreateEventNameLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim eventNameLabel As Label
        eventNameLabel = New Label

        'Set Properties
        With eventNameLabel
            .AutoSize = True
            .Location = New Point(10, 8)
            .Name = "lblContactName" + EventPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(eventNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateEventDateLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim eventDateLabel As Label
        eventDateLabel = New Label

        'Set Properties 
        With eventDateLabel
            .AutoSize = True
            .Location = New Point(10, 28)
            .Name = "lblContactName" + EventPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(eventDateLabel)
            End If
        Next
    End Sub

    Public Sub CreateEventTimeLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim eventTimeLabel As Label
        eventTimeLabel = New Label

        'Set Properties
        With eventTimeLabel
            .AutoSize = True
            .Location = New Point(10, 48)
            .Name = "lblContactName" + EventPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = textToShow
        End With

        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(eventTimeLabel)
            End If
        Next
    End Sub

    Public Sub CreateEventsPanelButtons(ByVal panelName As String)
        Dim EventDeleteButton As Button
        EventDeleteButton = New Button
        Dim EventEditButton As Button
        EventEditButton = New Button

        'Set Properties of the Event Edit button
        With EventEditButton
            .AutoSize = True
            .BackColor = Color.LightBlue
            .Location = New Point(330, 5)
            .Name = "btnEdit" + EventPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Edit"
        End With

        'Set Properties
        With EventDeleteButton
            .AutoSize = True
            .BackColor = Color.LightPink
            .Location = New Point(330, 38)
            .Name = "btnDelete" + EventPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Delete"
        End With


        'Loop through panels and add new label to passed panel
        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(EventDeleteButton)
                controlObject.Controls.Add(EventEditButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler EventDeleteButton.Click, AddressOf DynamicEventDeleteButton_Click
        AddHandler EventEditButton.Click, AddressOf DynamicEventEditButton_Click


    End Sub

    Sub DynamicEventEditButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        For Each controlObject As Control In FlpEvents.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    ' Get the datatable row number to edit 
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then

                            EventRowIndex = CInt(MyString) - 1 'Used to edit Event row

                            ' copy data from datatable to textboxes
                            FormEvents.TxtTitle.Text = EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Description").ToString
                            FormEvents.DtpDate.Text = EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Date").ToString

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Time").ToString = "True" Then
                                FormEvents.ChkTime.Checked = True
                                FormEvents.DtpTime.Text = Format(EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Date"), "HH:mm tt")
                            End If

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Bill").ToString = "True" Then
                                FormEvents.ChkBill.Checked = True
                                FormEvents.TxtAmount.Text = EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Amount").ToString
                            End If

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Appointment").ToString = "True" Then
                                FormEvents.ChkAppointment.Checked = True
                            End If

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Birthday").ToString = "True" Then
                                FormEvents.ChkBirthday.Checked = True
                            End If

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Other").ToString = "True" Then
                                FormEvents.ChkOther.Checked = True
                            End If

                            If EventsDataTable.Rows.Item(CInt(MyString) - 1).Item("Starred").ToString = "True" Then
                                FormEvents.ChkStarred.Checked = True
                            End If

                            Exit For 'I put "Exit For" in here because once a number is found It should stop testing ***************
                        End If

                    Next
                End If
            Next
        Next

        FormEvents.BtnAddEventRecord.Text = "Save"
        Enabled = False
        FormEvents.Show()

    End Sub

    Sub DynamicEventDeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim parentPanelName As String
        parentPanelName = Nothing

        'Remove Handler from Sender
        For Each controlObject As Control In FlpEvents.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    'Get the datatable row number to delete
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then
                            Dim intTrackerDeleteRow = CInt(MyString) - 1 'Used to edit Tracker row

                            EventsDataTable.Rows.Remove(EventsDataTable.Rows(CInt(MyString) - 1))

                            Exit For
                        End If

                    Next

                    RemoveHandler childControlObject.Click, AddressOf DynamicEventDeleteButton_Click
                    parentPanelName = childControlObject.Parent.Name
                End If

            Next

        Next

        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = parentPanelName Then
                FlpEvents.Controls.Remove(controlObject)
                controlObject.Dispose()
            End If
        Next

        'Save the DataTable
        DataTable2TSV(EventsDataTable, EventsFileName)
        DisplayEvents()

    End Sub

    Private Sub BtnSortEvent_Click(sender As Object, e As EventArgs) Handles BtnSortEvent.Click

        If EventsSortOrder = "A" Then
            EventsDataTable.DefaultView.Sort = "SortDate ASC"
            EventsDataTable = EventsDataTable.DefaultView.ToTable
            EventsSortOrder = "D"
        Else
            EventsDataTable.DefaultView.Sort = "SortDate DESC"
            EventsDataTable = EventsDataTable.DefaultView.ToTable
            EventsSortOrder = "A"
        End If

        DataTable2TSV(EventsDataTable, EventsFileName)
        SaveSettings()
        DisplayEvents()

    End Sub

    Friend Sub EventsSort()

        If EventsSortOrder = "A" Then
            EventsDataTable.DefaultView.Sort = "SortDate DESC"
            EventsDataTable = EventsDataTable.DefaultView.ToTable
        Else
            EventsDataTable.DefaultView.Sort = "SortDate ASC"
            EventsDataTable = EventsDataTable.DefaultView.ToTable
        End If
        DataTable2TSV(EventsDataTable, EventsFileName)

        DisplayEvents()

    End Sub

#End Region

#Region "*** Contact Panels Display ***"

    Sub DisplayContacts() Handles CboContactList.SelectedIndexChanged

        FlpContacts.Controls.Clear()
        ContactPanelsAddedCount = 0

        Dim row As DataRow
        For Each row In ContactsDataTable.Rows
            ContactPanelsAddedCount += 1
            Select Case CboContactList.SelectedIndex
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
                    CreateContactPanelButtons(CurrentContactPanelName)
                    Select Case row("Groups").ToString
                        Case "Acquaintance"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.LightGreen
                        Case "Family"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.LightBlue
                        Case "Friend"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.Beige
                        Case "Business"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                            g.BackColor = Color.LightGray
                        Case "Other"
                            Dim unused As New Panel
                            Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
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
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
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
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.LightGray
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
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
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
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.Beige
                    End If
                Case 5 'Other Selected
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
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Dim unused As New Panel
                        Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                        g.BackColor = Color.Bisque
                    End If
                Case 6
                    Dim strDetail As String
                    strDetail = row("Starred").ToString
                    If strDetail = "True" Then
                        CreateContactPanel()
                        Dim strFullName As String
                        strFullName = row("First Name").ToString & " " & row("Middle Name").ToString & " " & row("Last Name").ToString
                        If strFullName = "  " Then
                            strFullName = row("Company").ToString
                        End If
                        CreateContactNameLabel(CurrentContactPanelName, strFullName)
                        CreateContactPhoneLabel(CurrentContactPanelName, row("Phone").ToString)
                        CreateContactEmailLabel(CurrentContactPanelName, row("Email").ToString)
                        CreateContactPanelButtons(CurrentContactPanelName)
                        Select Case row("Groups").ToString
                            Case "Acquaintance"
                                Dim unused As New Panel
                                Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                                g.BackColor = Color.LightGreen
                            Case "Family"
                                Dim unused As New Panel
                                Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                                g.BackColor = Color.LightBlue
                            Case "Friend"
                                Dim unused As New Panel
                                Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                                g.BackColor = Color.Beige
                            Case "Business"
                                Dim unused As New Panel
                                Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                                g.BackColor = Color.LightGray
                            Case "Other"
                                Dim unused As New Panel
                                Dim g As Panel = DirectCast(FlpContacts.Controls(CurrentContactPanelName), Panel)
                                g.BackColor = Color.Bisque
                        End Select

                    End If
            End Select
        Next row

        LblContacts.Focus() 'Take the focus off the listbox, keep it from being highlighted

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
        FlpContacts.Controls.Add(contactPanel)

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
        For Each controlObject As Control In FlpContacts.Controls
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
        For Each controlObject As Control In FlpContacts.Controls
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
        For Each controlObject As Control In FlpContacts.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(contactNameLabel)
            End If
        Next
    End Sub

    Public Sub CreateContactPanelButtons(ByVal panelName As String)
        Dim ContactEditButton As Button
        ContactEditButton = New Button
        Dim contactDeleteButton As Button
        contactDeleteButton = New Button

        'Set Properties of Edit Button
        With ContactEditButton
            .AutoSize = True
            .BackColor = Color.LightBlue
            .Location = New Point(330, 5)
            .Name = "btnEdit" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Edit"
        End With

        'Set Properties of Delete Button
        With contactDeleteButton
            .AutoSize = True
            .BackColor = Color.LightPink
            .Location = New Point(330, 38)
            .Name = "btnContactDelete" + ContactPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Text = "Delete"
        End With

        'Loop through panels and add buttons to passed panel
        For Each controlObject As Control In FlpContacts.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(ContactEditButton)
                controlObject.Controls.Add(contactDeleteButton)
            End If
        Next

        'Add Handler for the Click Event
        AddHandler ContactEditButton.Click, AddressOf DynamicContactEditButton_Click

    End Sub

    Sub DynamicContactEditButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        For Each controlObject As Control In FlpContacts.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    ' Get the datatable row number to edit from edit button name
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)
                        If IsNumeric(MyString) Then

                            ContactRowIndex = CInt(MyString) - 1 'Used to edit Contact row

                            ' copy data from datatable to textboxes
                            FormContacts.TxtFirstName.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("First Name").ToString
                            FormContacts.TxTMiddleName.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Middle Name").ToString
                            FormContacts.TxtLastName.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Last Name").ToString
                            FormContacts.TxtCompany.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Company").ToString
                            FormContacts.TxtAddress1.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Address1").ToString
                            FormContacts.TxtAddress2.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Address2").ToString
                            FormContacts.TxtCity.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("City").ToString
                            FormContacts.CboState.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("State").ToString
                            FormContacts.TxtZipcode.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Zipcode").ToString
                            FormContacts.TxtPhone.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Phone").ToString
                            FormContacts.TxtEmail.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Email").ToString
                            FormContacts.TxtBirthdate.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Birthdate").ToString
                            FormContacts.CboGroups.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Groups").ToString


                            FormContacts.TxtNotes.Text = ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Notes").ToString
                            FormContacts.TxtNotes.Text = FormContacts.TxtNotes.Text.Replace("_\n", vbNewLine)

                            If ContactsDataTable.Rows.Item(CInt(MyString) - 1).Item("Starred").ToString = "True" Then
                                FormContacts.ChkStarred.Checked = True
                            End If

                            Exit For 'I put "Exit For" in here because once a number is found It should stop testing ***************

                        End If
                    Next
                End If
            Next
        Next

        FormContacts.BtnAddContact.Text = "Save"
        Enabled = False
        FormContacts.Show()

    End Sub

    Sub DynamicContactDeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim parentPanelName As String
        parentPanelName = Nothing

        'Remove Handler from Sender
        For Each controlObject As Control In FlpContacts.Controls
            For Each childControlObject As Control In controlObject.Controls
                If childControlObject.Name = DirectCast(sender, Control).Name.ToString Then

                    'Get the datatable row number to delete
                    For x = 4 To 1 Step -1
                        Dim MyString As String = childControlObject.Name.Substring(childControlObject.Name.Length - x)

                        If IsNumeric(MyString) Then
                            Dim intContactDeleteRow = CInt(MyString) - 1 'Used to edit Contact row

                            ContactsDataTable.Rows.Remove(ContactsDataTable.Rows(CInt(MyString) - 1))

                            Exit For
                        End If

                    Next

                    RemoveHandler childControlObject.Click, AddressOf DynamicContactDeleteButton_Click
                    parentPanelName = childControlObject.Parent.Name
                End If

            Next

        Next

        For Each controlObject As Control In FlpEvents.Controls
            If controlObject.Name = parentPanelName Then
                FlpEvents.Controls.Remove(controlObject)
                controlObject.Dispose()
            End If
        Next

        'Save the DataTable
        DataTable2TSV(ContactsDataTable, ContactsFileName)
        DisplayContacts()

    End Sub

    Private Sub BtnContactSort_Click(sender As Object, e As EventArgs) Handles BtnContactSort.Click

        If ContactsSortOrder = "A" Then
            ContactsDataTable.DefaultView.Sort = "SortName ASC"
            ContactsDataTable = ContactsDataTable.DefaultView.ToTable
            ContactsSortOrder = "D"
        Else
            ContactsDataTable.DefaultView.Sort = "SortName DESC"
            ContactsDataTable = ContactsDataTable.DefaultView.ToTable
            ContactsSortOrder = "A"
        End If

        DataTable2TSV(ContactsDataTable, ContactsFileName)
        SaveSettings()      'Saves the Sort order choice
        DisplayContacts()   'Redisplay Contacts

    End Sub

    Public Sub ContactsSort() 'To sort the file after an edit or add from FormContacts.vb

        If ContactsSortOrder = "D" Then
            ContactsDataTable.DefaultView.Sort = "SortName ASC"
            ContactsDataTable = ContactsDataTable.DefaultView.ToTable
        Else
            ContactsDataTable.DefaultView.Sort = "SortName DESC"
            ContactsDataTable = ContactsDataTable.DefaultView.ToTable
        End If

        DisplayContacts()

    End Sub

#End Region

#Region "*** Memo Section ***"

    Sub FillMemoListBox()

        For Each row As DataRow In MemosDataTable.Rows
            LstMemos.Items.Add(row("Title"))
        Next

    End Sub

    Private Sub BtnAddMemo_Click(sender As Object, e As EventArgs) Handles BtnAddMemo.Click
        Enabled = False
        FormMemos.Show()
    End Sub

    Private Sub LstMemos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMemos.SelectedIndexChanged

        'The datatable row equals the selected index number
        Dim dtbRow As Integer = LstMemos.SelectedIndex

        'copy the datatable information to the textbox fields converting the _\n to a newline
        FormMemos.TxtTitle.Text = MemosDataTable.Rows.Item(dtbRow).Item("Title").ToString
        FormMemos.TxtMemo.Text = MemosDataTable.Rows.Item(dtbRow).Item("Memo").ToString.Replace("_\n", vbNewLine)

        FormMemos.BtnAddMemo.Text = "Save" 'This is to distinquish between Add and Edit modes. Add mode says 'Add'.
        Me.Enabled = False
        FormMemos.BtnDeleteMemo.Visible = True
        FormMemos.Show()

    End Sub


#End Region

#Region "*** Event Procedures ***"

    Private Sub BtnAddContact_Click(sender As Object, e As EventArgs) Handles BtnAddContact.Click
        Enabled = False
        FormContacts.Show()
    End Sub

    Private Sub BtnAddEvent_Click(sender As Object, e As EventArgs) Handles BtnAddEvent.Click
        Enabled = False
        FormEvents.Show()
    End Sub

    Private Sub TmrClock_Tick(sender As Object, e As EventArgs) Handles TmrClock.Tick
        LblClock.Text = Format(Date.Now, $"dddd: MMMM d, yyyy                  hh:mm:ss tt ")
    End Sub

    Private Sub MnuExit(sender As Object, e As EventArgs) Handles miExit.Click
        SaveSettings()
        Application.Exit()
    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveSettings()
    End Sub

#End Region

#Region "***** Browser Section *****"

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Process.Start("http://www.google.com/#hl=en&q=" & TxtSearch.Text.Replace(" ", "+"))
        TxtSearch.Text = ""
        TxtSearch.Focus()
    End Sub

    Private Sub CalendarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalendarToolStripMenuItem1.Click
        Process.Start("https://Calendar.google.com")
    End Sub

    Private Sub CoronavirusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoronavirusToolStripMenuItem1.Click
        Process.Start("https://ncov2019.live/")
    End Sub

    Private Sub NewsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem2.Click
        Process.Start("https://news.google.com")
    End Sub

    Private Sub OnThisDayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OnThisDayToolStripMenuItem1.Click
        Process.Start("https://www.onthisday.com")
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeatherToolStripMenuItem.Click
        Process.Start("https://forecast.weather.gov")
    End Sub

    Private Sub NetflixToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NetflixToolStripMenuItem1.Click
        Process.Start("https://www.netflix.com/browse")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        Process.Start("https://youtube.com")
    End Sub

    Private Sub MailToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MailToolStripMenuItem1.Click
        Process.Start("https://Mail.google.com")
    End Sub

    Private Sub CalculatorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click
        Process.Start("https://www.jango.com/")
    End Sub

#End Region

End Class
