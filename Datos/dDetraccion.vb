Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dDetraccion
    Inherits Conexion

    Public Function registrarDetracciones(entidad As RetencionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetraccion"
                .Parameters.Add("@operacion", SqlDbType.VarChar).Value = entidad.operacion
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entidad.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entidad.numero
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@fec_reg", SqlDbType.Date).Value = entidad.fec_reg
                .Parameters.Add("@id_comprobante", SqlDbType.Int).Value = entidad.id_comprobante
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entidad.monto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entidad.tipo
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return ex.Message
        Finally
            desconectarBD()
        End Try
    End Function

    Public Function listaTipoTasaDetraccion() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoTasaDetraccion", cn)
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
    Public Function listaTipoTasaDetraccionBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoTasaDetraccion", cnBD)
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

    Public Function listaTipoTasaDetraccionPorId(id As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoTasaDetraccionPorId", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@id", SqlDbType.Int).Value = id
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaTipoTasaDetraccionPorIdBD(id As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaTipoTasaDetraccionPorId", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@id", SqlDbType.Int).Value = id
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
