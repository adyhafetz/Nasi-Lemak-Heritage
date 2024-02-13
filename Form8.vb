Imports System.IO

Public Class formComplete
    Dim reviewFile As StreamWriter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Terminate program
        End
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Reset control
        formSummary.lblTax.Text = Nothing
        formSummary.lblDiscount.Text = Nothing
        formSummary.lblTotal.Text = Nothing
        formMenu.lblCartQty.Text = Nothing
        formOption.lblCartQty.Text = Nothing
        formOption.totalPrice = 0
        formOption.tax = 0
        formOption.discount = 0
        formOption.totalPrice = 0
        formOption.finalPrice = 0
        formOption.itemCount = 0
        formSignUp.dt.Clear()
        formSummary.dgvInvoice.Refresh()
        Try
            formSignUp.conn2.Open()
            formSignUp.cmd = formSignUp.conn2.CreateCommand()
            formSignUp.cmd.CommandType = CommandType.Text
            formSignUp.command = "DELETE * FROM [Invoice]"
            formSignUp.cmd.CommandText = formSignUp.command
            formSignUp.cmd.ExecuteNonQuery()
            formSignUp.conn2.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        'Show formHome
        Me.Hide()
        formHome.Show()
    End Sub

    Private Sub ReviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewToolStripMenuItem.Click
        Try
            reviewFile = File.AppendText("Review.txt")
            Dim userReview As String = InputBox("Leave a review...")

            If userReview <> Nothing Then
                reviewFile.WriteLine(userReview)
                MsgBox("Thanks for the review!", vbInformation)
            Else
                MsgBox("No review entered", vbCritical)
            End If
            reviewFile.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class