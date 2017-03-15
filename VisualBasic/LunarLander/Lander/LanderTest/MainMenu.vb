Public Class MainMenu

    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        LanderServer.Show()

    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        LanderClient.Show()

    End Sub
End Class