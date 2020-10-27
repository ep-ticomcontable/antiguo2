Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nImpuestosSunat
    Inherits Conexion

    Dim obj As New dImpuestosSunat

    Public Function nRegistrarImpuestosSunat(entiAA As ImpuestosSunatEntity) As String
        Return obj.registrarImpuestosSunat(entiAA)
    End Function
    Public Function nRegistrarImpuestosSunatBD(entiAA As ImpuestosSunatEntity, cadena As String) As String
        Return obj.registrarImpuestosSunatBD(entiAA, cadena)
    End Function

    Public Function nRegistrarImpuestosBD(entiAA As ImpuestosSunatEntity, cadena As String) As String
        Return obj.registrarImpuestosBD(entiAA, cadena)
    End Function


End Class
