Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dUsuarios
    Inherits Conexion

    Public Function verificarSesionUsuario(user As UsuariosE) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarSesionUsuario", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = user.usuario
                .Parameters.Add("@clave", SqlDbType.VarChar).Value = user.clave
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function verificarSesionUsuarioBD(user As UsuariosE, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarSesionUsuario", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = user.usuario
                .Parameters.Add("@clave", SqlDbType.VarChar).Value = user.clave
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function listaUsuariosPorTipoDeUsuario(tipo As String, idUsuario As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaUsuariosPorTipoDeUsuario", cn)
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
    Public Function listaUsuariosPorTipoDeUsuarioBD(tipo As String, idUsuario As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaUsuariosPorTipoDeUsuario", cnBD)
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

    Public Function registrarUsuario(entiUsu As UsuariosE) As String
        If cn.State = ConnectionState.Closed Then conectar()
        'Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                '.Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarUsuario"
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = entiUsu.usuario
                .Parameters.Add("@clave", SqlDbType.VarChar).Value = entiUsu.clave
                .Parameters.Add("@tipo", SqlDbType.Char).Value = entiUsu.tipo
                .ExecuteNonQuery()
            End With
            'miTran.Commit()
            Return "1"
        Catch ex As Exception
            'miTran.Rollback()
            Return ex.Message
        Finally
            desconectar()
        End Try
    End Function
    Public Function registrarUsuarioBD(entiUsu As UsuariosE, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        'Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                '.Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarUsuario"
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = entiUsu.usuario
                .Parameters.Add("@clave", SqlDbType.VarChar).Value = entiUsu.clave
                .Parameters.Add("@tipo", SqlDbType.Char).Value = entiUsu.tipo
                .ExecuteNonQuery()
            End With
            'miTran.Commit()
            Return "1"
        Catch ex As Exception
            'miTran.Rollback()
            Return ex.Message
        Finally
            desconectarBD()
        End Try
    End Function
End Class

