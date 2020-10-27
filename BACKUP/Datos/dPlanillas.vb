Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dPlanillas
    Inherits Conexion

    Public Function registrarCabeceraPlanilla(glosa As String, total As Decimal, fecha As Date, tipo As String, estado As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCabeceraPlanilla"
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = glosa
                .Parameters.Add("@total", SqlDbType.Decimal).Value = total
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("@tipo_estado", SqlDbType.VarChar).Value = tipo
                .Parameters.Add("@estado", SqlDbType.Char).Value = estado
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
    Public Function registrarCabeceraPlanillaBD(id As Integer, glosa As String, periodo As String, moneda As String, total As Decimal, fecha As Date, tipo As String, estado As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCabeceraPlanilla"
                .Parameters.Add("@id", SqlDbType.Int).Value = id
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = glosa
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = periodo
                .Parameters.Add("@moneda", SqlDbType.VarChar).Value = moneda
                .Parameters.Add("@total", SqlDbType.Decimal).Value = total
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("@tipo_estado", SqlDbType.VarChar).Value = tipo
                .Parameters.Add("@estado", SqlDbType.Char).Value = estado
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

    Public Function actualizarCabeceraPlanillaBD(id As Integer, glosa As String, periodo As String, moneda As String, total As Decimal, fecha As Date, tipo As String, estado As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarCabeceraPlanilla"
                .Parameters.Add("@id", SqlDbType.Int).Value = id
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = glosa
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = periodo
                .Parameters.Add("@moneda", SqlDbType.VarChar).Value = moneda
                .Parameters.Add("@total", SqlDbType.Decimal).Value = total
                .Parameters.Add("@fec_emision", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("@tipo_estado", SqlDbType.VarChar).Value = tipo
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

    Public Function registrarAbonoPlanillasBD(entiAA As AbonoPlanillasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoPlanillas"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_planilla", SqlDbType.VarChar).Value = entiAA.id_planilla
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entiAA.id_caja
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = entiAA.descripcion
                .Parameters.Add("@fecha", SqlDbType.DateTime).Value = entiAA.fecha
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
    Public Function obtenerUltimoAbonoPlanillaBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerUltimoAbonoPlanilla", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return ex.Message
        Finally
            desconectarBD()
        End Try
        Return Integer.Parse(dt.Rows(0)("numero").ToString)
    End Function
    Public Function registrarAsientoAbonoPlanillasBD(entiAA As AbonoPlanillasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoAbonoPlanillas"
                .Parameters.Add("@id_abono_planilla", SqlDbType.VarChar).Value = entiAA.id
                .Parameters.Add("@id_personal", SqlDbType.VarChar).Value = entiAA.id_personal
                .Parameters.Add("@id_planilla", SqlDbType.VarChar).Value = entiAA.id_planilla
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiAA.base_imponible
                .Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@tipo_pago", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@descripcion_pago", SqlDbType.VarChar).Value = entiAA.descripcion
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@fecha_pago", SqlDbType.DateTime).Value = entiAA.fecha
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
