Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dPagosCompras
    Inherits Conexion

    Public Function listaComprasPorPagar(datoProveedor As String, tipoCompra As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaComprasPorPagar", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@datoProveedor", SqlDbType.VarChar).Value = datoProveedor
                .Parameters.Add("@tipoCompra", SqlDbType.VarChar).Value = tipoCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaComprasPorPagarBD(datoProveedor As String, tipoCompra As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaComprasPorPagar", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@datoProveedor", SqlDbType.VarChar).Value = datoProveedor
                .Parameters.Add("@tipoCompra", SqlDbType.VarChar).Value = tipoCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function buscarProveedor(datoProveedor As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_buscarProveedor", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@datoProveedor", SqlDbType.VarChar).Value = datoProveedor
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function buscarProveedorBD(datoProveedor As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_buscarProveedor", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@datoProveedor", SqlDbType.VarChar).Value = datoProveedor
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function buscarClienteBD(datoCliente As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_buscarCliente", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@datoCliente", SqlDbType.VarChar).Value = datoCliente
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
