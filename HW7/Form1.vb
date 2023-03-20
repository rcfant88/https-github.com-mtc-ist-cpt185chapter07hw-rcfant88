' Program Name: HW7
' Author:       Rod Fant
' Date:         3/20/2023
' Purpose:      HW7 provides a list of four careers. A user can select each of the jobs and
'               will be shown the current hourly and annual pay, as well as the projected pay
'               based on a 4% raise for 5 years in a row.

Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Put "Select a Job" text shown and add jobs to the box on load.
        cboJobs.Items.Add("Select a Job")
        cboJobs.Items.Add("Computer Developer")
        cboJobs.Items.Add("Computer System Analyst")
        cboJobs.Items.Add("Computer and Information Systems Manager")
        cboJobs.Items.Add("Computer Software Engineer, Applications")
        cboJobs.SelectedIndex = 0 ' Select the default "Select a Job" text
    End Sub

    Private Sub cboJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJobs.SelectedIndexChanged
        ' Initializes and sets the four variables to 0
        Dim hourlyPay As Double = 0
        Dim annualPay As Double = 0
        Dim projHourlyPay As Double = 0
        Dim projAnnualPay As Double = 0
        GetCurrentAndProjectedPay(cboJobs.SelectedIndex, hourlyPay, annualPay, projHourlyPay, projAnnualPay)
        ' Displays the results in these labels below. C2 formats to currency
        lblHourlyPay.Text = hourlyPay.ToString("C2")
        lblAnnualPay.Text = annualPay.ToString("C2")
        lblFYPHourly.Text = projHourlyPay.ToString("C2")
        lblFYPYearly.Text = projAnnualPay.ToString("C2")
    End Sub

    Private Function ProjectedCalculations(ByRef payRate As Double) As Double
        ' This function accepts the data in a new/unused variable "payRate" (because instructions said "You cannot use variables declared outside the function)
        ' Projection is a new variable found nowhere else
        Dim projection As Double = payRate
        ' Projection is calculated (prob. should us a loop)
        projection = payRate * 1.04 * 1.04 * 1.04 * 1.04 * 1.04

        ' Projection is returned whenever called
        Return projection

    End Function



    Private Sub GetCurrentAndProjectedPay(ByVal occupationIndex As Integer, ByRef hourlyPay As Double, ByRef annualPay As Double, ByRef projHourlyPay As Double, ByRef projAnnualPay As Double)
        ' The function "GetCurrentAndProjectedPay" accepts the selected job, and the four pay variables
        ' Next we declare the pay for each
        Dim computerDeveloperHourlyMean As Double = 46.46
        Dim computerDeveloperAnnualMean As Double = 96650
        Dim computerSystemsAnalystsHourlyMean As Double = 49.14
        Dim computerSystemsAnalystsAnnualMean As Double = 102210
        Dim systemsManagerHourlyMean As Double = 43.87
        Dim systemsManagerAnnualMean As Double = 91250
        Dim computerSoftwareEngineersHourlyMean As Double = 58.17
        Dim computerSoftwareEngineersAnnualMean As Double = 120990
        ' The integer (selected job from the combo box) outputs the corresponding pay rates
        Select Case occupationIndex
            Case 1 'Computer Developer
                hourlyPay = computerDeveloperHourlyMean ' Displays the given data
                annualPay = computerDeveloperAnnualMean ' Displays the given data
                projHourlyPay = ProjectedCalculations(hourlyPay) ' Calls the function "ProjectedCalculations" and passes the data to be calculated
                projAnnualPay = ProjectedCalculations(annualPay) ' Calls the function "ProjectedCalculations" and passes the data to be calculated
            Case 2 'Computer Systems Analysts
                hourlyPay = computerSystemsAnalystsHourlyMean ' Same as above block
                annualPay = computerSystemsAnalystsAnnualMean
                projHourlyPay = ProjectedCalculations(hourlyPay)
                projAnnualPay = ProjectedCalculations(annualPay)
            Case 3 'Systems Manager
                hourlyPay = systemsManagerHourlyMean ' Same as above block
                annualPay = systemsManagerAnnualMean
                projHourlyPay = ProjectedCalculations(hourlyPay)
                projAnnualPay = ProjectedCalculations(annualPay)
            Case 4 'Computer Software Engineers
                hourlyPay = computerSoftwareEngineersHourlyMean ' Same as above block
                annualPay = computerSoftwareEngineersAnnualMean
                projHourlyPay = ProjectedCalculations(hourlyPay)
                projAnnualPay = ProjectedCalculations(annualPay)
        End Select

    End Sub
End Class
