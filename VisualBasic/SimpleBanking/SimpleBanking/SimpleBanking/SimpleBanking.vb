Public Class SimpleBanking

    ' Author: Patrick Martin
    ' Class: CISC113 Section N83
    ' Project: SimpleBanking
    'Purpose: Create a form to do basic banking transactions such as:
    '       Lookup Account, Withdraw Money, Deposit Money, Make a Loan Payment
    '       And Purchase a CD
    'Pseudocode:  Use radio buttons to determine the type of transaction. If a radio button is selcted
    '       make the associated controls visible. If another radio button is chosen make the previously visible text boxes and labels not visible.
    '       On btnTransaction click make a message box pop up with a message. 
    '           Messages and associated controls are defined in the assignment which is pasted below:

    '           Lookup account  when selected a text box and label appears and during the check a messagebox states no account.
    '           Width draw: when selected a text box and label appears, an amount is entered and a messagebox stating you do not have a high enough balance for that width draw.
    '           Deposit: when selected a text box and label appears, an amount is entered and a messagebox stating thank you.
    '           Loan payment: when selected a text box and label appears, an amount is entered and a messagebox stating thank you.
    '           Purchase a cd: when selected a text box and label appears, an amount is entered and an other radio buttons

    '               3 months = .25% interest
    '               6  months = .35% interest
    '               12 months = .50% interest
    '               18 months  = .75% interest
    '               24 months = 1.00% interest

    '   when complete a state a cd was purchased for the term, amount and interest rate. State thank you as well in a messagebox.



    '   Make Account controls visible on click
    Private Sub radLookupAccount_Click(sender As Object, e As EventArgs) Handles radLookupAccount.Click
        lblAccount.Visible = True
        txtAccount.Visible = True
    End Sub

    ' Make Account controls invisible when other button is clicked
    Private Sub radLookupAccount_CheckedChanged(sender As Object, e As EventArgs) Handles radLookupAccount.CheckedChanged
        lblAccount.Visible = False
        txtAccount.Visible = False

    End Sub


    ' Make Withdraw controls visible on click
    Private Sub radWithdraw_Click(sender As Object, e As EventArgs) Handles radWithdraw.Click
        lblWithdraw.Visible = True
        txtWithdraw.Visible = True
    End Sub

    ' Make Withdraw controls invisible when other button is clicked
    Private Sub radWithdraw_CheckedChanged(sender As Object, e As EventArgs) Handles radWithdraw.CheckedChanged
        lblWithdraw.Visible = False
        txtWithdraw.Visible = False

    End Sub


    ' Make Deposit controls visible on click
    Private Sub radDeposit_Click(sender As Object, e As EventArgs) Handles radDeposit.Click
        lblDeposit.Visible = True
        txtDeposit.Visible = True
    End Sub

    ' Make Deposit controls invisible when other button is clicked
    Private Sub radDeposit_CheckedChanged(sender As Object, e As EventArgs) Handles radDeposit.CheckedChanged
        lblDeposit.Visible = False
        txtDeposit.Visible = False

    End Sub

    ' Make LoanPayment controls visible on click
    Private Sub radLoanPayment_Click(sender As Object, e As EventArgs) Handles radLoanPayment.Click
        lblLoanPayment.Visible = True
        txtLoanPayment.Visible = True
    End Sub

    ' Make LoanPayment controls invisible when other button is clicked
    Private Sub radLoanPayment_CheckedChanged(sender As Object, e As EventArgs) Handles radLoanPayment.CheckedChanged
        lblLoanPayment.Visible = False
        txtLoanPayment.Visible = False

    End Sub

    ' Make CD controls visible on click
    Private Sub radPurchaseCD_Click(sender As Object, e As EventArgs) Handles radPurchaseCD.Click
        'Move button down so it is not hidden
        btnTransaction.Location = New Point(114, 407)

        lblCD.Visible = True
        txtCD.Visible = True
        grpCDOptions.Visible = True
    End Sub

    ' Make CD controls invisible when other button is clicked
    Private Sub radPurchaseCD_CheckedChanged(sender As Object, e As EventArgs) Handles radPurchaseCD.CheckedChanged
        ' Move button back to original position
        btnTransaction.Location = New Point(114, 285)

        lblCD.Visible = False
        txtCD.Visible = False
        grpCDOptions.Visible = False
    End Sub

    ' Finish Transaction
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        If radLookupAccount.Checked Then
            MessageBox.Show("Not a Valid Account")

        ElseIf radWithdraw.Checked Then
            MessageBox.Show("You Do Not Have a High Enough Balance For That Withdrawal")

        ElseIf radDeposit.Checked Then
            MessageBox.Show("Thank You For Your Patronage. Have a Nice Day!")

        ElseIf radLoanPayment.Checked Then
            MessageBox.Show("Thank You For Your Patronage. Have a Nice Day!")
            ' Purchase CD choice selected
        ElseIf radPurchaseCD.Checked Then
            ' CD Term selected check for numeric input
            If IsNumeric(txtCD.Text) Then
                Dim amount As Double
                amount = CDbl(txtCD.Text)

                If rad3MonthCD.Checked Then
                    MessageBox.Show("You have put " & amount.ToString("C2") & " into a 3 Month CD at 0.25% APY Thank you for your patronage.")

                ElseIf rad6MonthCD.Checked Then
                    MessageBox.Show("You have put " & amount.ToString("C2") & " into a 6 Month CD at 0.35% APY. Thank you for your patronage.")

                ElseIf rad12MonthCD.Checked Then
                    MessageBox.Show("You have put " & amount.ToString("C2") & " into a 12 Month CD at 0.50% APY. Thank you for your patronage.")

                ElseIf rad18MonthCD.Checked Then
                    MessageBox.Show("You have put " & amount.ToString("C2") & " into a 18 Month CD at 0.75% APY. Thank you for your patronage.")

                ElseIf rad24MonthCD.Checked Then
                    MessageBox.Show("You have put " & amount.ToString("C2") & " into a 24 Month CD at 1.00% APY. Thank you for your patronage.")
                End If

            Else
                MessageBox.Show("Please enter a number for the amount")
            End If
        End If

        ' Reset all txtboxes for next transaction
        txtAccount.Text = ""
        txtWithdraw.Text = ""
        txtDeposit.Text = ""
        txtLoanPayment.Text = ""
    End Sub
End Class
