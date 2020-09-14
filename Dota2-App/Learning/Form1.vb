Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        sender = MsgBox("Muhamammad Iqbal Aryo Anggoro")
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label0.Text = TimeOfDay
    End Sub

    Private Sub cmbheroes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbheroes.SelectedIndexChanged

        If cmbheroes.Text = "Strength" Then
            lbltipe.Text = "Earth Spirit"
        End If
    End Sub
End Class
