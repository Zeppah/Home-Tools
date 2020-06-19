Public Class FrmContacts
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMain.Enabled = True
        Me.Close()
    End Sub

    Private Sub FrmContacts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
    End Sub
End Class