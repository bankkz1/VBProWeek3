Public Class FMLab1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtSaraly.Text = txtMoney.Text * 12

        txtVat.Text = txtSaraly.Text * 0.05

        txtReColi.Text = txtSaraly.Text - txtVat.Text







    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
