Imports Winotify.Winotify
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Warning)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Info)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Errors)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Success)
    End Sub
End Class
