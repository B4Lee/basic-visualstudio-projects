Public Class Form1
    Dim jenkel As String
    Private Sub txtktp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtktp.KeyPress
        If e.KeyChar = vbBack Or IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rdlaki_CheckedChanged(sender As Object, e As EventArgs) Handles rdlaki.CheckedChanged
        If rdlaki.Checked = True Then
            jenkel = "Laki-laki"
        Else
            jenkel = "Perempuan"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv.View = View.Details
        With lv.Columns
            .Add("Nama", 100, HorizontalAlignment.Center)
            .Add("No.Ktp", 120, HorizontalAlignment.Center)
            .Add("Jenis Kelamin", 90, HorizontalAlignment.Center)
            .Add("Tanggal Masuk", 140, HorizontalAlignment.Center)
            .Add("No.Kamar", 80, HorizontalAlignment.Center)
            .Add("Tanggal Keluar", 140, HorizontalAlignment.Center)
        End With
        lv.GridLines = True
        lv.MultiSelect = True
        lv.FullRowSelect = True
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtnama.Text = " " Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Critical)
        ElseIf txtktp.Text = " " Or txtktp.TextLength < 16 Then
            MsgBox("No ktp harus di isi dengan benar", MsgBoxStyle.Critical)
        ElseIf rdlaki.Checked = False And rdpr.Checked = False Then
            MsgBox("Jenis kelamin wajib di isi", MsgBoxStyle.Critical)
        ElseIf cbokmr.SelectedItem = " " Or cbokmr.SelectedItem = "<none>" Then
            MsgBox("Belum memilih kamar")
        Else
            lv.Items.Add(New ListViewItem(New String() {
            txtnama.Text, txtktp.Text, jenkel, datemasuk.Text, cbokmr.SelectedItem, datekeluar.Text}))
            txtnama.Clear()

        End If
        txtnama.Clear()
        txtktp.Clear()
        rdlaki.Checked = False
        rdpr.Checked = False
        cbokmr.SelectedIndex = 0
    End Sub

    Private Sub lv_MouseClick(sender As Object, e As MouseEventArgs) Handles lv.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            lv.ContextMenuStrip = cms
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim XTP As Double = 0
        txtnama.Text = lv.SelectedItems(0).SubItems(0).Text
        txtktp.Text = lv.SelectedItems(0).SubItems(1).Text
        cbokmr.Text = lv.SelectedItems(0).SubItems(4).Text

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        lv.Items.Remove(lv.SelectedItems(0))
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class