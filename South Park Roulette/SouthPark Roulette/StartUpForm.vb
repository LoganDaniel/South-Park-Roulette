Public Class StartUpForm

    Private Sub StartUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'I've added this form as Starting the application from MainMenu crashes the program when I have to make MainMenu pop up again
        ' which means Visual Studio tries to change code to SouthPark Font but already sees I have it running and crashes
        Me.Opacity = 0
        MainMenu.Show()
    End Sub
End Class