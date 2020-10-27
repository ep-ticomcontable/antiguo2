Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nBancosCheques
    Inherits Conexion

    Dim obj As New dBancosCheques

    Public Function nRegistrarGiroCheques(entidad As BancoChequeEntity, cadena As String) As String
        Return obj.registrarGiroCheque(entidad, cadena)
    End Function
    Public Function nActualizarGiroCheques(entidad As BancoChequeEntity, cadena As String) As String
        Return obj.actualizarGiroCheque(entidad, cadena)
    End Function
    
End Class
