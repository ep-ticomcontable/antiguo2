Public Class ComprobanteVentaEntity
    Private _id As Integer
    Private _tipo_venta As String
    Private _id_gravado As String
    Private _marca As String
    Private _centro As String
    Private _detraccion As String
    Private _id_asiento_venta As Integer
    Private _numero_cuo As Integer
    Private _numero_maquina As String
    Private _id_tipo_comprobante As String
    Private _fec_emision As Date
    Private _fec_pago As Date
    Private _serie_comprobante As String
    Private _numero_comprobante As String
    Private _cod_dni As String
    Private _num_dni As String
    Private _razon_social As String
    Private _valor_facturado As Decimal
    Private _base_imponible As Decimal
    Private _valor_exonerado As Decimal
    Private _valor_inafecto As Decimal
    Private _valor_isc As Decimal
    Private _valor_igv As Decimal
    Private _otros_base_imponible As Decimal
    Private _valor_descuento As Decimal
    Private _total As Decimal
    Private _id_moneda As String
    Private _tipo_cambio As Decimal
    Private _fec_comp_origen As Date
    Private _tip_comp_origen As String
    Private _serie_comp_origen As String
    Private _numero_comp_origen As String
    Private _estado As Integer
    Private _cuenta As String
    Private _debe As Decimal
    Private _haber As Decimal
    Private _glosa As String
    Private _id_usuario As String
    Private _estado_comprobante As String
    Private _numero_detraccion As String
    Private _tipo_tasa_detraccion As String
    Private _tasa_detraccion As Decimal
    Private _valor_detraccion As Decimal
    Private _fecha_detraccion As Date


    Public Property valor_detraccion() As Decimal
        Get
            Return _valor_detraccion
        End Get
        Set(ByVal value As Decimal)
            _valor_detraccion = value
        End Set
    End Property

    Public Property numero_detraccion() As String
        Get
            Return _numero_detraccion
        End Get
        Set(ByVal value As String)
            _numero_detraccion = value
        End Set
    End Property

    Public Property tipo_tasa_detraccion() As String
        Get
            Return _tipo_tasa_detraccion
        End Get
        Set(ByVal value As String)
            _tipo_tasa_detraccion = value
        End Set
    End Property

    Public Property tasa_detraccion() As Decimal
        Get
            Return _tasa_detraccion
        End Get
        Set(ByVal value As Decimal)
            _tasa_detraccion = value
        End Set
    End Property

    Public Property fecha_detraccion() As Date
        Get
            Return _fecha_detraccion
        End Get
        Set(ByVal value As Date)
            _fecha_detraccion = value
        End Set
    End Property

    Public Property id_gravado() As String
        Get
            Return _id_gravado
        End Get
        Set(ByVal value As String)
            _id_gravado = value
        End Set
    End Property
    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property
    Public Property centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property
    Public Property detraccion() As String
        Get
            Return _detraccion
        End Get
        Set(ByVal value As String)
            _detraccion = value
        End Set
    End Property
    Public Property tipo_venta() As String
        Get
            Return _tipo_venta
        End Get
        Set(ByVal value As String)
            _tipo_venta = value
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
    Public Property glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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

    Public Property id_asiento_venta() As Integer
        Get
            Return _id_asiento_venta
        End Get
        Set(ByVal value As Integer)
            _id_asiento_venta = value
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

    Public Property numero_cuo() As Integer
        Get
            Return _numero_cuo
        End Get
        Set(ByVal value As Integer)
            _numero_cuo = value
        End Set
    End Property

    Public Property numero_maquina() As String
        Get
            Return _numero_maquina
        End Get
        Set(ByVal value As String)
            _numero_maquina = value
        End Set
    End Property

    Public Property id_tipo_comprobante() As String
        Get
            Return _id_tipo_comprobante
        End Get
        Set(ByVal value As String)
            _id_tipo_comprobante = value
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

    Public Property serie_comprobante() As String
        Get
            Return _serie_comprobante
        End Get
        Set(ByVal value As String)
            _serie_comprobante = value
        End Set
    End Property

    Public Property numero_comprobante() As String
        Get
            Return _numero_comprobante
        End Get
        Set(ByVal value As String)
            _numero_comprobante = value
        End Set
    End Property

    Public Property cod_dni() As String
        Get
            Return _cod_dni
        End Get
        Set(ByVal value As String)
            _cod_dni = value
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

    Public Property valor_facturado() As Decimal
        Get
            Return _valor_facturado
        End Get
        Set(ByVal value As Decimal)
            _valor_facturado = value
        End Set
    End Property

    Public Property base_imponible() As Decimal
        Get
            Return _base_imponible
        End Get
        Set(ByVal value As Decimal)
            _base_imponible = value
        End Set
    End Property

    Public Property valor_exonerado() As Decimal
        Get
            Return _valor_exonerado
        End Get
        Set(ByVal value As Decimal)
            _valor_exonerado = value
        End Set
    End Property

    Public Property valor_inafecto() As Decimal
        Get
            Return _valor_inafecto
        End Get
        Set(ByVal value As Decimal)
            _valor_inafecto = value
        End Set
    End Property

    Public Property valor_isc() As Decimal
        Get
            Return _valor_isc
        End Get
        Set(ByVal value As Decimal)
            _valor_isc = value
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

    Public Property otros_base_imponible() As Decimal
        Get
            Return _otros_base_imponible
        End Get
        Set(ByVal value As Decimal)
            _otros_base_imponible = value
        End Set
    End Property

    Public Property valor_descuento() As Decimal
        Get
            Return _valor_descuento
        End Get
        Set(ByVal value As Decimal)
            _valor_descuento = value
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

    Public Property tipo_cambio() As Decimal
        Get
            Return _tipo_cambio
        End Get
        Set(ByVal value As Decimal)
            _tipo_cambio = value
        End Set
    End Property

    Public Property fec_comp_origen() As Date
        Get
            Return _fec_comp_origen
        End Get
        Set(ByVal value As Date)
            _fec_comp_origen = value
        End Set
    End Property

    Public Property tip_comp_origen() As String
        Get
            Return _tip_comp_origen
        End Get
        Set(ByVal value As String)
            _tip_comp_origen = value
        End Set
    End Property

    Public Property serie_comp_origen() As String
        Get
            Return _serie_comp_origen
        End Get
        Set(ByVal value As String)
            _serie_comp_origen = value
        End Set
    End Property

    Public Property numero_comp_origen() As String
        Get
            Return _numero_comp_origen
        End Get
        Set(ByVal value As String)
            _numero_comp_origen = value
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

    Public Property estado_comprobante() As String
        Get
            Return _estado_comprobante
        End Get
        Set(ByVal value As String)
            _estado_comprobante = value
        End Set
    End Property
End Class