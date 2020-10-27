Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dBancosCheques
    Inherits Conexion

    
    Public Function registrarGiroCheque(entidad As BancoChequeEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[usp_registrarGiroCheque]"
                .Parameters.Add("@id_cheque", SqlDbType.VarChar).Value = entidad.id_cheque
                .Parameters.Add("@numero", SqlDbType.Int).Value = entidad.numero
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entidad.monto
                .Parameters.Add("@nomenclatura", SqlDbType.VarChar).Value = entidad.nomenclatura
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
    Public Function actualizarGiroCheque(entidad As BancoChequeEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[usp_actualizarGiroCheque]"
                .Parameters.Add("@id", SqlDbType.VarChar).Value = entidad.id
                .Parameters.Add("@id_cheque", SqlDbType.VarChar).Value = entidad.id_cheque
                .Parameters.Add("@numero", SqlDbType.Int).Value = entidad.numero
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entidad.monto
                .Parameters.Add("@nomenclatura", SqlDbType.VarChar).Value = entidad.nomenclatura
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
