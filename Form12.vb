Imports System.Data.OleDb
Imports System.IO
Public Class formOrder
    Dim rd As OleDbDataReader
    Dim orderReport As StreamWriter
    Dim totalES, totalEA, totalCS, totalCA, totalBS, totalBA, totalSS, totalSA, totalIncome As Double
    Sub display()
        'Reset control
        formSignUp.dt.Clear()
        dgvOrder.Refresh()

        'Display table Order in datagridview
        Try
            formSignUp.conn1.Open()
            formSignUp.da = New OleDbDataAdapter("SELECT * FROM [Order]", formSignUp.conn1)
            formSignUp.da.Fill(formSignUp.dt)
            dgvOrder.DataSource = formSignUp.dt
            formSignUp.conn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Function calculateIncome(ES As Double, EA As Double, CS As Double, CA As Double, BS As Double, BA As Double, SS As Double, SA As Double)
        'Calculate total income
        calculateIncome = ES + EA + CS + CA + BS + BA + SS + SA
    End Function
    Private Sub formSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Calculate total price for each of ordered items
            formSignUp.conn1.Open()
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'Set'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalES = rd("Order_Quantity")
            totalES *= formMenu.menuPrice(0)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Egg-dition' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalEA = rd("Order_Quantity")
            totalEA *= formMenu.menuPrice(1)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'Set'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalCS = rd("Order_Quantity")
            totalCS *= formMenu.menuPrice(2)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Chicken Lover' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalCA = rd("Order_Quantity")
            totalCA *= formMenu.menuPrice(3)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'Set'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalBS = rd("Order_Quantity")
            totalBS *= formMenu.menuPrice(4)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Beef Maniac' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalBA = rd("Order_Quantity")
            totalBA *= formMenu.menuPrice(5)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'Set'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalSS = rd("Order_Quantity")
            totalSS *= formMenu.menuPrice(6)
            formSignUp.cmd = New OleDbCommand("SELECT [Order_Quantity] FROM [Order] WHERE [Order_Name] = 'Seafood Addict' AND [Order_Type] = 'A La Carte'", formSignUp.conn1)
            rd = formSignUp.cmd.ExecuteReader()
            rd.Read()
            totalSA = rd("Order_Quantity")
            totalSA *= formMenu.menuPrice(7)
            formSignUp.conn1.Close()

            'Display total price for each of ordered items
            lblES.Text = totalES.ToString("C2")
            lblEA.Text = totalEA.ToString("C2")
            lblCS.Text = totalCS.ToString("C2")
            lblCA.Text = totalCA.ToString("C2")
            lblBS.Text = totalBS.ToString("C2")
            lblBA.Text = totalBA.ToString("C2")
            lblSS.Text = totalSS.ToString("C2")
            lblSA.Text = totalSA.ToString("C2")

            'Calculate total price for all of ordered items
            totalIncome = calculateIncome(totalES, totalEA, totalCS, totalCA, totalBS, totalBA, totalSS, totalSA)

            'Display total price for all of ordered items
            lblTotalIncome.Text = totalIncome.ToString("C2")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

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

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        'Create "Order Report" file to store total price each of ordered item and total income
        Try
            orderReport = File.CreateText("Order Report.txt")
            orderReport.WriteLine("--------------------------------------------")
            orderReport.WriteLine(vbTab & vbTab & "Order Report")
            orderReport.WriteLine("--------------------------------------------")
            orderReport.WriteLine("Total Egg-dition (Set):" & totalES.ToString("C2").PadLeft(21))
            orderReport.WriteLine("Total Egg-dition (A La Carte):" & totalEA.ToString("C2").PadLeft(14))
            orderReport.WriteLine("Total Chicken Lover (Set):" & totalCS.ToString("C2").PadLeft(18))
            orderReport.WriteLine("Total Chicken Lover (A La Carte):" & totalCA.ToString("C2").PadLeft(11))
            orderReport.WriteLine("Total Beef Maniac (Set):" & totalBS.ToString("C2").PadLeft(20))
            orderReport.WriteLine("Total Beef Maniac (A La Carte):" & totalBA.ToString("C2").PadLeft(13))
            orderReport.WriteLine("Total Seafood Addict (Set):" & totalSS.ToString("C2").PadLeft(17))
            orderReport.WriteLine("Total Seafood Addict (A La Carte):" & totalSA.ToString("C2").PadLeft(10))
            orderReport.WriteLine("--------------------------------------------")
            orderReport.WriteLine("TOTAL INCOME:" & totalIncome.ToString("C2").PadLeft(31))
            orderReport.WriteLine("--------------------------------------------")
            orderReport.Close()
            MsgBox("Report successfully generated", vbInformation)
        Catch ex As Exception
            MsgBox("Report generation unsuccesfull", vbCritical)
        End Try
    End Sub
End Class