Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dCuentaImpuestos
    Inherits Conexion

    Public Function obtenerImpuestoPorCuenta(idCuenta As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerImpuestosPorCuenta", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCuenta", SqlDbType.VarChar).Value = idCuenta
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function obtenerImpuestoPorCuentaBD(idCuenta As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerImpuestosPorCuenta", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCuenta", SqlDbType.VarChar).Value = idCuenta
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
