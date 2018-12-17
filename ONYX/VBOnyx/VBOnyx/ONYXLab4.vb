Public Class ONYXLab4
    Const decR_BONUS = 0.2
    Const decR_Tax = 0.07
    Dim Day As Date = Date.Now
    Dim saraly, sale As Double
    Dim dblSumSalary
    Dim dblBonus
    Dim dblIncome
    Dim dblAllowance
    Dim dblTax
   

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        If radShortDate.Checked Then

            lblDate.Text = FormatDateTime(Day, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        If radGenDate.Checked Then
            lblDate.Text = FormatDateTime(Day, DateFormat.GeneralDate)
        End If
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        If radLongDate.Checked Then

            lblDate.Text = FormatDateTime(Day, DateFormat.LongDate)

        End If
    End Sub

    Private Sub btnExcute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click

        dblSumSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblIncome = dblSumSalary + dblBonus
        dblAllowance = dblIncome * 0.01
        dblTax = (dblIncome - dblAllowance) * decR_Tax


        lblYearSalary.Text = FormatNumber(dblSumSalary)

        lblBonus.Text = FormatNumber(dblBonus)

        lblAllIncome.Text = FormatNumber(dblIncome)
        lblAllowance.Text = FormatNumber(dblAllowance)

        lblTax.Text = FormatNumber(dblTax)
    End Sub

    Private Sub lblTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTax.Click

    End Sub
End Class