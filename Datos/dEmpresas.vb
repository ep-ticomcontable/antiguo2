Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dEmpresas
    Inherits Conexion

    Public Function listaEmpresasActivasPorUsuario(idUsuario As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasActivasPorUsuario", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaEmpresasActivasPorUsuarioBD(idUsuario As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasActivasPorUsuario", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function listaEmpresasTodas() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasTodas", cn)
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
    Public Function listaEmpresasTodasBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasTodas", cnBD)
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

    Public Function datosEmpresaPorId(idEmpresa As Integer) As DataTable
        conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosEmpresaPorId", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idEmpresa", SqlDbType.Int).Value = idEmpresa
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function datosEmpresaPorIdBD(idEmpresa As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosEmpresaPorId", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idEmpresa", SqlDbType.Int).Value = idEmpresa
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function datosEmpresaPorAliasBD(nomAlias As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosEmpresaPorAlias", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@alias", SqlDbType.VarChar).Value = nomALias
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function listaEmpresasPorTipoDeUsuario(tipo As String, idUsuario As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasPorTipoDeUsuario", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaEmpresasPorTipoDeUsuarioBD(tipo As String, idUsuario As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasPorTipoDeUsuario", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function dRegNuevaEmpresa(nombre As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spi_empresa"
                .Parameters.Add("@nombreEmpresa", SqlDbType.VarChar).Value = nombre
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "1"
        Catch ex As Exception
            miTran.Rollback()
            Return "2"
        Finally
            desconectar()
        End Try
    End Function
    Public Function dRegNuevaEmpresaBD(nombre As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spi_empresa"
                .Parameters.Add("@nombreEmpresa", SqlDbType.VarChar).Value = nombre
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "1"
        Catch ex As Exception
            miTran.Rollback()
            Return "2"
        Finally
            desconectarBD()
        End Try
    End Function

End Class

