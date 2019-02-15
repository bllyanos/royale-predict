Public Class MainForm
    '0. Kosong
    '1. Profile
    Private currentPanel = 0
    Private Sub RefreshPanel()
        Profile.Close()
        If currentPanel = 1 Then
            Profile.MdiParent = Me
            Me.mainPanel.Controls.Add(Profile)
            Profile.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentPanel = 1
        RefreshPanel()
    End Sub
End Class
