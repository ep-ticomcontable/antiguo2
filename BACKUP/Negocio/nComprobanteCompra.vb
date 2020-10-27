Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nComprobanteCompra
    Inherits Conexion

    Dim obj As New dComprobanteCompra

    Public Function nRegistrarComprobanteCompra(entidad As ComprobanteCompraEntity) As String
        Return obj.registrarComprobanteCompra(entidad)
    End Function
    Public Function nRegistrarComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        Return obj.registrarComprobanteCompraBD(entidad, cadena)
    End Function
    Public Function nActualizarComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        Return obj.actualizarComprobanteCompraBD(entidad, cadena)
    End Function

    Public Function nRegistrarAsientoComprobanteCompra(entidad As ComprobanteCompraEntity) As String
        Return obj.registrarAsientoComprobanteCompra(entidad)
    End Function
    Public Function nRegistrarAsientoComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        Return obj.registrarAsientoComprobanteCompraBD(entidad, cadena)
    End Function

    Public Function nObtenerCUO_Compra() As String
        Return obj.obtenerCUO_Compra()
    End Function
    Public Function nObtenerCUO_CompraBD(cadena As String) As String
        Return obj.obtenerCUO_CompraBD(cadena)
    End Function

    Public Function nDataComprobanteCompraPorId(codCompra As String) As DataTable
        Return obj.dataComprobanteCompraPorId(codCompra)
    End Function
    Public Function nDataComprobanteCompraPorIdBD(codCompra As String, cadena As String) As DataTable
        Return obj.dataComprobanteCompraPorIdBD(codCompra, cadena)
    End Function
End Class
