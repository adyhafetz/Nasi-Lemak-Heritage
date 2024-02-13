Public Class formControl
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        'Show formHome
        Me.Hide()
        formHome.Show()
    End Sub
    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        'Show formStaff
        Me.Hide()
        formStaff.Show()
    End Sub
    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        'Show formCustomer
        Me.Hide()
        formCustomer.Show()
    End Sub
    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        'Show formOrder
        Me.Hide()
        formOrder.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Company info auto slide image
        If lblImage.Text = "1" Then
            picAds.Image = My.Resources.staff2
            lblImage.Text = "2"
        ElseIf lblImage.Text = "2" Then
            picAds.Image = My.Resources.staff3
            lblImage.Text = "3"
        ElseIf lblImage.Text = "3" Then
            picAds.Image = My.Resources.staff4
            lblImage.Text = "4"
        ElseIf lblImage.Text = "4" Then
            picAds.Image = My.Resources.staff1
            lblImage.Text = "1"
        End If
    End Sub
End Class