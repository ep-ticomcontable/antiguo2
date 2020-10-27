Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dLetras
    Inherits Conexion

    Public Function registrarCanjeLetra(entiCV As CanjeLetraEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCanjeLetra"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiCV.tipo_comprobante
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiCV.id_comprobante
                .Parameters.Add("@estado_deuda", SqlDbType.VarChar).Value = entiCV.estado_deuda
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@librado", SqlDbType.VarChar).Value = entiCV.librado
                .Parameters.Add("@aval", SqlDbType.VarChar).Value = entiCV.aval
                .Parameters.Add("@direccion", SqlDbType.VarChar).Value = entiCV.direccion
                .Parameters.Add("@lugar_giro", SqlDbType.VarChar).Value = entiCV.lugar_giro
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = entiCV.fecha_emision
                .Parameters.Add("@fec_vencimiento", SqlDbType.Date).Value = entiCV.fecha_vencimiento
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCV.estado
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
    Public Function actualizarCanjeLetraBD(entiCV As CanjeLetraEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarCanjeLetra"
                .Parameters.Add("@id", SqlDbType.VarChar).Value = entiCV.id
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiCV.tipo_comprobante
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiCV.id_comprobante
                .Parameters.Add("@estado_deuda", SqlDbType.VarChar).Value = entiCV.estado_deuda
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@librado", SqlDbType.VarChar).Value = entiCV.librado
                .Parameters.Add("@aval", SqlDbType.VarChar).Value = entiCV.aval
                .Parameters.Add("@direccion", SqlDbType.VarChar).Value = entiCV.direccion
                .Parameters.Add("@lugar_giro", SqlDbType.VarChar).Value = entiCV.lugar_giro
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = entiCV.porcentaje
                .Parameters.Add("@interes", SqlDbType.Decimal).Value = entiCV.interes
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = entiCV.fecha_emision
                .Parameters.Add("@fec_vencimiento", SqlDbType.Date).Value = entiCV.fecha_vencimiento
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCV.estado
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
    Public Function registrarCanjeLetraBD(entiCV As CanjeLetraEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCanjeLetra"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiCV.tipo_comprobante
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiCV.id_comprobante
                .Parameters.Add("@estado_deuda", SqlDbType.VarChar).Value = entiCV.estado_deuda
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@librado", SqlDbType.VarChar).Value = entiCV.librado
                .Parameters.Add("@aval", SqlDbType.VarChar).Value = entiCV.aval
                .Parameters.Add("@direccion", SqlDbType.VarChar).Value = entiCV.direccion
                .Parameters.Add("@lugar_giro", SqlDbType.VarChar).Value = entiCV.lugar_giro
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = entiCV.porcentaje
                .Parameters.Add("@interes", SqlDbType.Decimal).Value = entiCV.interes
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = entiCV.fecha_emision
                .Parameters.Add("@fec_vencimiento", SqlDbType.Date).Value = entiCV.fecha_vencimiento
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCV.estado
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

    Public Function registrarAsientosLetrasBD(idComprobante As String, idLetra As String, tipo As String, descripcion As String, cuenta As String, debe As Decimal, haber As Decimal, fecha As Date, diario As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoLetras"
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = idComprobante
                .Parameters.Add("@id_letra", SqlDbType.VarChar).Value = idLetra
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = haber
                .Parameters.Add("@fecha_operacion", SqlDbType.Date).Value = fecha
                .Parameters.Add("@diario", SqlDbType.Char).Value = diario
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
