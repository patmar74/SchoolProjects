Public Class DoYouHaveAChance

    ' Project: Do You Have a Chance
    ' Author: Patrick Martin
    ' Class: CISC113 N83
    ' Date: 3/1/16

    'Purpose: Determine if the user has a chance with the girl he has been eyeing.
    'Pseudocode: Upon clicking button btnCalculate: Convert the value of each textbox to either a double or int and assign them
    '           to a variable of what that value represents. Break the equation up into manageable pieces by having temporary variables
    '           such as firstImpression, salaryComparison, yourComparison and, effectOfFamiliarity. Plug these variables into the given equation
    '           and assign the value to variable chance. 
    '           If chance is less than zero, set lblAnswer.Text to "You have no chance. It is our professional opinion that you should lower your standards."
    '           ElseIF chance between zero and one, set lblAnswer.Text to "You have exactly a snowball's chance. Best of luck to you!"
    '           ElseIf chance between one and ten, set lblAnswer.Text to "Game on! Go get her!"
    '           Else set lblAnswer.Text to ""Our numbers tell us that you're too good for her. You should go for her cute friend instead."
    '           Make the lblAnswer visible.

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim attractiveYou, attractiveHer, relationshipStatus As Integer
        Dim convoSkill, schoolYou, schoolHer, aggressive As Integer
        Dim commonalities, differences As Integer
        Dim salaryHer, salaryYou As Double
        Dim familiarity As Integer
        Dim chance As Double
        ' Make all textbox values into variables
        attractiveYou = CInt(txtAttractiveYou.Text)
        attractiveHer = CInt(txtAttractiveHer.Text)
        relationshipStatus = CInt(txtRelationStatus.Text)
        convoSkill = CInt(txtConvoSkill.Text)
        schoolYou = CInt(txtSchoolYou.Text)
        schoolHer = CInt(txtSchoolHer.Text)
        aggressive = CInt(txtAggressive.Text)
        commonalities = CInt(txtCommonalities.Text)
        differences = CInt(txtDifferences.Text)
        salaryHer = CDbl(txtSalaryHer.Text)
        salaryYou = CDbl(txtSalaryYou.Text)
        familiarity = CInt(txtFamiliarity.Text)

        'Equation Part 1 set as firstImpression
        Dim firstImpression As Double

        firstImpression = (convoSkill * aggressive * attractiveYou ^ 2) _
                            / attractiveHer ^ 3
        'Equation Part 2 section 1 set as yourComparison
        Dim yourComparison As Double
        Dim salaryComparison As Double

        salaryComparison = (salaryYou - salaryHer) / 100

        yourComparison = commonalities - differences + salaryComparison + schoolYou - schoolHer

        'Equation Part 2 Section 2 set as effectOfFamiliarity
        Dim effectOfFamiliarity As Double

        effectOfFamiliarity = yourComparison / familiarity

        'Put the equation together and get the answer
        chance = firstImpression + effectOfFamiliarity - relationshipStatus

        'Change lblAnswer base on value of chance
        If chance < 0 Then
            lblAnswer.Text = "You have no chance. It is our professional opinion that you should lower your standards."
        ElseIf chance >= 0 And chance < 1 Then
            lblAnswer.Text = "You have exactly a snowball's chance. Best of luck to you!"
        ElseIf chance >= 1 And chance <= 10 Then
            lblAnswer.Text = "Game on! Go get her!"
        Else
            lblAnswer.Text = "Our numbers tell us that you're too good for her. You should go for her cute friend instead."
        End If
        lblAnswer.Visible = True

    End Sub
End Class
