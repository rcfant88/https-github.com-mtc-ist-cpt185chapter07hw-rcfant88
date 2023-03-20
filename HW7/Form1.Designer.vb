<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboJobs = New System.Windows.Forms.ComboBox()
        Me.lblHourlyPay = New System.Windows.Forms.Label()
        Me.lblCurrentPayTitle = New System.Windows.Forms.Label()
        Me.lblCurrentYearlyTitle = New System.Windows.Forms.Label()
        Me.lblAnnualPay = New System.Windows.Forms.Label()
        Me.lblFiveYearProjectionTitle = New System.Windows.Forms.Label()
        Me.lblFiveYearProjectionAnnual = New System.Windows.Forms.Label()
        Me.lblFYPHourly = New System.Windows.Forms.Label()
        Me.lblFYPYearly = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboJobs
        '
        Me.cboJobs.FormattingEnabled = True
        Me.cboJobs.Location = New System.Drawing.Point(300, 143)
        Me.cboJobs.Name = "cboJobs"
        Me.cboJobs.Size = New System.Drawing.Size(370, 24)
        Me.cboJobs.TabIndex = 1
        '
        'lblHourlyPay
        '
        Me.lblHourlyPay.AutoSize = True
        Me.lblHourlyPay.Location = New System.Drawing.Point(486, 261)
        Me.lblHourlyPay.Name = "lblHourlyPay"
        Me.lblHourlyPay.Size = New System.Drawing.Size(100, 17)
        Me.lblHourlyPay.TabIndex = 2
        Me.lblHourlyPay.Text = "Current Hourly"
        '
        'lblCurrentPayTitle
        '
        Me.lblCurrentPayTitle.AutoSize = True
        Me.lblCurrentPayTitle.Location = New System.Drawing.Point(297, 261)
        Me.lblCurrentPayTitle.Name = "lblCurrentPayTitle"
        Me.lblCurrentPayTitle.Size = New System.Drawing.Size(182, 17)
        Me.lblCurrentPayTitle.TabIndex = 3
        Me.lblCurrentPayTitle.Text = "Current Median Hourly Pay:"
        '
        'lblCurrentYearlyTitle
        '
        Me.lblCurrentYearlyTitle.AutoSize = True
        Me.lblCurrentYearlyTitle.Location = New System.Drawing.Point(297, 292)
        Me.lblCurrentYearlyTitle.Name = "lblCurrentYearlyTitle"
        Me.lblCurrentYearlyTitle.Size = New System.Drawing.Size(181, 17)
        Me.lblCurrentYearlyTitle.TabIndex = 4
        Me.lblCurrentYearlyTitle.Text = "Current Median Yearly Pay:"
        '
        'lblAnnualPay
        '
        Me.lblAnnualPay.AutoSize = True
        Me.lblAnnualPay.Location = New System.Drawing.Point(486, 292)
        Me.lblAnnualPay.Name = "lblAnnualPay"
        Me.lblAnnualPay.Size = New System.Drawing.Size(99, 17)
        Me.lblAnnualPay.TabIndex = 5
        Me.lblAnnualPay.Text = "Current Yearly"
        '
        'lblFiveYearProjectionTitle
        '
        Me.lblFiveYearProjectionTitle.AutoSize = True
        Me.lblFiveYearProjectionTitle.Location = New System.Drawing.Point(297, 321)
        Me.lblFiveYearProjectionTitle.Name = "lblFiveYearProjectionTitle"
        Me.lblFiveYearProjectionTitle.Size = New System.Drawing.Size(184, 17)
        Me.lblFiveYearProjectionTitle.TabIndex = 6
        Me.lblFiveYearProjectionTitle.Text = "Five Year Projection Hourly:"
        '
        'lblFiveYearProjectionAnnual
        '
        Me.lblFiveYearProjectionAnnual.AutoSize = True
        Me.lblFiveYearProjectionAnnual.Location = New System.Drawing.Point(297, 348)
        Me.lblFiveYearProjectionAnnual.Name = "lblFiveYearProjectionAnnual"
        Me.lblFiveYearProjectionAnnual.Size = New System.Drawing.Size(183, 17)
        Me.lblFiveYearProjectionAnnual.TabIndex = 7
        Me.lblFiveYearProjectionAnnual.Text = "Five Year Projection Yearly:"
        '
        'lblFYPHourly
        '
        Me.lblFYPHourly.AutoSize = True
        Me.lblFYPHourly.Location = New System.Drawing.Point(489, 321)
        Me.lblFYPHourly.Name = "lblFYPHourly"
        Me.lblFYPHourly.Size = New System.Drawing.Size(79, 17)
        Me.lblFYPHourly.TabIndex = 8
        Me.lblFYPHourly.Text = "FYP Hourly"
        '
        'lblFYPYearly
        '
        Me.lblFYPYearly.AutoSize = True
        Me.lblFYPYearly.Location = New System.Drawing.Point(489, 348)
        Me.lblFYPYearly.Name = "lblFYPYearly"
        Me.lblFYPYearly.Size = New System.Drawing.Size(78, 17)
        Me.lblFYPYearly.TabIndex = 9
        Me.lblFYPYearly.Text = "FYP Yearly"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(489, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 629)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFYPYearly)
        Me.Controls.Add(Me.lblFYPHourly)
        Me.Controls.Add(Me.lblFiveYearProjectionAnnual)
        Me.Controls.Add(Me.lblFiveYearProjectionTitle)
        Me.Controls.Add(Me.lblAnnualPay)
        Me.Controls.Add(Me.lblCurrentYearlyTitle)
        Me.Controls.Add(Me.lblCurrentPayTitle)
        Me.Controls.Add(Me.lblHourlyPay)
        Me.Controls.Add(Me.cboJobs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboJobs As ComboBox
    Friend WithEvents lblHourlyPay As Label
    Friend WithEvents lblCurrentPayTitle As Label
    Friend WithEvents lblCurrentYearlyTitle As Label
    Friend WithEvents lblAnnualPay As Label
    Friend WithEvents lblFiveYearProjectionTitle As Label
    Friend WithEvents lblFiveYearProjectionAnnual As Label
    Friend WithEvents lblFYPHourly As Label
    Friend WithEvents lblFYPYearly As Label
    Friend WithEvents Label1 As Label
End Class
