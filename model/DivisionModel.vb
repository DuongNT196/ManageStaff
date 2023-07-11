Public Class DivisionModel
    Dim _idDivision As Integer
    Dim _name As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal idDivision As Integer, ByVal name As String)
        Me._idDivision = idDivision
        Me._name = name
    End Sub

    Public Property IdDivision As Integer
        Get
            Return _idDivision
        End Get
        Set(value As Integer)
            _idDivision = value
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