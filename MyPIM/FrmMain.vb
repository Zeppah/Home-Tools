
'#Region "*** Options and Imports ***"

'Imports System.IO

'#End Region

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
        Timer1.Start()
        MsgBox(DataPath)
    End Sub

#End Region

#Region "*** Event Procedures ***"
    Private Sub MnuTracker(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.Enabled = False
        FrmTracker.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(Date.Now, $"dddd: MMMM d, yyyy                  hh:mm:ss tt ")
    End Sub

    Private Sub MnuExit(sender As Object, e As EventArgs) Handles miExit.Click
        Application.Exit()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Me.Enabled = False
        FrmContacts.Show()
    End Sub


#End Region

End Class
