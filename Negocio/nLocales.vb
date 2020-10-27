Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nLocales
    Inherits Conexion

    Dim obj As New dLocales

    Public Function nListaLocalesActivos() As DataTable
        Return obj.listaLocalesActivos()
    End Function
    Public Function nListaLocalesActivosBD(cadena As String) As DataTable
        Return obj.listaLocalesActivosBD(cadena)
    End Function
End Class
