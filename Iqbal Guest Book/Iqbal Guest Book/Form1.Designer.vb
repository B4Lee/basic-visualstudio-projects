<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtktp = New System.Windows.Forms.TextBox()
        Me.rdpr = New System.Windows.Forms.RadioButton()
        Me.rdlaki = New System.Windows.Forms.RadioButton()
        Me.lv = New System.Windows.Forms.ListView()
        Me.datemasuk = New System.Windows.Forms.DateTimePicker()
        Me.datekeluar = New System.Windows.Forms.DateTimePicker()
        Me.cbokmr = New System.Windows.Forms.ComboBox()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. KTP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Keluar"
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(15, 164)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(671, 23)
        Me.btntambah.TabIndex = 6
        Me.btntambah.Text = "Simpan"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(152, 42)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(160, 20)
        Me.txtnama.TabIndex = 7
        '
        'txtktp
        '
        Me.txtktp.Location = New System.Drawing.Point(152, 78)
        Me.txtktp.Name = "txtktp"
        Me.txtktp.Size = New System.Drawing.Size(160, 20)
        Me.txtktp.TabIndex = 8
        '
        'rdpr
        '
        Me.rdpr.AutoSize = True
        Me.rdpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdpr.Location = New System.Drawing.Point(239, 118)
        Me.rdpr.Name = "rdpr"
        Me.rdpr.Size = New System.Drawing.Size(88, 17)
        Me.rdpr.TabIndex = 10
        Me.rdpr.TabStop = True
        Me.rdpr.Text = "Perempuan"
        Me.rdpr.UseVisualStyleBackColor = True
        '
        'rdlaki
        '
        Me.rdlaki.AutoSize = True
        Me.rdlaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdlaki.Location = New System.Drawing.Point(152, 118)
        Me.rdlaki.Name = "rdlaki"
        Me.rdlaki.Size = New System.Drawing.Size(73, 17)
        Me.rdlaki.TabIndex = 9
        Me.rdlaki.TabStop = True
        Me.rdlaki.Text = "Laki-laki"
        Me.rdlaki.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(11, 203)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(675, 138)
        Me.lv.TabIndex = 11
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'datemasuk
        '
        Me.datemasuk.Location = New System.Drawing.Point(550, 43)
        Me.datemasuk.Name = "datemasuk"
        Me.datemasuk.Size = New System.Drawing.Size(136, 20)
        Me.datemasuk.TabIndex = 12
        '
        'datekeluar
        '
        Me.datekeluar.Location = New System.Drawing.Point(550, 119)
        Me.datekeluar.Name = "datekeluar"
        Me.datekeluar.Size = New System.Drawing.Size(136, 20)
        Me.datekeluar.TabIndex = 13
        '
        'cbokmr
        '
        Me.cbokmr.FormattingEnabled = True
        Me.cbokmr.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "201", "202", "203", "204", "205", "301", "302", "303", "304", "305"})
        Me.cbokmr.Location = New System.Drawing.Point(550, 77)
        Me.cbokmr.Name = "cbokmr"
        Me.cbokmr.Size = New System.Drawing.Size(136, 21)
        Me.cbokmr.TabIndex = 14
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.HapusToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(109, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 353)
        Me.Controls.Add(Me.cbokmr)
        Me.Controls.Add(Me.datekeluar)
        Me.Controls.Add(Me.datemasuk)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.rdpr)
        Me.Controls.Add(Me.rdlaki)
        Me.Controls.Add(Me.txtktp)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(715, 391)
        Me.MinimumSize = New System.Drawing.Size(715, 391)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtktp As System.Windows.Forms.TextBox
    Friend WithEvents rdpr As System.Windows.Forms.RadioButton
    Friend WithEvents rdlaki As System.Windows.Forms.RadioButton
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents datemasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents datekeluar As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbokmr As System.Windows.Forms.ComboBox
    Friend WithEvents cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
