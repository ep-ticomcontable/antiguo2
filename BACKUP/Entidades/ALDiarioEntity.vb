Public Class ALDiarioEntity
    Private _id As Integer
    Private _id_comprobante As String
    Private _cuo_electronico As String
    Private _cuo As String
    Private _fecha_operacion As Date
    Private _glosa As String
    Private _cod_libro As String
    Private _numero_correlativo As String
    Private _numero_documento As String
    Private _cuenta As String
    Private _denominacion As String
    Private _debe As Decimal
    Private _haber As Decimal


    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Public Property cuo_electronico() As String
        Get
            Return _cuo_electronico
        End Get
        Set(ByVal value As String)
            _cuo_electronico = value
        End Set
    End Property

    Public Property cuo() As String
        Get
            Return _cuo
        End Get
        Set(ByVal value As String)
            _cuo = value
        End Set
    End Property

    Public Property fecha_operacion() As Date
        Get
            Return _fecha_operacion
        End Get
        Set(ByVal value As Date)
            _fecha_operacion = value
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

    Public Property cod_libro() As String
        Get
            Return _cod_libro
        End Get
        Set(ByVal value As String)
            _cod_libro = value
        End Set
    End Property

    Public Property numero_correlativo() As String
        Get
            Return _numero_correlativo
        End Get
        Set(ByVal value As String)
            _numero_correlativo = value
        End Set
    End Property

    Public Property numero_documento() As String
        Get
            Return _numero_documento
        End Get
        Set(ByVal value As String)
            _numero_documento = value
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

    Public Property denominacion() As String
        Get
            Return _denominacion
        End Get
        Set(ByVal value As String)
            _denominacion = value
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

