Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dAsientosContables
    Inherits Conexion

    Public Function obtenerNumeroCUO() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerCUO_Venta", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return ex.Message
        Finally
            desconectar()
        End Try
        Return Integer.Parse(dt.Rows(0)("numero").ToString) + 1

    End Function
    Public Function obtenerNumeroCUOBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerCUO_Venta", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return ex.Message
        Finally
            desconectarBD()
        End Try
        Return Integer.Parse(dt.Rows(0)("numero").ToString) + 1

    End Function

End Class
