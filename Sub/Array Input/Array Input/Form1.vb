Public Class Form1

    Dim n As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama(15) As String 'Mendefinisikan variabel global nama sebagai array
        Dim n As Integer 'Jumlah data


        n = n + 1 'Setiap Command 1 di klik maka nilai n akan bertambah 1
        nama(n) = Trim(Textbox1.Text) 'Memindahkan / menuliskan isi text1 ke array nama
        TextBox1.Text = "" 'Isi dari text 1, setelah klik command 1, akan kosong

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListView1.Clear() 'Mengkosongkan area list 1
        For i = 1 To n 'Menampilkan semua isi array nama di list 1
            ListView1.Items.Add(XName(i))
        Next i
    End Sub

    Private Function XName(i As Object) As String
        Throw New NotImplementedException
    End Function

End Class
