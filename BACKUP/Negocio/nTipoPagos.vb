Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nTipoPagos
    Inherits Conexion

    Dim obj As New dTipoPagos

    Public Function nListaTipoPagos() As DataTable
        Return obj.listaTipoPagos()
    End Function
    Public Function nListaTipoPagosBD(cadena As String) As DataTable
        Return obj.listaTipoPagosBD(cadena)
    End Function

End Class
