Module Configuracion
    Public wForm As Integer = 1050
    Public hForm As Integer = 716
    Public rutaServer As String = "ftp://ftp.ticomsoftware.com/"
    Public usuarioFtp As String = "ticom@ticomsoftware.com"
    Public passwordFtp As String = "12ticom34"
    Public rutaEnvio As String = "D:\replicacion\enviar\"
    Public rutaRecepcion As String = "D:\replicacion\recibir\"
    Public CodigoLocalSession As Integer
    Public CodigoUsuarioSession As Integer
    Public NombreUsuarioSession As String
    Public TipoUsuarioSession As String
    Public CodigoEmpleadoSession As Integer
    Public CodigoEmpresaSession As Integer
    Public AnioEjercicio As Integer
    Public fondoPantalla As Object
    Public Sub cebrasDatagrid(ByVal grilla As DataGridView, ByVal col1 As Color, ByVal col2 As Color)
        With grilla
            .RowsDefaultCellStyle.BackColor = col2
            .AlternatingRowsDefaultCellStyle.BackColor = col1
        End With
    End Sub
    Public SERVER As String = "PCPROG\PCPROG"
    Public CadenaConexion As String = "Server=" & SERVER & ";DataBase=TICOM-CONTABLE;Uid=sa;Password=123456;"
End Module
