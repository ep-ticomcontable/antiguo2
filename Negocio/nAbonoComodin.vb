Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAbonoComodin
    Inherits Conexion

    Dim obj As New dComodin

    Public Function registrarAbonosComodin(entiCV As AbonosComodin, cadena As String) As String
        Return obj.registrarAbonosComodin(entiCV, cadena)
    End Function
    Public Function registrarAsientosAbonosComodin(entiCV As AbonosComodin, cadena As String) As String
        Return obj.registrarAsientosAbonosComodin(entiCV, cadena)
    End Function
End Class
