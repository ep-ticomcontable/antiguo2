Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAbonosPagos
    Inherits Conexion

    Dim obj As New dAbonoPagos

    Public Function nRegistrarAbonoCompras(entiAA As AbonoComprasEntity) As String
        Return obj.registrarAbonoCompras(entiAA)
    End Function
    Public Function nRegistrarAbonoComprasBD(entiAA As AbonoComprasEntity, cadena As String) As String
        Return obj.registrarAbonoComprasBD(entiAA, cadena)
    End Function

    Public Function nObtenerUltimoAbonoCompra() As String
        Return obj.obtenerUltimoAbonoCompra()
    End Function

    Public Function nObtenerUltimoAbonoCompraBD(cadena As String) As String
        Return obj.obtenerUltimoAbonoCompraBD(cadena)
    End Function

    Public Function nObtenerUltimoAbonoVenta(cadena As String) As String
        Return obj.obtenerUltimoAbonoVenta(cadena)
    End Function

    Public Function nSumaAbonoPagoCompras(idCompra As String) As DataTable
        Return obj.sumaAbonoPagoCompras(idCompra)
    End Function
    Public Function nSumaAbonoPagoComprasBD(idCompra As String, cadena As String) As DataTable
        Return obj.sumaAbonoPagoComprasBD(idCompra, cadena)
    End Function

    Public Function nListaAbonosPagoCompras(idCompra As String) As DataTable
        Return obj.listaAbonosPagoCompras(idCompra)
    End Function
    Public Function nListaAbonosPagoComprasBD(idCompra As String, cadena As String) As DataTable
        Return obj.listaAbonosPagoComprasBD(idCompra, cadena)
    End Function

    Public Function nRegistrarAsientoAbonoCompras(entiAA As AbonoComprasEntity) As String
        Return obj.registrarAsientoAbonoCompras(entiAA)
    End Function
    Public Function nRegistrarAsientoAbonoComprasBD(entiAA As AbonoComprasEntity, cadena As String) As String
        Return obj.registrarAsientoAbonoComprasBD(entiAA, cadena)
    End Function

    Public Function nRegistrarAsientoAbonoVentas(entiAA As AbonoComprasEntity, cadena As String) As String
        Return obj.registrarAsientoAbonoVentas(entiAA, cadena)
    End Function

    Public Function nRegistrarAbonoVentas(entiAA As AbonoVentasEntity) As String
        Return obj.registrarAbonoVentas(entiAA)
    End Function
    Public Function nRegistrarAbonoVentasBD(entiAA As AbonoVentasEntity, cadena As String) As String
        Return obj.registrarAbonoVentasBD(entiAA, cadena)
    End Function

End Class
