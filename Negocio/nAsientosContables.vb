Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAsientosContables
    Inherits Conexion

    Dim obj As New dAsientosContables

    Public Function nObtenerNumeroCUO() As String
        Return obj.obtenerNumeroCUO()
    End Function
    Public Function nObtenerNumeroCUOBD(cadena As String) As String
        Return obj.obtenerNumeroCUOBD(cadena)
    End Function
End Class
