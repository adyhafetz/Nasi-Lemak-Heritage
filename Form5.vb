Imports System.Data.OleDb
Public Class formOption
    Public price As Double = 0.0
    Public totalPrice As Double = 0.0
    Public tax As Double = 0.0
    Public discount As Double = 0.0
    Public Const taxRate As Double = 0.07
    Public Const discRate As Double = 0.05
    Public finalPrice As Double = 0.0
    Public itemCount As Integer = 0
    Public countES, countEA, countCS, countCA, countBS, countBA, countSS, countSA As Integer
    Sub itemCounter(ByRef itemCount As Integer)
        'Count item in cart
        itemCount += 1
    End Sub
    Sub orderCounter(ByRef orderCount As Integer, ByVal qty As Integer)
        'Addition and substraction of order quantity
        If formSummary.cancelOrder = "Cancel" Then
            orderCount -= qty
        Else
            orderCount += qty
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        'Update cart quantity value
        itemCounter(itemCount)
        lblCartQty.Text = itemCount
        formMenu.lblCartQty.Text = itemCount

        Try
            formSignUp.conn1.Open()
            formSignUp.conn2.Open()
            formSignUp.cmd = formSignUp.conn1.CreateCommand()
            formSignUp.cmd.CommandType = CommandType.Text
            If formMenu.sMenu = "E" Then
                If formMenu.radSetE.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(0) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'Set'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countES = rd("Order_Quantity")
                            orderCounter(countES, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countES & "' WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'Set'"
                        End If
                    End Using
                ElseIf formMenu.radAlaE.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(1) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countEA = rd("Order_Quantity")
                            orderCounter(countEA, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countEA & "' WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'A La Carte'"
                        End If
                    End Using
                End If
            ElseIf formMenu.sMenu = "C" Then
                If formMenu.radSetC.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(2) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'Set'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countCS = rd("Order_Quantity")
                            orderCounter(countCS, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countCS & "' WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'Set'"
                        End If
                    End Using
                ElseIf formMenu.radAlaC.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(3) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countCA = rd("Order_Quantity")
                            orderCounter(countCA, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countCA & "' WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'A La Carte'"
                        End If
                    End Using
                End If
            ElseIf formMenu.sMenu = "B" Then
                If formMenu.radSetB.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(4) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'Set'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countBS = rd("Order_Quantity")
                            orderCounter(countBS, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countBS & "' WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'Set'"
                        End If
                    End Using
                ElseIf formMenu.radAlaB.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(5) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countBA = rd("Order_Quantity")
                            orderCounter(countBA, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countBA & "' WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'A La Carte'"
                        End If
                    End Using
                End If
            ElseIf formMenu.sMenu = "S" Then
                If formMenu.radSetS.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(6) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'Set'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countSS = rd("Order_Quantity")
                            orderCounter(countSS, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countSS & "' WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'Set'"
                        End If
                    End Using
                ElseIf formMenu.radAlaS.Checked Then
                    'Calculate price
                    price = formMenu.menuPrice(7) * updQty.Value

                    'Increament of order quantity
                    formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
                    Using rd = formSignUp.cmd.ExecuteReader()
                        If rd.Read() AndAlso Not IsDBNull(rd("Order_Quantity")) Then
                            countSA = rd("Order_Quantity")
                            orderCounter(countSA, updQty.Value)
                            formSignUp.command = "UPDATE [Order] SET [Order_Quantity] = '" & countSA & "' WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'A La Carte'"
                        End If
                    End Using
                End If
            End If
            formSignUp.cmd.CommandText = formSignUp.command
            formSignUp.cmd.ExecuteNonQuery()

            'Insert order details in Invoice table
            formSignUp.cmd = formSignUp.conn2.CreateCommand()
            formSignUp.cmd.CommandText = "INSERT INTO [Invoice]([No], [Item], [Quantity], [Price(RM)]) VALUES ('" & itemCount.ToString() & "','" & formMenu.sMenuName & "', '" & updQty.Value.ToString() & "', '" & price.ToString("C2") & "')"
            formSignUp.cmd.ExecuteNonQuery()

            'Display Invoice table in datagridview
            formSignUp.da = New OleDbDataAdapter("SELECT * FROM [Invoice]", formSignUp.conn2)
            formSignUp.dt.Clear()
            formSignUp.da.Fill(formSignUp.dt)
            formSummary.dgvInvoice.DataSource = formSignUp.dt

            'Calculate total price
            totalPrice = formSignUp.dt.AsEnumerable().Sum(Function(row) CDbl(row("Price(RM)")))

            'Calculate tax
            tax = totalPrice * taxRate

            'Calculate membership discount
            formSignUp.cmd = New OleDbCommand("SELECT [Cust_Membership] FROM [Customer] WHERE [Cust_Username] = '" & formLogin.txtUsername.Text & "'", formSignUp.conn1)
            Using rd = formSignUp.cmd.ExecuteReader()
                If rd.Read() AndAlso Not IsDBNull(rd("Cust_Membership")) Then
                    formSignUp.membership = rd("Cust_Membership")
                    If formSignUp.membership = "Yes" Then
                        discount = totalPrice * discRate
                    ElseIf formSignUp.membership = "No" Then
                        discount = 0.00
                    End If
                End If
            End Using

            'Calculate final price
            finalPrice = totalPrice + tax - discount
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

        'Display tax, discount, final price
        formSummary.lblTax.Text = tax.ToString("C2")
        formSummary.lblDiscount.Text = discount.ToString("C2")
        formSummary.lblTotal.Text = finalPrice.ToString("C2")

        'Reset controls
        formMenu.radAlaE.Checked = False
        formMenu.radAlaB.Checked = False
        formMenu.radAlaC.Checked = False
        formMenu.radAlaS.Checked = False
        formMenu.radSetE.Checked = False
        formMenu.radSetB.Checked = False
        formMenu.radSetC.Checked = False
        formMenu.radSetS.Checked = False
        cmbSideDish.Items.Clear()
        cmbGravy.SelectedIndex = -1
        cmbBeverage.SelectedIndex = -1
        radHot.Checked = False
        radCold.Checked = False
        updQty.Value = 0

        'Show fromMenu
        Me.Hide()
        formMenu.Show()
    End Sub

    Private Sub pdPreview_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPreview.PrintPage
        Dim startY As Integer = 60
        Dim custName As String
        Dim no As String = "No"
        Dim item As String = " Item"
        Dim quantity As String = " Quantity"
        Dim price As String = " Price(RM)"

        'Display title
        e.Graphics.DrawString("NASI LEMAK HERITTAGE", New Font("Courier New", 20, FontStyle.Bold), Brushes.Black, 243, startY)
        startY += 40
        e.Graphics.DrawString("************************************************", New Font("Courier New", 20, FontStyle.Bold), Brushes.Black, 0, startY)
        startY += 40

        'Display customer name
        Try
            formSignUp.conn1.Open()
            formSignUp.cmd = New OleDbCommand("SELECT Cust_Name FROM Customer WHERE Cust_Username = '" & formLogin.txtUsername.Text & "'", formSignUp.conn1)
            Using rd = formSignUp.cmd.ExecuteReader()
                rd.Read()
                custName = rd("Cust_Name")
                e.Graphics.DrawString("Customer Name: " & custName, New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
                startY += 50
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If formSignUp.conn1.State = ConnectionState.Open Then
                formSignUp.conn1.Close()
            End If
        End Try

        'Display column
        e.Graphics.DrawString(no.PadRight(3) & "|" & item.PadRight(28) & "|" & quantity.PadRight(10) & "|" & price.PadRight(10), New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
        startY += 20
        e.Graphics.DrawString("------------------------------------------------------", New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
        startY += 30

        'Display Invoice
        Try
            formSignUp.conn2.Open()
            formSignUp.cmd = New OleDbCommand("SELECT * FROM Invoice", formSignUp.conn2)
            Using rd = formSignUp.cmd.ExecuteReader()
                While rd.Read()
                    no = rd("No")
                    item = rd("Item")
                    quantity = rd("Quantity")
                    price = rd("Price(RM)")
                    e.Graphics.DrawString(no.PadRight(3) & "| " & item.PadRight(27) & "| " & quantity.PadRight(9) & "| " & price.PadRight(9), New Font("Courier New", 16, FontStyle.Regular), Brushes.Black, 50, startY)
                    startY += 30
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            If formSignUp.conn2.State = ConnectionState.Open Then
                formSignUp.conn2.Close()
            End If
        End Try

        e.Graphics.DrawString("------------------------------------------------------", New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
        startY += 30

        'Display remarks if any"
        If formSummary.remarksCheck Then
            e.Graphics.DrawString("Remarks: " & formSummary.remarks, New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
            startY += 30
        End If

        'Display tax, discount, final price
        e.Graphics.DrawString("Tax(7%): " & tax.ToString("C2"), New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
        startY += 30
        e.Graphics.DrawString("Membership Discount: " & discount.ToString("C2"), New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
        startY += 30
        e.Graphics.DrawString("Total Price: " & finalPrice.ToString("C2"), New Font("Courier New", 16, FontStyle.Bold), Brushes.Black, 50, startY)
    End Sub

    Private Sub tsmPreview_Click(sender As Object, e As EventArgs) Handles tsmPreview.Click
        'Print preview
        prPreview.ShowDialog()
    End Sub

    Private Sub tsmCart_Click(sender As Object, e As EventArgs) Handles tsmCart.Click
        'Show formSummary
        Me.Hide()
        formSummary.Show()
    End Sub
End Class