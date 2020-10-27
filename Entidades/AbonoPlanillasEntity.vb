Public Class AbonoPlanillasEntity
    Private _id As Integer
    Private _tipo_comprobante As String
    Private _id_personal As String
    Private _id_planilla As String
    Private _id_caja As String
    Private _cuenta As String
    Private _base_imponible As Decimal
    Private _monto As Decimal
    Private _tipo As String
    Private _numero As String
    Private _descripcion As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _fecha As Date
    Private _estado As String


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
    Public Property id_planilla() As String
        Get
            Return _id_planilla
        End Get
        Set(ByVal value As String)
            _id_planilla = value
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
    Public Property id_personal() As String
        Get
            Return _id_personal
        End Get
        Set(ByVal value As String)
            _id_personal = value
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
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Public Property base_imponible() As Decimal
        Get
            Return _base_imponible
        End Get
        Set(ByVal value As Decimal)
            _base_imponible = value
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
    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
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
End Class

