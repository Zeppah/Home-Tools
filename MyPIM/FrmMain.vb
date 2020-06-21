
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

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()
        TmrClock.Start()
        DefineTrackerDataTable()
        CSV2DataTable(dtbTracker, strDataPath & "\" & strTrackersFile)
        DefineContactsDataTable()
        CSV2DataTable(dtbContacts, strDataPath & "\" & strContactsFile)

        Me.dgvTracker.DataSource = dtbTracker
        Me.dgvContacts.DataSource = dtbContacts

    End Sub

#End Region
#Region "*** Datagridview code ***"



#End Region

#Region "*** Event Procedures ***"

    Private Sub MnuContacts_Click(sender As Object, e As EventArgs) Handles Form1ToolStripMenuItem.Click
        Me.Enabled = False
        FrmContacts.Show()
    End Sub

    Private Sub MnuTracker_Click(sender As Object, e As EventArgs) Handles miTracker.Click
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

#End Region

End Class
