Public Class ComodinEntity
    Private _id As Integer
    Private _id_tipo_operacion As String
    Private _id_tipo_documento As String
    Private _serie As String
    Private _numero As String
    Private _operacion As String
    Private _id_banco As String
    Private _id_moneda As String
    Private _tipo_cambio As Decimal
    Private _glosa As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _diferencia As Decimal
    Private _fec_reg As Date
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

    Public Property id_tipo_operacion() As String
        Get
            Return _id_tipo_operacion
        End Get
        Set(ByVal value As String)
            _id_tipo_operacion = value
        End Set
    End Property

    Public Property id_tipo_documento() As String
        Get
            Return _id_tipo_documento
        End Get
        Set(ByVal value As String)
            _id_tipo_documento = value
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

    Public Property operacion() As String
        Get
            Return _operacion
        End Get
        Set(ByVal value As String)
            _operacion = value
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

    Public Property diferencia() As Decimal
        Get
            Return _diferencia
        End Get
        Set(ByVal value As Decimal)
            _diferencia = value
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

