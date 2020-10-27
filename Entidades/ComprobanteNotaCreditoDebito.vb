Public Class ComprobanteNotaCreditoDebito
    Private _id As Integer
    Private _id_comprobante As String
    Private _id_nota_credito As Integer
    Private _numero_cuo As Integer
    Private _serie As String
    Private _numero As String
    Private _fec_emision As Date
    Private _serie_ref As String
    Private _numero_ref As String
    Private _num_dni As String
    Private _razon_social As String
    Private _glosa As String
    Private _monto As Decimal
    Private _valor_igv As Decimal
    Private _total As Decimal
    Private _motivo As String
    Private _comentario As String
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _estado As Integer
    Private _tipo As String

    Public Property id_comprobante() As String
        Get
            Return _id_comprobante
        End Get
        Set(ByVal value As String)
            _id_comprobante = value
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

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property id_nota_credito() As Integer
        Get
            Return _id_nota_credito
        End Get
        Set(ByVal value As Integer)
            _id_nota_credito = value
        End Set
    End Property
    Public Property numero_cuo() As Integer
        Get
            Return _numero_cuo
        End Get
        Set(ByVal value As Integer)
            _numero_cuo = value
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
    Public Property fec_emision() As Date
        Get
            Return _fec_emision
        End Get
        Set(ByVal value As Date)
            _fec_emision = value
        End Set
    End Property
    Public Property serie_ref() As String
        Get
            Return _serie_ref
        End Get
        Set(ByVal value As String)
            _serie_ref = value
        End Set
    End Property
    Public Property numero_ref() As String
        Get
            Return _numero_ref
        End Get
        Set(ByVal value As String)
            _numero_ref = value
        End Set
    End Property
    Public Property num_dni() As String
        Get
            Return _num_dni
        End Get
        Set(ByVal value As String)
            _num_dni = value
        End Set
    End Property
    Public Property razon_social() As String
        Get
            Return _razon_social
        End Get
        Set(ByVal value As String)
            _razon_social = value
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
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
    Public Property valor_igv() As Decimal
        Get
            Return _valor_igv
        End Get
        Set(ByVal value As Decimal)
            _valor_igv = value
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
    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property
    Public Property comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
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
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
End Class