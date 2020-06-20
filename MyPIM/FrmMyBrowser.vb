Public Class FrmMyBrowser
    Private Sub FrmMyBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmMyBrowser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmMain.Enabled = True
    End Sub
End Class