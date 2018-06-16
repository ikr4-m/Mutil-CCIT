<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrepareBox
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TeamPage = New System.Windows.Forms.TabPage()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PenghitungCheck = New System.Windows.Forms.Label()
        Me.Tim4 = New System.Windows.Forms.ComboBox()
        Me.Tim3 = New System.Windows.Forms.ComboBox()
        Me.Tim2 = New System.Windows.Forms.ComboBox()
        Me.Tim1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConditionScores = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SkorSalah = New System.Windows.Forms.TextBox()
        Me.SkorBenar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimerSetup = New System.Windows.Forms.TabPage()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Waktu = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TeamPage.SuspendLayout()
        Me.ConditionScores.SuspendLayout()
        Me.TimerSetup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TeamPage)
        Me.TabControl1.Controls.Add(Me.ConditionScores)
        Me.TabControl1.Controls.Add(Me.TimerSetup)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(346, 229)
        Me.TabControl1.TabIndex = 0
        '
        'TeamPage
        '
        Me.TeamPage.Controls.Add(Me.CheckBox4)
        Me.TeamPage.Controls.Add(Me.CheckBox3)
        Me.TeamPage.Controls.Add(Me.CheckBox2)
        Me.TeamPage.Controls.Add(Me.CheckBox1)
        Me.TeamPage.Controls.Add(Me.PenghitungCheck)
        Me.TeamPage.Controls.Add(Me.Tim4)
        Me.TeamPage.Controls.Add(Me.Tim3)
        Me.TeamPage.Controls.Add(Me.Tim2)
        Me.TeamPage.Controls.Add(Me.Tim1)
        Me.TeamPage.Controls.Add(Me.Label4)
        Me.TeamPage.Controls.Add(Me.Label3)
        Me.TeamPage.Controls.Add(Me.Label2)
        Me.TeamPage.Controls.Add(Me.Label1)
        Me.TeamPage.Location = New System.Drawing.Point(4, 25)
        Me.TeamPage.Name = "TeamPage"
        Me.TeamPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TeamPage.Size = New System.Drawing.Size(338, 200)
        Me.TeamPage.TabIndex = 0
        Me.TeamPage.Text = "Daftar Tim"
        Me.TeamPage.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(278, 158)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(278, 113)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(278, 67)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(278, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PenghitungCheck
        '
        Me.PenghitungCheck.AutoSize = True
        Me.PenghitungCheck.Location = New System.Drawing.Point(24, 73)
        Me.PenghitungCheck.Name = "PenghitungCheck"
        Me.PenghitungCheck.Size = New System.Drawing.Size(16, 17)
        Me.PenghitungCheck.TabIndex = 10
        Me.PenghitungCheck.Text = "0"
        '
        'Tim4
        '
        Me.Tim4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim4.FormattingEnabled = True
        Me.Tim4.Location = New System.Drawing.Point(118, 152)
        Me.Tim4.Name = "Tim4"
        Me.Tim4.Size = New System.Drawing.Size(142, 30)
        Me.Tim4.TabIndex = 9
        '
        'Tim3
        '
        Me.Tim3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim3.FormattingEnabled = True
        Me.Tim3.Location = New System.Drawing.Point(118, 106)
        Me.Tim3.Name = "Tim3"
        Me.Tim3.Size = New System.Drawing.Size(142, 30)
        Me.Tim3.TabIndex = 8
        '
        'Tim2
        '
        Me.Tim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim2.FormattingEnabled = True
        Me.Tim2.Location = New System.Drawing.Point(118, 60)
        Me.Tim2.Name = "Tim2"
        Me.Tim2.Size = New System.Drawing.Size(142, 30)
        Me.Tim2.TabIndex = 7
        '
        'Tim1
        '
        Me.Tim1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tim1.FormattingEnabled = True
        Me.Tim1.Location = New System.Drawing.Point(118, 15)
        Me.Tim1.Name = "Tim1"
        Me.Tim1.Size = New System.Drawing.Size(142, 30)
        Me.Tim1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tim D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tim C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tim B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tim A"
        '
        'ConditionScores
        '
        Me.ConditionScores.Controls.Add(Me.Label8)
        Me.ConditionScores.Controls.Add(Me.Label7)
        Me.ConditionScores.Controls.Add(Me.SkorSalah)
        Me.ConditionScores.Controls.Add(Me.SkorBenar)
        Me.ConditionScores.Controls.Add(Me.Label6)
        Me.ConditionScores.Controls.Add(Me.Label5)
        Me.ConditionScores.Location = New System.Drawing.Point(4, 25)
        Me.ConditionScores.Name = "ConditionScores"
        Me.ConditionScores.Padding = New System.Windows.Forms.Padding(3)
        Me.ConditionScores.Size = New System.Drawing.Size(338, 200)
        Me.ConditionScores.TabIndex = 1
        Me.ConditionScores.Text = "Pengaturan Skor"
        Me.ConditionScores.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Skor Salah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Skor Benar"
        '
        'SkorSalah
        '
        Me.SkorSalah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkorSalah.Location = New System.Drawing.Point(186, 109)
        Me.SkorSalah.MaxLength = 3
        Me.SkorSalah.Name = "SkorSalah"
        Me.SkorSalah.Size = New System.Drawing.Size(100, 28)
        Me.SkorSalah.TabIndex = 3
        '
        'SkorBenar
        '
        Me.SkorBenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkorBenar.Location = New System.Drawing.Point(186, 56)
        Me.SkorBenar.MaxLength = 3
        Me.SkorBenar.Name = "SkorBenar"
        Me.SkorBenar.Size = New System.Drawing.Size(100, 28)
        Me.SkorBenar.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 0
        '
        'TimerSetup
        '
        Me.TimerSetup.Controls.Add(Me.Waktu)
        Me.TimerSetup.Controls.Add(Me.RadioButton2)
        Me.TimerSetup.Controls.Add(Me.RadioButton1)
        Me.TimerSetup.Location = New System.Drawing.Point(4, 25)
        Me.TimerSetup.Name = "TimerSetup"
        Me.TimerSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.TimerSetup.Size = New System.Drawing.Size(338, 200)
        Me.TimerSetup.TabIndex = 2
        Me.TimerSetup.Text = "Pengaturan Timer"
        Me.TimerSetup.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(91, 99)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 27)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Custom"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(91, 61)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(154, 27)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Default (1 detik)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(94, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "LAUNCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Waktu
        '
        Me.Waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waktu.Location = New System.Drawing.Point(205, 98)
        Me.Waktu.MaxLength = 1
        Me.Waktu.Name = "Waktu"
        Me.Waktu.Size = New System.Drawing.Size(42, 28)
        Me.Waktu.TabIndex = 7
        '
        'PrepareBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 294)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrepareBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengaturan Papan Skor"
        Me.TabControl1.ResumeLayout(False)
        Me.TeamPage.ResumeLayout(False)
        Me.TeamPage.PerformLayout()
        Me.ConditionScores.ResumeLayout(False)
        Me.ConditionScores.PerformLayout()
        Me.TimerSetup.ResumeLayout(False)
        Me.TimerSetup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TeamPage As System.Windows.Forms.TabPage
    Friend WithEvents Tim4 As System.Windows.Forms.ComboBox
    Friend WithEvents Tim3 As System.Windows.Forms.ComboBox
    Friend WithEvents Tim2 As System.Windows.Forms.ComboBox
    Friend WithEvents Tim1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ConditionScores As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SkorBenar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PenghitungCheck As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SkorSalah As System.Windows.Forms.TextBox
    Friend WithEvents TimerSetup As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Waktu As System.Windows.Forms.TextBox
End Class
