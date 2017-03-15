' Project: Hello World
' Author: Patrick Martin
' Date: 1/27/2016
' Description: take input from a textbox and post to a label
' Pseudocode: take the value input from textbox textFullName and display the value in the 
'             label lblFullName when the button btFullName is clicked.


Public Class HelloWorld
    ' btnFullName will take input and post to label as output

    Private Sub btnFullName_Click(sender As Object, e As EventArgs) Handles btnFullName.Click
        lblFullName.Text = txtFullName.Text

    End Sub
End Class
