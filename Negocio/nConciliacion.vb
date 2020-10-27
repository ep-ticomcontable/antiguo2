Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nConciliacion
    Inherits Conexion

    Dim obj As New dConciliacion

    Public Function registrarConciliacion(enti As ConciliacionEntity) As String
        Return obj.registrarConciliacion(enti)
    End Function
    Public Function registrarConciliacionBD(enti As ConciliacionEntity, cadena As String) As String
        Return obj.registrarConciliacionBD(enti, cadena)
    End Function

    Public Function registrarConciliacionCabecera(enti As ConciliacionEntity, cadena As String) As String
        Return obj.registrarConciliacionCabecera(enti, cadena)
    End Function
    Public Function registrarConciliacionDetalle(movimiento As String, enti As ConciliacionEntity, cadena As String) As String
        Return obj.registrarConciliacionDetalle(movimiento, enti, cadena)
    End Function
    Public Function registrarConciliacionPendiente(movimiento As String, enti As ConciliacionEntity, cadena As String) As String
        Return obj.registrarConciliacionPendiente(movimiento, enti, cadena)
    End Function
End Class
