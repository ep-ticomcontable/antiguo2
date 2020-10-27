Public Class RetencionEntity
    Private _id As Integer
    Private _operacion As String
    Private _serie As String
    Private _numero As String
    Private _glosa As String
    Private _fec_reg As Date
    Private _id_comprobante As Integer
    Private _total As Decimal
    Private _monto As Decimal
    Private _tipo As String
    Private _estado As String


    '--GET's y SET's

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

    Public Property glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property fec_reg() As Date
        Get
            Return _fec_reg
        End Get
        Set(ByVal value As Date)
            _fec_reg = value
        End Set
    End Property

    Public Property id_comprobante() As Integer
        Get
            Return _id_comprobante
        End Get
        Set(ByVal value As Integer)
            _id_comprobante = value
        End Set
    End Property

    Public Property total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
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


End Class

