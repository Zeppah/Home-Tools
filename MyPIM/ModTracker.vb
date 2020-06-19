#Region "*** Imports ***"

Imports System.IO

#End Region

#Region "*** Reference Section ***"

'strTrackerRecord(0) = CStr(intRecordIndexNumber)       : integer
'strTrackerRecord(1) = tbxDescription.Text              : string
'strTrackerRecord(2) = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay).ToString : Date Ticks
'strTrackerRecord(3) = tbxAmount.ToString               : Double
'strTrackerRecord(4) = cbxTime.Checked.ToString         : Boolean
'strTrackerRecord(5) = cbxAppointment.Checked.ToString  : Boolean
'strTrackerRecord(6) = cbxBill.Checked.ToString         : Boolean
'strTrackerRecord(7) = cbxBirthday.Checked.ToString     : Boolean
'strTrackerRecord(8) = cbxOther.Checked.ToString        : Boolean

#End Region

Module ModTracker

#Region "*** Public Variables ***"

    Friend intRecordIndexNumber As Integer = 0                  'Unique Index Number for each record
    Friend strDataPath As String = Application.UserAppDataPath  'The Users Data Path
    Friend strDelimiter As String = ControlChars.Tab            'Delimiter for Tab Separated Files
    Friend strSettingsFile As String = "Settings.tsv"           'The settings file
    Friend strTrackerFile As String = "Tracker.tsv"             'The Tracker Record file
    Friend strTrackerRecord(9) As String                        'Holds the fields for each record

#End Region

#Region "*** Read and Write Files ***"

    Public Sub ReadSettings()
        Dim SplitLine() As String
        If File.Exists(strDataPath & "\" & strSettingsFile) = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(strDataPath & "\" & strSettingsFile, System.Text.Encoding.Default)
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

    Public Sub SaveRecord()
        Try
            'True appends the record to the file. False replaces the file.
            Dim filewriter As New StreamWriter(strDataPath & "\" & strTrackerFile, True)
            Dim record As String = Nothing
            record = Nothing
            record = strTrackerRecord(0) & strDelimiter & strTrackerRecord(1) & strDelimiter & strTrackerRecord(2) _
                & strDelimiter & strTrackerRecord(3) & strDelimiter & strTrackerRecord(4) _
                & strDelimiter & strTrackerRecord(5) & strDelimiter & strTrackerRecord(6) _
                & strDelimiter & strTrackerRecord(7) & strDelimiter & strTrackerRecord(8)
            filewriter.WriteLine(record)
            filewriter.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write Tracker record.")
        End Try

    End Sub

    Public Sub SaveSettings()
        File.WriteAllText(strDataPath & "\" & strSettingsFile, CStr(intRecordIndexNumber))
    End Sub

#End Region

End Module
