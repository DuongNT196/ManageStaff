Public Class StaffModel
    Dim _idStaff As Integer
    Dim _firstName As String
    Dim _lastName As String
    Dim _birthday As Date
    Dim _age As Integer
    Dim _sex As Boolean
    Dim _address As String
    Dim _idRank As Integer
    Dim _idDivision As Integer

    Public Sub New()

    End Sub
    Public Sub New(ByVal idStaff As Integer, ByVal firstName As String, ByVal lastName As String, ByVal birthday As Date, ByVal age As Integer, ByVal sex As Boolean, ByVal address As String, ByVal idRank As Integer, ByVal idDivision As Integer)
        Me._idStaff = idStaff
        Me._firstName = firstName
        Me._lastName = lastName
        Me._birthday = birthday
        Me._age = age
        Me._sex = sex
        Me._address = address
        Me._idRank = idRank
        Me._idDivision = idDivision
    End Sub

    Public Property IdStaff As Integer
        Get
            Return _idStaff
        End Get
        Set(value As Integer)
            _idStaff = value
        End Set
    End Property
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _idStaff = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Public Property Birthday As Date
        Get
            Return _birthday
        End Get
        Set(value As Date)
            _birthday = value
        End Set
    End Property
    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property
    Public Property Sex As Boolean
        Get
            Return _sex
        End Get
        Set(value As Boolean)
            _sex = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Public Property IdRank As Integer
        Get
            Return _idRank
        End Get
        Set(value As Integer)
            _idRank = value
        End Set
    End Property
    Public Property IdDivision As Integer
        Get
            Return _idDivision
        End Get
        Set(value As Integer)
            _idDivision = value
        End Set
    End Property
End Class
