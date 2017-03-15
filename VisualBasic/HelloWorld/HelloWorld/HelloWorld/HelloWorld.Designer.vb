<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
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
        Me.lblFullNameInput = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnFullName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFullNameInput
        '
        Me.lblFullNameInput.AutoSize = True
        Me.lblFullNameInput.Location = New System.Drawing.Point(13, 67)
        Me.lblFullNameInput.Name = "lblFullNameInput"
        Me.lblFullNameInput.Size = New System.Drawing.Size(71, 17)
        Me.lblFullNameInput.TabIndex = 0
        Me.lblFullNameInput.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(90, 62)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 22)
        Me.txtFullName.TabIndex = 1
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(90, 107)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(104, 17)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "____________"
        '
        'btnFullName
        '
        Me.btnFullName.Location = New System.Drawing.Point(9, 107)
        Me.btnFullName.Name = "btnFullName"
        Me.btnFullName.Size = New System.Drawing.Size(75, 23)
        Me.btnFullName.TabIndex = 3
        Me.btnFullName.Text = "Press"
        Me.btnFullName.UseVisualStyleBackColor = True
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 243)
        Me.Controls.Add(Me.btnFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblFullNameInput)
        Me.Name = "HelloWorld"
        Me.Text = "First Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFullNameInput As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents btnFullName As System.Windows.Forms.Button

End Class
