Public Class Form1

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub cmbhari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbulan.SelectedIndexChanged
        Dim Bulan(13) As String


        Bulan(1) = "JANUARI"
        Bulan(2) = "FEBRUAR"
        Bulan(3) = "MARET"
        Bulan(4) = "APRIL"
        Bulan(5) = "MEI"
        Bulan(6) = "JUNI"
        Bulan(7) = "JULI"
        Bulan(8) = "AGUSTUS"
        Bulan(9) = "SEPTEMBER"
        Bulan(10) = "OKTOBER"
        Bulan(11) = "NOVEMBER"
        Bulan(12) = "DESEMBER"

        lblbulan.Text = Bulan(cmbbulan.Text)

    End Sub

End Class
