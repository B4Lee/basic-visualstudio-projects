
Imports System.Data.OleDb
Public Class CreateAccount
    Sub koneksi()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Lenovo\Desktop\Login Form v.2\db1.mdb")
        conn.Open()
    End Sub
    Private Sub createaccount_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Sub Clear()
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox5.Text = "" Or TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belom lengkap ")
            TextBox5.Focus()
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from Login where Username='" & TextBox5.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim simpan As String = "insert into login values ('" & Rep(TextBox5.Text) & "','" & Rep(TextBox4.Text) & "','" & Rep(TextBox3.Text) & "')"
                cmd = New OleDbCommand(simpan, conn)
                cmd.ExecuteReader()
                MsgBox(" Account Berhasil Dibuat! ")
                Clear()
            Else
                TextBox5.Text = ""
                MsgBox("Username Telah Digunakan")
                TextBox5.Focus()
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Me.Hide()
    End Sub
End Class
