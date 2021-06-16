Public Class FormKasir
    Private Sub RefreshGridid()
        DTGrid = KontrolKasir.tampilData.ToTable
        DGKasir.DataSource = DTGrid
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class