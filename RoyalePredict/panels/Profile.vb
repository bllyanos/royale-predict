Imports RoyaleWrapper
Imports System.Net
Imports System.IO

Public Class Profile
    Private requestWrapper As RoyaleRequest
    Private player As Player

    Private Sub ApplyUIPlayer()
        PlayerName.Text = "Name : " + player.name
        PlayerTrophies.Text = player.trophies
        PlayerArena.Text = player.arena.arena
        PlayerFavorite.Text = player.stats.favoriteCard.name
        Dim iconUrl = player.stats.favoriteCard.icon
        Dim tClient As New WebClient()
        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(iconUrl)))
        PictureBox1.Image = tImage
        tClient.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player = requestWrapper.GetPlayerByTag(TextInputTag.Text)
        MsgBox("Found a Player !")
        ApplyUIPlayer()
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        requestWrapper = New RoyaleRequest(Glob.API_KEY)
    End Sub
End Class