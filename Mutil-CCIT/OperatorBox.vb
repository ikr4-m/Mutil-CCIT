Public Class OperatorBox

    ' Ambil tanggal sekarang
    Public Intro As String = "Cerdas Cermat IT " + DateTime.Now.ToString("yyyy") + " SMK Mutiara ilmu"
    'Cara mencari ukuran resolusi monitor
    Public Function CariMonitor1() As String
        Dim resX_1 As Integer = Screen.AllScreens(1).Bounds.Width
        Dim resY_1 As Integer = Screen.AllScreens(1).Bounds.Height
        Return resX_1 & " X " & resY_1
    End Function

    Dim Player As Integer
    Dim StatusGame As String
    Dim PanasStatusGame As String
    Public SkorPlus As Integer
    Public SkorMin As Integer
    Dim PlusTick As Integer
    Dim MinTick As Integer
    Private Sub OperatorBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Status reso papan + status papan
        ResoStatus.Text = "Status: Berjalan pada resolusi " + CariMonitor1()
        StatusGame = "Siap dijalankan!"
        PanasStatusGame = "Status Permainan: "
        GameStatus.Text = PanasStatusGame + StatusGame

        'Ambil poin
        SkorPlus = PrepareBox.SkorBenar.Text
        SkorMin = PrepareBox.SkorSalah.Text

        'Kondisi awal nama
        Tim1Nama.Text = ""
        Tim2Nama.Text = ""
        Tim3Nama.Text = ""
        Tim4Nama.Text = ""

        'Nampilin nama
        Tim1Nama.Text = PrepareBox.Tim1.Text
        Tim2Nama.Text = PrepareBox.Tim2.Text
        Tim3Nama.Text = PrepareBox.Tim3.Text
        Tim4Nama.Text = PrepareBox.Tim4.Text

        'Disable ALL button
        Default1.Enabled = False
        Default2.Enabled = False
        Default3.Enabled = False
        Default4.Enabled = False
        Tim1Plus.Enabled = False
        Tim2Plus.Enabled = False
        Tim3Plus.Enabled = False
        Tim4Plus.Enabled = False
        Tim1Min.Enabled = False
        Tim2Min.Enabled = False
        Tim3Min.Enabled = False
        Tim4Min.Enabled = False

        'Tentukan pemain
        If Val(PrepareBox.PenghitungCheck.Text) = 2 Then
            Player = 2
        ElseIf Val(PrepareBox.PenghitungCheck.Text) = 3 Then
            Player = 3
        ElseIf Val(PrepareBox.PenghitungCheck.Text) = 4 Then
            Player = 4
        End If

        'Timer
        If PrepareBox.RadioButton2.Checked = True Then
            PlusTick = Val(PrepareBox.Waktu.Text) * 1000
            MinTick = Val(PrepareBox.Waktu.Text) * 1000
        Else
            PlusTick = 1000
            MinTick = 1000
        End If
        WhenClickingMin.Interval = MinTick
        WhenClickingPlus.Interval = PlusTick

        'Kopiret
        Kopiret.Text = "© 2018-" + DateTime.Now.ToString("yyyy") + " SMK Mutiara Ilmu Makassar, github/skymunn. All rights reserved."
    End Sub

    Private Sub ExitBut_Click(sender As Object, e As EventArgs) Handles ExitBut.Click
        If MessageBox.Show("Yakin mau keluar?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PrepareBox.LaunchForm.Close()
            PrepareBox.Show()
            Me.Close()
        End If
    End Sub

    ' Deklarasi mode
    Private Sub tblKelompok_Click(sender As Object, e As EventArgs) Handles tblKelompok.Click
        ' Ubah status
        StatusGame = "Soal Kelompok"
        GameStatus.Text = PanasStatusGame + StatusGame

        ' Fungsi sebenarnya
        If Player = 2 Then
            LeaderBoard_2P.Mode.Text = StatusGame
            Default1.Enabled = True
            Default2.Enabled = True
            Default3.Enabled = False
            Default4.Enabled = False
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = False
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = False
            Tim4Min.Enabled = False
        ElseIf Player = 3 Then
            LeaderBoard_3P.Mode.Text = StatusGame
            Default1.Enabled = True
            Default2.Enabled = True
            Default3.Enabled = True
            Default4.Enabled = False
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = False
        ElseIf Player = 4 Then
            LeaderBoard_4P.Mode.Text = StatusGame
            Default1.Enabled = True
            Default2.Enabled = True
            Default3.Enabled = True
            Default4.Enabled = True
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = True
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = True
        End If
    End Sub

    Private Sub tblRebutan_Click(sender As Object, e As EventArgs) Handles tblRebutan.Click
        Default1.Enabled = False
        Default2.Enabled = False
        Default3.Enabled = False
        Default4.Enabled = False

        ' Ubah status
        StatusGame = "Soal Rebutan"
        GameStatus.Text = PanasStatusGame + StatusGame

        ' Fungsi sebenarnya
        If Player = 2 Then
            LeaderBoard_2P.Mode.Text = StatusGame
            LeaderBoard_2P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_2P.BPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = False
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = False
            Tim4Min.Enabled = False
        ElseIf Player = 3 Then
            LeaderBoard_3P.Mode.Text = StatusGame
            LeaderBoard_3P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.CPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = False
        ElseIf Player = 4 Then
            LeaderBoard_4P.Mode.Text = StatusGame
            LeaderBoard_4P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.CPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.DPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = True
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = True
        End If
    End Sub

    Private Sub tblBonus_Click(sender As Object, e As EventArgs) Handles tblBonus.Click
        Default1.Enabled = False
        Default2.Enabled = False
        Default3.Enabled = False
        Default4.Enabled = False

        ' Ubah status
        StatusGame = "Soal Bonus"
        GameStatus.Text = PanasStatusGame + StatusGame

        ' Fungsi sebenarnya
        If Player = 2 Then
            LeaderBoard_2P.Mode.Text = StatusGame
            LeaderBoard_2P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_2P.BPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = False
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = False
            Tim4Min.Enabled = False
        ElseIf Player = 3 Then
            LeaderBoard_3P.Mode.Text = StatusGame
            LeaderBoard_3P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.CPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = False
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = False
        ElseIf Player = 4 Then
            LeaderBoard_4P.Mode.Text = StatusGame
            LeaderBoard_4P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.CPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.DPanel.BackColor = SystemColors.GradientActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = True
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = True
        End If
    End Sub

    ' Penghitungan skor
    ' Sekalian ama ngewarnainnya
    Dim APlus As Boolean
    Dim BPlus As Boolean
    Dim CPlus As Boolean
    Dim DPlus As Boolean
    Dim AMin As Boolean
    Dim BMin As Boolean
    Dim CMin As Boolean
    Dim DMin As Boolean

    Private Sub Tim1Plus_Click(sender As Object, e As EventArgs) Handles Tim1Plus.Click
        Tim1Skor.Text = Val(Tim1Skor.Text) + SkorPlus
        If Player = 2 Then
            LeaderBoard_2P.ASkor.Text = Val(LeaderBoard_2P.ASkor.Text) + SkorPlus
        ElseIf Player = 3 Then
            LeaderBoard_3P.ASkor.Text = Val(LeaderBoard_3P.ASkor.Text) + SkorPlus
        ElseIf Player = 4 Then
            LeaderBoard_4P.ASkor.Text = Val(LeaderBoard_4P.ASkor.Text) + SkorPlus
        End If
        APlus = True
        Hijau()
    End Sub

    Private Sub Tim1Min_Click(sender As Object, e As EventArgs) Handles Tim1Min.Click
        Tim1Skor.Text = Val(Tim1Skor.Text) - SkorMin
        If Player = 2 Then
            LeaderBoard_2P.ASkor.Text = Val(LeaderBoard_2P.ASkor.Text) - SkorMin
        ElseIf Player = 3 Then
            LeaderBoard_3P.ASkor.Text = Val(LeaderBoard_3P.ASkor.Text) - SkorMin
        ElseIf Player = 4 Then
            LeaderBoard_4P.ASkor.Text = Val(LeaderBoard_4P.ASkor.Text) - SkorMin
        End If
        AMin = True
        Merah()
    End Sub

    Private Sub Tim2Plus_Click(sender As Object, e As EventArgs) Handles Tim2Plus.Click
        Tim2Skor.Text = Val(Tim2Skor.Text) + SkorPlus
        If Player = 2 Then
            LeaderBoard_2P.BSkor.Text = Val(LeaderBoard_2P.BSkor.Text) + SkorPlus
        ElseIf Player = 3 Then
            LeaderBoard_3P.BSkor.Text = Val(LeaderBoard_3P.BSkor.Text) + SkorPlus
        ElseIf Player = 4 Then
            LeaderBoard_4P.BSkor.Text = Val(LeaderBoard_4P.BSkor.Text) + SkorPlus
        End If
        BPlus = True
        Hijau()
    End Sub

    Private Sub Tim2Min_Click(sender As Object, e As EventArgs) Handles Tim2Min.Click
        Tim2Skor.Text = Val(Tim2Skor.Text) - SkorMin
        If Player = 2 Then
            LeaderBoard_2P.BSkor.Text = Val(LeaderBoard_2P.BSkor.Text) - SkorMin
        ElseIf Player = 3 Then
            LeaderBoard_3P.BSkor.Text = Val(LeaderBoard_3P.BSkor.Text) - SkorMin
        ElseIf Player = 4 Then
            LeaderBoard_4P.BSkor.Text = Val(LeaderBoard_4P.BSkor.Text) - SkorMin
        End If
        BMin = True
        Merah()
    End Sub

    Private Sub Tim3Plus_Click(sender As Object, e As EventArgs) Handles Tim3Plus.Click
        Tim3Skor.Text = Val(Tim3Skor.Text) + SkorPlus
        If Player = 3 Then
            LeaderBoard_3P.CSkor.Text = Val(LeaderBoard_3P.CSkor.Text) + SkorPlus
        ElseIf Player = 4 Then
            LeaderBoard_4P.CSkor.Text = Val(LeaderBoard_4P.CSkor.Text) + SkorPlus
        End If
        CPlus = True
        Hijau()
    End Sub

    Private Sub Tim3Min_Click(sender As Object, e As EventArgs) Handles Tim3Min.Click
        Tim3Skor.Text = Val(Tim3Skor.Text) - SkorMin
        If Player = 3 Then
            LeaderBoard_3P.CSkor.Text = Val(LeaderBoard_3P.CSkor.Text) - SkorMin
        ElseIf Player = 4 Then
            LeaderBoard_4P.CSkor.Text = Val(LeaderBoard_4P.CSkor.Text) - SkorMin
        End If
        CMin = True
        Merah()
    End Sub

    Private Sub Tim4Plus_Click(sender As Object, e As EventArgs) Handles Tim4Plus.Click
        Tim4Skor.Text = Val(Tim4Skor.Text) + SkorPlus
        LeaderBoard_4P.DSkor.Text = Val(LeaderBoard_4P.DSkor.Text) + SkorPlus
        DPlus = True
        Hijau()
    End Sub

    Private Sub Tim4Min_Click(sender As Object, e As EventArgs) Handles Tim4Min.Click
        Tim4Skor.Text = Val(Tim4Skor.Text) - SkorMin
        LeaderBoard_4P.DSkor.Text = Val(LeaderBoard_4P.DSkor.Text) - SkorPlus
        DMin = True
        Merah()
    End Sub

    Sub Hijau()
        If Player = 2 Then
            If APlus = True Then
                LeaderBoard_2P.ASkorPanel.BackColor = Color.Green
                APlus = False
                Tim1Plus.Enabled = False
            ElseIf BPlus = True Then
                LeaderBoard_2P.BSkorPanel.BackColor = Color.Green
                BPlus = False
                Tim2Plus.Enabled = False
            End If
        ElseIf Player = 3 Then
            If APlus = True Then
                LeaderBoard_3P.ASkorPanel.BackColor = Color.Green
                APlus = False
                Tim1Plus.Enabled = False
            ElseIf BPlus = True Then
                LeaderBoard_3P.BSkorPanel.BackColor = Color.Green
                BPlus = False
                Tim2Plus.Enabled = False
            ElseIf CPlus = True Then
                LeaderBoard_3P.CSkorPanel.BackColor = Color.Green
                CPlus = False
                Tim3Plus.Enabled = False
            End If
        ElseIf Player = 4 Then
            If APlus = True Then
                LeaderBoard_4P.ASkorPanel.BackColor = Color.Green
                APlus = False
                Tim1Plus.Enabled = False
            ElseIf BPlus = True Then
                LeaderBoard_4P.BSkorPanel.BackColor = Color.Green
                BPlus = False
                Tim2Plus.Enabled = False
            ElseIf CPlus = True Then
                LeaderBoard_4P.CSkorPanel.BackColor = Color.Green
                CPlus = False
                Tim3Plus.Enabled = False
            ElseIf DPlus = True Then
                LeaderBoard_4P.DSkorPanel.BackColor = Color.Green
                DPlus = False
                Tim4Plus.Enabled = False
            End If
        End If
        WhenClickingPlus.Start()
    End Sub

    Sub Merah()
        If Player = 2 Then
            If AMin = True Then
                LeaderBoard_2P.ASkorPanel.BackColor = Color.Red
                AMin = False
                Tim1Min.Enabled = False
            ElseIf BMin = True Then
                LeaderBoard_2P.BSkorPanel.BackColor = Color.Red
                BMin = False
                Tim2Min.Enabled = False
            End If
        ElseIf Player = 3 Then
            If AMin = True Then
                LeaderBoard_3P.ASkorPanel.BackColor = Color.Red
                AMin = False
                Tim1Min.Enabled = False
            ElseIf BMin = True Then
                LeaderBoard_3P.BSkorPanel.BackColor = Color.Red
                BMin = False
                Tim2Min.Enabled = False
            ElseIf CMin = True Then
                LeaderBoard_3P.CSkorPanel.BackColor = Color.Red
                CMin = False
                Tim3Plus.Enabled = False
            End If
        ElseIf Player = 4 Then
            If AMin = True Then
                LeaderBoard_4P.ASkorPanel.BackColor = Color.Red
                AMin = False
                Tim1Min.Enabled = False
            ElseIf BMin = True Then
                LeaderBoard_4P.BSkorPanel.BackColor = Color.Red
                BMin = False
                Tim2Min.Enabled = False
            ElseIf CMin = True Then
                LeaderBoard_4P.CSkorPanel.BackColor = Color.Red
                CMin = False
                Tim3Plus.Enabled = False
            ElseIf DMin = True Then
                LeaderBoard_4P.DSkorPanel.BackColor = Color.Red
                DMin = False
                Tim4Min.Enabled = False
            End If
        End If
        WhenClickingMin.Start()
    End Sub

    Private Sub WhenClickingPlus_Tick(sender As Object, e As EventArgs) Handles WhenClickingPlus.Tick
        If Player = 2 Then
            LeaderBoard_2P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_2P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
        ElseIf Player = 3 Then
            LeaderBoard_3P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_3P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_3P.CSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
        ElseIf Player = 4 Then
            LeaderBoard_4P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.CSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.DSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Plus.Enabled = True
            Tim2Plus.Enabled = True
            Tim3Plus.Enabled = True
            Tim4Plus.Enabled = True
        End If
        WhenClickingPlus.Stop()
    End Sub

    Private Sub WhenClickingMin_Tick(sender As Object, e As EventArgs) Handles WhenClickingMin.Tick
        If Player = 2 Then
            LeaderBoard_2P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_2P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
        ElseIf Player = 3 Then
            LeaderBoard_3P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_3P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_3P.CSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
        ElseIf Player = 4 Then
            LeaderBoard_4P.ASkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.BSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.CSkorPanel.BackColor = SystemColors.ActiveCaption
            LeaderBoard_4P.DSkorPanel.BackColor = SystemColors.ActiveCaption
            Tim1Min.Enabled = True
            Tim2Min.Enabled = True
            Tim3Min.Enabled = True
            Tim4Min.Enabled = True
        End If
        WhenClickingMin.Stop()
    End Sub

    'Deklarasi tombol berwarna merah
    Private Sub Default1_Click(sender As Object, e As EventArgs) Handles Default1.Click
        If Player = 2 Then
            Default1.Enabled = False
            Default2.Enabled = True
            Default3.Enabled = False
            Default4.Enabled = False
            LeaderBoard_2P.APanel.BackColor = Color.Red
            LeaderBoard_2P.BPanel.BackColor = SystemColors.GradientActiveCaption
        ElseIf Player = 3 Then
            Default1.Enabled = False
            Default2.Enabled = True
            Default3.Enabled = True
            Default4.Enabled = False
            LeaderBoard_3P.APanel.BackColor = Color.Red
            LeaderBoard_3P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.CPanel.BackColor = SystemColors.GradientActiveCaption
        ElseIf Player = 4 Then
            Default1.Enabled = False
            Default2.Enabled = True
            Default3.Enabled = True
            Default4.Enabled = True
            LeaderBoard_4P.APanel.BackColor = Color.Red
            LeaderBoard_4P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.CPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.DPanel.BackColor = SystemColors.GradientActiveCaption
        End If
    End Sub

    Private Sub Default2_Click(sender As Object, e As EventArgs) Handles Default2.Click
        If Player = 2 Then
            Default1.Enabled = True
            Default2.Enabled = False
            Default3.Enabled = False
            Default4.Enabled = False
            LeaderBoard_2P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_2P.BPanel.BackColor = Color.Red
        ElseIf Player = 3 Then
            Default1.Enabled = True
            Default2.Enabled = False
            Default3.Enabled = True
            Default4.Enabled = False
            LeaderBoard_3P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.BPanel.BackColor = Color.Red
            LeaderBoard_3P.CPanel.BackColor = SystemColors.GradientActiveCaption
        ElseIf Player = 4 Then
            Default1.Enabled = True
            Default2.Enabled = False
            Default3.Enabled = True
            Default4.Enabled = True
            LeaderBoard_4P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.BPanel.BackColor = Color.Red
            LeaderBoard_4P.CPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.DPanel.BackColor = SystemColors.GradientActiveCaption
        End If
    End Sub

    Private Sub Default3_Click(sender As Object, e As EventArgs) Handles Default3.Click
        If Player = 3 Then
            Default1.Enabled = True
            Default2.Enabled = True
            Default3.Enabled = False
            Default4.Enabled = False
            LeaderBoard_3P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_3P.CPanel.BackColor = Color.Red
        ElseIf Player = 4 Then
            Default1.Enabled = True
            Default2.Enabled = True
            Default3.Enabled = False
            Default4.Enabled = True
            LeaderBoard_4P.APanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.BPanel.BackColor = SystemColors.GradientActiveCaption
            LeaderBoard_4P.CPanel.BackColor = Color.Red
            LeaderBoard_4P.DPanel.BackColor = SystemColors.GradientActiveCaption
        End If
    End Sub

    Private Sub Default4_Click(sender As Object, e As EventArgs) Handles Default4.Click
        Default1.Enabled = True
        Default2.Enabled = True
        Default3.Enabled = True
        Default4.Enabled = False
        LeaderBoard_4P.APanel.BackColor = SystemColors.GradientActiveCaption
        LeaderBoard_4P.BPanel.BackColor = SystemColors.GradientActiveCaption
        LeaderBoard_4P.CPanel.BackColor = SystemColors.GradientActiveCaption
        LeaderBoard_4P.DPanel.BackColor = Color.Red
    End Sub
End Class