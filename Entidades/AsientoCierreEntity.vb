Public Class AsientoCierreEntity
    Private _id As Integer
    Private _id_cierre As Integer
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _glosa As String
    Private _id_doc As Integer
    Private _num_doc As String
    Private _fec_emision As Date


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

    Public Property id_cierre() As Integer
        Get
            Return _id_cierre
        End Get
        Set(ByVal value As Integer)
            _id_cierre = value
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

    
    Public Property glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property id_doc() As Integer
        Get
            Return _id_doc
        End Get
        Set(ByVal value As Integer)
            _id_doc = value
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

