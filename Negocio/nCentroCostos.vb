Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCentroCostos
    Inherits Conexion

    Dim obj As New dCentroCostos

    Public Function registrarCentroCosto(idLocal As Integer, descripcion As String, idEmpleado As Integer, subCentro As Integer, estado As Integer) As String
        Return obj.registrarCentroCosto(idLocal, descripcion, idEmpleado, subCentro, estado)
    End Function
    Public Function registrarCentroCostoBD(idLocal As Integer, descripcion As String, idEmpleado As Integer, subCentro As Integer, estado As Integer, cadena As String) As String
        Return obj.registrarCentroCostoBD(idLocal, descripcion, idEmpleado, subCentro, estado, cadena)
    End Function

    Public Function registrarParametroCentroCosto(idCentro As Integer, descripcion As String, porcentaje As Decimal, cuenta As String, debe As String, haber As String, estado As Integer) As String
        Return obj.registrarParametroCentroCosto(idCentro, descripcion, porcentaje, cuenta, debe, haber, estado)
    End Function
    Public Function registrarParametroCentroCostoBD(idCentro As Integer, descripcion As String, porcentaje As Decimal, cuenta As String, debe As String, haber As String, estado As Integer, cadena As String) As String
        Return obj.registrarParametroCentroCostoBD(idCentro, descripcion, porcentaje, cuenta, debe, haber, estado, cadena)
    End Function

End Class
