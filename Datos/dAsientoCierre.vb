Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dAsientoCierre
    Inherits Conexion

    Public Function registrarAjusteAsientoCierre(entiAA As AsientoCierreEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_AjusteAsientoCierre"
                .Parameters.Add("@id_cierre", SqlDbType.Int).Value = entiAA.id_cierre
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc", SqlDbType.Int).Value = entiAA.id_doc
                .Parameters.Add("@num_doc", SqlDbType.VarChar).Value = entiAA.num_doc
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiAA.fec_emision
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return ex.Message
        Finally
            desconectar()
        End Try
    End Function
    Public Function registrarAjusteAsientoCierreBD(entiAA As AsientoCierreEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_AjusteAsientoCierre"
                .Parameters.Add("@id_cierre", SqlDbType.Int).Value = entiAA.id_cierre
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc", SqlDbType.Int).Value = entiAA.id_doc
                .Parameters.Add("@num_doc", SqlDbType.VarChar).Value = entiAA.num_doc
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiAA.fec_emision
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

    Public Function registrarCierreMensual(anio As String, mes As String, proceso As String, cuenta As String, glosa As String, debe As Decimal, haber As Decimal, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCierreMensual"
                .Parameters.Add("@anio", SqlDbType.VarChar).Value = anio
                .Parameters.Add("@mes", SqlDbType.VarChar).Value = mes
                .Parameters.Add("@proceso", SqlDbType.VarChar).Value = proceso
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = haber
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
