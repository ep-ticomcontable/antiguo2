Public Class CanjeLetraEntity
    Private _id As Integer
    Private _tipo_comprobante As String
    Private _estado_deuda As String
    Private _id_comprobante As String
    Private _serie As String
    Private _numero As String
    Private _librado As String
    Private _aval As String
    Private _direccion As String
    Private _lugar_giro As String
    Private _monto As Decimal
    Private _fecha_emision As Date
    Private _fecha_vencimiento As Date
    Private _estado As Integer

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property tipo_comprobante() As String
        Get
            Return _tipo_comprobante
        End Get
        Set(ByVal value As String)
            _tipo_comprobante = value
        End Set
    End Property
    Public Property estado_deuda() As String
        Get
            Return _estado_deuda
        End Get
        Set(ByVal value As String)
            _estado_deuda = value
        End Set
    End Property
    Public Property id_comprobante() As String
        Get
            Return _id_comprobante
        End Get
        Set(ByVal value As String)
            _id_comprobante = value
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
    Public Property librado() As String
        Get
            Return _librado
        End Get
        Set(ByVal value As String)
            _librado = value
        End Set
    End Property
    Public Property aval() As String
        Get
            Return _aval
        End Get
        Set(ByVal value As String)
            _aval = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Public Property lugar_giro() As String
        Get
            Return _lugar_giro
        End Get
        Set(ByVal value As String)
            _lugar_giro = value
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
    Public Property fecha_emision() As Date
        Get
            Return _fecha_emision
        End Get
        Set(ByVal value As Date)
            _fecha_emision = value
        End Set
    End Property
    Public Property fecha_vencimiento() As Date
        Get
            Return _fecha_vencimiento
        End Get
        Set(ByVal value As Date)
            _fecha_vencimiento = value
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