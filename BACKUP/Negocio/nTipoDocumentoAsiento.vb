Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nTipoDocumentoAsiento
    Inherits Conexion

    Dim obj As New dTipoDocumentoAsiento

    Public Function nListarCuentasSegunTipoAsiento(tipoAsiento As String) As DataTable
        Return obj.listaTipoDocumentoPorTipoAsiento(tipoAsiento)
    End Function
    Public Function nListarCuentasSegunTipoAsientoBD(tipoAsiento As String, cadena As String) As DataTable
        Return obj.listaTipoDocumentoPorTipoAsientoBD(tipoAsiento, cadena)
    End Function

    Public Function nObtenerCuentaSegunId(id As Integer) As DataTable
        Return obj.obtenerTipoDocumentoSegunId(id)
    End Function
    Public Function nObtenerCuentaSegunIdBD(id As Integer, cadena As String) As DataTable
        Return obj.obtenerTipoDocumentoSegunIdBD(id, cadena)
    End Function
End Class
