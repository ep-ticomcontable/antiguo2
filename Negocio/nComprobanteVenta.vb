Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nComprobanteVenta
    Inherits Conexion

    Dim obj As New dComprobanteVenta

    Public Function nRegistrarComprobanteVenta(entiCV As ComprobanteVentaEntity) As String
        Return obj.registrarComprobanteVenta(entiCV)
    End Function
    Public Function nRegistrarComprobanteVentaBD(entiCV As ComprobanteVentaEntity, cadena As String) As String
        Return obj.registrarComprobanteVentaBD(entiCV, cadena)
    End Function
    Public Function nActualizarComprobanteVentaBD(entidad As ComprobanteVentaEntity, cadena As String) As String
        Return obj.actualizarComprobanteVentaBD(entidad, cadena)
    End Function

    Public Function nRegistrarDetalleAsientoVenta(entiCV As ComprobanteVentaEntity) As String
        Return obj.registrarDetalleAsientoVenta(entiCV)
    End Function
    Public Function nRegistrarDetalleAsientoVentaBD(entiCV As ComprobanteVentaEntity, cadena As String) As String
        Return obj.registrarDetalleAsientoVentaBD(entiCV, cadena)
    End Function

    Public Function obtenerIdComprobanteVenta() As DataTable
        Return obj.obtenerIdComprobanteVenta()
    End Function
    Public Function obtenerIdComprobanteVentaBD(cadena As String) As DataTable
        Return obj.obtenerIdComprobanteVentaBD(cadena)
    End Function

    Public Function registrarCajaChica(enti As CajaEntity) As String
        Return obj.registrarCajaChica(enti)
    End Function
    Public Function registrarCajaChicaBD(enti As CajaEntity, cadena As String) As String
        Return obj.registrarCajaChicaBD(enti, cadena)
    End Function

    Public Function registrarCajaBancos(enti As CajaEntity) As String
        Return obj.registrarCajaBancos(enti)
    End Function
    Public Function registrarCajaBancosBD(enti As CajaEntity, cadena As String) As String
        Return obj.registrarCajaBancosBD(enti, cadena)
    End Function
    Public Function nDataComprobanteVentaPorId(codVenta As String, cadena As String) As DataTable
        Return obj.dataComprobanteVentaPorId(codVenta, cadena)
    End Function
End Class
