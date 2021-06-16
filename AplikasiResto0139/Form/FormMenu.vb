Public Class FormMenu
    Private Sub RefreshGridid()
        DTGrid = KontrolMenu.tampilData.ToTable
        DGMenu.DataSource = DTGrid
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGridid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class