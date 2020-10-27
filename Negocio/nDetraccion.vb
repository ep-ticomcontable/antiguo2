Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nDetraccion
    Inherits Conexion

    Dim obj As New dDetraccion

    Public Function registrarDetracciones(entidad As RetencionEntity, cadena As String) As String
        Return obj.registrarDetracciones(entidad, cadena)
    End Function

    Public Function nListaTipoTasaDetraccion() As DataTable
        Return obj.listaTipoTasaDetraccion()
    End Function
    Public Function nListaTipoTasaDetraccionBD(cadena As String) As DataTable
        Return obj.listaTipoTasaDetraccionBD(cadena)
    End Function

    Public Function nListaTipoTasaDetraccionPorId(id As Integer) As DataTable
        Return obj.listaTipoTasaDetraccionPorId(id)
    End Function
    Public Function nListaTipoTasaDetraccionPorIdBD(id As Integer, cadena As String) As DataTable
        Return obj.listaTipoTasaDetraccionPorIdBD(id, cadena)
    End Function
End Class
