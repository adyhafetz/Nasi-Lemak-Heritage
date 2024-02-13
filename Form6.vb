Imports System.Data.OleDb
Public Class formSummary
    'Dim remarksFile As StreamWriter
    Public remarksCheck As Boolean = False
    Public remarks, cancelOrder As String
    Private Sub btnRemarks_Click(sender As Object, e As EventArgs) Handles btnRemarks.Click
        'Write remarks in "Remarks" text file
        remarksCheck = True
        remarks = txtRemarks.Text
    End Sub
    Private Sub tsmPreview_Click(sender As Object, e As EventArgs) Handles tsmPreview.Click
        'Print preview
        formOption.prPreview.ShowDialog()
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Show formPayment
        Me.Hide()
        formPayment.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelOrder = "Cancel"
        Try
            Dim item As String
            Dim quantity As String

            formSignUp.conn1.Open()
            formSignUp.conn2.Open()
            formSignUp.cmd = New OleDbCommand("SELECT [Item] FROM [Invoice]", formSignUp.conn2)
            Using rdItem As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                While rdItem.Read()
                    item = rdItem("Item")
                    If item = formMenu.menuName(0) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countES = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countES, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countES & "' WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(1) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countEA = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countEA, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countEA & "' WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(2) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countCS = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countCS, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countCS & "' WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(3) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countCA = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countCA, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countCA & "' WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(4) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countBS = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countBS, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countBS & "' WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(5) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countBA = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countBA, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countBA & "' WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(6) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countSS = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countSS, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countSS & "' WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'Set'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    ElseIf item = formMenu.menuName(7) Then
                        formSignUp.cmd = New OleDbCommand("SELECT [Quantity] FROM [Invoice] WHERE [Item] = '" & item & "'", formSignUp.conn2)
                        Using rdQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()
                            If rdQuantity.Read() AndAlso Not IsDBNull(rdQuantity("Quantity")) Then
                                quantity = rdQuantity("Quantity")
                                formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                Using rdOrderQuantity As OleDbDataReader = formSignUp.cmd.ExecuteReader()

                                    'Decreament of order quantity
                                    If rdOrderQuantity.Read() AndAlso Not IsDBNull(rdOrderQuantity("Order_Quantity")) Then
                                        formOption.countSA = rdOrderQuantity("Order_Quantity")
                                        formOption.orderCounter(formOption.countSA, quantity)
                                        formSignUp.cmd = New OleDbCommand("UPDATE [Order] SET [Order_Quantity] = '" & formOption.countSA & "' WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                                        formSignUp.cmd.ExecuteNonQuery()
                                    End If
                                End Using
                            End If
                        End Using
                    End If
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If formSignUp.conn1.State = ConnectionState.Open Then
                formSignUp.conn1.Close()
            End If

            If formSignUp.conn2.State = ConnectionState.Open Then
                formSignUp.conn2.Close()
            End If
        End Try
        Me.Hide()
        formHome.Show()
    End Sub
    Private Sub tsmBack_Click(sender As Object, e As EventArgs) Handles tsmBack.Click
        'show formMenu
        Me.Hide()
        formMenu.Show()
    End Sub
End Class