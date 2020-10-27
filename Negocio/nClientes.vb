Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nClientes
    Inherits Conexion

    Public Function ultimoClientePorLocal(idLocal As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ultimoClientePorLocal", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function ultimoClientePorLocalBD(idLocal As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ultimoClientePorLocal", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function clientePorId(id As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ClientePorId", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@id", SqlDbType.Int).Value = id
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function clientePorIdBD(id As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ClientePorId", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@id", SqlDbType.Int).Value = id
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function listaClientesPorDato(dato As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ListaClientesPorDato", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaClientesPorDatoBD(dato As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("lista")
        Try
            da = New SqlDataAdapter("usp_ListaClientesPorDato", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("lista")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function modificarCliente(ByVal cliente As ClientesEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_ModificarCliente"
                .Parameters.Add("@id", SqlDbType.Int).Value = cliente.id
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = cliente.idLocal
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombres
                .Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos
                .Parameters.Add("@estado", SqlDbType.Char).Value = cliente.estado
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
    End Function
    Public Function modificarClienteBD(ByVal cliente As ClientesEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_ModificarCliente"
                .Parameters.Add("@id", SqlDbType.Int).Value = cliente.id
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = cliente.idLocal
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombres
                .Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos
                .Parameters.Add("@estado", SqlDbType.Char).Value = cliente.estado
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectarBD()
        End Try
    End Function

    Public Function crearCliente(ByVal cliente As ClientesEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_CrearCliente"
                .Parameters.Add("@id", SqlDbType.Int).Value = cliente.id
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = cliente.idLocal
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombres
                .Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos
                .Parameters.Add("@estado", SqlDbType.Char).Value = cliente.estado
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
    End Function
    Public Function crearClienteBD(ByVal cliente As ClientesEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_CrearCliente"
                .Parameters.Add("@id", SqlDbType.Int).Value = cliente.id
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = cliente.idLocal
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.nombres
                .Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.apellidos
                .Parameters.Add("@estado", SqlDbType.Char).Value = cliente.estado
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectarBD()
        End Try
    End Function
End Class
