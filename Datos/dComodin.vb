Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dComodin
    Inherits Conexion

    Public Function registrarAbonosComodin(entidad As AbonosComodin, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonosComodin"
                .Parameters.Add("@id_comodin", SqlDbType.VarChar).Value = entidad.id_comodin
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entidad.monto
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entidad.id_caja
                .Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = entidad.id_tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entidad.numero
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entidad.fec_reg
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
    Public Function registrarAsientosAbonosComodin(entidad As AbonosComodin, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientosAbonosComodin"
                .Parameters.Add("@id_abono_comodin", SqlDbType.VarChar).Value = entidad.id_abono_comodin
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entidad.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entidad.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entidad.haber
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@fecha_pago", SqlDbType.Date).Value = entidad.fec_reg
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
