Public Class ImpuestosSunatEntity
    Private _id As Integer
    Private _operacion As String
    Private _id_impuesto As Integer
    Private _serie As Integer
    Private _numero As Integer
    Private _id_tipo_comprobante As String
    Private _tipo_comprobante As String
    Private _total_comprobante As Decimal
    Private _descripcion As String
    Private _porcentaje As Decimal
    Private _monto As Decimal
    Private _cuenta As String
    Private _estado As String

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property operacion() As String
        Get
            Return _operacion
        End Get
        Set(ByVal value As String)
            _operacion = value
        End Set
    End Property
    Public Property id_impuesto() As Integer
        Get
            Return _id_impuesto
        End Get
        Set(ByVal value As Integer)
            _id_impuesto = value
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
    Public Property id_tipo_comprobante() As String
        Get
            Return _id_tipo_comprobante
        End Get
        Set(ByVal value As String)
            _id_tipo_comprobante = value
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
    Public Property total_comprobante() As Decimal
        Get
            Return _total_comprobante
        End Get
        Set(ByVal value As Decimal)
            _total_comprobante = value
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
    Public Property porcentaje() As Decimal
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Decimal)
            _porcentaje = value
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
    Public Property cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
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

