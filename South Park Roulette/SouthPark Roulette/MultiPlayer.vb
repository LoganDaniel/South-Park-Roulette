Public Class MultiPlayer
    Public GameMechanics As New MultiplayerClass

    Dim PlayMusic As Boolean = True ' Determines if the music is played or not
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

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Shows the quit form.
        QuitForm.Show()
    End Sub

    Private Sub pbJoker_Click(sender As Object, e As EventArgs) Handles pbJoker.Click
        'If it's Player1s turn Then Shoot themselves. Else Player2's turn then Joker2 Shoots Joker1
        If GameMechanics.Player1Turn = True Then
            GameMechanics.ShootMyselfPlayer1()
        Else
            tMovement.Start()
            tAnimation.Start()
        End If

    End Sub

    Private Sub pbSecondPlayer_Click(sender As Object, e As EventArgs) Handles pbSecondPlayer.Click
        'If it's Player1s turn Then Shoot Player2. Else Player2's turn then Joker2 Shoots Themselves
        If GameMechanics.Player1Turn = False Then
            GameMechanics.ShootMyselfPlayer2()
        Else
            tMovement.Start()
            tAnimation.Start()
        End If
    End Sub

    Private Sub tMovement_Tick(sender As Object, e As EventArgs) Handles tMovement.Tick
        'Either Player 1/2 has shot their opponent and this function determines who did it and runs it.
        If GameMechanics.Player1Turn = True Then
            GameMechanics.MainChar = pbJoker
            If GameMechanics.MainCharReturn = False Then
                GameMechanics.MovementForwardPlayer1()
            End If
            If GameMechanics.MainCharReturn = True Then
                GameMechanics.MovementBackwardsPlayer1()
            End If

        Else
            GameMechanics.MainChar = pbSecondPlayer
            If GameMechanics.MainCharReturn = False Then
                GameMechanics.MovementForwardPlayer2()
            End If
            If GameMechanics.MainCharReturn = True Then
                GameMechanics.MovementBackwardsPlayer2()
            End If
        End If
    End Sub

    Private Sub JokerFaceTransition_Tick(sender As Object, e As EventArgs) Handles JokerFaceTransition.Tick
        'If either Player shoots themselves, then start a timer that changes whoever shot to a worried face back to normal.
        If GameMechanics.Player1Turn = True Then
            GameMechanics.BulletMiss_MySelfPlayer1()
        Else
            GameMechanics.BulletMiss_MySelfPlayer2()
        End If
    End Sub

    Private Sub tAnimation_Tick(sender As Object, e As EventArgs) Handles tAnimation.Tick
        'Starts animation of 'SouthPark walking if either Player shoots their opponent.
        If GameMechanics.Player1Turn = True Then
            GameMechanics.MainChar = pbJoker
            GameMechanics.Animation()
        Else
            GameMechanics.MainChar = pbSecondPlayer
            GameMechanics.Animation2()
        End If
    End Sub

    Private Sub pbJoker_MouseHover(sender As Object, e As EventArgs) Handles pbJoker.MouseHover
        'If Player hovers over First Joker, then a yellow hand indicator appears
        pbIndicator1.Visible = True
    End Sub

    Private Sub pbJoker_MouseLeave(sender As Object, e As EventArgs) Handles pbJoker.MouseLeave
        'If Player hovers over First Joker and then leaves, this makes the yellow hand indicator invisible
        pbIndicator1.Visible = False
    End Sub

    Private Sub pbSecondPlayer_MouseHover(sender As Object, e As EventArgs) Handles pbSecondPlayer.MouseHover
        'If Player hovers over Second Joker, then a yellow hand indicator appears
        PictureBox1.Visible = True
    End Sub

    Private Sub pbSecondPlayer_MouseLeave(sender As Object, e As EventArgs) Handles pbSecondPlayer.MouseLeave
        'If Player hovers over Second Joker and then leaves, this makes the yellow hand indicator invisible
        PictureBox1.Visible = False
    End Sub


    'The below code determines who starts the game.
    Private Sub btnPlayer1_Click(sender As Object, e As EventArgs) Handles btnPlayer1.Click
        'If this button is clicked, then Player 1 starts the game
        GameMechanics.Player1Turn = True
        btnPlayer1.Visible = False
        btnPlayer2.Visible = False
        btnRandom.Visible = False
        If GameMechanics.Player1Turn = True Then
            lblWhosTurn.Text = "Player 1's Turn"
        End If
    End Sub

    Private Sub btnPlayer2_Click(sender As Object, e As EventArgs) Handles btnPlayer2.Click
        'If this button is clicked, then Player 2 starts the game
        GameMechanics.Player1Turn = False
        btnPlayer1.Visible = False
        btnPlayer2.Visible = False
        btnRandom.Visible = False
        If GameMechanics.Player1Turn = False Then
            lblWhosTurn.Text = "Player 2's Turn"
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        'If this button is clicked, then it randomizes who starts the game
        If GameMechanics.WhoStarts = 1 Then
            GameMechanics.Player1Turn = True
        Else
            GameMechanics.Player1Turn = False
        End If
        btnPlayer1.Visible = False
        btnPlayer2.Visible = False
        btnRandom.Visible = False
        lblWhosTurn.Text = "Player" & GameMechanics.WhoStarts & "'s Turn"
    End Sub

    Private Sub pbCheat_Click(sender As Object, e As EventArgs) Handles pbCheat.Click
        'If you click on the Yellow bus symbol, then a Cheat number becomes visible which shows the location of the bullet.
        lblAnswer.Visible = True
        lblAnswer.Text = GameMechanics.BulletLocation
    End Sub

    Private Sub MultiPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'In Case Player wants to stop Music In Game without having to select a song
        cbSongSelection.Text = "SouthPark Intro"
        PlayMusic = False
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        'Randomizes the Bullet location, basically restarts the game
        GameMechanics.BulletRandomLocation()
        GameMechanics.BulletCount = 1
        lblAnswer.Text = GameMechanics.BulletLocation
        pbCylinder.Image = My.Resources.Revolver
        pbCylinder.Refresh()
    End Sub
End Class