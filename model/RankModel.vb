Public Class RankModel
    Dim _idRank As Integer
    Dim _name As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal idRank As Integer, ByVal name As String)
        Me._idRank = idRank
        Me._name = name
    End Sub

    Public Property IdRank As Integer
        Get
            Return _idRank
        End Get
        Set(value As Integer)
            _idRank = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
End Class