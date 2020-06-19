#Region "*** Imports ***"

Imports System.IO

#End Region

#Region "*** Reference Section ***"

'strContactRecord(0) = Cstr(intContactRecordIndexNumber)    : integer
'strContactRecord(1) = tbxFirstName.Text                    : String
'strContactRecord(2) = tbxMiddleName.Text                   : String
'strContactRecord(3) = tbxLastName.Text                     : String
'strContactRecord(4) = tbxCompany.Text                      : String
'strContactRecord(5) = tbxAddress1.Text                     : String
'strContactRecord(6) = tbxAddress2.Text                     : String
'strContactRecord(7) = tbxCity.Text                         : String
'strContactRecord(8) = cbxState.Text                        : String
'strContactRecord(9) = mtbZipcode.Text                      : String
'strContactRecord(10) = mtbPhone.Text                       : String
'strContactRecord(11) = tbxEmail.Text                       : String
'strContactRecord(12) = mtbBirthdate.Text                   : String
'strContactRecord(13) = cbxGroups.Text                      : String
'strContactRecord(14) = tbxNotes.Text                       : String

'strTrackerRecord(0) = CStr(intTrackerRecordIndexNumber)    : integer
'strTrackerRecord(1) = tbxDescription.Text                  : string
'strTrackerRecord(2) = (dtpDate.Value.Date + dtpTime.Value.TimeOfDay).ToString : Date Ticks
'strTrackerRecord(3) = tbxAmount.ToString                   : Double
'strTrackerRecord(4) = cbxTime.Checked.ToString             : Boolean
'strTrackerRecord(5) = cbxAppointment.Checked.ToString      : Boolean
'strTrackerRecord(6) = cbxBill.Checked.ToString             : Boolean
'strTrackerRecord(7) = cbxBirthday.Checked.ToString         : Boolean
'strTrackerRecord(8) = cbxOther.Checked.ToString            : Boolean

#End Region

Module ModMyPIM

#Region "*** Public Variables ***"

    Friend intContactRecordIndexNumber As Integer = 0           'Unique Index Number for each Contact
    Friend intTrackerRecordIndexNumber As Integer = 0           'Unique Index Number for each Tracker
    Friend strContactRecord(15) As String                       'Holds the fields for each condact record
    Friend strDataPath As String = Application.UserAppDataPath  'The Users Data Path
    Friend strDelimiter As String = ControlChars.Tab            'Delimiter for Tab Separated Files
    Friend strContactsFile As String = "Contacts.tsv"           'The Contacts record file
    Friend strSettingsFile As String = "Settings.tsv"           'The Settings file
    Friend strTrackersFile As String = "Tracker.tsv"            'The Trackers record file
    Friend strTrackerRecord(9) As String                        'Holds the fields for each tracker record

#End Region

#Region "*** Read and Write Files ***"

    Public Sub ReadSettings()
        Dim SplitLine() As String
        If File.Exists(strDataPath & "\" & strSettingsFile) = True Then
            'Open the StreamReader
            Dim objReader As New StreamReader(strDataPath & "\" & strSettingsFile, System.Text.Encoding.Default)
            Do While objReader.Peek() <> -1                     'Peek to see if there is another line of data to process
                Dim TextLine As String = objReader.ReadLine()   'Read the next line of data
                SplitLine = Split(TextLine, strDelimiter) 'Separate the line into the SplitLine array
                intTrackerRecordIndexNumber = CInt(SplitLine(0)) ' Tracker Record Counter
                intContactRecordIndexNumber = CInt(SplitLine(1)) ' Contact Record Counter
            Loop
            'Close the StreamReader
            objReader.Close()
        Else
            SaveSettings()
        End If
    End Sub


    Public Sub SaveContactRecord()
        Try
            'True appends the record to the file. False replaces the file.
            Dim filewriter As New StreamWriter(strDataPath & "\" & strContactsFile, True)
            Dim record As String = Nothing
            record = Nothing
            record = strContactRecord(0) & strDelimiter & strContactRecord(1) & strDelimiter _
                & strContactRecord(2) & strDelimiter & strContactRecord(3) & strDelimiter _
                & strContactRecord(4) & strDelimiter & strContactRecord(5) & strDelimiter _
                & strContactRecord(6) & strDelimiter & strContactRecord(7) & strDelimiter _
                & strContactRecord(8) & strDelimiter & strContactRecord(9) & strDelimiter _
                & strContactRecord(10) & strDelimiter & strContactRecord(11) & strDelimiter _
                & strContactRecord(12) & strDelimiter & strContactsFile(13) & strDelimiter _
                & strContactRecord(14)

            filewriter.WriteLine(record)
            filewriter.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write Contact record.")
        End Try

    End Sub

    Public Sub SaveTrackerRecord()
        Try
            'True appends the record to the file. False replaces the file.
            Dim filewriter As New StreamWriter(strDataPath & "\" & strTrackersFile, True)
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
        File.WriteAllText(strDataPath & "\" & strSettingsFile, CStr(intTrackerRecordIndexNumber) _
            & strDelimiter & CStr(intContactRecordIndexNumber))
    End Sub

#End Region

End Module
