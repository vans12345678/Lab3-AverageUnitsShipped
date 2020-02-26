'*****  Lab 3 - Average Units Shipped                                                       *****'
'*****  Name: Andre Agrippa                                                                 *****'
'*****                                                                                      *****'
'*****  Purpose: Prompts the user to enter units shipped for 7 days                         *****'
'*****           for 3 employees. The average per employee will be shown                    *****'
'*****           as well as the avrage per day.                                             *****'
'*****                                                                                      *****'
'*****  Date: 02/21/2020                                                                    *****'
'*****  Class: NETD 2202 

Option Strict On
Public Class FrmAverageUnitsShipped
#Region "Variables Declarations"

    'Keeps count of days/weeks
    Dim day As Integer = 0
    Dim week As Integer = 0

    'Holds the weekly total units per employee and total units for 3 employees
    Dim weeklyTotalUnits As Double
    Dim totalUnits As Double

    'Holds the average units weekly and total average
    Dim weeklyAverageUnits As Double
    Dim totalAverageUnits As Double

    'Array to hold units for 3 employees
    Dim unitsArray(2, 6) As Integer

    'Array to told each txtEntries input, Array to hold each valid units to output to lblOutput
    Dim textUnitsArray() As TextBox
    Dim outLabelArray() As Label

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' When the form loads, assign each textbox a place in the textbox array,
    ''' Assign each label a place in the label array
    ''' </summary>
    Private Sub FrmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textUnitsArray = {txtEntries1, txtEntries2, txtEntries3}
        outLabelArray = {lblOutput1, lblOutput2, lblOutput3}
    End Sub

    ''' <summary>
    ''' This event handler will close the form completely
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This event handler will call a function to set all input/output back to default
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Calls Sub procedure to set all input/output back to default
        SetDefaults()

    End Sub

    ''' <summary>
    ''' Validates the input, displays input, calculates the average per employee and the average per day. 
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Declare constants for days per week and number of weeks
        Const DaysPerWeek As Integer = 7
        Const NumberOfWeeks As Integer = 3

        'If user input can be parsed into integer and placed into proper array index
        If Integer.TryParse(txtUnits.Text, unitsArray(week, day)) Then

            'If user input is less than 0
            If unitsArray(week, day) < 0 Or unitsArray(week, day) > 5000 Then

                'Display error message, input must be greater or equal to 0, highlights error
                MessageBox.Show("Units must be a whole real number between 0 and 5000. Please try again.")
                txtUnits.SelectAll()
                txtUnits.Focus()

            Else
                'Output unit value
                textUnitsArray(week).Text &= unitsArray(week, day) & vbCrLf

                'Entry is valid, increments days
                day += 1
                lblDay.Text = " Day " & (day + 1)

                'Clear input field
                txtUnits.Clear()

                'If days is equal to amount of days per week
                If day = DaysPerWeek Then

                    'Reset total units for employee
                    weeklyTotalUnits = 0

                    'Calculate weekly total units for employee x entries
                    For dayCounter As Integer = 0 To DaysPerWeek - 1
                        weeklyTotalUnits += unitsArray(week, dayCounter)
                    Next

                    'Calculate and output the average for employee x
                    weeklyAverageUnits = weeklyTotalUnits / DaysPerWeek
                    outLabelArray(week).Text = "Average:" & Math.Round(weeklyAverageUnits, 2)

                    'Increment week
                    week += 1

                    'Reset days
                    day = 0
                    lblDay.Text = "Day " & (day + 1)

                    'If week is equal to amount of weeks
                    If week = NumberOfWeeks Then

                        'Calculate total units for each units entry
                        For Each day In unitsArray
                            totalUnits += day
                        Next

                        'Calculate and output total average per day
                        totalAverageUnits = totalUnits / unitsArray.Length
                        lblAveragePerDay.Text = "Total Average: " & Math.Round(totalAverageUnits, 2)

                        'Disable all input controls
                        txtUnits.Enabled = False
                        btnEnter.Enabled = False
                        btnReset.Focus()

                        'Display complete
                        lblDay.Text = "Complete"

                    End If

                End If

            End If

        Else

            'Display error message, input must be a real number, highlights error
            MessageBox.Show("Units must be entered as a whole real number. Please try again.")
            txtUnits.SelectAll()
            txtUnits.Focus()

        End If

    End Sub

#End Region

#Region "Procedures"

    ''' <summary>
    ''' Clears input and output, re-enables controls, sets the form back to the default state
    ''' </summary>
    Sub SetDefaults()

        ' Clear all textboxes on form
        txtUnits.Clear()
        txtEntries1.Clear()
        txtEntries2.Clear()
        txtEntries3.Clear()

        'Clear all output labels on form
        lblOutput1.Text = String.Empty
        lblOutput2.Text = String.Empty
        lblOutput3.Text = String.Empty
        lblAveragePerDay.Text = String.Empty

        'Enable all input controls
        txtUnits.Enabled = True
        btnEnter.Enabled = True

        'Set all varibles to default
        day = 0
        week = 0
        lblDay.Text = "Day " & (day + 1)

        'Reset total week employee units and total units for all entries
        weeklyTotalUnits = 0
        totalUnits = 0

        'Focus 
        txtUnits.Focus()

    End Sub

#End Region


End Class
