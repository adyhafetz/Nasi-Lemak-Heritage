Imports System.Data.OleDb
Public Class formLogin
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'Password visibilty
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf chkShow.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            'Input validation
            If txtUsername.Text = Nothing Then
                MsgBox("Please enter your username", vbExclamation)
                txtUsername.Focus()
            End If
            If txtPassword.Text = Nothing Then
                MsgBox("Please enter your passwords", vbExclamation)
                txtPassword.Focus()
            End If
        Else
            Try
                formSignUp.conn1.Open()
                If formHome.status = "Customer" Then
                    'Check customer's information in database
                    formSignUp.cmd = New OleDbCommand("SELECT * FROM [Customer] WHERE [Cust_Username] = '" & txtUsername.Text & "' AND [Cust_Password] = '" & txtPassword.Text & "'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() Then
                            MsgBox("Login Successful", vbInformation)

                            'Show formMenu
                            Me.Hide()
                            formMenu.Show()
                        Else
                            MsgBox("Invalid username or password", vbExclamation)
                        End If
                    End Using
                ElseIf formHome.status = "Staff" Then
                    'Check staff's information in database
                    formSignUp.cmd = New OleDbCommand("SELECT * FROM [Staff] WHERE [Staff_Username] = '" & txtUsername.Text & "' AND [Staff_Password] = '" & txtPassword.Text & "'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() Then
                            MsgBox("Login Successful", vbInformation)

                            'Show formControl
                            Me.Hide()
                            formControl.Show()
                        Else
                            MsgBox("Invalid username or password", vbExclamation)
                        End If
                    End Using
                End If
                formSignUp.conn1.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        formHome.Show()
    End Sub
End Class