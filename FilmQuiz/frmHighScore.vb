Public Class frmHighScore
    Private Sub lstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHighScore.SelectedIndexChanged

    End Sub
    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.text = "Sorry your score was not good enough"
        Else
            lblMessage.text = "Congratulations your score will be added to the hall of fame"
            lstHighScore.Items.Add(playername & vbTab & playerScore)
        End If
    End Sub
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class