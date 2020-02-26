<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.txtEntries1 = New System.Windows.Forms.TextBox()
        Me.txtEntries2 = New System.Windows.Forms.TextBox()
        Me.txtEntries3 = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.tipAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblOutput1
        '
        Me.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput1.Location = New System.Drawing.Point(30, 312)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(113, 35)
        Me.lblOutput1.TabIndex = 10
        Me.lblOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblOutput1, "Employee 1 Average Output")
        '
        'lblOutput2
        '
        Me.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput2.Location = New System.Drawing.Point(218, 312)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(113, 35)
        Me.lblOutput2.TabIndex = 9
        Me.lblOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblOutput2, "Employee 2 Average Output")
        '
        'lblOutput3
        '
        Me.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput3.Location = New System.Drawing.Point(406, 312)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(113, 35)
        Me.lblOutput3.TabIndex = 8
        Me.lblOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblOutput3, "Employee 3 Average Output")
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(31, 368)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(489, 35)
        Me.lblAveragePerDay.TabIndex = 7
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblAveragePerDay, "Average Per Day Output")
        '
        'txtEntries1
        '
        Me.txtEntries1.Location = New System.Drawing.Point(30, 119)
        Me.txtEntries1.Multiline = True
        Me.txtEntries1.Name = "txtEntries1"
        Me.txtEntries1.ReadOnly = True
        Me.txtEntries1.Size = New System.Drawing.Size(113, 170)
        Me.txtEntries1.TabIndex = 1
        Me.tipAverageUnitsShipped.SetToolTip(Me.txtEntries1, "Employee 1 Entries")
        '
        'txtEntries2
        '
        Me.txtEntries2.Location = New System.Drawing.Point(218, 119)
        Me.txtEntries2.Multiline = True
        Me.txtEntries2.Name = "txtEntries2"
        Me.txtEntries2.ReadOnly = True
        Me.txtEntries2.Size = New System.Drawing.Size(113, 170)
        Me.txtEntries2.TabIndex = 2
        Me.tipAverageUnitsShipped.SetToolTip(Me.txtEntries2, "Employee 2 Entries")
        '
        'txtEntries3
        '
        Me.txtEntries3.Location = New System.Drawing.Point(406, 119)
        Me.txtEntries3.Multiline = True
        Me.txtEntries3.Name = "txtEntries3"
        Me.txtEntries3.ReadOnly = True
        Me.txtEntries3.Size = New System.Drawing.Size(113, 170)
        Me.txtEntries3.TabIndex = 3
        Me.tipAverageUnitsShipped.SetToolTip(Me.txtEntries3, "Employee 3 Entries")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(30, 24)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(35, 13)
        Me.lblDay.TabIndex = 15
        Me.lblDay.Text = "Day 1"
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblDay, "Indicates what day you are entering for")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(30, 50)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 14
        Me.lblUnits.Text = "&Units:"
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblUnits, "Units per day")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(70, 47)
        Me.txtUnits.Multiline = True
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(73, 20)
        Me.txtUnits.TabIndex = 0
        Me.tipAverageUnitsShipped.SetToolTip(Me.txtUnits, "Units input")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(30, 406)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(113, 41)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "&Enter"
        Me.tipAverageUnitsShipped.SetToolTip(Me.btnEnter, "Enters unit per day and calculates average if 7 entries")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(218, 406)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 41)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.tipAverageUnitsShipped.SetToolTip(Me.btnReset, "Resets all input/output")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(406, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 41)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.tipAverageUnitsShipped.SetToolTip(Me.btnExit, "Closes then form without further instruction")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(30, 94)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(113, 22)
        Me.lblEmployee1.TabIndex = 13
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblEmployee1, "Employee 1 Section")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(218, 94)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(113, 22)
        Me.lblEmployee2.TabIndex = 12
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblEmployee2, "Employee 2 Section")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(407, 94)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(113, 22)
        Me.lblEmployee3.TabIndex = 11
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipAverageUnitsShipped.SetToolTip(Me.lblEmployee3, "Employee 3 Section")
        '
        'FrmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(562, 463)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtEntries3)
        Me.Controls.Add(Me.txtEntries2)
        Me.Controls.Add(Me.txtEntries1)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput1 As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents txtEntries1 As TextBox
    Friend WithEvents txtEntries2 As TextBox
    Friend WithEvents txtEntries3 As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents tipAverageUnitsShipped As ToolTip
End Class
