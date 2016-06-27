Public Class SomeoneWon
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'Shows MainMenu
        MultiPlayer.Close()
        MainMenu.Show()
        Me.Close()
    End Sub
End Class