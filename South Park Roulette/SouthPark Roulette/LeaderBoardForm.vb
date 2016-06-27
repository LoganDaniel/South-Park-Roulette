Imports System.IO
Public Class LeaderBoardForm



    Public GameMechanics As New GameManager
    Dim Path As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) &
                          "\Saved Games\SouthParkRoulette.csv")    'Path for default save location
    Dim Line As String  'Program reads each LINE and converts it to LeaderBoard, then does next LINE
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes LeaderBoard Form which makes only the MainMenu visible.
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Pops up a Dialog box which allows the user to load a save file
        OpenFileDialog1.Title = "Select your Leaderboard Textfile"
        OpenFileDialog1.Filter = "Text File|*.txt;*.csv|All Files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub LeaderBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Load.h e program will try and read my default path for my save file.
        If File.Exists(Path) = True Then
            Dim FileRead As StreamReader
            FileRead = New StreamReader(Path)
            Do Until FileRead.EndOfStream
                Line = FileRead.ReadLine
                Dim LeaderBoardArray = Line.Split(",")
                dgLeaderBoard.Rows.Add(LeaderBoardArray(0), Convert.ToInt32(LeaderBoardArray(1)), Convert.ToInt32(LeaderBoardArray(2)), Convert.ToInt32(LeaderBoardArray(1)) - Convert.ToInt32(LeaderBoardArray(2)))
            Loop
            dgLeaderBoard.Sort(dgLeaderBoard.Columns(3), System.ComponentModel.ListSortDirection.Descending)

        ElseIf File.Exists(Path) = False Then
            MsgBox("No Save file detected, Please finish the game to create one" & vbCrLf & "To load a Save File, Use the load button")
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'This function Reads, and converts the save file into the LeaderBoard.
        Dim FileRead As StreamReader
        dgLeaderBoard.Rows.Clear()
        FileRead = New StreamReader(OpenFileDialog1.FileName)
        Do Until FileRead.EndOfStream
            Line = FileRead.ReadLine
            Dim LeaderBoardArray = Line.Split(",")
            dgLeaderBoard.Rows.Add(LeaderBoardArray(0), Convert.ToInt32(LeaderBoardArray(1)), Convert.ToInt32(LeaderBoardArray(2)), Convert.ToInt32(LeaderBoardArray(3)))
        Loop
    End Sub
End Class