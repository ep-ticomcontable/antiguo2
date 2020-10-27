Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCuentaImpuestos
    Inherits Conexion

    Dim obj As New dCuentaImpuestos

    Public Function nObtenerImpuestoPorCuenta(idCuenta As String) As DataTable
        Return obj.obtenerImpuestoPorCuenta(idCuenta)
    End Function
    Public Function nObtenerImpuestoPorCuentaBD(idCuenta As String, cadena As String) As DataTable
        Return obj.obtenerImpuestoPorCuentaBD(idCuenta, cadena)
    End Function
End Class
