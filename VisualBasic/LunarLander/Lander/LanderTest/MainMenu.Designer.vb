<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnServer = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnServer
        '
        Me.btnServer.Location = New System.Drawing.Point(98, 59)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(75, 23)
        Me.btnServer.TabIndex = 0
        Me.btnServer.Text = "Server"
        Me.btnServer.UseVisualStyleBackColor = True
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(98, 120)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(75, 23)
        Me.btnClient.TabIndex = 1
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.btnServer)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnServer As System.Windows.Forms.Button
    Friend WithEvents btnClient As System.Windows.Forms.Button
End Class
