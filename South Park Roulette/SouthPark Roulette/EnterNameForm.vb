Imports System.IO
Public Class EnterNameForm
    Dim GameMechanics As New GameManager
    Public OutCome As String 'Determines if you have won or lost
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        GameMechanics.SaveDetails()
    End Sub
End Class