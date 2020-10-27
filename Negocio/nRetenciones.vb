Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nRetenciones
    Inherits Conexion

    Dim obj As New dRetenciones

    Public Function registrarRetenciones(entidad As RetencionEntity, cadena As String) As String
        Return obj.registrarRetenciones(entidad, cadena)
    End Function

    Public Function registrarAbonoRetenciones(entidad As AbonoRetencionEntity, cadena As String) As String
        Return obj.registrarAbonoRetenciones(entidad, cadena)
    End Function

    Public Function registrarPercepciones(entidad As RetencionEntity, cadena As String) As String
        Return obj.registrarPercepciones(entidad, cadena)
    End Function
End Class
