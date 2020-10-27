Public Class AbonosComodin
    Private _id As Integer
    Private _id_comodin As String
    Private _monto As Decimal
    Private _id_caja As String
    Private _id_tipo As String
    Private _numero As String
    Private _glosa As String
    Private _fec_reg As Date
    Private _estado As String
    Private _id_abono_comodin As String
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal

    '--GET's y SET's
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property id_comodin() As String
        Get
            Return _id_comodin
        End Get
        Set(ByVal value As String)
            _id_comodin = value
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
    Public Property id_caja() As String
        Get
            Return _id_caja
        End Get
        Set(ByVal value As String)
            _id_caja = value
        End Set
    End Property
    Public Property id_tipo() As String
        Get
            Return _id_tipo
        End Get
        Set(ByVal value As String)
            _id_tipo = value
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
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
    Public Property id_abono_comodin() As String
        Get
            Return _id_abono_comodin
        End Get
        Set(ByVal value As String)
            _id_abono_comodin = value
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
End Class

