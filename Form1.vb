Public Class formHome
    Public status As String
    Private Sub timerAds_Tick(sender As Object, e As EventArgs) Handles timerAds.Tick
        'Advertisment auto slide image
        If lblImage.Text = "1" Then
            picAds.Image = My.Resources._2
            lblImage.Text = "2"
        ElseIf lblImage.Text = "2" Then
            picAds.Image = My.Resources._3
            lblImage.Text = "3"
        ElseIf lblImage.Text = "3" Then
            picAds.Image = My.Resources._4
            lblImage.Text = "4"
        ElseIf lblImage.Text = "4" Then
            picAds.Image = My.Resources._1
            lblImage.Text = "1"
        End If
    End Sub
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'Show formSignUp
        Me.Hide()
        formSignUp.Show()
        formSignUp.txtCustName.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Set user status to "Customer"
        status = "Customer"

        'Show formLogin
        Me.Hide()
        formLogin.Show()

        'Set focus and reset username and password text box
        formLogin.txtUsername.Focus()
        formLogin.txtUsername.Text = Nothing
        formLogin.txtPassword.Text = Nothing
    End Sub

    Private Sub tsmStaff_Click(sender As Object, e As EventArgs) Handles tsmStaff.Click
        'Set user status to "Customer" and show formLogin
        status = "Staff"

        'Show formLogin
        Me.Hide()
        formLogin.Show()

        'Set focus and reset username and password text box
        formLogin.txtUsername.Focus()
        formLogin.txtUsername.Text = Nothing
        formLogin.txtPassword.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Terminate program
        End
    End Sub
End Class
