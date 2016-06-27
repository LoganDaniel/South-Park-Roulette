Public Class Form1
    Public GameMechanics As New GameManager
    Dim PlayMusic As Boolean = True             'Determines if music is playing or not
    Private Sub tMovement_Tick(sender As Object, e As EventArgs) Handles tMovement.Tick
        ' Controls the movement when Player shoots away at enemy with MainCharReturn = False by default
        GameMechanics.MainChar = pbJoker
        If GameMechanics.MainCharReturn = False Then
            'If MainCharReturn = False then Joker moves forward
            GameMechanics.MovementForward()
        End If
        If GameMechanics.MainCharReturn = True Then
            'If MainCharReturn = False then Joker moves backwards
            GameMechanics.MovementBackwards()
        End If
    End Sub

    Private Sub tAnimation_Tick(sender As Object, e As EventArgs) Handles tAnimation.Tick
        'Begins the animation function
        GameMechanics.MainChar = pbJoker
        GameMechanics.Animation()
    End Sub

    Private Sub Blinking_Tick(sender As Object, e As EventArgs) Handles Blinking.Tick
        ' Runs Blinking function inside Game Manager
        GameMechanics.Blink()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Visuals only, Turns my Blinking timer on which makes Mysterion start blinking
        Blinking.Start()
        'In Case Player wants to stop Music In Game without having to select a song
        cbSongSelection.Text = "SouthPark Intro"
        PlayMusic = False
    End Sub

    Private Sub pbMysterion_Click(sender As Object, e As EventArgs) Handles pbMysterion.Click
        'If you click on Mytserion, star the timers which will begin the Shoot Away function
        tMovement.Start()
        tAnimation.Start()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbCheat.Click
        'Cheat funtion, this makes a label visible which reveals which bullet the chamber is in.
        lblAnswer.Visible = True
        lblAnswer.Text = GameMechanics.BulletLocation
    End Sub

    Private Sub pbJoker_Click(sender As Object, e As EventArgs) Handles pbJoker.Click
        'If player clicks Joker, then begins funtion ShootMyself
        GameMechanics.ShootMyself()
    End Sub

    Private Sub pbJoker_MouseHover(sender As Object, e As EventArgs) Handles pbJoker.MouseHover
        'If Player hovers over Joker, then a yellow hand indicator appears
        pbIndicator1.Visible = True
    End Sub

    Private Sub pbJoker_MouseLeave(sender As Object, e As EventArgs) Handles pbJoker.MouseLeave
        'If Player hovers over Mysterion and then leaves, makes the yellow hand indicator invisible
        pbIndicator1.Visible = False
    End Sub

    Private Sub pbMysterion_MouseHover(sender As Object, e As EventArgs) Handles pbMysterion.MouseHover
        'If Player hovers over Joker, then a yellow hand indicator appears
        PictureBox1.Visible = True
    End Sub

    Private Sub pbMysterion_MouseLeave(sender As Object, e As EventArgs) Handles pbMysterion.MouseLeave
        'If Player hovers over Joker and then leaves, makes the yellow hand indicator invisible
        PictureBox1.Visible = False
    End Sub

    Private Sub LaserEye_Tick(sender As Object, e As EventArgs) Handles LaserEye.Tick
        'If the player has lost all of their chances, then begin Mysterion Laser facing Joker.
        GameMechanics.LaserHit()
    End Sub

    Private Sub JokerFaceTransition_Tick(sender As Object, e As EventArgs) Handles JokerFaceTransition.Tick
        'If the player shoots themselves and misses, start timer which makes joker have a worried face
        GameMechanics.BulletMiss_MySelf()
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        'Randomizes the Bullet location, basically restarts the game
        GameMechanics.BulletRandomLocation()
        GameMechanics.BulletCount = 1
        GameMechanics.Chances = 2
        lblChances.Text = "Chances: 2"
        lblAnswer.Text = GameMechanics.BulletLocation
        GameMechanics.CylinderImage()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Show quit form if player wishes to return to menu.
        QuitForm.Show()
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

End Class
