Public Class MultiplayerClass
    Inherits GameManager

    'MultiPlayer
    Public PlayerStarts As New Random       'Creates random variable - Who STarts
    Public WhoStarts As Integer = PlayerStarts.Next(1, 3)   ' Random between 1 and 2
    Public Player1Turn As Boolean       'Is it Player Ones turn, if not Then it's Player 2s Turn

    Public CanPlayerOneShoot As Boolean = True  'If player one shoots Player2 and misses, then Player 1 cannot shoot until Player 2 misses
    Public CanPlayerTwoShoot As Boolean = True 'If player two shoots Player1 and misses, then Player 2 cannot shoot until Player 1 misses

    Public Sub CylinderImageMultiPlayer()
        ' Changes the cylinder image if the bullet was a miss
        If BulletCount = 1 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver
            MultiPlayer.pbCylinder.Refresh()
        ElseIf BulletCount = 2 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver1
            MultiPlayer.pbCylinder.Refresh()
        ElseIf BulletCount = 3 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver2
            MultiPlayer.pbCylinder.Refresh()
        ElseIf BulletCount = 4 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver3
            MultiPlayer.pbCylinder.Refresh()
        ElseIf BulletCount = 5 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver4
            MultiPlayer.pbCylinder.Refresh()
        ElseIf BulletCount = 6 Then
            MultiPlayer.pbCylinder.Image = My.Resources.Revolver5
            MultiPlayer.pbCylinder.Refresh()
        End If
    End Sub

    ' PLAYER ONE CONTROLS

    Public Sub MovementForwardPlayer1()
        'Player1 has shot Player 2, this function makes him move forward
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left + 13
        If Seconds = 15 Then
            MultiPlayer.tMovement.Stop()
            MultiPlayer.tAnimation.Stop()
            Seconds = 0
            MainChar.Image = My.Resources.Movement1
            MainChar.Refresh()
            ShootEnemyPlayer1()
        End If
    End Sub

    Public Sub MovementBackwardsPlayer1()
        'Player1 has shot Player 2, this function makes him move backwards
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left - 13
        If Seconds = 15 Then
            MultiPlayer.tMovement.Stop()
            MultiPlayer.tAnimation.Stop()
            MainCharReturn = False
            MainChar.Image = My.Resources.Movement1
            MainChar.Refresh()
            Seconds = 0
            CanPlayerOneShoot = False
            If CanPlayerTwoShoot = True Then
                Player1Turn = False
                MultiPlayer.lblWhosTurn.Text = "Player 2's turn"
            ElseIf CanPlayerOneShoot = False And CanPlayerTwoShoot = False Then
                CanPlayerOneShoot = True
                CanPlayerTwoShoot = True
                Player1Turn = False
                MultiPlayer.lblWhosTurn.Text = "Player 2's turn"
            Else
                Player1Turn = True
                MultiPlayer.lblWhosTurn.Text = "Player 1's turn"
            End If
        End If
    End Sub

    Public Sub ShootEnemyPlayer1()
        ' This sub checks if Player One has shot Player two with a empty chamber or not
        If BulletCount <> BulletLocation Then
            BulletMiss_EnemyPlayer1()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_EnemyPlayer1()
        End If
    End Sub

    Public Sub ShootMyselfPlayer1()
        ' This sub checks if Player One has shot themselves with a empty chamber or not
        If BulletCount <> BulletLocation Then
            MultiPlayer.JokerFaceTransition.Start()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_MySelfPlayer1()
        End If
    End Sub

    Public Sub BulletHit_MySelfPlayer1()
        ' This sub is for when the bullet was in the chamber and the player has shot themselves.
        MultiPlayer.pbJoker.Image = My.Resources.Killed
        MultiPlayer.pbSecondPlayer.Image = My.Resources.mJokerWins
        SomeoneWon.lblWinner.Text = "Player 2"
        SomeoneWon.Show()
    End Sub

    Public Sub BulletMiss_MySelfPlayer1()
        ' This sub is for when the bullet was NOT in the chamber and the player has shot themselves.
        Seconds = Seconds + 1
        MultiPlayer.pbJoker.Image = My.Resources.JokerWins
        If Seconds = 4 Then
            MultiPlayer.JokerFaceTransition.Stop()
            MultiPlayer.pbJoker.Image = My.Resources.Movement1
            Seconds = 0
            BulletCount = BulletCount + 1
            CylinderImageMultiPlayer()
            If CanPlayerTwoShoot = True Then
                Player1Turn = False
                MultiPlayer.lblWhosTurn.Text = "Player 2's turn"
            Else
                Player1Turn = True
                MultiPlayer.lblWhosTurn.Text = "Player 1's turn"
            End If
        End If
    End Sub

    Public Sub BulletMiss_EnemyPlayer1()
        ' This sub is for when the bullet was NOT in the chamber and the player has shot at Player 2
        BulletCount = BulletCount + 1
        CylinderImageMultiPlayer()
        MainCharReturn = True
        Seconds = 0
        MultiPlayer.tMovement.Start()
        MultiPlayer.tAnimation.Start()
    End Sub

    Public Sub BulletHit_EnemyPlayer1()
        ' This sub is for when the bullet was  in the chamber and the player has shot at Player 2
        MainChar.Image = My.Resources.GunFlag
        MultiPlayer.pbSecondPlayer.Image = My.Resources.Killed
        SomeoneWon.lblWinner.Text = "Player 1"
        SomeoneWon.Show()
    End Sub


    'PLAYER TWO CONTROLS
    
    Public Sub MovementForwardPlayer2()
        'Player2 has shot Player 1, this function makes him move forward
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left - 13
        If Seconds = 15 Then
            MultiPlayer.tMovement.Stop()
            MultiPlayer.tAnimation.Stop()
            Seconds = 0
            MainChar.Image = My.Resources.mMovement1
            MainChar.Refresh()
            ShootEnemyPlayer2()
        End If
    End Sub

    Public Sub MovementBackwardsPlayer2()
        ' Returns back to original location after MovementForwardPlayer2
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left + 13
        If Seconds = 15 Then
            MultiPlayer.tMovement.Stop()
            MultiPlayer.tAnimation.Stop()
            MainCharReturn = False
            MainChar.Image = My.Resources.mMovement1
            MainChar.Refresh()
            Seconds = 0
            CanPlayerTwoShoot = False
            If CanPlayerOneShoot = True Then
                Player1Turn = True
                MultiPlayer.lblWhosTurn.Text = "Player 1's turn"
            ElseIf CanPlayerOneShoot = False And CanPlayerTwoShoot = False Then
                CanPlayerOneShoot = True
                CanPlayerTwoShoot = True
                Player1Turn = True
                MultiPlayer.lblWhosTurn.Text = "Player 1's turn"
            Else
                Player1Turn = False
                MultiPlayer.lblWhosTurn.Text = "Player 2's turn"
            End If
        End If
    End Sub

    Public Sub ShootEnemyPlayer2()
        ' This sub checks if Player Two has shot Player One with a empty chamber or not
        If BulletCount <> BulletLocation Then
            BulletMiss_EnemyPlayer2()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_EnemyPlayer2()
        End If
    End Sub

    Public Sub ShootMyselfPlayer2()
        ' This sub checks if Player Two has shot themselves with a empty chamber or not
        If BulletCount <> BulletLocation Then
            MultiPlayer.JokerFaceTransition.Start()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_MySelfPlayer2()
        End If
    End Sub

    Public Sub BulletHit_MySelfPlayer2()
        ' This sub is for when the bullet was in the chamber and the player has shot themselves.
        MultiPlayer.pbJoker.Image = My.Resources.JokerWins
        MultiPlayer.pbSecondPlayer.Image = My.Resources.mKilled
        SomeoneWon.lblWinner.Text = "Player 1"
        SomeoneWon.Show()
    End Sub

    Public Sub BulletMiss_MySelfPlayer2()
        ' This sub is for when the bullet was NOT in the chamber and the player has shot themselves.
        Seconds = Seconds + 1
        MultiPlayer.pbSecondPlayer.Image = My.Resources.mJokerWins
        If Seconds = 4 Then
            MultiPlayer.JokerFaceTransition.Stop()
            MultiPlayer.pbSecondPlayer.Image = My.Resources.mMovement1
            Seconds = 0
            BulletCount = BulletCount + 1
            CylinderImageMultiPlayer()
            If CanPlayerOneShoot = True Then
                Player1Turn = True
                MultiPlayer.lblWhosTurn.Text = "Player 1's turn"
            Else
                Player1Turn = False
                MultiPlayer.lblWhosTurn.Text = "Player 2's turn"
            End If

        End If
    End Sub

    Public Sub BulletMiss_EnemyPlayer2()
        ' This sub is for when the bullet was NOT in the chamber and player 2 has shot at Player One
        BulletCount = BulletCount + 1
        CylinderImageMultiPlayer()
        MainCharReturn = True
        Seconds = 0
        MultiPlayer.tMovement.Start()
        MultiPlayer.tAnimation.Start()
    End Sub

    Public Sub BulletHit_EnemyPlayer2()
        ' This sub is for when the bullet was  in the chamber and player 2 has shot at Player One
        MainChar.Image = My.Resources.mGunFlag
        MultiPlayer.pbJoker.Image = My.Resources.Killed
        SomeoneWon.lblWinner.Text = "Player 2"
        SomeoneWon.Show()
    End Sub

    Public Sub Animation2()
        ' This sub is for when the bullet was  in the chamber and player 2 has shot at Player One
        MainChar.Image = My.Resources.mMovement1
        MainChar.Refresh()
        MainChar.Image = My.Resources.mMovement2
        MainChar.Refresh()
        MainChar.Image = My.Resources.mMovement1
        MainChar.Refresh()
        MainChar.Image = My.Resources.mMovement3
        MainChar.Refresh()
    End Sub

End Class
