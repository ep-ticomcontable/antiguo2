Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCuentaAsiento
    Inherits Conexion

    Dim obj As New dCuentaAsiento

    Public Function nListarCuentasSegunTipoAsiento(tipoAsiento As String) As DataTable
        Return obj.listarCuentasSegunTipoAsiento(tipoAsiento)
    End Function
    Public Function nListarCuentasSegunTipoAsientoBD(tipoAsiento As String, cadena As String) As DataTable
        Return obj.listarCuentasSegunTipoAsientoBD(tipoAsiento, cadena)
    End Function

    Public Function nObtenerCuentaSegunId(idCuenta As String) As DataTable
        Return obj.obtenerCuentaSegunId(idCuenta)
    End Function
    Public Function nObtenerCuentaSegunIdBD(idCuenta As String, cadena As String) As DataTable
        Return obj.obtenerCuentaSegunIdBD(idCuenta, cadena)
    End Function
End Class
