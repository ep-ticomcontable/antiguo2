Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nPlanillas
    Inherits Conexion

    Dim obj As New dPlanillas

    Public Function registrarCabeceraPlanilla(glosa As String, total As Decimal, fecha As Date, tipo As String, estado As String) As String
        Return obj.registrarCabeceraPlanilla(glosa, total, fecha, tipo, estado)
    End Function
    Public Function registrarCabeceraPlanillaBD(id As Integer, glosa As String, periodo As String, moneda As String, total As Decimal, fecha As Date, tipo As String, estado As String, cadena As String) As String
        Return obj.registrarCabeceraPlanillaBD(id, glosa, periodo, moneda, total, fecha, tipo, estado, cadena)
    End Function
    Public Function actualizarCabeceraPlanillaBD(id As Integer, glosa As String, periodo As String, moneda As String, total As Decimal, fecha As Date, tipo As String, estado As String, cadena As String) As String
        Return obj.actualizarCabeceraPlanillaBD(id, glosa, periodo, moneda, total, fecha, tipo, estado, cadena)
    End Function
    Public Function nRegistrarAbonoPlanillasBD(entiAA As AbonoPlanillasEntity, cadena As String) As String
        Return obj.registrarAbonoPlanillasBD(entiAA, cadena)
    End Function
    Public Function nRegistrarAsientosAbonoPlanillasBD(entiAA As AbonoPlanillasEntity, cadena As String) As String
        Return obj.registrarAsientoAbonoPlanillasBD(entiAA, cadena)
    End Function
    Public Function nObtenerUltimoAbonoPlanillaBD(cadena As String) As String
        Return obj.obtenerUltimoAbonoPlanillaBD(cadena)
    End Function
End Class
