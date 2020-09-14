Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a + b
        TextBox3.Text = c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a - b
        TextBox3.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a * b
        TextBox3.Text = c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a / b
        TextBox3.Text = c
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a Mod b
        TextBox3.Text = c
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a \ b
        TextBox3.Text = c
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text < TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text > TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <= TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text >= TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"

        End If
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text <> TextBox2.Text Then
            TextBox3.Text = "True"
        Else
            TextBox3.Text = "false"

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim logika As Boolean
        If ComboBox1.Text = "True" Then
            logika = True
        Else
            logika = False

        End If
        TextBox4.Text = Not logika
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        End
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim text1 As Boolean
        Dim text2 As Boolean

        If UCase(TextBox1.Text) = "TRUE" Then
            text1 = True
        Else
            text1 = False

        End If
        If UCase(TextBox2.Text) = "TRUE" Then
            text2 = True
        Else
            text2 = False
        End If
        TextBox3.Text = text1 Or text2

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text = "True" And TextBox2.Text = "True" Then
            TextBox3.Text = "True"
        ElseIf TextBox1.Text = "True" And TextBox2.Text = "False" Then
            TextBox3.Text = "False"
        ElseIf TextBox1.Text = "False" And TextBox2.Text = "True" Then
            TextBox3.Text = "False"
        ElseIf TextBox1.Text = "False" And TextBox2.Text = "False" Then
            TextBox3.Text = "False"
        Else
            TextBox3.Text = "False"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'Hapus semua input
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
    End Sub

End Class