Public Class TablaContenidoEntity
    Private _id As Integer
    Private _idLocal As Integer
    Private _idTabla As Integer
    Private _descripcion As String
    Private _abreviatura As String
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

    Public Property idTabla() As Integer
        Get
            Return _idTabla
        End Get
        Set(ByVal value As Integer)
            _idTabla = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property abreviatura() As String
        Get
            Return _abreviatura
        End Get
        Set(ByVal value As String)
            _abreviatura = value
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
