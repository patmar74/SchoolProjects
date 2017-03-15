<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardShuffleArrays
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDealCards = New System.Windows.Forms.Button()
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.txtHandSize = New System.Windows.Forms.TextBox()
        Me.chkOneSuit = New System.Windows.Forms.CheckBox()
        Me.chkJokers = New System.Windows.Forms.CheckBox()
        Me.lblHandSize = New System.Windows.Forms.Label()
        Me.grpPlayerSetting = New System.Windows.Forms.GroupBox()
        Me.rad5Player = New System.Windows.Forms.RadioButton()
        Me.rad4Player = New System.Windows.Forms.RadioButton()
        Me.rad3Player = New System.Windows.Forms.RadioButton()
        Me.rad2Player = New System.Windows.Forms.RadioButton()
        Me.rad1Player = New System.Windows.Forms.RadioButton()
        Me.lstPlayer1Hand = New System.Windows.Forms.ListBox()
        Me.lblPlayer1Hand = New System.Windows.Forms.Label()
        Me.lblPlayer2Hand = New System.Windows.Forms.Label()
        Me.lstPlayer2Hand = New System.Windows.Forms.ListBox()
        Me.lblPlayer3Hand = New System.Windows.Forms.Label()
        Me.lstPlayer3Hand = New System.Windows.Forms.ListBox()
        Me.lblPlayer4Hand = New System.Windows.Forms.Label()
        Me.lstPlayer4Hand = New System.Windows.Forms.ListBox()
        Me.lblPlayer5Hand = New System.Windows.Forms.Label()
        Me.lstPlayer5Hand = New System.Windows.Forms.ListBox()
        Me.lstShuffledDeck = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDeck = New System.Windows.Forms.ListBox()
        Me.grpSettings.SuspendLayout()
        Me.grpPlayerSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDealCards
        '
        Me.btnDealCards.Location = New System.Drawing.Point(353, 543)
        Me.btnDealCards.Name = "btnDealCards"
        Me.btnDealCards.Size = New System.Drawing.Size(75, 23)
        Me.btnDealCards.TabIndex = 1
        Me.btnDealCards.Text = "Deal Cards"
        Me.btnDealCards.UseVisualStyleBackColor = True
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.txtHandSize)
        Me.grpSettings.Controls.Add(Me.chkOneSuit)
        Me.grpSettings.Controls.Add(Me.chkJokers)
        Me.grpSettings.Controls.Add(Me.lblHandSize)
        Me.grpSettings.Controls.Add(Me.grpPlayerSetting)
        Me.grpSettings.Location = New System.Drawing.Point(231, 422)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(329, 109)
        Me.grpSettings.TabIndex = 3
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Enter the Preferred Settings"
        '
        'txtHandSize
        '
        Me.txtHandSize.Location = New System.Drawing.Point(187, 17)
        Me.txtHandSize.Name = "txtHandSize"
        Me.txtHandSize.Size = New System.Drawing.Size(30, 20)
        Me.txtHandSize.TabIndex = 4
        '
        'chkOneSuit
        '
        Me.chkOneSuit.AutoSize = True
        Me.chkOneSuit.Location = New System.Drawing.Point(170, 43)
        Me.chkOneSuit.Name = "chkOneSuit"
        Me.chkOneSuit.Size = New System.Drawing.Size(139, 17)
        Me.chkOneSuit.TabIndex = 2
        Me.chkOneSuit.Text = "Play With Only One Suit"
        Me.chkOneSuit.UseVisualStyleBackColor = True
        '
        'chkJokers
        '
        Me.chkJokers.AutoSize = True
        Me.chkJokers.Location = New System.Drawing.Point(19, 43)
        Me.chkJokers.Name = "chkJokers"
        Me.chkJokers.Size = New System.Drawing.Size(102, 17)
        Me.chkJokers.TabIndex = 1
        Me.chkJokers.Text = "Play with Jokers"
        Me.chkJokers.UseVisualStyleBackColor = True
        '
        'lblHandSize
        '
        Me.lblHandSize.AutoSize = True
        Me.lblHandSize.Location = New System.Drawing.Point(14, 20)
        Me.lblHandSize.Name = "lblHandSize"
        Me.lblHandSize.Size = New System.Drawing.Size(167, 13)
        Me.lblHandSize.TabIndex = 3
        Me.lblHandSize.Text = "Enter Number of Cards for a Hand"
        '
        'grpPlayerSetting
        '
        Me.grpPlayerSetting.Controls.Add(Me.rad5Player)
        Me.grpPlayerSetting.Controls.Add(Me.rad4Player)
        Me.grpPlayerSetting.Controls.Add(Me.rad3Player)
        Me.grpPlayerSetting.Controls.Add(Me.rad2Player)
        Me.grpPlayerSetting.Controls.Add(Me.rad1Player)
        Me.grpPlayerSetting.Location = New System.Drawing.Point(0, 62)
        Me.grpPlayerSetting.Name = "grpPlayerSetting"
        Me.grpPlayerSetting.Size = New System.Drawing.Size(329, 46)
        Me.grpPlayerSetting.TabIndex = 0
        Me.grpPlayerSetting.TabStop = False
        Me.grpPlayerSetting.Text = "Select Number of Players"
        '
        'rad5Player
        '
        Me.rad5Player.AutoSize = True
        Me.rad5Player.Location = New System.Drawing.Point(289, 19)
        Me.rad5Player.Name = "rad5Player"
        Me.rad5Player.Size = New System.Drawing.Size(31, 17)
        Me.rad5Player.TabIndex = 5
        Me.rad5Player.Text = "5"
        Me.rad5Player.UseVisualStyleBackColor = True
        '
        'rad4Player
        '
        Me.rad4Player.AutoSize = True
        Me.rad4Player.Location = New System.Drawing.Point(221, 19)
        Me.rad4Player.Name = "rad4Player"
        Me.rad4Player.Size = New System.Drawing.Size(31, 17)
        Me.rad4Player.TabIndex = 4
        Me.rad4Player.Text = "4"
        Me.rad4Player.UseVisualStyleBackColor = True
        '
        'rad3Player
        '
        Me.rad3Player.AutoSize = True
        Me.rad3Player.Location = New System.Drawing.Point(153, 19)
        Me.rad3Player.Name = "rad3Player"
        Me.rad3Player.Size = New System.Drawing.Size(31, 17)
        Me.rad3Player.TabIndex = 2
        Me.rad3Player.Text = "3"
        Me.rad3Player.UseVisualStyleBackColor = True
        '
        'rad2Player
        '
        Me.rad2Player.AutoSize = True
        Me.rad2Player.Location = New System.Drawing.Point(85, 19)
        Me.rad2Player.Name = "rad2Player"
        Me.rad2Player.Size = New System.Drawing.Size(31, 17)
        Me.rad2Player.TabIndex = 1
        Me.rad2Player.Text = "2"
        Me.rad2Player.UseVisualStyleBackColor = True
        '
        'rad1Player
        '
        Me.rad1Player.AutoSize = True
        Me.rad1Player.Checked = True
        Me.rad1Player.Location = New System.Drawing.Point(17, 19)
        Me.rad1Player.Name = "rad1Player"
        Me.rad1Player.Size = New System.Drawing.Size(31, 17)
        Me.rad1Player.TabIndex = 0
        Me.rad1Player.Text = "1"
        Me.rad1Player.UseVisualStyleBackColor = True
        '
        'lstPlayer1Hand
        '
        Me.lstPlayer1Hand.FormattingEnabled = True
        Me.lstPlayer1Hand.Location = New System.Drawing.Point(227, 84)
        Me.lstPlayer1Hand.Name = "lstPlayer1Hand"
        Me.lstPlayer1Hand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer1Hand.TabIndex = 4
        '
        'lblPlayer1Hand
        '
        Me.lblPlayer1Hand.AutoSize = True
        Me.lblPlayer1Hand.Location = New System.Drawing.Point(224, 65)
        Me.lblPlayer1Hand.Name = "lblPlayer1Hand"
        Me.lblPlayer1Hand.Size = New System.Drawing.Size(59, 13)
        Me.lblPlayer1Hand.TabIndex = 5
        Me.lblPlayer1Hand.Text = "Player One"
        '
        'lblPlayer2Hand
        '
        Me.lblPlayer2Hand.AutoSize = True
        Me.lblPlayer2Hand.Location = New System.Drawing.Point(227, 242)
        Me.lblPlayer2Hand.Name = "lblPlayer2Hand"
        Me.lblPlayer2Hand.Size = New System.Drawing.Size(60, 13)
        Me.lblPlayer2Hand.TabIndex = 7
        Me.lblPlayer2Hand.Text = "Player Two"
        '
        'lstPlayer2Hand
        '
        Me.lstPlayer2Hand.FormattingEnabled = True
        Me.lstPlayer2Hand.Location = New System.Drawing.Point(227, 261)
        Me.lstPlayer2Hand.Name = "lstPlayer2Hand"
        Me.lstPlayer2Hand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer2Hand.TabIndex = 6
        '
        'lblPlayer3Hand
        '
        Me.lblPlayer3Hand.AutoSize = True
        Me.lblPlayer3Hand.Location = New System.Drawing.Point(440, 35)
        Me.lblPlayer3Hand.Name = "lblPlayer3Hand"
        Me.lblPlayer3Hand.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayer3Hand.TabIndex = 9
        Me.lblPlayer3Hand.Text = "Player Three"
        '
        'lstPlayer3Hand
        '
        Me.lstPlayer3Hand.FormattingEnabled = True
        Me.lstPlayer3Hand.Location = New System.Drawing.Point(440, 54)
        Me.lstPlayer3Hand.Name = "lstPlayer3Hand"
        Me.lstPlayer3Hand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer3Hand.TabIndex = 8
        '
        'lblPlayer4Hand
        '
        Me.lblPlayer4Hand.AutoSize = True
        Me.lblPlayer4Hand.Location = New System.Drawing.Point(443, 166)
        Me.lblPlayer4Hand.Name = "lblPlayer4Hand"
        Me.lblPlayer4Hand.Size = New System.Drawing.Size(60, 13)
        Me.lblPlayer4Hand.TabIndex = 11
        Me.lblPlayer4Hand.Text = "Player Four"
        '
        'lstPlayer4Hand
        '
        Me.lstPlayer4Hand.FormattingEnabled = True
        Me.lstPlayer4Hand.Location = New System.Drawing.Point(443, 185)
        Me.lstPlayer4Hand.Name = "lstPlayer4Hand"
        Me.lstPlayer4Hand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer4Hand.TabIndex = 10
        '
        'lblPlayer5Hand
        '
        Me.lblPlayer5Hand.AutoSize = True
        Me.lblPlayer5Hand.Location = New System.Drawing.Point(443, 302)
        Me.lblPlayer5Hand.Name = "lblPlayer5Hand"
        Me.lblPlayer5Hand.Size = New System.Drawing.Size(59, 13)
        Me.lblPlayer5Hand.TabIndex = 13
        Me.lblPlayer5Hand.Text = "Player Five"
        '
        'lstPlayer5Hand
        '
        Me.lstPlayer5Hand.FormattingEnabled = True
        Me.lstPlayer5Hand.Location = New System.Drawing.Point(443, 321)
        Me.lstPlayer5Hand.Name = "lstPlayer5Hand"
        Me.lstPlayer5Hand.Size = New System.Drawing.Size(120, 95)
        Me.lstPlayer5Hand.TabIndex = 12
        '
        'lstShuffledDeck
        '
        Me.lstShuffledDeck.FormattingEnabled = True
        Me.lstShuffledDeck.Location = New System.Drawing.Point(611, 54)
        Me.lstShuffledDeck.Name = "lstShuffledDeck"
        Me.lstShuffledDeck.Size = New System.Drawing.Size(120, 394)
        Me.lstShuffledDeck.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Deck"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(631, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Shuffled Deck"
        '
        'lstDeck
        '
        Me.lstDeck.FormattingEnabled = True
        Me.lstDeck.Location = New System.Drawing.Point(76, 54)
        Me.lstDeck.Name = "lstDeck"
        Me.lstDeck.Size = New System.Drawing.Size(120, 394)
        Me.lstDeck.TabIndex = 0
        '
        'CardShuffleArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 585)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstShuffledDeck)
        Me.Controls.Add(Me.lblPlayer5Hand)
        Me.Controls.Add(Me.lstPlayer5Hand)
        Me.Controls.Add(Me.lblPlayer4Hand)
        Me.Controls.Add(Me.lstPlayer4Hand)
        Me.Controls.Add(Me.lblPlayer3Hand)
        Me.Controls.Add(Me.lstPlayer3Hand)
        Me.Controls.Add(Me.lblPlayer2Hand)
        Me.Controls.Add(Me.lstPlayer2Hand)
        Me.Controls.Add(Me.lblPlayer1Hand)
        Me.Controls.Add(Me.lstPlayer1Hand)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.btnDealCards)
        Me.Controls.Add(Me.lstDeck)
        Me.Name = "CardShuffleArrays"
        Me.Text = "Shuffle Your Cards"
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.grpPlayerSetting.ResumeLayout(False)
        Me.grpPlayerSetting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDealCards As System.Windows.Forms.Button
    Friend WithEvents grpSettings As System.Windows.Forms.GroupBox
    Friend WithEvents grpPlayerSetting As System.Windows.Forms.GroupBox
    Friend WithEvents chkOneSuit As System.Windows.Forms.CheckBox
    Friend WithEvents chkJokers As System.Windows.Forms.CheckBox
    Friend WithEvents rad5Player As System.Windows.Forms.RadioButton
    Friend WithEvents rad4Player As System.Windows.Forms.RadioButton
    Friend WithEvents rad3Player As System.Windows.Forms.RadioButton
    Friend WithEvents rad2Player As System.Windows.Forms.RadioButton
    Friend WithEvents rad1Player As System.Windows.Forms.RadioButton
    Friend WithEvents lblHandSize As System.Windows.Forms.Label
    Friend WithEvents txtHandSize As System.Windows.Forms.TextBox
    Friend WithEvents lstPlayer1Hand As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayer1Hand As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Hand As System.Windows.Forms.Label
    Friend WithEvents lstPlayer2Hand As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayer3Hand As System.Windows.Forms.Label
    Friend WithEvents lstPlayer3Hand As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayer4Hand As System.Windows.Forms.Label
    Friend WithEvents lstPlayer4Hand As System.Windows.Forms.ListBox
    Friend WithEvents lblPlayer5Hand As System.Windows.Forms.Label
    Friend WithEvents lstPlayer5Hand As System.Windows.Forms.ListBox
    Friend WithEvents lstShuffledDeck As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstDeck As System.Windows.Forms.ListBox

End Class
