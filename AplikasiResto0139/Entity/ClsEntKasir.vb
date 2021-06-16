Public Class ClsEntKasir
    Private _idKasir As String
    Private _namaKasir As String
    Private _userID As String
    Private _pass As String
    Private _LevelKasir As String

    Public Property IdKasir As String
        Get
            Return _idKasir
        End Get
        Set(value As String)
            _idKasir = value
        End Set
    End Property

    Public Property NamaKasir As String
        Get
            Return _namaKasir
        End Get
        Set(value As String)
            _namaKasir = value
        End Set
    End Property

    Public Property UserId As String
        Get
            Return _userID
        End Get
        Set(value As String)
            _userID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Property LevelKasir As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property
End Class
