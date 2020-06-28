#Region "*** Imports ***"

Imports System.IO

#End Region

Module ModMyPIM

#Region "*** Public Variables ***"

    Friend ContactsDataTable As New DataTable                   'The Contacts DataTable
    Friend MemosDataTable As New DataTable                      'The Memos DataTable
    Friend EventsDataTable As New DataTable                     'The Events DataTable
    Friend ContactRowIndex As Integer = 0                       'Contacts DataTable Row being edited
    Friend EventRowIndex As Integer = 0                         'Event DataTable Row being edited
    'Friend EventEditRow As Integer = 0                           'dtbEvent Row being edited
    Friend UserDataPath As String = Application.UserAppDataPath 'The Users Data Path
    Friend Delimiter As String = vbTab                          'Tab delimiter for .tsv files
    Friend strContactsFile As String = "Contacts.tsv"           'The Contacts record file
    Friend strMemosFile As String = "Memos.tsv"                 'The Memos file
    Friend strRunProgramName As String                          'The Program name to run
    Friend SettingsFileName As String = UserDataPath & "\Settings.tsv"   'The Settings File
    Friend strContactSortOrder As String = "A"                  'Contact datatable sort order 'dtbTracker'
    Friend strTrackerSortOrder As String = "A"                  'Tracker datatable sort order 'dtbTracker'
    Friend strTrackersFile As String = "Events.tsv"            'The Events record file

    'Used to give unique control names such as pnlTracker1, pnlTracker2 etc.
    Friend TrackerPanelsAddedCount As Integer = 0
    'Used to give unique control names such as pnlContact1, pnlContact2 etc.
    Friend ContactPanelsAddedCount As Integer = 0



#End Region

#Region "*** Define DataTables ***"

    Public Sub DefineContactsDataTable()
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

    Public Sub DefineMemosDataTable()
        With MemosDataTable
            .Columns.Add("Header", System.Type.GetType("System.String"))
            .Columns.Add("Memo", System.Type.GetType("System.String"))
        End With
    End Sub

    Public Sub DefineEventsDataTable()
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

    ' Read the input CSV file to a DataTable. By default the values are Tab 
    ' delimited, but you can use the second overload version to use any other 
    ' string you want.
    '
    ' Example:
    '    CSV2DataTable(DataTable, "C:\Records.tsv")
    Public Sub CSV2DataTable(ByVal table As DataTable, ByVal filename As String)
        CSV2DataTable(table, filename, vbTab)
    End Sub
    Public Sub CSV2DataTable(ByVal table As DataTable, ByVal filename As String, ByVal sepChar As String)

        Dim TextLine As String
        Dim SplitLine() As String

        If System.IO.File.Exists(filename) = True Then
            Dim objReader As New System.IO.StreamReader(filename, System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, sepChar)

                table.Rows.Add(SplitLine)
            Loop
            objReader.Close()
        Else
            'Save the DataTable
            DataTable2CSV(table, filename)
        End If

    End Sub


    '***** Write TSV Files *****

    ' Save the input DataTable to a CSV file. By default the values are Tab 
    ' delimited, but you can use the second overload version to use any other 
    ' string you want.
    '
    ' Example:
    '    DataTable2CSV(DataTable, "C:\Users.tsv")
    Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String)
        DataTable2CSV(table, filename, vbTab)
    End Sub
    Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String,
    ByVal sepChar As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(filename)

            Dim sep As String = ""
            Dim builder As New System.Text.StringBuilder

            ' write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In table.Columns
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
            writer.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Failed in the DataTable2CSV routine...: " & filename)
        End Try


    End Sub


    Public Sub LoadSettings()
        Dim SplitLine() As String
        If File.Exists(SettingsFileName) = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(SettingsFileName, System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1                         ' Peek to see if there is another line of data to process
                Dim TextLine As String = objReader.ReadLine()       ' Read the next line of data
                SplitLine = Split(TextLine, Delimiter)           ' Separate the line into the SplitLine array
                strTrackerSortOrder = SplitLine(0)                  ' Tracker display sort order
                strContactSortOrder = SplitLine(1)                  ' Contact display sort order
                FormMain.cboTrackerTime.SelectedIndex = CInt(SplitLine(2))   ' Tracker display range
                FormMain.cboTracker.SelectedIndex = CInt(SplitLine(3))       ' Tracker Category choice
                FormMain.cboContact.SelectedIndex = CInt(SplitLine(4))       ' Contact Category choice
            Loop
            'Close the StreamReader
            objReader.Close()
        Else
            SaveSettings()
        End If
    End Sub
    Public Sub SaveSettings()
        File.WriteAllText(SettingsFileName, strTrackerSortOrder & Delimiter & strContactSortOrder _
                          & Delimiter & FormMain.cboTrackerTime.SelectedIndex & Delimiter _
                          & FormMain.cboTracker.SelectedIndex & Delimiter & FormMain.cboContact.SelectedIndex)
    End Sub

#End Region

End Module
