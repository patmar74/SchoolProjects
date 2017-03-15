Public Class GiveAMouseACookie

    ' Project: If You Give a Mouse a Cookie...
    ' Author: Patrick Martin
    ' Class: CISC 113 Section N83
    ' Date: 3/1/16

    ' Purpose: To continually ask the user if they want to help the mouse. If they say yes show pictures of the mouse and object given.
    '   If they say no then show a picture of a sad mouse, and show the start button and edited dialogue again.
    ' Pseudocode: Upon clicking the start button: make lblIntro, and btnStart not visible. Use inputBox to prompt for user answer. If answer = "Y" or "YES" then ask another question
    '   If answer is something else program takes response as no. If user gives a no answer then display the sadmouse for picMouse,
    '   Set lblIntro.Text = "The mouse is so sad but he understands." and make lblIntro visible again. He hopes that you'll help him" & set the btnStart.Text = "Help the mouse" and make it visible again.
    '   If the user goes all the way to the end of the nested if statements (mouse wants cookie again), then make lblIntro.Text = "Now he wants another cookie..."
    '   Set btnStart.Text = "Give him a cookie" and make btnStart visible again. User will re-enter nested if statements on btnStart_Click.

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        picMouse.Image = My.Resources.beginningMouse
        lblIntro.Visible = False
        Dim answer As String
        ' Cookie?
        answer = InputBox("The mouse seems to really want a cookie. " & "Will you give him a cookie? (Y for yes, N for no)")
        If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
            ' Milk?
            answer = InputBox("Now that he's eating his cookie, he wants a glass of milk. " & "Will you give him some milk? (Y for yes, N for no)")

            If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                ' Straw?
                answer = InputBox("You gave him the milk but he can't drink it without a straw. " & "Will you give him a straw? (Y for yes, N for no)")

                If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                    ' Napkin?
                    answer = InputBox("Now that he's finished his milk, he's asking for a napkin. " & "Will you give him a napkin? (Y for yes, N for no)")

                    If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                        ' Mirror?
                        answer = InputBox("He's wiped himself off but wants to make sure that he doesn't have a milk mustache. " &
                                          "Will you give him a mirror to check himself? (Y for yes, N for no)")

                        If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                            ' Scissors?
                            answer = InputBox("When he looks in the mirror he notices that his hair needs a trim. " &
                                              "Will you give him some scissors to cut his hair? (Y for yes, N for no)")

                            If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                ' Nail Scissors?
                                answer = InputBox("Scissors are too dangerous for a little mouse, give him nail scissors instead? ")

                                If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                    ' Broom?
                                    answer = InputBox("Now that he's finished with his trim, he wants to sweep up his hair. " &
                                                      "Will you give him a broom to sweep up?(Y for yes, N for no)")

                                    If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                        ' Mop?
                                        answer = InputBox("It looks like he's gotten a bit carried away and has sweeped every room of your house. " &
                                                          "Will you give him a mop to see if he'll wash the floors as well? (Y for yes, N for no)")

                                        If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                            ' Prepare box for sleep?
                                            answer = InputBox("Lucky you he took the mop and went straight to work. Now the poor fella is all tuckered out. " &
                                                              "Will you fix up a little box with a pillow and blanket for him to sleep in?  (Y for yes, N for no)")

                                            If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                ' Read BedtimeStory
                                                answer = InputBox("He's taken to the box quite nicely but still can't get to sleep. Will you read him a bedtime story? (Y for yes, N for no)")

                                                If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                    ' Show Pictures?
                                                    answer = InputBox("He's become really excited about the story and wants to see the pictures. " &
                                                                      "Will you show him the pictures? (Y for yes, N for no)")

                                                    If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                        ' Paper and crayons?
                                                        answer = InputBox("Now he's even more excited and wants to draw his own pictures. " &
                                                                          "Will you give him a paper and some crayons? (Y for yes, N for no)")

                                                        If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                            ' Pen to sign?
                                                            answer = InputBox("He's created a wonderful piece of work and wants to sign it. " &
                                                                              "Will you give him a pen to sign his work? (Y for yes, N for no)")

                                                            If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                                ' Scotch Tape?
                                                                answer = InputBox("Now he wants to hang it on your refrigerator. " &
                                                                                  "Do you have scotch tape to give him so he can hang up his picture? (Y for yes, N for no)")

                                                                If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                                    'Milk?
                                                                    answer = InputBox("He stands back and looks at the refrigerator and he remembers that he's thirsty. " &
                                                                                      "Will you give him a glass of milk? (Y for yes, N for no)")

                                                                    If answer.ToUpper = "Y" Or answer.ToUpper = "YES" Then
                                                                        ' Start the "Loop" Again if user pushes button
                                                                        lblIntro.Text = "Now he wants something else again..."
                                                                        lblIntro.Visible = True
                                                                        btnStart.Text = "What does he want?"
                                                                        btnStart.Visible = True

                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        'If answer is no at any time display sadmouse and offer button to help him
        If answer.ToUpper <> "Y" And answer.ToUpper <> "YES" Then
            picMouse.Image = My.Resources.sadMouse
            lblIntro.Text = "The mouse is so sad but he understands. He hopes that you'll help him."
            lblIntro.Visible = True
            btnStart.Text = "Help the mouse."
            btnStart.Visible = True
        End If


    End Sub

    
End Class
