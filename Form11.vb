Imports System.Data.OleDb
Imports System.IO
Public Class formCustomer
    Dim openReview As StreamReader
    Sub display()
        'Reset control
        formSignUp.dt.Clear()
        dgvCustomer.Refresh()

        'Display table Customer in datagridview
        Try
            formSignUp.conn1.Open()
            formSignUp.da = New OleDbDataAdapter("SELECT * FROM [Customer]", formSignUp.conn1)
            formSignUp.da.Fill(formSignUp.dt)
            dgvCustomer.DataSource = formSignUp.dt
            formSignUp.conn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub formCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call display sub procedure
        display()
    End Sub
    Private Sub tsmBack_Click(sender As Object, e As EventArgs) Handles tsmBack.Click
        'Show formControl
        Me.Hide()
        formControl.Show()
    End Sub
    Private Sub tsmRefresh_Click(sender As Object, e As EventArgs) Handles tsmRefresh.Click
        'Call display sub procedure
        display()
    End Sub

    Private Sub ReviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewToolStripMenuItem.Click
        Dim review As String
        lstReview.Items.Clear()
        lstReview.Items.Add("-----------------------------------------------------------------------------------------------------------------------")
        lstReview.Items.Add(vbTab & vbTab & vbTab & "        Review List")
        lstReview.Items.Add("-----------------------------------------------------------------------------------------------------------------------")
        openReview = File.OpenText("Review.txt")
        Do Until openReview.EndOfStream
            review = openReview.ReadLine()
            lstReview.Items.Add("# " & review)
        Loop
    End Sub
End Class