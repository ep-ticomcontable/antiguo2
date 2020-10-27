Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dRetenciones
    Inherits Conexion

    Public Function registrarRetenciones(entidad As RetencionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarRetencion"
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

    Public Function registrarAbonoRetenciones(entidad As AbonoRetencionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoRetencion"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entidad.tipo_comprobante
                .Parameters.Add("@id_retencion", SqlDbType.VarChar).Value = entidad.id_retencion
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entidad.id_caja
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entidad.monto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entidad.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entidad.numero
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = entidad.descripcion
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entidad.fecha
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

    Public Function registrarPercepciones(entidad As RetencionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarPercepcion"
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
End Class
