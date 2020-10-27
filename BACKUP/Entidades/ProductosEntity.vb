Public Class ProductosEntity
    Private _id As Integer
    Private _id_categoria As Integer
    Private _id_marca As Integer
    Private _id_modelo As Integer
    Private _id_material As Integer
    Private _id_temporada As Integer
    Private _id_genero As Integer
    Private _id_unidad As Integer
    Private _id_color As Integer
    Private _num_serie As String
    Private _cod_barra As String
    Private _imagen As String
    Private _web As Integer
    Private _id_usuario As Integer
    Private _estado As Integer

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property id_categoria() As Integer
        Get
            Return _id_categoria
        End Get
        Set(ByVal value As Integer)
            _id_categoria = value
        End Set
    End Property

    Public Property id_marca() As Integer
        Get
            Return _id_marca
        End Get
        Set(ByVal value As Integer)
            _id_marca = value
        End Set
    End Property

    Public Property id_modelo() As Integer
        Get
            Return _id_modelo
        End Get
        Set(ByVal value As Integer)
            _id_modelo = value
        End Set
    End Property

    Public Property id_material() As Integer
        Get
            Return _id_material
        End Get
        Set(ByVal value As Integer)
            _id_material = value
        End Set
    End Property

    Public Property id_temporada() As Integer
        Get
            Return _id_temporada
        End Get
        Set(ByVal value As Integer)
            _id_temporada = value
        End Set
    End Property

    Public Property id_genero() As Integer
        Get
            Return _id_genero
        End Get
        Set(ByVal value As Integer)
            _id_genero = value
        End Set
    End Property

    Public Property id_unidad() As Integer
        Get
            Return _id_unidad
        End Get
        Set(ByVal value As Integer)
            _id_unidad = value
        End Set
    End Property

    Public Property id_color() As Integer
        Get
            Return _id_color
        End Get
        Set(ByVal value As Integer)
            _id_color = value
        End Set
    End Property

    Public Property num_serie() As String
        Get
            Return _num_serie
        End Get
        Set(ByVal value As String)
            _num_serie = value
        End Set
    End Property

    Public Property cod_barra() As String
        Get
            Return _cod_barra
        End Get
        Set(ByVal value As String)
            _cod_barra = value
        End Set
    End Property

    Public Property imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property

    Public Property web() As Integer
        Get
            Return _web
        End Get
        Set(ByVal value As Integer)
            _web = value
        End Set
    End Property

    Public Property id_usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property
End Class
