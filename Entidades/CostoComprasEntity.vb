Public Class CostoComprasEntity
    Private _id As Integer
    Private _id_comprobante As Integer
    Private _numero_cuo As String
    Private _id_cuenta As String
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

    Public Property id_comprobante() As Integer
        Get
            Return _id_comprobante
        End Get
        Set(ByVal value As Integer)
            _id_comprobante = value
        End Set
    End Property

    Public Property numero_cuo() As String
        Get
            Return _numero_cuo
        End Get
        Set(ByVal value As String)
            _numero_cuo = value
        End Set
    End Property

    Public Property id_cuenta() As String
        Get
            Return _id_cuenta
        End Get
        Set(ByVal value As String)
            _id_cuenta = value
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
