Public Class formMenu
    Public sMenu As String
    Public sMenuName As String
    Dim title() As String = {"Egg-dition", "Chicken Lover", "Beef Maniac", "Seafood Addict"}
    Dim sideDish() As String = {"Boiled Egg", "Sunny Side Up Egg", "Scrambled Egg", "Crispy Fried Chicken", "Spiced Fried Chicken", "Smoked Beef", "Beef Rendang", "Fried Octopus", "Fried Prawn"}
    Public menuName() As String = {"Egg-dition (Set)", "Egg-dition (A la carte)", "Chicken Lover (Set)", "Chicken Lover (A la Carte)", "Beef Maniac (Set)", "Beef Maniac (A la Carte)", "Seafood Addict (Set)", "Seafood Addict (A la Carte)"}
    Public menuPrice() As Double = {7.9, 5.5, 13.9, 10.6, 14, 11.5, 15.6, 13.9}
    Private Sub btnAddE_Click(sender As Object, e As EventArgs) Handles btnAddE.Click
        If radSetE.Checked = False And radAlaE.Checked = False Then
            'Input validation
            MsgBox("Please choose Set or A La Carte", vbExclamation)
        Else
            'Initialize formOption with "Egg-dition" menu
            sMenu = "E"
            formOption.picOption.Image = My.Resources.egg
            formOption.lblTitle.Text = title(0)
            formOption.cmbSideDish.Items.Add(sideDish(0))
            formOption.cmbSideDish.Items.Add(sideDish(1))
            formOption.cmbSideDish.Items.Add(sideDish(2))
            If radSetE.Checked Then
                sMenuName = menuName(0)
                formOption.lblDescription.Text = "Coconut infused rice, served with variety types of egg and served with either aromatic and hot sambal; completing the meals with classic beverages."
                Me.Hide()
                formOption.gbBeverage.Show()
                formOption.Show()
            ElseIf radAlaE.Checked Then
                sMenuName = menuName(1)
                formOption.lblDescription.Text = "Coconut infused rice, served with variety types of egg and served with either aromatic and hot sambal."
                formOption.Show()
                formOption.gbBeverage.Hide()
            Else
                MsgBox("Please choose Set or A La Carte", vbExclamation)
            End If
        End If
    End Sub
    Private Sub btnAddC_Click(sender As Object, e As EventArgs) Handles btnAddC.Click
        If radSetC.Checked = False And radAlaC.Checked = False Then
            'Input validation
            MsgBox("Please choose Set or A La Carte", vbExclamation)
        Else
            'Initialize formOption with "Chicken Lover" menu
            sMenu = "C"
            formOption.picOption.Image = My.Resources.chicken
            formOption.lblTitle.Text = title(1)
            formOption.cmbSideDish.Items.Add(sideDish(3))
            formOption.cmbSideDish.Items.Add(sideDish(4))
            If radSetC.Checked Then
                sMenuName = menuName(2)
                formOption.lblDescription.Text = "Coconut infused rice, served with perfectly marinated with blended spices chicken, can be either deep fried or coated with savoury crispy flour and served with either aromatic and hot sambal; completing the meals with classic beverages."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Show()
            ElseIf radAlaC.Checked Then
                sMenuName = menuName(3)
                formOption.lblDescription.Text = "Coconut infused rice, served with perfectly marinated with blended spices chicken, can be either deep fried or coated with savoury crispy flour and served with either aromatic and hot sambal."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Hide()
            End If
        End If
    End Sub
    Private Sub btnAddB_Click(sender As Object, e As EventArgs) Handles btnAddB.Click
        If radSetB.Checked = False And radAlaB.Checked = False Then
            'Input validation
            MsgBox("Please choose Set or A La Carte", vbExclamation)
        Else
            'Initialize formOption with "Beef Maniac" menu
            sMenu = "B"
            formOption.picOption.Image = My.Resources.beef
            formOption.lblTitle.Text = title(2)
            formOption.cmbSideDish.Items.Add(sideDish(5))
            formOption.cmbSideDish.Items.Add(sideDish(6))
            If radSetB.Checked Then
                sMenuName = menuName(4)
                formOption.lblDescription.Text = "Coconut infused rice, served served with braised beef brisket slow cooked in rendang spice and hot sambal; completing the meals with classic beverages."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Show()
            ElseIf radAlaB.Checked Then
                sMenuName = menuName(5)
                formOption.lblDescription.Text = "Coconut infused rice, served served with braised beef brisket slow cooked in rendang spice and hot sambal."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Hide()
            Else
                MsgBox("Please choose Set or A La Carte", vbExclamation)
            End If
        End If
    End Sub
    Private Sub btnAddS_Click(sender As Object, e As EventArgs) Handles btnAddS.Click
        If radSetS.Checked = False And radAlaS.Checked = False Then
            'Input validation
            MsgBox("Please choose Set or A La Carte", vbExclamation)
        Else
            'Initialize formOption with "Seafood Addict" menu
            sMenu = "S"
            formOption.picOption.Image = My.Resources.seafood
            formOption.lblTitle.Text = title(3)
            formOption.cmbSideDish.Items.Add(sideDish(7))
            formOption.cmbSideDish.Items.Add(sideDish(8))
            If radSetS.Checked Then
                sMenuName = menuName(6)
                formOption.lblDescription.Text = "Coconut infused rice, served with variety choices of seafoods that is perfectly marinated and served with either aromatic and hot sambal; completing the meals with classic beverages."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Show()
            ElseIf radAlaS.Checked Then
                sMenuName = menuName(7)
                formOption.lblDescription.Text = "Coconut infused rice, served with variety choices of seafoods that is perfectly marinated and served with either aromatic and hot sambal."
                Me.Hide()
                formOption.Show()
                formOption.gbBeverage.Hide()
            End If
        End If
    End Sub
    Private Sub tsmPreview_Click(sender As Object, e As EventArgs) Handles tsmPreview.Click
        'Preview order
        formOption.prPreview.ShowDialog()
    End Sub
    Private Sub tsmCart_Click(sender As Object, e As EventArgs) Handles tsmCart.Click
        'Show formSummary
        Me.Hide()
        formSummary.Show()
    End Sub

End Class