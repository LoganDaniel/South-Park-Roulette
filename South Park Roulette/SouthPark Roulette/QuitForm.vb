Imports System.Drawing.Text
Public Class QuitForm
    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        'Returns back to game
        Me.Close()
    End Sub

    Private Sub btnJoke_Click(sender As Object, e As EventArgs) Handles btnJoke.Click
        'This is for pure SouthPark amusment, Buddy
        If btnJoke.Text = "I'm not your Buddy, Guy" Then
            lblHeader.Text = "I'M NOT YOUR GUY, FRIEND"
            btnJoke.Text = "I'M NOT YOUR FRIEND, PAL"
        ElseIf btnJoke.Text = "I'M NOT YOUR FRIEND, PAL" Then
            lblHeader.Text = "I'M NOT YOUR PAL, Guy"
            btnJoke.Text = "I'm not your Guy, Friend"
        ElseIf btnJoke.Text = "I'm not your Guy, Friend" Then
            lblHeader.Text = "I'M NOT YOUR Friend, Buddy"
            btnJoke.Text = "I'm not your Buddy, Guy"
        End If
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'Closes Game (Either Single or Multiplayer) and shows MainMenu
        Form1.Close()
        MultiPlayer.Close()
        MainMenu.Show()
        Me.Close()

    End Sub
End Class