Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dConciliacion
    Inherits Conexion

    Public Function registrarConciliacion(entiAA As ConciliacionEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarConciliacion"
                .Parameters.Add("@id_abono", SqlDbType.VarChar).Value = entiAA.id_abono
                .Parameters.Add("@concepto", SqlDbType.VarChar).Value = entiAA.concepto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@verificador", SqlDbType.VarChar).Value = entiAA.verificador
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
                .Parameters.Add("@estado", SqlDbType.VarChar).Value = entiAA.estado
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
    Public Function registrarConciliacionBD(entiAA As ConciliacionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarConciliacion"
                .Parameters.Add("@id_abono", SqlDbType.VarChar).Value = entiAA.id_abono
                .Parameters.Add("@concepto", SqlDbType.VarChar).Value = entiAA.concepto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@verificador", SqlDbType.VarChar).Value = entiAA.verificador
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
                .Parameters.Add("@estado", SqlDbType.VarChar).Value = entiAA.estado
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

    Public Function registrarConciliacionCabecera(entiAA As ConciliacionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[usp_registrarConciliacionCabecera]"
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entiAA.id_abono
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = entiAA.periodo
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@r1", SqlDbType.Decimal).Value = entiAA.r1
                .Parameters.Add("@r2", SqlDbType.Decimal).Value = entiAA.r2
                .Parameters.Add("@saldo", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@estado", SqlDbType.VarChar).Value = entiAA.estado
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
    Public Function registrarConciliacionDetalle(movimiento As String, entiAA As ConciliacionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[usp_registrarConciliacionDetalle]"
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = entiAA.periodo
                .Parameters.Add("@movimiento", SqlDbType.VarChar).Value = movimiento
                .Parameters.Add("@id_abono", SqlDbType.VarChar).Value = entiAA.id_abono
                .Parameters.Add("@concepto", SqlDbType.VarChar).Value = entiAA.concepto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
                .Parameters.Add("@estado", SqlDbType.VarChar).Value = entiAA.estado
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
    Public Function registrarConciliacionPendiente(movimiento As String, entiAA As ConciliacionEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarConciliacionPendientes"
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = entiAA.periodo
                .Parameters.Add("@movimiento", SqlDbType.VarChar).Value = movimiento
                .Parameters.Add("@id_abono", SqlDbType.VarChar).Value = entiAA.id_abono
                .Parameters.Add("@concepto", SqlDbType.VarChar).Value = entiAA.concepto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
                .Parameters.Add("@estado", SqlDbType.VarChar).Value = entiAA.estado
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
