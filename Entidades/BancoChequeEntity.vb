Public Class BancoChequeEntity
    Private _id As Integer
    Private _id_cheque As String
    Private _numero As Integer
    Private _id_banco As String
    Private _id_moneda As String
    Private _cuenta As String
    Private _monto As Decimal
    Private _glosa As String
    Private _nomenclatura As String
    Private _fec_emision As Date
    Private _fec_pago As Date
    Private _estado As Integer

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property id_cheque() As String
        Get
            Return _id_cheque
        End Get
        Set(ByVal value As String)
            _id_cheque = value
        End Set
    End Property
    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property
    Public Property id_banco() As String
        Get
            Return _id_banco
        End Get
        Set(ByVal value As String)
            _id_banco = value
        End Set
    End Property
    Public Property id_moneda() As String
        Get
            Return _id_moneda
        End Get
        Set(ByVal value As String)
            _id_moneda = value
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
    Public Property glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property
    Public Property nomenclatura() As String
        Get
            Return _nomenclatura
        End Get
        Set(ByVal value As String)
            _nomenclatura = value
        End Set
    End Property
    Public Property fec_emision() As Date
        Get
            Return _fec_emision
        End Get
        Set(ByVal value As Date)
            _fec_emision = value
        End Set
    End Property
    Public Property fec_pago() As Date
        Get
            Return _fec_pago
        End Get
        Set(ByVal value As Date)
            _fec_pago = value
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

