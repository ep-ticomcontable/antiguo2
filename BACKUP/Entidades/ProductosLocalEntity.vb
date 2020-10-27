Public Class ProductosLocalEntity
    Private _id_producto As Integer
    Private _id_local As Integer
    Private _ubicacion As String
    Private _stock As Integer
    Private _p_compra As Decimal
    Private _p_venta As Decimal
    Private _p_mayor As Decimal
    Private _estado As Integer


    Public Property id_producto() As Integer
        Get
            Return _id_producto
        End Get
        Set(ByVal value As Integer)
            _id_producto = value
        End Set
    End Property

    Public Property id_local() As Integer
        Get
            Return _id_local
        End Get
        Set(ByVal value As Integer)
            _id_local = value
        End Set
    End Property

    Public Property ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property

    Public Property p_compra() As Decimal
        Get
            Return _p_compra
        End Get
        Set(ByVal value As Decimal)
            _p_compra = value
        End Set
    End Property

    Public Property p_venta() As Decimal
        Get
            Return _p_venta
        End Get
        Set(ByVal value As Decimal)
            _p_venta = value
        End Set
    End Property

    Public Property p_mayor() As Decimal
        Get
            Return _p_mayor
        End Get
        Set(ByVal value As Decimal)
            _p_mayor = value
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
