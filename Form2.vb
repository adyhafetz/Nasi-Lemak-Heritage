Imports System.Data.OleDb

Public Class formSignUp
    Public conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adyha\OneDrive\Desktop\CSC301 - Database.accdb")
    Public conn2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\adyha\OneDrive\Desktop\CSC301 - Group Project\bin\Debug\CSC301 - Database.accdb")
    Public cmd As New OleDbCommand
    Public rd As OleDbDataReader
    Public dt As New DataTable
    Public da As New OleDbDataAdapter(cmd)
    Public command As String = ""
    Public membership As String
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'Password visibilty
        If chkShow.Checked = True Then
            txtCustPassword.UseSystemPasswordChar = False
        Else
            txtCustPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtCustName.Text = Nothing Or txtCustTelephone.Text = Nothing Or txtCustUsername.Text = Nothing Or txtCustPassword.Text = Nothing Or radCustMemberYes.Checked = False And radCustMemberNo.Checked = False Then
            'Input validation
            If txtCustName.Text = Nothing Then
                MsgBox("Please enter your name", vbExclamation)
                txtCustName.Focus()
            End If
            If txtCustTelephone.Text = Nothing Then
                MsgBox("Please enter your telephone number", vbExclamation)
                txtCustTelephone.Focus()
            End If
            If txtCustUsername.Text = Nothing Then
                MsgBox("Please enter your username", vbExclamation)
                txtCustUsername.Focus()
            End If
            If txtCustPassword.Text = Nothing Then
                MsgBox("Please enter your password", vbExclamation)
                txtCustPassword.Focus()
            End If
            If radCustMemberYes.Checked = False And radCustMemberNo.Checked = False Then
                MsgBox("Please select membership status", vbExclamation)
            End If
        Else
            'Set membership status
            If radCustMemberYes.Checked Then
                membership = "Yes"
            ElseIf radCustMemberNo.Checked Then
                membership = "No"
            End If
            'Insert customer's information into database
            Try
                conn1.Open()
                cmd = conn1.CreateCommand()
                cmd.CommandType = CommandType.Text
                command = "INSERT INTO [Customer]([Cust_Name], [Cust_Telephone], [Cust_Username], [Cust_Password], [Cust_Membership])VALUES ('" & txtCustName.Text & "', '" & txtCustTelephone.Text & "', '" & txtCustUsername.Text & "', '" & txtCustPassword.Text & "', '" & membership & "')"
                cmd.CommandText = command
                cmd.ExecuteNonQuery()
                conn1.Close()
                MsgBox("Sign Up Successful!", vbInformation)
                'Show formHome
                Me.Hide()
                formHome.Show()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Show formHome
        formHome.Show()
        Me.Hide()
    End Sub

End Class