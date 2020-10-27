Public Class ConciliacionEntity
    Private _id As Integer
    Private _periodo As String
    Private _id_abono As String
    Private _concepto As String
    Private _tipo As String
    Private _numero As String
    Private _monto As Decimal
    Private _r1 As Decimal
    Private _r2 As Decimal
    Private _saldo As Decimal
    Private _verificador As String
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
    Public Property id_abono() As String
        Get
            Return _id_abono
        End Get
        Set(ByVal value As String)
            _id_abono = value
        End Set
    End Property
    Public Property periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property
    Public Property concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
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
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Public Property r1() As Decimal
        Get
            Return _r1
        End Get
        Set(ByVal value As Decimal)
            _r1 = value
        End Set
    End Property
    Public Property r2() As Decimal
        Get
            Return _r2
        End Get
        Set(ByVal value As Decimal)
            _r2 = value
        End Set
    End Property
    Public Property saldo() As Decimal
        Get
            Return _saldo
        End Get
        Set(ByVal value As Decimal)
            _saldo = value
        End Set
    End Property
    Public Property verificador() As String
        Get
            Return _verificador
        End Get
        Set(ByVal value As String)
            _verificador = value
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
    Public Property estado() As Decimal
        Get
            Return _estado
        End Get
        Set(ByVal value As Decimal)
            _estado = value
        End Set
    End Property
End Class

