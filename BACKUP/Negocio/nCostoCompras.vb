Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCostoCompras
    Inherits Conexion

    Dim obj As New dCostosCompras

    Public Function nRegistrarCostoDeCompras(entiCV As CostoComprasEntity) As String
        Return obj.registrarCostoDeCompras(entiCV)
    End Function
    Public Function nRegistrarCostoDeComprasBD(entiCV As CostoComprasEntity, cadena As String) As String
        Return obj.registrarCostoDeComprasBD(entiCV, cadena)
    End Function

    'Public Function registrarConciliacionPendiente(movimiento As String, enti As ConciliacionEntity) As String
    '    Return obj.registrarConciliacionPendiente(movimiento, enti)
    'End Function
End Class
