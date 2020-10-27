Public Class CajaEntity
    Private _id As Integer
    Private _id_caja As String
    Private _id_tipo_caja As String
    Private _id_tipo_salida As String
    Private _id_documento As String
    Private _serie As String
    Private _numero As String
    Private _dni_ruc As String
    Private _cliente As String
    Private _monto As Decimal
    Private _glosa As String
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _fecha As Date
    Private _estado As Integer
    Private _id_usuario As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property id_caja() As String
        Get
            Return _id_caja
        End Get
        Set(ByVal value As String)
            _id_caja = value
        End Set
    End Property
    Public Property id_tipo_caja() As String
        Get
            Return _id_tipo_caja
        End Get
        Set(ByVal value As String)
            _id_tipo_caja = value
        End Set
    End Property
    Public Property id_tipo_salida() As String
        Get
            Return _id_tipo_salida
        End Get
        Set(ByVal value As String)
            _id_tipo_salida = value
        End Set
    End Property
    Public Property id_documento() As String
        Get
            Return _id_documento
        End Get
        Set(ByVal value As String)
            _id_documento = value
        End Set
    End Property
    Public Property serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property
    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property
    Public Property dni_ruc() As String
        Get
            Return _dni_ruc
        End Get
        Set(ByVal value As String)
            _dni_ruc = value
        End Set
    End Property
    Public Property cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Public Property glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property
    Public Property cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property
    Public Property debe() As Decimal
        Get
            Return _debe
        End Get
        Set(ByVal value As Decimal)
            _debe = value
        End Set
    End Property
    Public Property haber() As Decimal
        Get
            Return _haber
        End Get
        Set(ByVal value As Decimal)
            _haber = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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
    Public Property id_usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property
End Class