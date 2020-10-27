Public Class UsuariosE
    Private _id As Integer
    Private _idLocal As Integer
    Private _idEmpleado As Integer
    Private _usuario As String
    Private _clave As String
    Private _tipo As String
    Private _estado As Integer
    Private _fecReg As Date


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

    Public Property idEmpleado() As Integer
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As Integer)
            _idEmpleado = value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
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

    Public Property fecReg() As Date
        Get
            Return _fecReg
        End Get
        Set(ByVal value As Date)
            _fecReg = value
        End Set
    End Property
End Class
