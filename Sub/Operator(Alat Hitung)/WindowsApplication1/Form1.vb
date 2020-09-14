Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim A As Integer
        Dim B As Integer
        Dim C As String

        A = Val(bil1.Text)
        B = Val(bil2.Text)
        C = A + B
        bil3.Text = C

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim A As Integer
        Dim B As Integer
        Dim C As String

        A = Val(bil1.Text)
        B = Val(bil2.Text)
        C = A - B
        bil3.Text = C

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim A As Integer
        Dim B As Integer
        Dim C As String

        A = Val(bil1.Text)
        B = Val(bil2.Text)
        C = A * B
        bil3.Text = C

    End Sub

End Class
