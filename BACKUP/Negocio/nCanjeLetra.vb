Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCanjeLetra
    Inherits Conexion

    Dim obj As New dLetras

    Public Function nRegistrarCanjeLetra(entidad As CanjeLetraEntity) As String
        Return obj.registrarCanjeLetra(entidad)
    End Function
    Public Function nRegistrarCanjeLetraBD(entidad As CanjeLetraEntity, cadena As String) As String
        Return obj.registrarCanjeLetraBD(entidad, cadena)
    End Function
    Public Function nRegistrarAsientosLetrasBD(idComprobante As String, idLetra As String, tipo As String, descripcion As String, cuenta As String, debe As Decimal, haber As Decimal, fecha As Date, cadena As String) As String
        Return obj.registrarAsientosLetrasBD(idComprobante, idLetra, tipo, descripcion, cuenta, debe, haber, fecha, cadena)
    End Function
End Class
