Public Class MainMenu
    Public GameMechanics As New GameManager

    Dim PlayMusic As Boolean = True     'Determines wether to Play or Stop the music from playing.

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'Closes the application
        Application.Exit()
    End Sub

    Private Sub BtnSingle_Click(sender As Object, e As EventArgs) Handles BtnSingle.Click
        'Starts the SinglePlayer component of this game.
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnLeader_Click(sender As Object, e As EventArgs) Handles btnLeader.Click
        'Shows LeaderBoard Form
        LeaderBoardForm.Show()
    End Sub
    Private Sub btnMusic_Click(sender As Object, e As EventArgs) Handles btnMusic.Click
        'My music function. If player selects something from ComboBox and clicks button, it will play that song.
        If PlayMusic = True Then
            If cbSongSelection.Text = "SouthPark Intro" Then
                My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.Background)
                PlayMusic = False
            ElseIf cbSongSelection.Text = "What_Would_Brian_Boitano_Do" Then
                My.Computer.Audio.Play(My.Resources.What_Would_Brian_Boitano_Do, AudioPlayMode.Background)
                PlayMusic = False
            End If
        Else
            My.Computer.Audio.Stop()
            PlayMusic = True
        End If
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        'Starts the MultiPLayer componet of this game
        MultiPlayer.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'In Case Player wants to stop Music In Game without having to select a song
        cbSongSelection.Text = "SouthPark Intro"
        My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.Background)
        PlayMusic = False
    End Sub


    Private Sub btnHowtoPlay_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay.Click
        InformationForm.Show()
    End Sub
End Class