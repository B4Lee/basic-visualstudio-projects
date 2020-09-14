Imports System.Data.OleDb
Public Class Form1
    Sub koneksi()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Lenovo\Desktop\Login Form v.2\db1.mdb")
        conn.Open()
    End Sub
    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belom lengkap ")
            TextBox1.Focus()
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from Login where username='" & Rep(TextBox1.Text) & "' and Password= '" & Rep(TextBox2.Text) & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox(" Login Berhasil! ")
                Me.Visible = False
                MenuUtama.Show()

                MenuUtama.Label6.Text = rd("TypeUser")
                clear()
            Else
                MsgBox(" Username dan Password Anda Salah ")
                clear()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
