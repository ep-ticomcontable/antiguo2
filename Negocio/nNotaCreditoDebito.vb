Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nNotaCreditoDebito
    Inherits Conexion

    Dim obj As New dNotaCreditoDebito

    Public Function registrarNotaCredito(entiCV As ComprobanteNotaCreditoDebito) As String
        Return obj.registrarNotaCredito(entiCV)
    End Function
    Public Function registrarNotaCreditoBD(entiCV As ComprobanteNotaCreditoDebito, cadena As String) As String
        Return obj.registrarNotaCreditoBD(entiCV, cadena)
    End Function

    Public Function registrarAsientoNotaCredito(enti As ComprobanteNotaCreditoDebito) As String
        Return obj.registrarAsientoNotaCredito(enti)
    End Function
    Public Function registrarAsientoNotaCreditoBD(enti As ComprobanteNotaCreditoDebito, cadena As String) As String
        Return obj.registrarAsientoNotaCreditoBD(enti, cadena)
    End Function

    Public Function obtenerIdNotaCredito() As String
        Return obj.obtenerIdNotaCredito()
    End Function
    Public Function obtenerIdNotaCreditoBD(cadena As String) As String
        Return obj.obtenerIdNotaCreditoBD(cadena)
    End Function

    Public Function registrarNotaDebito(entiCV As ComprobanteNotaCreditoDebito) As String
        Return obj.registrarNotaDebito(entiCV)
    End Function
    Public Function registrarNotaDebitoBD(entiCV As ComprobanteNotaCreditoDebito, cadena As String) As String
        Return obj.registrarNotaDebitoBD(entiCV, cadena)
    End Function

    Public Function registrarAsientoNotaDebito(enti As ComprobanteNotaCreditoDebito) As String
        Return obj.registrarAsientoNotaDebito(enti)
    End Function
    Public Function registrarAsientoNotaDebitoBD(enti As ComprobanteNotaCreditoDebito, cadena As String) As String
        Return obj.registrarAsientoNotaDebitoBD(enti, cadena)
    End Function

    Public Function obtenerIdNotaDebito() As String
        Return obj.obtenerIdNotaDebito()
    End Function
    Public Function obtenerIdNotaDebitoBD(cadena As String) As String
        Return obj.obtenerIdNotaDebitoBD(cadena)
    End Function

    Public Function comprobanteCompraPorSerieNumero(serie As String, numero As String) As DataTable
        Return obj.comprobanteCompraPorSerieNumero(serie, numero)
    End Function
    Public Function comprobanteCompraPorSerieNumeroBD(serie As String, numero As String, cadena As String) As DataTable
        Return obj.comprobanteCompraPorSerieNumeroBD(serie, numero, cadena)
    End Function

    Public Function comprobanteVentaPorSerieNumero(serie As String, numero As String) As DataTable
        Return obj.comprobanteVentaPorSerieNumero(serie, numero)
    End Function
    Public Function comprobanteVentaPorSerieNumeroBD(serie As String, numero As String, cadena As String) As DataTable
        Return obj.comprobanteVentaPorSerieNumeroBD(serie, numero, cadena)
    End Function

End Class
