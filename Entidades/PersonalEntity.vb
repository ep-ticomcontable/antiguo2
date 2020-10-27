Public Class PersonalEntity
    Private _id As Integer
    Private _cod_dni As Integer
    Private _cuspp As String
    Private _nombres As String
    Private _ape_pat As String
    Private _ape_mat As String
    Private _fec_ingreso As Date
    Private _id_cargo As Integer
    Private _id_moneda As Integer
    Private _sueldo_basico As Decimal
    Private _asignacion As String
    Private _valor_asignacion As Decimal
    Private _num_hijos As Integer
    Private _id_pension As Integer
    Private _porc_pension As Decimal
    Private _descuentos As Decimal
    Private _total_remuneracion As Decimal
    Private _fec_registro As Date
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

    Public Property cod_dni() As Integer
        Get
            Return _cod_dni
        End Get
        Set(ByVal value As Integer)
            _cod_dni = value
        End Set
    End Property

    Public Property cuspp() As String
        Get
            Return _cuspp
        End Get
        Set(ByVal value As String)
            _cuspp = value
        End Set
    End Property

    Public Property nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property

    Public Property ape_pat() As String
        Get
            Return _ape_pat
        End Get
        Set(ByVal value As String)
            _ape_pat = value
        End Set
    End Property

    Public Property ape_mat() As String
        Get
            Return _ape_mat
        End Get
        Set(ByVal value As String)
            _ape_mat = value
        End Set
    End Property

    Public Property fec_ingreso() As Date
        Get
            Return _fec_ingreso
        End Get
        Set(ByVal value As Date)
            _fec_ingreso = value
        End Set
    End Property

    Public Property id_cargo() As Integer
        Get
            Return _id_cargo
        End Get
        Set(ByVal value As Integer)
            _id_cargo = value
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

    Public Property sueldo_basico() As Decimal
        Get
            Return _sueldo_basico
        End Get
        Set(ByVal value As Decimal)
            _sueldo_basico = value
        End Set
    End Property

    Public Property asignacion() As String
        Get
            Return _asignacion
        End Get
        Set(ByVal value As String)
            _asignacion = value
        End Set
    End Property

    Public Property valor_asignacion() As Decimal
        Get
            Return _valor_asignacion
        End Get
        Set(ByVal value As Decimal)
            _valor_asignacion = value
        End Set
    End Property

    Public Property num_hijos() As Integer
        Get
            Return _num_hijos
        End Get
        Set(ByVal value As Integer)
            _num_hijos = value
        End Set
    End Property

    Public Property id_pension() As Integer
        Get
            Return _id_pension
        End Get
        Set(ByVal value As Integer)
            _id_pension = value
        End Set
    End Property

    Public Property porc_pension() As Decimal
        Get
            Return _porc_pension
        End Get
        Set(ByVal value As Decimal)
            _porc_pension = value
        End Set
    End Property

    Public Property descuentos() As Decimal
        Get
            Return _descuentos
        End Get
        Set(ByVal value As Decimal)
            _descuentos = value
        End Set
    End Property

    Public Property total_remuneracion() As Decimal
        Get
            Return _total_remuneracion
        End Get
        Set(ByVal value As Decimal)
            _total_remuneracion = value
        End Set
    End Property

    Public Property fec_registro() As Date
        Get
            Return _fec_registro
        End Get
        Set(ByVal value As Date)
            _fec_registro = value
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
