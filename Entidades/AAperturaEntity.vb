Public Class AAperturaEntity

    Private _id As Integer
    Private _id_asiento As Integer
    Private _glosa As String
    Private _numero As String
    Private _total_debe_s As Decimal
    Private _total_haber_s As Decimal
    Private _diferencia_s As Decimal
    Private _total_debe_d As Decimal
    Private _total_haber_d As Decimal
    Private _diferencia_d As Decimal
    Private _periodo As String
    Private _fecha As Date
    Private _estado As Integer
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

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property id_asiento() As Integer
        Get
            Return _id_asiento
        End Get
        Set(ByVal value As Integer)
            _id_asiento = value
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

    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property total_debe_s() As Decimal
        Get
            Return _total_debe_s
        End Get
        Set(ByVal value As Decimal)
            _total_debe_s = value
        End Set
    End Property

    Public Property total_haber_s() As Decimal
        Get
            Return _total_haber_s
        End Get
        Set(ByVal value As Decimal)
            _total_haber_s = value
        End Set
    End Property

    Public Property diferencia_s() As Decimal
        Get
            Return _diferencia_s
        End Get
        Set(ByVal value As Decimal)
            _diferencia_s = value
        End Set
    End Property

    Public Property total_debe_d() As Decimal
        Get
            Return _total_debe_d
        End Get
        Set(ByVal value As Decimal)
            _total_debe_d = value
        End Set
    End Property

    Public Property total_haber_d() As Decimal
        Get
            Return _total_haber_d
        End Get
        Set(ByVal value As Decimal)
            _total_haber_d = value
        End Set
    End Property

    Public Property diferencia_d() As Decimal
        Get
            Return _diferencia_d
        End Get
        Set(ByVal value As Decimal)
            _diferencia_d = value
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

    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
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

    Public Property estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property
End Class

