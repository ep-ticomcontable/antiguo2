Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCostoVentas
    Inherits Conexion

    Dim obj As New dCostosVentas

    Public Function nRegistrarCostoDeVentas(entiCV As CostoVentasEntity) As String
        Return obj.registrarCostoDeVentas(entiCV)
    End Function
    Public Function nRegistrarCostoDeVentasBD(entiCV As CostoVentasEntity, cadena As String) As String
        Return obj.registrarCostoDeVentasBD(entiCV, cadena)
    End Function
End Class
