Public Class frmQuestion2
    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAnswer4_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer4.CheckedChanged

    End Sub

    Private Sub btnAnswer3_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer4.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()
        Me.Hide()
    End Sub
End Class