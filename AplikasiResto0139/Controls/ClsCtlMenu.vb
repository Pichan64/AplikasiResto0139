Imports System.Data.Odbc
Public Class ClsCtlMenu : Implements InfProses

    Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Function kodebaru() As String
        Throw New NotImplementedException()
    End Function

    Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("Select * from menu", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Menu")
            Dim grid As New DataView(DTS.Tables("Tabel_Menu"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

End Class
