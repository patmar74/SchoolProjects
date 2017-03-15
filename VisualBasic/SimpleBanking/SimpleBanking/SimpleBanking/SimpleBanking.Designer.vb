<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleBanking
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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.txtCD = New System.Windows.Forms.TextBox()
        Me.radPurchaseCD = New System.Windows.Forms.RadioButton()
        Me.lblCD = New System.Windows.Forms.Label()
        Me.radLoanPayment = New System.Windows.Forms.RadioButton()
        Me.txtLoanPayment = New System.Windows.Forms.TextBox()
        Me.radDeposit = New System.Windows.Forms.RadioButton()
        Me.lblLoanPayment = New System.Windows.Forms.Label()
        Me.radWithdraw = New System.Windows.Forms.RadioButton()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.radLookupAccount = New System.Windows.Forms.RadioButton()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.lblWithdraw = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.grpCDOptions = New System.Windows.Forms.GroupBox()
        Me.rad24MonthCD = New System.Windows.Forms.RadioButton()
        Me.rad18MonthCD = New System.Windows.Forms.RadioButton()
        Me.rad12MonthCD = New System.Windows.Forms.RadioButton()
        Me.rad6MonthCD = New System.Windows.Forms.RadioButton()
        Me.rad3MonthCD = New System.Windows.Forms.RadioButton()
        Me.grpOptions.SuspendLayout()
        Me.grpCDOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.txtCD)
        Me.grpOptions.Controls.Add(Me.radPurchaseCD)
        Me.grpOptions.Controls.Add(Me.lblCD)
        Me.grpOptions.Controls.Add(Me.radLoanPayment)
        Me.grpOptions.Controls.Add(Me.txtLoanPayment)
        Me.grpOptions.Controls.Add(Me.radDeposit)
        Me.grpOptions.Controls.Add(Me.lblLoanPayment)
        Me.grpOptions.Controls.Add(Me.radWithdraw)
        Me.grpOptions.Controls.Add(Me.txtDeposit)
        Me.grpOptions.Controls.Add(Me.radLookupAccount)
        Me.grpOptions.Controls.Add(Me.lblDeposit)
        Me.grpOptions.Controls.Add(Me.lblAccount)
        Me.grpOptions.Controls.Add(Me.txtWithdraw)
        Me.grpOptions.Controls.Add(Me.lblWithdraw)
        Me.grpOptions.Controls.Add(Me.txtAccount)
        Me.grpOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(440, 272)
        Me.grpOptions.TabIndex = 0
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select an Action"
        '
        'txtCD
        '
        Me.txtCD.Location = New System.Drawing.Point(231, 242)
        Me.txtCD.Name = "txtCD"
        Me.txtCD.Size = New System.Drawing.Size(188, 20)
        Me.txtCD.TabIndex = 14
        Me.txtCD.Visible = False
        '
        'radPurchaseCD
        '
        Me.radPurchaseCD.AutoSize = True
        Me.radPurchaseCD.Location = New System.Drawing.Point(18, 225)
        Me.radPurchaseCD.Name = "radPurchaseCD"
        Me.radPurchaseCD.Size = New System.Drawing.Size(97, 17)
        Me.radPurchaseCD.TabIndex = 12
        Me.radPurchaseCD.Text = "Purchase a CD"
        Me.radPurchaseCD.UseVisualStyleBackColor = True
        '
        'lblCD
        '
        Me.lblCD.AutoSize = True
        Me.lblCD.Location = New System.Drawing.Point(59, 245)
        Me.lblCD.Name = "lblCD"
        Me.lblCD.Size = New System.Drawing.Size(156, 13)
        Me.lblCD.TabIndex = 13
        Me.lblCD.Text = "Enter Amount to be Put Into CD"
        Me.lblCD.Visible = False
        '
        'radLoanPayment
        '
        Me.radLoanPayment.AutoSize = True
        Me.radLoanPayment.Location = New System.Drawing.Point(18, 176)
        Me.radLoanPayment.Name = "radLoanPayment"
        Me.radLoanPayment.Size = New System.Drawing.Size(156, 17)
        Me.radLoanPayment.TabIndex = 9
        Me.radLoanPayment.Text = "Make a Payment on a Loan"
        Me.radLoanPayment.UseVisualStyleBackColor = True
        '
        'txtLoanPayment
        '
        Me.txtLoanPayment.Location = New System.Drawing.Point(231, 193)
        Me.txtLoanPayment.Name = "txtLoanPayment"
        Me.txtLoanPayment.Size = New System.Drawing.Size(188, 20)
        Me.txtLoanPayment.TabIndex = 11
        Me.txtLoanPayment.Visible = False
        '
        'radDeposit
        '
        Me.radDeposit.AutoSize = True
        Me.radDeposit.Location = New System.Drawing.Point(18, 127)
        Me.radDeposit.Name = "radDeposit"
        Me.radDeposit.Size = New System.Drawing.Size(139, 17)
        Me.radDeposit.TabIndex = 6
        Me.radDeposit.Text = "Deposit Checks or Cash"
        Me.radDeposit.UseVisualStyleBackColor = True
        '
        'lblLoanPayment
        '
        Me.lblLoanPayment.AutoSize = True
        Me.lblLoanPayment.Location = New System.Drawing.Point(59, 196)
        Me.lblLoanPayment.Name = "lblLoanPayment"
        Me.lblLoanPayment.Size = New System.Drawing.Size(142, 13)
        Me.lblLoanPayment.TabIndex = 10
        Me.lblLoanPayment.Text = "Enter Loan Payment Amount"
        Me.lblLoanPayment.Visible = False
        '
        'radWithdraw
        '
        Me.radWithdraw.AutoSize = True
        Me.radWithdraw.Location = New System.Drawing.Point(18, 78)
        Me.radWithdraw.Name = "radWithdraw"
        Me.radWithdraw.Size = New System.Drawing.Size(105, 17)
        Me.radWithdraw.TabIndex = 3
        Me.radWithdraw.Text = "Withdraw Money"
        Me.radWithdraw.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(231, 144)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(188, 20)
        Me.txtDeposit.TabIndex = 8
        Me.txtDeposit.Visible = False
        '
        'radLookupAccount
        '
        Me.radLookupAccount.AutoSize = True
        Me.radLookupAccount.Location = New System.Drawing.Point(18, 29)
        Me.radLookupAccount.Name = "radLookupAccount"
        Me.radLookupAccount.Size = New System.Drawing.Size(104, 17)
        Me.radLookupAccount.TabIndex = 0
        Me.radLookupAccount.Text = "Lookup Account"
        Me.radLookupAccount.UseVisualStyleBackColor = True
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(59, 147)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(149, 13)
        Me.lblDeposit.TabIndex = 7
        Me.lblDeposit.Text = "Enter Amount to be Deposited"
        Me.lblDeposit.Visible = False
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(59, 49)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(115, 13)
        Me.lblAccount.TabIndex = 1
        Me.lblAccount.Text = "Enter Account Number"
        Me.lblAccount.Visible = False
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(231, 95)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(188, 20)
        Me.txtWithdraw.TabIndex = 5
        Me.txtWithdraw.Visible = False
        '
        'lblWithdraw
        '
        Me.lblWithdraw.AutoSize = True
        Me.lblWithdraw.Location = New System.Drawing.Point(59, 98)
        Me.lblWithdraw.Name = "lblWithdraw"
        Me.lblWithdraw.Size = New System.Drawing.Size(152, 13)
        Me.lblWithdraw.TabIndex = 4
        Me.lblWithdraw.Text = "Enter Amount to be Withdrawn"
        Me.lblWithdraw.Visible = False
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(194, 46)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(188, 20)
        Me.txtAccount.TabIndex = 2
        Me.txtAccount.Visible = False
        '
        'btnTransaction
        '
        Me.btnTransaction.Location = New System.Drawing.Point(114, 285)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(174, 23)
        Me.btnTransaction.TabIndex = 2
        Me.btnTransaction.Text = "Process Transaction"
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'grpCDOptions
        '
        Me.grpCDOptions.Controls.Add(Me.rad24MonthCD)
        Me.grpCDOptions.Controls.Add(Me.rad18MonthCD)
        Me.grpCDOptions.Controls.Add(Me.rad12MonthCD)
        Me.grpCDOptions.Controls.Add(Me.rad6MonthCD)
        Me.grpCDOptions.Controls.Add(Me.rad3MonthCD)
        Me.grpCDOptions.Location = New System.Drawing.Point(30, 290)
        Me.grpCDOptions.Name = "grpCDOptions"
        Me.grpCDOptions.Size = New System.Drawing.Size(422, 111)
        Me.grpCDOptions.TabIndex = 1
        Me.grpCDOptions.TabStop = False
        Me.grpCDOptions.Text = "Select a CD"
        Me.grpCDOptions.Visible = False
        '
        'rad24MonthCD
        '
        Me.rad24MonthCD.AutoSize = True
        Me.rad24MonthCD.Location = New System.Drawing.Point(112, 84)
        Me.rad24MonthCD.Name = "rad24MonthCD"
        Me.rad24MonthCD.Size = New System.Drawing.Size(146, 17)
        Me.rad24MonthCD.TabIndex = 4
        Me.rad24MonthCD.TabStop = True
        Me.rad24MonthCD.Text = "24 Months  at 1.00% APY"
        Me.rad24MonthCD.UseVisualStyleBackColor = True
        '
        'rad18MonthCD
        '
        Me.rad18MonthCD.AutoSize = True
        Me.rad18MonthCD.Location = New System.Drawing.Point(227, 52)
        Me.rad18MonthCD.Name = "rad18MonthCD"
        Me.rad18MonthCD.Size = New System.Drawing.Size(149, 17)
        Me.rad18MonthCD.TabIndex = 3
        Me.rad18MonthCD.TabStop = True
        Me.rad18MonthCD.Text = "18 Months  at 0 .75% APY"
        Me.rad18MonthCD.UseVisualStyleBackColor = True
        '
        'rad12MonthCD
        '
        Me.rad12MonthCD.AutoSize = True
        Me.rad12MonthCD.Location = New System.Drawing.Point(31, 52)
        Me.rad12MonthCD.Name = "rad12MonthCD"
        Me.rad12MonthCD.Size = New System.Drawing.Size(149, 17)
        Me.rad12MonthCD.TabIndex = 2
        Me.rad12MonthCD.TabStop = True
        Me.rad12MonthCD.Text = "12 Months  at 0 .50% APY"
        Me.rad12MonthCD.UseVisualStyleBackColor = True
        '
        'rad6MonthCD
        '
        Me.rad6MonthCD.AutoSize = True
        Me.rad6MonthCD.Location = New System.Drawing.Point(227, 19)
        Me.rad6MonthCD.Name = "rad6MonthCD"
        Me.rad6MonthCD.Size = New System.Drawing.Size(137, 17)
        Me.rad6MonthCD.TabIndex = 1
        Me.rad6MonthCD.TabStop = True
        Me.rad6MonthCD.Text = "6 Months at 0.35% APY"
        Me.rad6MonthCD.UseVisualStyleBackColor = True
        '
        'rad3MonthCD
        '
        Me.rad3MonthCD.AutoSize = True
        Me.rad3MonthCD.Location = New System.Drawing.Point(31, 20)
        Me.rad3MonthCD.Name = "rad3MonthCD"
        Me.rad3MonthCD.Size = New System.Drawing.Size(143, 17)
        Me.rad3MonthCD.TabIndex = 0
        Me.rad3MonthCD.TabStop = True
        Me.rad3MonthCD.Text = "3 Months  at 0 .25% APY"
        Me.rad3MonthCD.UseVisualStyleBackColor = True
        '
        'SimpleBanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 547)
        Me.Controls.Add(Me.grpCDOptions)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.grpOptions)
        Me.Name = "SimpleBanking"
        Me.Text = "Simple Banking"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpCDOptions.ResumeLayout(False)
        Me.grpCDOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents radWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents radLookupAccount As System.Windows.Forms.RadioButton
    Friend WithEvents radPurchaseCD As System.Windows.Forms.RadioButton
    Friend WithEvents radLoanPayment As System.Windows.Forms.RadioButton
    Friend WithEvents radDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents lblWithdraw As System.Windows.Forms.Label
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtCD As System.Windows.Forms.TextBox
    Friend WithEvents lblCD As System.Windows.Forms.Label
    Friend WithEvents txtLoanPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblLoanPayment As System.Windows.Forms.Label
    Friend WithEvents grpCDOptions As System.Windows.Forms.GroupBox
    Friend WithEvents rad18MonthCD As System.Windows.Forms.RadioButton
    Friend WithEvents rad12MonthCD As System.Windows.Forms.RadioButton
    Friend WithEvents rad6MonthCD As System.Windows.Forms.RadioButton
    Friend WithEvents rad3MonthCD As System.Windows.Forms.RadioButton
    Friend WithEvents rad24MonthCD As System.Windows.Forms.RadioButton

End Class
