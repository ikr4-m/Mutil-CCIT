Public Class LeaderBoard_2P

    ' Memperbesar komponen secara dinamis
    ' Ingat, kudu pake As New agar dapat dibuat kembali classnya
    Dim besar As New Resizer
    Private Sub LeaderBoard_2P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        besar.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized

        ' Commit nama pemain
        ATim.Text = PrepareBox.Tim1.Text
        BTim.Text = PrepareBox.Tim2.Text

        Mode.Text = OperatorBox.Intro
    End Sub

    Private Sub LeaderBoard_2P_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        besar.ResizeAllControls(Me)
    End Sub
End Class