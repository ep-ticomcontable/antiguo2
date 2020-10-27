Public Class ClientesEntity
    Private _id As Integer
    Private _idLocal As Integer
    Private _nombres As String
    Private _apellidos As String
    Private _estado As Integer


    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property idLocal() As Integer
        Get
            Return _idLocal
        End Get
        Set(ByVal value As Integer)
            _idLocal = value
        End Set
    End Property

    Public Property nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property

    Public Property apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property


    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
End Class
