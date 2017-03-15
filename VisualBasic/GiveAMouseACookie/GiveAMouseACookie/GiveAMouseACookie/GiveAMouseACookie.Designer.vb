<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiveAMouseACookie
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.picMouse = New System.Windows.Forms.PictureBox()
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(200, 41)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Listen to the mouse."
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(38, 9)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(450, 13)
        Me.lblIntro.TabIndex = 1
        Me.lblIntro.Text = "A mouse looks like he is in dire need of something. Click the button below to lis" & _
    "ten to his plight."
        '
        'picMouse
        '
        Me.picMouse.Image = Global.GiveAMouseACookie.My.Resources.Resources.beginningMouse
        Me.picMouse.Location = New System.Drawing.Point(12, 70)
        Me.picMouse.Name = "picMouse"
        Me.picMouse.Size = New System.Drawing.Size(500, 375)
        Me.picMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMouse.TabIndex = 2
        Me.picMouse.TabStop = False
        '
        'GiveAMouseACookie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 481)
        Me.Controls.Add(Me.picMouse)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "GiveAMouseACookie"
        Me.Text = "If You Give a Mouse a Cookie..."
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents picMouse As System.Windows.Forms.PictureBox

End Class
