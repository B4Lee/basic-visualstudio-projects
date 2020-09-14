Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NIK"
        Arr(0, 1) = "NAMA"
        Arr(1, 0) = "KELAS"
        Arr(1, 1) = "KODE JURUSAN"

        ListView1.GridLines = True
        ListView1.View = View.Details
        For Baris = 0 To 1
            For Kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, Kolom), 100)
            Next Kolom
        Next Baris
        For Baris = 2 To 2
            For Kolom = 0 To 1
                CmbKelas.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
        For Baris = 3 To 3
            For Kolom = 0 To 1
                CmbJurusan.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
    End Sub

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Dim Arr(3) As String
        Arr(0) = TxtNIK.Text
        Arr(1) = TxtNama.Text
        Arr(2) = CmbKelas.Text
        Arr(3) = CmbJurusan.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        TxtNIK.Text = TxtNIK.Text + 1
        TxtNama.Text = ""
        CmbKelas.Text = ""
        CmbJurusan.Text = ""
        TxtNama.Focus()
    End Sub


End Class
