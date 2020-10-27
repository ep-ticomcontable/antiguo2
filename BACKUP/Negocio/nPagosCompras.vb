Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nPagosCompras
    Inherits Conexion

    Dim obj As New dPagosCompras

    Public Function nListaComprasPorPagar(datoProveedor As String, tipoCompra As String) As DataTable
        Return obj.listaComprasPorPagar(datoProveedor, tipoCompra)
    End Function
    Public Function nListaComprasPorPagarBD(datoProveedor As String, tipoCompra As String, cadena As String) As DataTable
        Return obj.listaComprasPorPagarBD(datoProveedor, tipoCompra, cadena)
    End Function

    Public Function nBuscarProveedor(datoProveedor As String) As DataTable
        Return obj.buscarProveedor(datoProveedor)
    End Function
    Public Function nBuscarProveedorBD(datoProveedor As String, cadena As String) As DataTable
        Return obj.buscarProveedorBD(datoProveedor, cadena)
    End Function

    Public Function nBuscarClienteBD(datoCliente As String, cadena As String) As DataTable
        Return obj.buscarClienteBD(datoCliente, cadena)
    End Function

End Class
