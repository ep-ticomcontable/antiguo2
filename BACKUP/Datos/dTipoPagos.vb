Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dTipoPagos
    Inherits Conexion

    Public Function listaTipoPagos() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoPagos", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaTipoPagosBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoPagos", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
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
