Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dLocales
    Inherits Conexion

    Public Function listaLocalesActivos() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listarLocalesActivos", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaLocalesActivosBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listarLocalesActivos", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

End Class

