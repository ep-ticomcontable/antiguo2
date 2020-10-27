Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dImpuestosSunat
    Inherits Conexion

    Public Function registrarImpuestosSunat(entiAA As ImpuestosSunatEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarImpuestosSunat"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = entiAA.descripcion
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = entiAA.porcentaje
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
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
    Public Function registrarImpuestosSunatBD(entiAA As ImpuestosSunatEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarImpuestosSunat"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = entiAA.descripcion
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = entiAA.porcentaje
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
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

    Public Function registrarImpuestosBD(entiAA As ImpuestosSunatEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarImpuestos"
                .Parameters.Add("@operacion", SqlDbType.VarChar).Value = entiAA.operacion
                .Parameters.Add("@id_impuesto", SqlDbType.Int).Value = entiAA.id_impuesto
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiAA.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entiAA.id_tipo_comprobante
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@total_comprobante", SqlDbType.Decimal).Value = entiAA.total_comprobante
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = entiAA.porcentaje
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
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
