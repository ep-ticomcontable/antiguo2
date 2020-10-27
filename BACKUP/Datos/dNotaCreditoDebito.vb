Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dNotaCreditoDebito
    Inherits Conexion

    Public Function registrarNotaCredito(entiCV As ComprobanteNotaCreditoDebito) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarNotaCredito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiCV.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@serie_ref", SqlDbType.VarChar).Value = entiCV.serie_ref
                .Parameters.Add("@numero_ref", SqlDbType.VarChar).Value = entiCV.numero_ref
                .Parameters.Add("@ruc", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@motivo", SqlDbType.VarChar).Value = entiCV.motivo
                .Parameters.Add("@comentario", SqlDbType.VarChar).Value = entiCV.comentario
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
    Public Function registrarNotaCreditoBD(entiCV As ComprobanteNotaCreditoDebito, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarNotaCredito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiCV.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@serie_ref", SqlDbType.VarChar).Value = entiCV.serie_ref
                .Parameters.Add("@numero_ref", SqlDbType.VarChar).Value = entiCV.numero_ref
                .Parameters.Add("@ruc", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@motivo", SqlDbType.VarChar).Value = entiCV.motivo
                .Parameters.Add("@comentario", SqlDbType.VarChar).Value = entiCV.comentario
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

    Public Function registrarAsientoNotaCredito(entiAA As ComprobanteNotaCreditoDebito) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoNotaCredito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiAA.numero_cuo
                .Parameters.Add("@id_nota_credito", SqlDbType.VarChar).Value = entiAA.id_nota_credito
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                .Parameters.Add("@fecha_operacion", SqlDbType.Date).Value = entiAA.fec_emision
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
    Public Function registrarAsientoNotaCreditoBD(entiAA As ComprobanteNotaCreditoDebito, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoNotaCredito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiAA.numero_cuo
                .Parameters.Add("@id_nota_credito", SqlDbType.VarChar).Value = entiAA.id_nota_credito
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                .Parameters.Add("@fecha_operacion", SqlDbType.Date).Value = entiAA.fec_emision
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

    Public Function obtenerIdNotaCredito() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdNotaCredito", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return ex.Message
        Finally
            desconectar()
        End Try
        Return Integer.Parse(dt.Rows(0)("id").ToString)
    End Function
    Public Function obtenerIdNotaCreditoBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdNotaCredito", cnBD)
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
        Return Integer.Parse(dt.Rows(0)("id").ToString)
    End Function

    Public Function registrarNotaDebito(entiCV As ComprobanteNotaCreditoDebito) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarNotaDebito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiCV.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@serie_ref", SqlDbType.VarChar).Value = entiCV.serie_ref
                .Parameters.Add("@numero_ref", SqlDbType.VarChar).Value = entiCV.numero_ref
                .Parameters.Add("@ruc", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@motivo", SqlDbType.VarChar).Value = entiCV.motivo
                .Parameters.Add("@comentario", SqlDbType.VarChar).Value = entiCV.comentario
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
    Public Function registrarNotaDebitoBD(entiCV As ComprobanteNotaCreditoDebito, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarNotaDebito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiCV.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCV.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCV.numero
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@serie_ref", SqlDbType.VarChar).Value = entiCV.serie_ref
                .Parameters.Add("@numero_ref", SqlDbType.VarChar).Value = entiCV.numero_ref
                .Parameters.Add("@ruc", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCV.monto
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@motivo", SqlDbType.VarChar).Value = entiCV.motivo
                .Parameters.Add("@comentario", SqlDbType.VarChar).Value = entiCV.comentario
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

    Public Function registrarAsientoNotaDebito(entiAA As ComprobanteNotaCreditoDebito) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoNotaDebito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiAA.numero_cuo
                .Parameters.Add("@id_nota_credito", SqlDbType.VarChar).Value = entiAA.id_nota_credito
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
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
    Public Function registrarAsientoNotaDebitoBD(entiAA As ComprobanteNotaCreditoDebito, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoNotaDebito"
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiAA.numero_cuo
                .Parameters.Add("@id_nota_credito", SqlDbType.VarChar).Value = entiAA.id_nota_credito
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
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

    Public Function obtenerIdNotaDebito() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdNotaDebito", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return ex.Message
        Finally
            desconectar()
        End Try
        Return Integer.Parse(dt.Rows(0)("id").ToString)
    End Function
    Public Function obtenerIdNotaDebitoBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdNotaDebito", cnBD)
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
        Return Integer.Parse(dt.Rows(0)("id").ToString)
    End Function

    Public Function comprobanteCompraPorSerieNumero(serie As String, numero As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_comprobanteCompraPorSerieNumero", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function comprobanteCompraPorSerieNumeroBD(serie As String, numero As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_comprobanteCompraPorSerieNumero", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function comprobanteVentaPorSerieNumero(serie As String, numero As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_comprobanteVentaPorSerieNumero", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function comprobanteVentaPorSerieNumeroBD(serie As String, numero As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_comprobanteVentaPorSerieNumero", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
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
