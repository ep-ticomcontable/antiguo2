Public Class DetalleAAperturaEntity
    Private _id As Integer
    Private _id_asiento_apertura As Integer
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _id_moneda As Integer
    Private _tipo_cambio As Decimal
    Private _glosa As String
    Private _id_doc_cont As Integer
    Private _num_doc As String
    Private _fec_emision As Date
    Private _id_empresa As Integer
    Private _id_usuario As Integer

    Public Property id_empresa() As Integer
        Get
            Return _id_empresa
        End Get
        Set(ByVal value As Integer)
            _id_empresa = value
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
    
    Public Property fec_emision() As Date
        Get
            Return _fec_emision
        End Get
        Set(ByVal value As Date)
            _fec_emision = value
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

    Public Property id_asiento_apertura() As Integer
        Get
            Return _id_asiento_apertura
        End Get
        Set(ByVal value As Integer)
            _id_asiento_apertura = value
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

    Public Property id_moneda() As Integer
        Get
            Return _id_moneda
        End Get
        Set(ByVal value As Integer)
            _id_moneda = value
        End Set
    End Property

    Public Property tipo_cambio() As Decimal
        Get
            Return _tipo_cambio
        End Get
        Set(ByVal value As Decimal)
            _tipo_cambio = value
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

    Public Property id_doc_cont() As Integer
        Get
            Return _id_doc_cont
        End Get
        Set(ByVal value As Integer)
            _id_doc_cont = value
        End Set
    End Property

    Public Property num_doc() As String
        Get
            Return _num_doc
        End Get
        Set(ByVal value As String)
            _num_doc = value
        End Set
    End Property

End Class

