Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nPersonal
    Inherits Conexion

    Dim obj As New dPersonal


    Public Function registrarPersonal(entiAA As PersonalEntity, cadena As String) As String
        Return obj.registrarPersonal(entiAA, cadena)
    End Function
    Public Function actualizarPersonal(entiAA As PersonalEntity, cadena As String) As String
        Return obj.actualizarPersonal(entiAA, cadena)
    End Function
    Public Function nListaAbonosPagoComprasBD(idCompra As String, cadena As String) As DataTable
        Return obj.listaAbonosPagoComprasBD(idCompra, cadena)
    End Function

End Class
