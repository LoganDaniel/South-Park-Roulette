Imports System.IO
Imports System.Text
Public Class GameManager
    Public RandomNo As New Random

    'Design Variables
    Public MainChar As New PictureBox   'Joker from SinglePlayer
    Public Seconds As Integer = 0       'Variable used for Movement Forward
    Public MainCharReturn As Boolean = False    'When it = True Then character walks backwards
    Dim ReturnSeconds As Integer = 0    'Variable used for Movement Backwards

    'Blinking Variables
    Dim EyeSeconds As Integer   'Variable used for EyeBlinking
    Dim RandomBlink As Integer = RandomNo.Next(500, 800)    'Random Blinking Timer Interval

    'Game Mechanics Variables
    Public BulletRandom As New Random()     'Declare Random
    Public BulletLocation As Integer = BulletRandom.Next(1, 7)      'Randoms Bullet Location
    Public BulletCount As Integer = 1   'Everytime the bullet misses then Count = + 1
    Public Chances As Integer = 2   'Amount of chances

    'LeaderBoards Variables
    Public ArrayTotal As Integer

    Public Sub Animation()
        ' The Animation function runs the SinglePlayer Animation Movement 
        MainChar.Image = My.Resources.Movement1
        MainChar.Refresh()
        MainChar.Image = My.Resources.Movement2
        MainChar.Refresh()
        MainChar.Image = My.Resources.Movement1
        MainChar.Refresh()
        MainChar.Image = My.Resources.Movement3
        MainChar.Refresh()
    End Sub

    Public Sub MovementForward()
        ' When the player shoots the enemy, this makes the player move forward and then runs the Shoot function
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left + 13
        If Seconds = 15 Then    'When the Counter reaches 15 Counts, it then Stops moving and begins fire sequence
            Form1.tMovement.Stop()
            Form1.tAnimation.Stop()
            Seconds = 0
            MainChar.Image = My.Resources.Movement1
            MainChar.Refresh()
            ShootEnemy()
        End If
    End Sub

    Public Sub MovementBackwards()
        'After the player has shot Mysterion and missed, then Player returns to position.
        Seconds = Seconds + 1
        MainChar.Left = MainChar.Left - 13
        If Seconds = 15 Then
            Form1.tMovement.Stop()
            Form1.tAnimation.Stop()
            MainCharReturn = False
            MainChar.Image = My.Resources.Movement1
            MainChar.Refresh()
            Seconds = 0
        End If
    End Sub

    Public Sub ShootMyself()
        'If player shot themselves, then check if bullet is in the chamber.
        If BulletCount <> BulletLocation Then
            Form1.JokerFaceTransition.Start()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_MySelf()
        End If
    End Sub

    Public Sub BulletMiss_MySelf()
        'If the player has shot themselves and missed then this function runs
        Seconds = Seconds + 1
        Form1.pbJoker.Image = My.Resources.JokerWins
        If Seconds = 4 Then
            Form1.JokerFaceTransition.Stop()
            Form1.pbJoker.Image = My.Resources.Movement1
            Seconds = 0
            BulletCount = BulletCount + 1
            CylinderImage()
        End If
    End Sub

    Public Sub BulletHit_MySelf()
        'If the player has shot themselves and bullet was in the chamber then run this function
        Form1.pbJoker.Image = My.Resources.Killed
        Form1.Blinking.Stop()
        Form1.pbMysterion.Image = My.Resources.MysterionWin
        EnterNameForm.OutCome = "Loser"
        EnterNameForm.Show()
    End Sub

    Public Sub ShootEnemy()
        'If player shot Mysterion, then check if bullet is in the chamber.
        If BulletCount <> BulletLocation Then
            BulletMiss_Enemy()
        ElseIf BulletCount = BulletLocation Then
            BulletHit_Enemy()
        End If
    End Sub

    Public Sub BulletMiss_Enemy()
        'If the player has shot the enemy and the bullet was in the chamber then run this function
        Chances = Chances - 1
        Form1.lblChances.Text = "Chances: " & Chances
        If Chances = 0 Then
            Form1.pbMysterion.Image = My.Resources.LaserEyes
            Form1.pbLaser.Visible = True
            Form1.LaserEye.Start()
            Form1.tMovement.Stop()
            Form1.tAnimation.Stop()
            Form1.Blinking.Stop()
            EnterNameForm.OutCome = "Loser"
            EnterNameForm.Show()
        Else
            BulletCount = BulletCount + 1
            CylinderImage()
            MainCharReturn = True
            Seconds = 0
            Form1.tMovement.Start()
            Form1.tAnimation.Start()
        End If

    End Sub

    Public Sub BulletHit_Enemy()
        'If the player has shot the enemy and the bullet was in the chamber.
        MainChar.Image = My.Resources.GunFlag
        Form1.Blinking.Stop()
        Form1.pbMysterion.Image = My.Resources.MysterionLost
        EnterNameForm.OutCome = "Winner"
        EnterNameForm.Show()
    End Sub

    Public Sub Blink()
        'Visuals only. Mysterion will blink every couple of seconds but not at the same time as it's random.
        EyeSeconds = EyeSeconds + 1
        If EyeSeconds = 5 Then
            Form1.Blinking.Interval = 200
            Form1.pbMysterion.Image = My.Resources.MysterionEyes
            Form1.pbMysterion.Refresh()
        ElseIf EyeSeconds > 5 Then
            Form1.Blinking.Interval = RandomBlink
            Form1.pbMysterion.Image = My.Resources.Mysterion
            Form1.pbMysterion.Refresh()
            EyeSeconds = 0
        End If
    End Sub

    Public Sub LaserHit()
        'VISUALS: When the Player has run out of chances and Mysterion has laser faced the player, then this funtion makes the player lose.
        Form1.pbLaser.Left = Form1.pbLaser.Left - 13
        If Form1.pbLaser.Bounds.IntersectsWith(MainChar.Bounds) Then
            Form1.LaserEye.Stop()
            Form1.pbLaser.Visible = False
            MainChar.Image = My.Resources.Killed
            MainChar.Refresh()
        End If
    End Sub

    Public Function BulletRandomLocation()
        'Function that puts the bullet in a random location
        BulletLocation = BulletRandom.Next(1, 6)
        Return BulletLocation
    End Function

    Public Sub CylinderImage()
        'If the Player has shot either himself or Mysterion and bullet chamber was empty, then change Revolver image to show it was safe.
        If BulletCount = 1 Then
            Form1.pbCylinder.Image = My.Resources.Revolver
            Form1.pbCylinder.Refresh()
        ElseIf BulletCount = 2 Then
            Form1.pbCylinder.Image = My.Resources.Revolver1
            Form1.pbCylinder.Refresh()
        ElseIf BulletCount = 3 Then
            Form1.pbCylinder.Image = My.Resources.Revolver2
            Form1.pbCylinder.Refresh()
        ElseIf BulletCount = 4 Then
            Form1.pbCylinder.Image = My.Resources.Revolver3
            Form1.pbCylinder.Refresh()
        ElseIf BulletCount = 5 Then
            Form1.pbCylinder.Image = My.Resources.Revolver4
            Form1.pbCylinder.Refresh()
        ElseIf BulletCount = 6 Then
            Form1.pbCylinder.Image = My.Resources.Revolver5
            Form1.pbCylinder.Refresh()
        End If
    End Sub

    Public Sub SaveDetails()
        ' This function checks if the save file exists. Adds text if it does, creates save file and adds text if it doesn't
        Dim FullName As String = EnterNameForm.txtName.Text
        If FullName = "" Then
            MsgBox("Please enter your initials")
            Return
        End If
        Dim Path As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) &
                              "\Saved Games\SouthParkRoulette.csv")        'Location where the default LeaderBoard file is
        Dim ReadAllLinesArray(0) As String
        Dim Check = False
        If File.Exists(Path) = False Then                  'Check if file exists and if doesn't then create text file and add text
            If EnterNameForm.OutCome = "Winner" Then
                ReadAllLinesArray(0) = FullName & "," & "1" & "," & "0" & "," & "0"
            Else
                ReadAllLinesArray(0) = FullName & "," & "0" & "," & "1" & "," & "0"
            End If
        Else
            ReadAllLinesArray = File.ReadAllLines(Path)
            For i = 0 To ReadAllLinesArray.Length - 1
                Dim LeaderBoardArray = ReadAllLinesArray(i).Split(",")
                If LeaderBoardArray(0) = FullName Then
                    Check = True
                    If EnterNameForm.OutCome = "Winner" Then
                        ReadAllLinesArray(i) = LeaderBoardArray(0) & "," & LeaderBoardArray(1) + 1 & "," & LeaderBoardArray(2)
                    Else
                        ReadAllLinesArray(i) = LeaderBoardArray(0) & "," & LeaderBoardArray(1) & "," & (LeaderBoardArray(2) + 1)
                    End If
                End If
            Next
            If Check = False Then
                Array.Resize(ReadAllLinesArray, ReadAllLinesArray.Length + 1)
                ReadAllLinesArray(ReadAllLinesArray.Length - 1) = FullName & "," & "1" & "," & "0" & "," & "0"
            End If
        End If
        File.WriteAllLines(Path, ReadAllLinesArray)

        ' Closes Game, Loads MainMenu
        EnterNameForm.Close()
        Form1.Close()
        MainMenu.Show()
        LeaderBoardForm.Show()
    End Sub

End Class
