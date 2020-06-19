#Region "*** Imports ***"

Imports System.IO

#End Region

#Region "*** Reference Section ***"

'strTrackerRecord(0) = CStr(intRecordIndexNumber) : integer
'strTrackerRecord(1) = tbxDescription.Text : string
'strTrackerRecord(2) = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay).ToString : Date Ticks
'strTrackerRecord(3) = tbxAmount.ToString : Double
'strTrackerRecord(4) = cbxTime.Checked.ToString : Boolean
'strTrackerRecord(5) = cbxAppointment.Checked.ToString : Boolean
'strTrackerRecord(6) = cbxBill.Checked.ToString : Boolean
'strTrackerRecord(7) = cbxBirthday.Checked.ToString : Boolean
'strTrackerRecord(8) = cbxOther.Checked.ToString : Boolean

#End Region

Module ModTracker

#Region "*** Public Variables ***"

    Friend delimiter As String = ControlChars.Tab           'for Tab Separated File
    Friend intRecordIndexNumber As Integer = 0              'Unique Index Number for each record
    Friend strTrackerRecord(9) As String                    'Stores the fields for each record
    Friend DataPath As String = Application.UserAppDataPath 'The Users Data Path
    Friend SettingsFile As String = "Settings.tsv"          'The settings file
    Friend TrackerFile As String = "Tracker.tsv"            'The Tracker Record file

#End Region

#Region "*** Read and Write Files ***"

    Public Sub SaveRecord()
        Try
            'True appends the record to the file. False replaces the file.
            Dim filewriter As New StreamWriter(DataPath & "\" & TrackerFile, True)
            Dim record As String = Nothing
            record = Nothing
            record = strTrackerRecord(0) & delimiter & strTrackerRecord(1) & delimiter & strTrackerRecord(2) _
                & delimiter & strTrackerRecord(3) & delimiter & strTrackerRecord(4) _
                & delimiter & strTrackerRecord(5) & delimiter & strTrackerRecord(6) _
                & delimiter & strTrackerRecord(7) & delimiter & strTrackerRecord(8)
            filewriter.WriteLine(record)
            filewriter.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write Tracker record.")
        End Try

    End Sub

    Public Sub ReadSettings()
        Dim SplitLine() As String
        If File.Exists(DataPath & "\Settings.tsv") = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(DataPath & "\" & SettingsFile, System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1                     'Peek to see if there is another line of data to process
                Dim TextLine As String = objReader.ReadLine()   'Read the next line of data
                SplitLine = Split(TextLine, ControlChars.Tab) 'Separate the line into the SplitLine array
                intRecordIndexNumber = CInt(SplitLine(0)) ' (0) = Record Counter "TsvCounter"
            Loop
            'Close the StreamReader
            objReader.Close()
        Else
            SaveSettings()
        End If
    End Sub

    Public Sub SaveSettings()
        File.WriteAllText(DataPath & "\" & SettingsFile, CStr(intRecordIndexNumber))
    End Sub

#End Region

End Module
