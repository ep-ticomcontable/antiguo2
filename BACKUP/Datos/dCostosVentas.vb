Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dCostosVentas
    Inherits Conexion

    Public Function registrarCostoDeVentas(entiCV As CostoVentasEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCostoDeVentas"
                .Parameters.Add("@id_comprobante", SqlDbType.Int).Value = entiCV.id_comprobante
                .Parameters.Add("@numero_cuo", SqlDbType.VarChar).Value = entiCV.numero_cuo
                .Parameters.Add("@id_cuenta", SqlDbType.VarChar).Value = entiCV.id_cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiCV.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiCV.haber
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
    Public Function registrarCostoDeVentasBD(entiCV As CostoVentasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCostoDeVentas"
                .Parameters.Add("@id_comprobante", SqlDbType.Int).Value = entiCV.id_comprobante
                .Parameters.Add("@numero_cuo", SqlDbType.VarChar).Value = entiCV.numero_cuo
                .Parameters.Add("@id_cuenta", SqlDbType.VarChar).Value = entiCV.id_cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiCV.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiCV.haber
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
