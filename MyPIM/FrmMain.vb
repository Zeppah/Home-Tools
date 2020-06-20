
''' <HEADER>
''' Project: My Personal Information Manager
''' Author: Larry Benner
''' Date: 6/17/2020
''' Revisions:
''' </HEADER>

Public Class FrmMain

#Region "*** Start ***"

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSettings()
        TmrClock.Start()
    End Sub

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


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Process.Start("http://www.google.com/#hl=en&q=" & txbSearch.Text.Replace(" ", "+"))
        txbSearch.Text = ""
        txbSearch.Focus()
    End Sub

End Class
