<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperatorBox
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
        Me.ResoStatus = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Kopiret = New System.Windows.Forms.Label()
        Me.GameStatus = New System.Windows.Forms.Label()
        Me.tblBonus = New System.Windows.Forms.Button()
        Me.tblKelompok = New System.Windows.Forms.Button()
        Me.tblRebutan = New System.Windows.Forms.Button()
        Me.ExitBut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tim1Min = New System.Windows.Forms.Button()
        Me.Tim1Plus = New System.Windows.Forms.Button()
        Me.Default1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Tim1Skor = New System.Windows.Forms.Label()
        Me.Tim1Nama = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tim2Min = New System.Windows.Forms.Button()
        Me.Tim2Plus = New System.Windows.Forms.Button()
        Me.Default2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Tim2Skor = New System.Windows.Forms.Label()
        Me.Tim2Nama = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Tim3Min = New System.Windows.Forms.Button()
        Me.Tim3Plus = New System.Windows.Forms.Button()
        Me.Default3 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Tim3Skor = New System.Windows.Forms.Label()
        Me.Tim3Nama = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Tim4Min = New System.Windows.Forms.Button()
        Me.Tim4Plus = New System.Windows.Forms.Button()
        Me.Default4 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Tim4Skor = New System.Windows.Forms.Label()
        Me.Tim4Nama = New System.Windows.Forms.Label()
        Me.WhenClickingPlus = New System.Windows.Forms.Timer(Me.components)
        Me.WhenClickingMin = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResoStatus
        '
        Me.ResoStatus.AutoSize = True
        Me.ResoStatus.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResoStatus.Location = New System.Drawing.Point(16, 12)
        Me.ResoStatus.Name = "ResoStatus"
        Me.ResoStatus.Size = New System.Drawing.Size(47, 19)
        Me.ResoStatus.TabIndex = 0
        Me.ResoStatus.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Kopiret)
        Me.Panel1.Controls.Add(Me.GameStatus)
        Me.Panel1.Controls.Add(Me.tblBonus)
        Me.Panel1.Controls.Add(Me.tblKelompok)
        Me.Panel1.Controls.Add(Me.tblRebutan)
        Me.Panel1.Controls.Add(Me.ExitBut)
        Me.Panel1.Controls.Add(Me.ResoStatus)
        Me.Panel1.Location = New System.Drawing.Point(-4, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 111)
        Me.Panel1.TabIndex = 1
        '
        'Kopiret
        '
        Me.Kopiret.AutoSize = True
        Me.Kopiret.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kopiret.Location = New System.Drawing.Point(16, 58)
        Me.Kopiret.Name = "Kopiret"
        Me.Kopiret.Size = New System.Drawing.Size(97, 12)
        Me.Kopiret.TabIndex = 7
        Me.Kopiret.Text = "Tertanda sebuah app"
        '
        'GameStatus
        '
        Me.GameStatus.AutoSize = True
        Me.GameStatus.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameStatus.Location = New System.Drawing.Point(16, 35)
        Me.GameStatus.Name = "GameStatus"
        Me.GameStatus.Size = New System.Drawing.Size(118, 19)
        Me.GameStatus.TabIndex = 5
        Me.GameStatus.Text = "Status Permainan:"
        '
        'tblBonus
        '
        Me.tblBonus.Location = New System.Drawing.Point(578, 27)
        Me.tblBonus.Name = "tblBonus"
        Me.tblBonus.Size = New System.Drawing.Size(84, 35)
        Me.tblBonus.TabIndex = 4
        Me.tblBonus.Text = "Bonus"
        Me.tblBonus.UseVisualStyleBackColor = True
        '
        'tblKelompok
        '
        Me.tblKelompok.Location = New System.Drawing.Point(758, 27)
        Me.tblKelompok.Name = "tblKelompok"
        Me.tblKelompok.Size = New System.Drawing.Size(84, 35)
        Me.tblKelompok.TabIndex = 2
        Me.tblKelompok.Text = "Kelompok"
        Me.tblKelompok.UseVisualStyleBackColor = True
        '
        'tblRebutan
        '
        Me.tblRebutan.Location = New System.Drawing.Point(668, 27)
        Me.tblRebutan.Name = "tblRebutan"
        Me.tblRebutan.Size = New System.Drawing.Size(84, 35)
        Me.tblRebutan.TabIndex = 3
        Me.tblRebutan.Text = "Rebutan"
        Me.tblRebutan.UseVisualStyleBackColor = True
        '
        'ExitBut
        '
        Me.ExitBut.Location = New System.Drawing.Point(848, 27)
        Me.ExitBut.Name = "ExitBut"
        Me.ExitBut.Size = New System.Drawing.Size(84, 35)
        Me.ExitBut.TabIndex = 1
        Me.ExitBut.Text = "Exit"
        Me.ExitBut.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Tim1Min)
        Me.Panel2.Controls.Add(Me.Tim1Plus)
        Me.Panel2.Controls.Add(Me.Default1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Tim1Nama)
        Me.Panel2.Location = New System.Drawing.Point(15, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 327)
        Me.Panel2.TabIndex = 3
        '
        'Tim1Min
        '
        Me.Tim1Min.Location = New System.Drawing.Point(107, 277)
        Me.Tim1Min.Name = "Tim1Min"
        Me.Tim1Min.Size = New System.Drawing.Size(92, 40)
        Me.Tim1Min.TabIndex = 3
        Me.Tim1Min.Text = "-"
        Me.Tim1Min.UseVisualStyleBackColor = True
        '
        'Tim1Plus
        '
        Me.Tim1Plus.Location = New System.Drawing.Point(7, 277)
        Me.Tim1Plus.Name = "Tim1Plus"
        Me.Tim1Plus.Size = New System.Drawing.Size(94, 40)
        Me.Tim1Plus.TabIndex = 2
        Me.Tim1Plus.Text = "+"
        Me.Tim1Plus.UseVisualStyleBackColor = True
        '
        'Default1
        '
        Me.Default1.Location = New System.Drawing.Point(7, 231)
        Me.Default1.Name = "Default1"
        Me.Default1.Size = New System.Drawing.Size(192, 40)
        Me.Default1.TabIndex = 1
        Me.Default1.Text = "Set Default"
        Me.Default1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.Tim1Skor)
        Me.Panel6.Location = New System.Drawing.Point(7, 58)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(192, 167)
        Me.Panel6.TabIndex = 1
        '
        'Tim1Skor
        '
        Me.Tim1Skor.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim1Skor.Location = New System.Drawing.Point(1, 33)
        Me.Tim1Skor.Name = "Tim1Skor"
        Me.Tim1Skor.Size = New System.Drawing.Size(193, 91)
        Me.Tim1Skor.TabIndex = 0
        Me.Tim1Skor.Text = "0"
        Me.Tim1Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tim1Nama
        '
        Me.Tim1Nama.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim1Nama.Location = New System.Drawing.Point(0, 12)
        Me.Tim1Nama.Name = "Tim1Nama"
        Me.Tim1Nama.Size = New System.Drawing.Size(209, 32)
        Me.Tim1Nama.TabIndex = 0
        Me.Tim1Nama.Text = "<Name>"
        Me.Tim1Nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.Tim2Min)
        Me.Panel3.Controls.Add(Me.Tim2Plus)
        Me.Panel3.Controls.Add(Me.Default2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Tim2Nama)
        Me.Panel3.Location = New System.Drawing.Point(249, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 327)
        Me.Panel3.TabIndex = 5
        '
        'Tim2Min
        '
        Me.Tim2Min.Location = New System.Drawing.Point(107, 277)
        Me.Tim2Min.Name = "Tim2Min"
        Me.Tim2Min.Size = New System.Drawing.Size(92, 40)
        Me.Tim2Min.TabIndex = 3
        Me.Tim2Min.Text = "-"
        Me.Tim2Min.UseVisualStyleBackColor = True
        '
        'Tim2Plus
        '
        Me.Tim2Plus.Location = New System.Drawing.Point(7, 277)
        Me.Tim2Plus.Name = "Tim2Plus"
        Me.Tim2Plus.Size = New System.Drawing.Size(94, 40)
        Me.Tim2Plus.TabIndex = 2
        Me.Tim2Plus.Text = "+"
        Me.Tim2Plus.UseVisualStyleBackColor = True
        '
        'Default2
        '
        Me.Default2.Location = New System.Drawing.Point(7, 231)
        Me.Default2.Name = "Default2"
        Me.Default2.Size = New System.Drawing.Size(192, 40)
        Me.Default2.TabIndex = 1
        Me.Default2.Text = "Set Default"
        Me.Default2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Tim2Skor)
        Me.Panel4.Location = New System.Drawing.Point(7, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 167)
        Me.Panel4.TabIndex = 1
        '
        'Tim2Skor
        '
        Me.Tim2Skor.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim2Skor.Location = New System.Drawing.Point(1, 33)
        Me.Tim2Skor.Name = "Tim2Skor"
        Me.Tim2Skor.Size = New System.Drawing.Size(193, 91)
        Me.Tim2Skor.TabIndex = 0
        Me.Tim2Skor.Text = "0"
        Me.Tim2Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tim2Nama
        '
        Me.Tim2Nama.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim2Nama.Location = New System.Drawing.Point(0, 12)
        Me.Tim2Nama.Name = "Tim2Nama"
        Me.Tim2Nama.Size = New System.Drawing.Size(209, 32)
        Me.Tim2Nama.TabIndex = 0
        Me.Tim2Nama.Text = "<Name>"
        Me.Tim2Nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Controls.Add(Me.Tim3Min)
        Me.Panel5.Controls.Add(Me.Tim3Plus)
        Me.Panel5.Controls.Add(Me.Default3)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Tim3Nama)
        Me.Panel5.Location = New System.Drawing.Point(486, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(209, 327)
        Me.Panel5.TabIndex = 6
        '
        'Tim3Min
        '
        Me.Tim3Min.Location = New System.Drawing.Point(107, 277)
        Me.Tim3Min.Name = "Tim3Min"
        Me.Tim3Min.Size = New System.Drawing.Size(92, 40)
        Me.Tim3Min.TabIndex = 3
        Me.Tim3Min.Text = "-"
        Me.Tim3Min.UseVisualStyleBackColor = True
        '
        'Tim3Plus
        '
        Me.Tim3Plus.Location = New System.Drawing.Point(7, 277)
        Me.Tim3Plus.Name = "Tim3Plus"
        Me.Tim3Plus.Size = New System.Drawing.Size(94, 40)
        Me.Tim3Plus.TabIndex = 2
        Me.Tim3Plus.Text = "+"
        Me.Tim3Plus.UseVisualStyleBackColor = True
        '
        'Default3
        '
        Me.Default3.Location = New System.Drawing.Point(7, 231)
        Me.Default3.Name = "Default3"
        Me.Default3.Size = New System.Drawing.Size(192, 40)
        Me.Default3.TabIndex = 1
        Me.Default3.Text = "Set Default"
        Me.Default3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Controls.Add(Me.Tim3Skor)
        Me.Panel7.Location = New System.Drawing.Point(7, 58)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(192, 167)
        Me.Panel7.TabIndex = 1
        '
        'Tim3Skor
        '
        Me.Tim3Skor.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim3Skor.Location = New System.Drawing.Point(1, 33)
        Me.Tim3Skor.Name = "Tim3Skor"
        Me.Tim3Skor.Size = New System.Drawing.Size(193, 91)
        Me.Tim3Skor.TabIndex = 0
        Me.Tim3Skor.Text = "0"
        Me.Tim3Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tim3Nama
        '
        Me.Tim3Nama.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim3Nama.Location = New System.Drawing.Point(0, 12)
        Me.Tim3Nama.Name = "Tim3Nama"
        Me.Tim3Nama.Size = New System.Drawing.Size(209, 32)
        Me.Tim3Nama.TabIndex = 0
        Me.Tim3Nama.Text = "<Name>"
        Me.Tim3Nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.Controls.Add(Me.Tim4Min)
        Me.Panel8.Controls.Add(Me.Tim4Plus)
        Me.Panel8.Controls.Add(Me.Default4)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Tim4Nama)
        Me.Panel8.Location = New System.Drawing.Point(715, 21)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(209, 327)
        Me.Panel8.TabIndex = 7
        '
        'Tim4Min
        '
        Me.Tim4Min.Location = New System.Drawing.Point(107, 277)
        Me.Tim4Min.Name = "Tim4Min"
        Me.Tim4Min.Size = New System.Drawing.Size(92, 40)
        Me.Tim4Min.TabIndex = 3
        Me.Tim4Min.Text = "-"
        Me.Tim4Min.UseVisualStyleBackColor = True
        '
        'Tim4Plus
        '
        Me.Tim4Plus.Location = New System.Drawing.Point(7, 277)
        Me.Tim4Plus.Name = "Tim4Plus"
        Me.Tim4Plus.Size = New System.Drawing.Size(94, 40)
        Me.Tim4Plus.TabIndex = 2
        Me.Tim4Plus.Text = "+"
        Me.Tim4Plus.UseVisualStyleBackColor = True
        '
        'Default4
        '
        Me.Default4.Location = New System.Drawing.Point(7, 231)
        Me.Default4.Name = "Default4"
        Me.Default4.Size = New System.Drawing.Size(192, 40)
        Me.Default4.TabIndex = 1
        Me.Default4.Text = "Set Default"
        Me.Default4.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel9.Controls.Add(Me.Tim4Skor)
        Me.Panel9.Location = New System.Drawing.Point(7, 58)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(192, 167)
        Me.Panel9.TabIndex = 1
        '
        'Tim4Skor
        '
        Me.Tim4Skor.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim4Skor.Location = New System.Drawing.Point(1, 33)
        Me.Tim4Skor.Name = "Tim4Skor"
        Me.Tim4Skor.Size = New System.Drawing.Size(193, 91)
        Me.Tim4Skor.TabIndex = 0
        Me.Tim4Skor.Text = "0"
        Me.Tim4Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tim4Nama
        '
        Me.Tim4Nama.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim4Nama.Location = New System.Drawing.Point(0, 12)
        Me.Tim4Nama.Name = "Tim4Nama"
        Me.Tim4Nama.Size = New System.Drawing.Size(209, 32)
        Me.Tim4Nama.TabIndex = 0
        Me.Tim4Nama.Text = "<Name>"
        Me.Tim4Nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WhenClickingPlus
        '
        '
        'WhenClickingMin
        '
        '
        'OperatorBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(940, 451)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OperatorBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Papan Skor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ResoStatus As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tblKelompok As System.Windows.Forms.Button
    Friend WithEvents tblRebutan As System.Windows.Forms.Button
    Friend WithEvents ExitBut As System.Windows.Forms.Button
    Friend WithEvents tblBonus As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Tim1Nama As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Tim1Skor As System.Windows.Forms.Label
    Friend WithEvents Tim1Min As System.Windows.Forms.Button
    Friend WithEvents Tim1Plus As System.Windows.Forms.Button
    Friend WithEvents Default1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Tim2Min As System.Windows.Forms.Button
    Friend WithEvents Tim2Plus As System.Windows.Forms.Button
    Friend WithEvents Default2 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Tim2Skor As System.Windows.Forms.Label
    Friend WithEvents Tim2Nama As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Tim3Min As System.Windows.Forms.Button
    Friend WithEvents Tim3Plus As System.Windows.Forms.Button
    Friend WithEvents Default3 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Tim3Skor As System.Windows.Forms.Label
    Friend WithEvents Tim3Nama As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Tim4Min As System.Windows.Forms.Button
    Friend WithEvents Tim4Plus As System.Windows.Forms.Button
    Friend WithEvents Default4 As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Tim4Skor As System.Windows.Forms.Label
    Friend WithEvents Tim4Nama As System.Windows.Forms.Label
    Friend WithEvents GameStatus As System.Windows.Forms.Label
    Friend WithEvents Kopiret As System.Windows.Forms.Label
    Friend WithEvents WhenClickingPlus As System.Windows.Forms.Timer
    Friend WithEvents WhenClickingMin As System.Windows.Forms.Timer
End Class
