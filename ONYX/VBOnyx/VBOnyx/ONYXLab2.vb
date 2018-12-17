Public Class ONYXLab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim VG As Double = txtVG.Text
        Dim FG As Double = txtFG.Text
        Dim Com5 As Double = VG * 0.05
        Dim Com10 As Double = FG * 0.1
        ibiCom5.Text = Com5
        ibiCom10.Text = Com10
        ibiAllSale.Text = Val(VG) + Val(FG)
        ibiAllcom.Text = Val(Com5) + Val(Com10)


    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    
End Class