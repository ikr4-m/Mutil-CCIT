Public Class PrepareBox

    Private Sub PrepareBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Membaca path file dari resou  rces
        Dim path As String = Application.UserAppDataPath
        Dim DBTeam As String = System.IO.Path.Combine(path, "teamlist.txt")

        ' Masukkan file yang telah dibaca kedalam ComboBox
        System.IO.File.WriteAllText(DBTeam, My.Resources.teamlist)
        Tim1.Items.AddRange(System.IO.File.ReadAllLines(DBTeam))
        Tim2.Items.AddRange(System.IO.File.ReadAllLines(DBTeam))
        Tim3.Items.AddRange(System.IO.File.ReadAllLines(DBTeam))
        Tim4.Items.AddRange(System.IO.File.ReadAllLines(DBTeam))

        'Enabled
        Tim1.Enabled = False
        Tim2.Enabled = False
        Tim3.Enabled = False
        Tim4.Enabled = False

        'Visible
        PenghitungCheck.Visible = False

        ' Persiapan bilamana OperatorBox menekan tombol Close
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked

        ' Default value skor
        SkorBenar.Text = 100
        SkorSalah.Text = 100

        ' Disable waktu
        Waktu.Enabled = False
    End Sub

    Public LaunchForm As New Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Nyortir Form, daripada ribet buat pengulangan lagi
        ' Jangan ada yang kosong di antara kita... UwU
        Dim ErrorJudul As String = "Galat"
        Dim ErrorIsi As String = "Isian masih kosong!"
        If Val(PenghitungCheck.Text) = 1 Then
            If Tim1.Text = "" Then
                MessageBox.Show(ErrorIsi, ErrorJudul, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Butuh satu tim lagi!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf Val(PenghitungCheck.Text) = 2 Then
            If Tim1.Text = "" Or Tim2.Text = "" Then
                MessageBox.Show(ErrorIsi, ErrorJudul, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                LaunchForm = LeaderBoard_2P
                RealLaunch()
            End If
        ElseIf Val(PenghitungCheck.Text) = 3 Then
            If Tim1.Text = "" Or Tim2.Text = "" Or Tim3.Text = "" Then
                MessageBox.Show(ErrorIsi, ErrorJudul, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                LaunchForm = LeaderBoard_3P
                RealLaunch()
            End If
        ElseIf Val(PenghitungCheck.Text) = 4 Then
            If Tim1.Text = "" Or Tim2.Text = "" Or Tim3.Text = "" Or Tim4.Text = "" Then
                MessageBox.Show(ErrorIsi, ErrorJudul, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                LaunchForm = LeaderBoard_4P
                RealLaunch()
            End If
        Else
            MessageBox.Show("Isian masih kosong!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub RealLaunch()
        ' Ngitung Monitor
        Dim JumlahMonitor As Integer = Screen.AllScreens.Length
        If JumlahMonitor > 1 Then
            MsgBox("Proyektor terdeteksi!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            OperatorBox.Show()

            ' Para pemindah monitor
            Dim screen As Screen = screen.AllScreens(1)
            LaunchForm.StartPosition = FormStartPosition.Manual
            LaunchForm.Location = screen.Bounds.Location + New Point(100, 100)
            LaunchForm.Show()

            Me.Hide()
        Else
            MsgBox("Sayangnya, proyektor tidak terdeteksi. Silahkan ubah ke mode Extended, bukan mode Duplicate" _
                , MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub

    'Fungsi list
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tim1.SelectedIndexChanged
        Dim ListCombo As New List(Of String) From {Tim2.Text, Tim3.Text, Tim4.Text}
        If Tim1.Text = "" Then
        ElseIf ListCombo.Contains(Tim1.Text) Then
            MessageBox.Show("Tim tidak boleh kembar!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tim2.SelectedIndexChanged
        Dim ListCombo As New List(Of String) From {Tim1.Text, Tim3.Text, Tim4.Text}
        If Tim2.Text = "" Then
        ElseIf ListCombo.Contains(Tim2.Text) Then
            MessageBox.Show("Tim tidak boleh kembar!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tim3.SelectedIndexChanged
        Dim ListCombo As New List(Of String) From {Tim2.Text, Tim1.Text, Tim4.Text}
        If Tim3.Text = "" Then
        ElseIf ListCombo.Contains(Tim3.Text) Then
            MessageBox.Show("Tim tidak boleh kembar!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tim4.SelectedIndexChanged
        Dim ListCombo As New List(Of String) From {Tim2.Text, Tim3.Text, Tim1.Text}
        If Tim4.Text = "" Then
        ElseIf ListCombo.Contains(Tim4.Text) Then
            MessageBox.Show("Tim tidak boleh kembar!", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Logika Player
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Tim1.Enabled = True
            PenghitungCheck.Text = Val(PenghitungCheck.Text) + 1
        Else
            Tim1.Enabled = False
            PenghitungCheck.Text = Val(PenghitungCheck.Text) - 1
            Tim1.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Tim2.Enabled = True
            PenghitungCheck.Text = Val(PenghitungCheck.Text) + 1
        Else
            Tim2.Enabled = False
            PenghitungCheck.Text = Val(PenghitungCheck.Text) - 1
            Tim2.Text = ""
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Tim3.Enabled = True
            PenghitungCheck.Text = Val(PenghitungCheck.Text) + 1
        Else
            Tim3.Enabled = False
            PenghitungCheck.Text = Val(PenghitungCheck.Text) - 1
            Tim3.Text = ""
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Tim4.Enabled = True
            PenghitungCheck.Text = Val(PenghitungCheck.Text) + 1
        Else
            Tim4.Enabled = False
            PenghitungCheck.Text = Val(PenghitungCheck.Text) - 1
            Tim4.Text = ""
        End If
    End Sub

    Dim SkorPesan As String = "Hanya dapat diisi oleh angka saja"
    Dim SkorPesan2 As String = "Skor hanya dapat diisi hingga 999"
    Dim SkorJudul As String = "Galat"

    Private Sub SkorBenar_TextChanged(sender As Object, e As EventArgs) Handles SkorBenar.TextChanged
        If IsNumeric(SkorBenar.Text) Then
        ElseIf SkorBenar.Text = "" Then
        Else
            MessageBox.Show(SkorPesan, SkorJudul, MessageBoxButtons.OK, MessageBoxIcon.Error)
            SkorBenar.Text = ""
        End If
    End Sub

    Private Sub SkorSalah_TextChanged(sender As Object, e As EventArgs) Handles SkorSalah.TextChanged
        If IsNumeric(SkorSalah.Text) Then
        ElseIf SkorSalah.Text = "" Then
        Else
            MessageBox.Show(SkorPesan, SkorJudul, MessageBoxButtons.OK, MessageBoxIcon.Error)
            SkorSalah.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Waktu.Enabled = True
        Else
            Waktu.Enabled = False
        End If
    End Sub
End Class