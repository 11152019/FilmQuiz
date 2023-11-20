Public Class frmQuestion1
    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer3.Checked Then
            playerScore = playerscore + 1
        End If

        frmQuestion2.Show()
        Me.Hide()
    End Sub
End Class