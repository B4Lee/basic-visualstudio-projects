Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim pass As String
        user = "Iqbal"
        pass = "Anggoro"
        If (TextBox1.Text = "Iqbal" And TextBox2.Text = "Anggoro") Then
            Call msgbox1()
            Form2.Show()
            'menampilkan form2 ketika command Button diklik'
            Me.Hide()
            'menutup form1 ketika form2 terbuka'
        Else
            Call msgbox2()
        End If

    End Sub
    Sub msgbox1()
        MsgBox("Login Success")
    End Sub
    Sub msgbox2()
        MsgBox("Sorry..!! Login Failed. Please try again")
    End Sub

 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
