Public Class formPayment
    Private Sub btnCompleted_Click(sender As Object, e As EventArgs) Handles btnCompleted.Click
        'Show formComplete
        Me.Hide()
        formComplete.Show()
    End Sub
    Private Sub tsmBack_Click(sender As Object, e As EventArgs) Handles tsmBack.Click
        'Show formSummary
        Me.Hide()
        formSummary.Show()
    End Sub
    Private Sub picQR_Click(sender As Object, e As EventArgs) Handles picQR.Click
        'Show QR code picture
        gpQr.Hide()
        gpCash.Hide()
        picPayment.Image = My.Resources.QR2
        picPayment.Visible = True
    End Sub
    Private Sub picCash_Click(sender As Object, e As EventArgs) Handles picCash.Click
        'Show Cash picture
        gpQr.Hide()
        gpCash.Hide()
        picPayment.Image = My.Resources.CH2
        picPayment.Visible = True
    End Sub
End Class