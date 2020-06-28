#Region "*** Imports ***"

Imports System.IO

#End Region

Module ModMyPIM

#Region "*** Public Variables ***"

    Friend ContactsDataTable As New DataTable  'Contacts DataTable
    Friend EventsDataTable As New DataTable    'Events DataTable
    Friend MemosDataTable As New DataTable     'Memos DataTable
    Friend ContactRowIndex As Integer = 0      'Contacts DataTable Row being edited
    Friend EventRowIndex As Integer = 0        'Event DataTable Row being edited
    Friend Delimiter As String = vbTab         'Tab delimiter for .tsv files
    Friend UserDataPath As String = Application.UserAppDataPath          'Users Data Path
    Friend ContactsFileName As String = UserDataPath & "\Contacts.tsv"   'Contacts file
    Friend MemosFileName As String = UserDataPath & "\Memos.tsv"         'Memos file
    Friend SettingsFileName As String = UserDataPath & "\Settings.tsv"   'Settings file
    Friend EventsFileName As String = UserDataPath & "\Events.tsv"       'Events file
    Friend EventsSortOrder As String = "A"     'Events DataTable sort order
    Friend ContactsSortOrder As String = "A"   'Contacts DataTable sort order

    Friend EventPanelsAddedCount As Integer = 0    'Used to give unique control names such as pnlEvent1, pnlEvent2 etc.
    Friend ContactPanelsAddedCount As Integer = 0  'Used to give unique control names such as pnlContact1, pnlContact2 etc.



#End Region

#Region "*** Define DataTables ***"

    Friend Sub AddContactsDataTableColumns()
        With ContactsDataTable
            .Columns.Add("First Name", System.Type.GetType("System.String"))
            .Columns.Add("Middle Name", System.Type.GetType("System.String"))
            .Columns.Add("Last Name", System.Type.GetType("System.String"))
            .Columns.Add("Company", System.Type.GetType("System.String"))
            .Columns.Add("Address1", System.Type.GetType("System.String"))
            .Columns.Add("Address2", System.Type.GetType("System.String"))
            .Columns.Add("City", System.Type.GetType("System.String"))
            .Columns.Add("State", System.Type.GetType("System.String"))
            .Columns.Add("Zipcode", System.Type.GetType("System.String"))
            .Columns.Add("Phone", System.Type.GetType("System.String"))
            .Columns.Add("Email", System.Type.GetType("System.String"))
            .Columns.Add("Birthdate", System.Type.GetType("System.String"))
            .Columns.Add("Groups", System.Type.GetType("System.String"))
            .Columns.Add("Notes", System.Type.GetType("System.String"))
            .Columns.Add("Starred", System.Type.GetType("System.Boolean"))
            .Columns.Add("SortName", System.Type.GetType("System.String"))
        End With
    End Sub

    Public Sub AddMemosDataTableColumns()
        With MemosDataTable
            .Columns.Add("Title", System.Type.GetType("System.String"))
            .Columns.Add("Memo", System.Type.GetType("System.String"))
        End With
    End Sub

    Public Sub AddEventsDataTableColumns()
        With EventsDataTable
            .Columns.Add("Description", System.Type.GetType("System.String"))
            .Columns.Add("Date", System.Type.GetType("System.DateTime"))
            .Columns.Add("Amount", System.Type.GetType("System.Double"))
            .Columns.Add("Time", System.Type.GetType("System.Boolean"))
            .Columns.Add("Appointment", System.Type.GetType("System.Boolean"))
            .Columns.Add("Bill", System.Type.GetType("System.Boolean"))
            .Columns.Add("Birthday", System.Type.GetType("System.Boolean"))
            .Columns.Add("Other", System.Type.GetType("System.Boolean"))
            .Columns.Add("SortDate", System.Type.GetType("System.DateTime"))
            .Columns.Add("Starred", System.Type.GetType("System.Boolean"))
        End With
    End Sub

#End Region

#Region "*** Read and Write Files ***"

    '***** Read TSV Files *****

    ' Read the input TSV file to a DataTable.
    Public Sub TSV2DataTable(ByVal table As DataTable, ByVal filename As String)

        Dim TextLine As String
        Dim SplitLine() As String

        If System.IO.File.Exists(filename) = True Then
            Dim fileReader As New StreamReader(filename, Text.Encoding.Default)
            Do While fileReader.Peek() <> -1
                TextLine = fileReader.ReadLine()
                SplitLine = Split(TextLine, Delimiter)
                table.Rows.Add(SplitLine)
            Loop
            fileReader.Close()
        Else
            'Save the DataTable
            DataTable2TSV(table, filename)
        End If

    End Sub


    '***** Write TSV File *****

    ' Write the input DataTable to a TSV file.
    Sub DataTable2TSV(ByVal table As DataTable, ByVal filename As String)
        Dim writer As StreamWriter
        Try
            writer = New StreamWriter(filename)

            Dim sep As String = "" 'Used to start the string without a tab
            Dim builder As New Text.StringBuilder

            ' write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New Text.StringBuilder

                'Build the row
                For Each col As DataColumn In table.Columns
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = Delimiter
                Next
                writer.WriteLine(builder.ToString())
            Next
            writer.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Failed in the DataTable2TSV routine...: " & filename)
        End Try


    End Sub


    Public Sub LoadSettings()
        Dim SplitLine() As String
        If File.Exists(SettingsFileName) = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(SettingsFileName, System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1                      ' Peek to see if there is another line of data to process
                Dim TextLine As String = objReader.ReadLine()    ' Read the next line of data
                SplitLine = Split(TextLine, Delimiter)           ' Separate the line into the SplitLine array
                EventsSortOrder = SplitLine(0)                   ' Events display sort order
                ContactsSortOrder = SplitLine(1)                 ' Contacts display sort order
                FormMain.cboEventTime.SelectedIndex = CInt(SplitLine(2))   ' Events display range
                FormMain.cboEventList.SelectedIndex = CInt(SplitLine(3))       ' Events Category choice
                FormMain.cboContact.SelectedIndex = CInt(SplitLine(4))       ' Contact Category choice
            Loop
            'Close the StreamReader
            objReader.Close()
        Else
            SaveSettings()
        End If
    End Sub
    Public Sub SaveSettings()
        File.WriteAllText(SettingsFileName, EventsSortOrder & Delimiter & ContactsSortOrder _
                          & Delimiter & FormMain.cboEventTime.SelectedIndex & Delimiter _
                          & FormMain.cboEventList.SelectedIndex & Delimiter & FormMain.cboContact.SelectedIndex)
    End Sub

#End Region

End Module
