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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.HoursWorkedLabel = New System.Windows.Forms.Label()
        Me.HourlyRateLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.HoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.HourlyRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.NameLabel.Location = New System.Drawing.Point(82, 61)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(70, 25)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name:"
        '
        'HoursWorkedLabel
        '
        Me.HoursWorkedLabel.AutoSize = True
        Me.HoursWorkedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.HoursWorkedLabel.Location = New System.Drawing.Point(82, 101)
        Me.HoursWorkedLabel.Name = "HoursWorkedLabel"
        Me.HoursWorkedLabel.Size = New System.Drawing.Size(144, 25)
        Me.HoursWorkedLabel.TabIndex = 1
        Me.HoursWorkedLabel.Text = "Hours Worked:"
        '
        'HourlyRateLabel
        '
        Me.HourlyRateLabel.AutoSize = True
        Me.HourlyRateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.HourlyRateLabel.Location = New System.Drawing.Point(82, 140)
        Me.HourlyRateLabel.Name = "HourlyRateLabel"
        Me.HourlyRateLabel.Size = New System.Drawing.Size(119, 25)
        Me.HourlyRateLabel.TabIndex = 2
        Me.HourlyRateLabel.Text = "Hourly Rate:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(273, 67)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(344, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'HoursWorkedTextBox
        '
        Me.HoursWorkedTextBox.Location = New System.Drawing.Point(273, 107)
        Me.HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        Me.HoursWorkedTextBox.Size = New System.Drawing.Size(344, 20)
        Me.HoursWorkedTextBox.TabIndex = 4
        '
        'HourlyRateTextBox
        '
        Me.HourlyRateTextBox.Location = New System.Drawing.Point(273, 145)
        Me.HourlyRateTextBox.Name = "HourlyRateTextBox"
        Me.HourlyRateTextBox.Size = New System.Drawing.Size(344, 20)
        Me.HourlyRateTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Pay:"
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TotalPayLabel.Location = New System.Drawing.Point(273, 250)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(344, 25)
        Me.TotalPayLabel.TabIndex = 7
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(83, 361)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(99, 31)
        Me.CalculateButton.TabIndex = 8
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(209, 361)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 31)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'EndButton
        '
        Me.EndButton.Location = New System.Drawing.Point(624, 361)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(99, 31)
        Me.EndButton.TabIndex = 10
        Me.EndButton.Text = "End"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalPayLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HourlyRateTextBox)
        Me.Controls.Add(Me.HoursWorkedTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.HourlyRateLabel)
        Me.Controls.Add(Me.HoursWorkedLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents HoursWorkedLabel As Label
    Friend WithEvents HourlyRateLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents HourlyRateTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalPayLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents EndButton As Button
End Class
