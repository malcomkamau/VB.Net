Public Class Form1

    Function tax(ByVal grossPay) As Double
        Dim _tax As Double

        If grossPay > 200000 Then
            _tax = grossPay * 0.15

        ElseIf grossPay >= 80000 AndAlso grossPay <= 200000 Then
            _tax = grossPay * 0.1
        ElseIf grossPay >= 60000 AndAlso grossPay <= 79000 Then
            _tax = grossPay * 0.05
        ElseIf grossPay >= 40000 AndAlso grossPay < 60000 Then
            _tax = grossPay * 0.01
        Else
            _tax = grossPay * 0.005
        End If

        Return _tax
    End Function

    Function nssf(ByVal grossPay) As Double
        Dim _nssf As Double

        If grossPay > 200000 Then
            _nssf = grossPay * 0.15

        ElseIf grossPay >= 80000 AndAlso grossPay <= 200000 Then
            _nssf = grossPay * 0.1
        ElseIf grossPay >= 60000 AndAlso grossPay <= 79000 Then
            _nssf = grossPay * 0.05
        ElseIf grossPay >= 40000 AndAlso grossPay < 60000 Then
            _nssf = grossPay * 0.01
        Else
            _nssf = grossPay * 0.005
        End If

        Return _nssf
    End Function

    Function nhif(ByVal grossPay) As Double
        Dim _nhif As Double

        If grossPay > 200000 Then
            _nhif = grossPay * 0.15

        ElseIf grossPay >= 80000 AndAlso grossPay <= 200000 Then
            _nhif = grossPay * 0.1
        ElseIf grossPay >= 60000 AndAlso grossPay <= 79000 Then
            _nhif = grossPay * 0.05
        ElseIf grossPay >= 40000 AndAlso grossPay < 60000 Then
            _nhif = grossPay * 0.01
        Else
            _nhif = grossPay * 0.005
        End If

        Return _nhif
    End Function

    Function grossSalary(ByVal _basicPay, _allowance) As Double
        Return _basicPay + _allowance
    End Function

    Function totalDeductions(ByVal tax_, nssf_, nhif_) As Double
        Return tax_ + nssf_ + nhif_
    End Function

    Function netSalary(ByVal grossSal, deductions) As Double
        Return grossSal - deductions
    End Function

    Private Sub compute_Click(sender As Object, e As EventArgs) Handles compute.Click
        Dim basicPay_ As Double = CDbl(basicPayInput.Text)
        Dim allowance_ As Double = CDbl(allowanceInput.Text)
        Dim _tax_ As Double = tax(grossSalary(basicPay_, allowance_))
        Dim _nssf_ As Double = nssf(grossSalary(basicPay_, allowance_))
        Dim _nhif_ As Double = nhif(grossSalary(basicPay_, allowance_))

        grossOutput.Text = grossSalary(basicPay_, allowance_)

        taxOutput.Text = _tax_
        nssfOutput.Text = _nssf_
        nhifOutput.Text = _nhif_
        netOutput.Text = netSalary(grossSalary(basicPay_, allowance_), totalDeductions(tax(grossSalary(basicPay_, allowance_)), nssf(grossSalary(basicPay_, allowance_)), nhif(grossSalary(basicPay_, allowance_))))
        deductionOutput.Text = totalDeductions(_tax_, _nssf_, _nhif_)
    End Sub

    Private Sub exitB_Click(sender As Object, e As EventArgs) Handles exitB.Click
        Me.Close()
    End Sub
End Class
