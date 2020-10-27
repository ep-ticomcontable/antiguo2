Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAsientoLibroDiario
    Inherits Conexion

    Dim obj As New dAsientoLibroDiario

    Public Function registrarAsientoLibroDiario(entiAA As ALDiarioEntity) As String
        Return obj.registrarAsientoLibroDiario(entiAA)
    End Function
    Public Function registrarAsientoLibroDiarioBD(entiAA As ALDiarioEntity, cadena As String) As String
        Return obj.registrarAsientoLibroDiarioBD(entiAA, cadena)
    End Function

    Public Function registrarComodinBD(entiAA As ComodinEntity, cadena As String) As String
        Return obj.registrarComodinBD(entiAA, cadena)
    End Function
    Public Function actualizarComodinBD(entiAA As ComodinEntity, cadena As String) As String
        Return obj.actualizarComodinBD(entiAA, cadena)
    End Function
End Class
