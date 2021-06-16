Public Class FormKategori
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = st
    End Sub
    Private Sub RefreshGridid()
        DTGrid = KontrolKategori.tampilData.ToTable
        DGKategori.DataSource = DTGrid
    End Sub

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class