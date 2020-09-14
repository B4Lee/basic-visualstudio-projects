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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bil1 = New System.Windows.Forms.TextBox()
        Me.bil2 = New System.Windows.Forms.TextBox()
        Me.bil3 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangan 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bilangan 3"
        '
        'bil1
        '
        Me.bil1.Location = New System.Drawing.Point(176, 36)
        Me.bil1.Name = "bil1"
        Me.bil1.Size = New System.Drawing.Size(132, 20)
        Me.bil1.TabIndex = 3
        '
        'bil2
        '
        Me.bil2.Location = New System.Drawing.Point(176, 76)
        Me.bil2.Name = "bil2"
        Me.bil2.Size = New System.Drawing.Size(132, 20)
        Me.bil2.TabIndex = 4
        '
        'bil3
        '
        Me.bil3.Location = New System.Drawing.Point(176, 115)
        Me.bil3.Name = "bil3"
        Me.bil3.Size = New System.Drawing.Size(132, 20)
        Me.bil3.TabIndex = 5
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.button1.Location = New System.Drawing.Point(12, 160)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(88, 32)
        Me.button1.TabIndex = 6
        Me.button1.Text = "+"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.button2.Location = New System.Drawing.Point(143, 160)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(88, 32)
        Me.button2.TabIndex = 7
        Me.button2.Text = "-"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(272, 160)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(88, 32)
        Me.button3.TabIndex = 8
        Me.button3.Text = "X"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 206)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.bil3)
        Me.Controls.Add(Me.bil2)
        Me.Controls.Add(Me.bil1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Operator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bil1 As System.Windows.Forms.TextBox
    Friend WithEvents bil2 As System.Windows.Forms.TextBox
    Friend WithEvents bil3 As System.Windows.Forms.TextBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button

End Class
