Public Class PennsylvaniaPaintCompany

    ' Project: Pennsylvania Paint Company
    ' Author: Patrick Martin
    ' CISC113 Section N83
    ' Purpose: The user will input Room Dimensions, Window Dimensions, & Door Dimensions. Using that information output the surface areas for each wall,
    ' window, and door, and then output the total amount of paint to be used if the room was painted with two coats of paint.
    ' Pseudocode: When a button is clicked: Calculate each wall's surface area using the formula Length*Width and post each value to the appropriate text box.
    '             Do the same for the ceiling. Sum all wall surface areas and the ceiling surface area and post that value to txtTotalWallSA.
    '             Take the input Window dimensions, calculate surface area of each window and post the value to the appropriate txtWinSA textbox. Sum all Window surface areas and post value to txtTotalWinSA.
    '             Take the input Door dimensions, calculate surface area of each door and post the value to the appropriate txtDoorSA textbox. Sum all Door surface areas and post value to txtTotalDoorSA.
    '             Take the value of txtTotalWallSA - value of txtTotalWindowSA - value of txtTotalDoorSA, store result in Double totalPaintableArea.
    '             Do totalPaintableArea*2/350 and post value into txtPaint.
    
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtWall1SA.Text = CDbl(txtRoomHeight.Text) * CDbl(txtRoomLength.Text)
        txtWall2SA.Text = CDbl(txtRoomHeight.Text) * CDbl(txtRoomLength.Text)
        txtWall3SA.Text = CDbl(txtRoomHeight.Text) * CDbl(txtRoomWidth.Text)
        txtWall4SA.Text = CDbl(txtRoomHeight.Text) * CDbl(txtRoomWidth.Text)
        txtCeilingSA.Text = CDbl(txtRoomLength.Text) * CDbl(txtRoomWidth.Text)
        txtTotalWallSA.Text = CDbl(txtWall1SA.Text) + CDbl(txtWall2SA.Text) + CDbl(txtWall3SA.Text) _
            + CDbl(txtWall4SA.Text) + CDbl(txtWall4SA.Text)

        txtWin1SA.Text = CDbl(txtWin1Length.Text) * CDbl(txtWin1Width.Text)
        txtWin2SA.Text = CDbl(txtWin2Length.Text) * CDbl(txtWin2Width.Text)
        txtWin3SA.Text = CDbl(txtWin3Length.Text) * CDbl(txtWin3Width.Text)
        txtWin4SA.Text = CDbl(txtWin4Length.Text) * CDbl(txtWin4Width.Text)
        txtWin5SA.Text = CDbl(txtWin5Length.Text) * CDbl(txtWin5Width.Text)
        txtWin6SA.Text = CDbl(txtWin6Length.Text) * CDbl(txtWin6Width.Text)
        txtWin7SA.Text = CDbl(txtWin7Length.Text) * CDbl(txtWin7Width.Text)
        txtWin8SA.Text = CDbl(txtWin8Length.Text) * CDbl(txtWin8Width.Text)
        txtTotalWinSA.Text = CDbl(txtWin1SA.Text) + CDbl(txtWin2SA.Text) + CDbl(txtWin3SA.Text) _
            + CDbl(txtWin4SA.Text) + CDbl(txtWin5SA.Text) + CDbl(txtWin6SA.Text) _
            + CDbl(txtWin7SA.Text) + CDbl(txtWin8SA.Text)

        txtDoor1SA.Text = CDbl(txtDoor1Length.Text) * CDbl(txtDoor1Width.Text)
        txtDoor2SA.Text = CDbl(txtDoor2Length.Text) * CDbl(txtDoor2Width.Text)
        txtDoor3SA.Text = CDbl(txtDoor3Length.Text) * CDbl(txtDoor3Width.Text)
        txtDoor4SA.Text = CDbl(txtDoor4Length.Text) * CDbl(txtDoor4Width.Text)
        txtTotalDoorSA.Text = CDbl(txtDoor1SA.Text) + CDbl(txtDoor2SA.Text) _
            + CDbl(txtDoor3SA.Text) + CDbl(txtDoor4SA.Text)

        Dim totalPaintableArea As Double
        totalPaintableArea = CDbl(txtTotalWallSA.Text) - CDbl(txtTotalDoorSA.Text) _
            - CDbl(txtTotalWinSA.Text)

        txtPaint.Text = (totalPaintableArea * 2 / 350).ToString("N1")

    End Sub
End Class
