Imports System.Data.OleDb
Public Class formStaff
    Sub display()
        'Reset control
        txtStaffName.Text = Nothing
        txtStaffTelephone.Text = Nothing
        txtStaffEmail.Text = Nothing
        txtStaffUsername.Text = Nothing
        txtStaffPassword.Text = Nothing
        formSignUp.dt.Clear()
        dgvStaff.Refresh()

        'Display table Staff in datagridview
        Try
            formSignUp.conn1.Open()
            formSignUp.da = New OleDbDataAdapter("SELECT * FROM Staff", formSignUp.conn1)
            formSignUp.da.Fill(formSignUp.dt)
            dgvStaff.DataSource = formSignUp.dt
            formSignUp.conn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub formStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call display sub procedure
        display()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStaffName.Text = Nothing Or txtStaffTelephone.Text = Nothing Or txtStaffEmail.Text = Nothing Or txtStaffUsername.Text = Nothing Or txtStaffPassword.Text = Nothing Then
            'Input validation
            If txtStaffName.Text = Nothing Then
                MsgBox("Please enter staff name", vbExclamation)
                txtStaffName.Focus()
            End If
            If txtStaffTelephone.Text = Nothing Then
                MsgBox("Please enter staff telephone number", vbExclamation)
                txtStaffTelephone.Focus()
            End If
            If txtStaffEmail.Text = Nothing Then
                MsgBox("Please enter staff email", vbExclamation)
                txtStaffEmail.Focus()
            End If
            If txtStaffUsername.Text = Nothing Then
                MsgBox("Please enter staff username", vbExclamation)
                txtStaffUsername.Focus()
            End If
            If txtStaffPassword.Text = Nothing Then
                MsgBox("Please enter staff password", vbExclamation)
                txtStaffPassword.Focus()
            End If
        Else
            'Insert staff's information into database
            Try
                formSignUp.conn1.Open()
                formSignUp.cmd = formSignUp.conn1.CreateCommand()
                formSignUp.cmd.CommandType = CommandType.Text
                formSignUp.cmd.CommandText = "INSERT INTO [Staff]([Staff_Name], [Staff_Telephone], [Staff_Email], [Staff_Hiring_Date], [Staff_Username], [Staff_Password]) VALUES('" & txtStaffName.Text & "', '" & txtStaffTelephone.Text & "', '" & txtStaffEmail.Text & "', '" & dtStaffHireDate.Value.Date.ToString("dd/MM/yyyy") & "', '" & txtStaffUsername.Text & "', '" & txtStaffPassword.Text & "')"
                formSignUp.cmd.ExecuteNonQuery()
                formSignUp.conn1.Close()
                MsgBox("Added Successfully", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If

        'Call display sub procedure
        display()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update staff info
        Try
            formSignUp.conn1.Open()
            formSignUp.cmd = formSignUp.conn1.CreateCommand()
            formSignUp.cmd.CommandType = CommandType.Text
            formSignUp.command = "UPDATE [Staff] SET [Staff_Name] = '" & txtStaffName.Text & "', [Staff_Telephone] = '" & txtStaffTelephone.Text & "', [Staff_Email] = '" & txtStaffEmail.Text & "', [Staff_Hiring_Date] = '" & dtStaffHireDate.Value.Date.ToString("dd/MM/yyyy") & "', [Staff_Username] = '" & txtStaffUsername.Text & "', [Staff_Password] = '" & txtStaffPassword.Text & "' WHERE [Staff_Username] = '" & txtStaffUsername.Text & "'"
            formSignUp.cmd.CommandText = formSignUp.command
            formSignUp.cmd.ExecuteNonQuery()
            formSignUp.conn1.Close()
            MsgBox("Updated Successfully", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        'Call display sub procedure
        display()
    End Sub
    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        'Select row
        Try
            txtStaffName.Text = dgvStaff.SelectedRows(0).Cells(0).Value.ToString()
            txtStaffTelephone.Text = dgvStaff.SelectedRows(0).Cells(1).Value.ToString()
            txtStaffEmail.Text = dgvStaff.SelectedRows(0).Cells(2).Value.ToString()
            dtStaffHireDate.Value = Date.Parse(dgvStaff.SelectedRows(0).Cells(3).Value.ToString())
            txtStaffUsername.Text = dgvStaff.SelectedRows(0).Cells(4).Value.ToString()
            txtStaffPassword.Text = dgvStaff.SelectedRows(0).Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Search staff based on username
        Try
            formSignUp.conn1.Open()
            formSignUp.cmd = formSignUp.conn1.CreateCommand()
            formSignUp.cmd.CommandType = CommandType.Text
            formSignUp.command = "SELECT * FROM [Staff] WHERE [Staff_Username] = '" & txtSearch.Text & "'"
            formSignUp.cmd.CommandText = formSignUp.command
            formSignUp.dt = New DataTable()
            formSignUp.da = New OleDbDataAdapter(formSignUp.cmd)
            formSignUp.da.Fill(formSignUp.dt)
            dgvStaff.DataSource = formSignUp.dt
            formSignUp.conn1.Close()
            txtSearch.Text = "Search"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete staff
        Try
            formSignUp.conn1.Open()
            formSignUp.cmd = formSignUp.conn1.CreateCommand()
            formSignUp.cmd.CommandType = CommandType.Text
            formSignUp.command = "DELETE * FROM [Staff] WHERE [Staff_Username] = '" & txtStaffUsername.Text & "'"
            formSignUp.cmd.CommandText = formSignUp.command
            formSignUp.cmd.ExecuteNonQuery()
            formSignUp.conn1.Close()
            MsgBox("Deleted Successfully", vbInformation)
            display()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Call display sub procedure
        display()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Call display sub procedure
        display()
    End Sub
    Private Sub tsmBack_Click(sender As Object, e As EventArgs) Handles tsmBack.Click
        'Show formControl
        Me.Hide()
        formControl.Show()
    End Sub
End Class