Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dComprobanteCompra
    Inherits Conexion

    Public Function dataComprobanteCompraPorId(codCompra As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_dataComprobanteCompraPorId", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codCompra", SqlDbType.VarChar).Value = codCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function dataComprobanteCompraPorIdBD(codCompra As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_dataComprobanteCompraPorId", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codCompra", SqlDbType.VarChar).Value = codCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function registrarAsientoComprobanteCompra(entidad As ComprobanteCompraEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoComprobanteCompra"
                .Parameters.Add("@id_comprobante", SqlDbType.Int).Value = entidad.id_comprobante
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entidad.numero_cuo
                .Parameters.Add("@tipo_compra", SqlDbType.VarChar).Value = entidad.tipo_compra
                .Parameters.Add("@numero_maquina", SqlDbType.VarChar).Value = entidad.numero_maquina
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entidad.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entidad.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entidad.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entidad.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entidad.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entidad.razon_social
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entidad.valor_facturado
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entidad.base_imponible
                .Parameters.Add("@valor_exonerado", SqlDbType.Decimal).Value = entidad.valor_exonerado
                .Parameters.Add("@valor_inafecto", SqlDbType.Decimal).Value = entidad.valor_inafecto
                .Parameters.Add("@valor_isc", SqlDbType.Decimal).Value = entidad.valor_isc
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entidad.valor_igv
                .Parameters.Add("@otros_base_imponible", SqlDbType.Decimal).Value = entidad.otros_base_imponible
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@tipo_cambio", SqlDbType.VarChar).Value = entidad.tipo_cambio
                .Parameters.Add("@fec_comp_origen", SqlDbType.Date).Value = entidad.fec_comp_origen
                .Parameters.Add("@tip_comp_origen", SqlDbType.VarChar).Value = entidad.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entidad.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entidad.numero_comp_origen
                .Parameters.Add("@serie_dua", SqlDbType.VarChar).Value = entidad.serie_dua
                .Parameters.Add("@numero_dua", SqlDbType.VarChar).Value = entidad.numero_dua
                .Parameters.Add("@anio_dua", SqlDbType.Date).Value = entidad.anio_dua
                .Parameters.Add("@numero_detraccion", SqlDbType.VarChar).Value = entidad.numero_detraccion
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entidad.tipo_tasa_detraccion
                .Parameters.Add("@tasa_detraccion", SqlDbType.Decimal).Value = entidad.tasa_detraccion
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entidad.valor_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entidad.fecha_detraccion
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entidad.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entidad.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entidad.haber
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Char).Value = entidad.id_usuario
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
    Public Function registrarAsientoComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoComprobanteCompra"
                .Parameters.Add("@id_comprobante", SqlDbType.Int).Value = entidad.id_comprobante
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entidad.numero_cuo
                .Parameters.Add("@tipo_compra", SqlDbType.VarChar).Value = entidad.tipo_compra
                .Parameters.Add("@numero_maquina", SqlDbType.VarChar).Value = entidad.numero_maquina
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entidad.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entidad.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entidad.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entidad.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entidad.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entidad.razon_social
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entidad.valor_facturado
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entidad.base_imponible
                .Parameters.Add("@valor_exonerado", SqlDbType.Decimal).Value = entidad.valor_exonerado
                .Parameters.Add("@valor_inafecto", SqlDbType.Decimal).Value = entidad.valor_inafecto
                .Parameters.Add("@valor_isc", SqlDbType.Decimal).Value = entidad.valor_isc
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entidad.valor_igv
                .Parameters.Add("@otros_base_imponible", SqlDbType.Decimal).Value = entidad.otros_base_imponible
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@tipo_cambio", SqlDbType.VarChar).Value = entidad.tipo_cambio
                .Parameters.Add("@fec_comp_origen", SqlDbType.Date).Value = entidad.fec_comp_origen
                .Parameters.Add("@tip_comp_origen", SqlDbType.VarChar).Value = entidad.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entidad.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entidad.numero_comp_origen
                .Parameters.Add("@serie_dua", SqlDbType.VarChar).Value = entidad.serie_dua
                .Parameters.Add("@numero_dua", SqlDbType.VarChar).Value = entidad.numero_dua
                .Parameters.Add("@anio_dua", SqlDbType.Date).Value = entidad.anio_dua
                .Parameters.Add("@numero_detraccion", SqlDbType.VarChar).Value = entidad.numero_detraccion
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entidad.tipo_tasa_detraccion
                .Parameters.Add("@tasa_detraccion", SqlDbType.Decimal).Value = entidad.tasa_detraccion
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entidad.valor_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entidad.fecha_detraccion
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entidad.cuenta
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entidad.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entidad.haber
                .Parameters.Add("@impuesto", SqlDbType.VarChar).Value = entidad.impuesto
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entidad.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entidad.numero
                .Parameters.Add("@operacion", SqlDbType.VarChar).Value = entidad.operacion
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Char).Value = entidad.id_usuario
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

    Public Function registrarComprobanteCompra(entidad As ComprobanteCompraEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarComprobanteCompra"
                .Parameters.Add("@tipo_compra", SqlDbType.VarChar).Value = entidad.tipo_compra
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entidad.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entidad.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entidad.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entidad.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entidad.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entidad.razon_social
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entidad.valor_facturado
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entidad.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entidad.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entidad.tipo_cambio
                .Parameters.Add("@detraccion", SqlDbType.Char).Value = entidad.detraccion
                .Parameters.Add("@fec_com_origen", SqlDbType.Date).Value = entidad.fec_comp_origen
                .Parameters.Add("@tipo_com_origen", SqlDbType.VarChar).Value = entidad.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entidad.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entidad.numero_comp_origen
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                .Parameters.Add("@id_usuario", SqlDbType.Int).Value = entidad.id_usuario
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
    Public Function registrarComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarComprobanteCompra"
                .Parameters.Add("@marca", SqlDbType.VarChar).Value = entidad.marca
                .Parameters.Add("@centro", SqlDbType.Int).Value = entidad.centro
                .Parameters.Add("@tipo_compra", SqlDbType.VarChar).Value = entidad.tipo_compra
                .Parameters.Add("@id_gravado", SqlDbType.VarChar).Value = entidad.id_gravado
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entidad.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entidad.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entidad.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entidad.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entidad.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entidad.razon_social
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entidad.valor_facturado
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entidad.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entidad.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entidad.tipo_cambio
                .Parameters.Add("@detraccion", SqlDbType.Char).Value = entidad.detraccion
                .Parameters.Add("@fec_com_origen", SqlDbType.Date).Value = entidad.fec_comp_origen
                .Parameters.Add("@tipo_com_origen", SqlDbType.VarChar).Value = entidad.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entidad.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entidad.numero_comp_origen
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                .Parameters.Add("@id_usuario", SqlDbType.Int).Value = entidad.id_usuario
                .Parameters.Add("@estadoComprobante", SqlDbType.Char).Value = entidad.estado_comprobante
                .Parameters.Add("@codEmpresa", SqlDbType.Int).Value = entidad.codEmpresa
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
    Public Function actualizarComprobanteCompraBD(entidad As ComprobanteCompraEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[usp_actualizarComprobanteCompra]"
                .Parameters.Add("@idCompra", SqlDbType.VarChar).Value = entidad.id
                .Parameters.Add("@marca", SqlDbType.VarChar).Value = entidad.marca
                .Parameters.Add("@centro", SqlDbType.Int).Value = entidad.centro
                .Parameters.Add("@tipo_compra", SqlDbType.VarChar).Value = entidad.tipo_compra
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entidad.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entidad.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entidad.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entidad.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entidad.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entidad.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entidad.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entidad.razon_social
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entidad.valor_facturado
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entidad.valor_igv
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entidad.total
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entidad.glosa
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entidad.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entidad.tipo_cambio
                .Parameters.Add("@detraccion", SqlDbType.Char).Value = entidad.detraccion
                .Parameters.Add("@fec_com_origen", SqlDbType.Date).Value = entidad.fec_comp_origen
                .Parameters.Add("@tipo_com_origen", SqlDbType.VarChar).Value = entidad.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entidad.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entidad.numero_comp_origen
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
                .Parameters.Add("@id_usuario", SqlDbType.Int).Value = entidad.id_usuario
                .Parameters.Add("@estadoComprobante", SqlDbType.Char).Value = entidad.estado_comprobante
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

    Public Function obtenerCUO_Compra() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerCUO_Compra", cn)
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
        Return dt.Rows(0)("numero").ToString

    End Function
    Public Function obtenerCUO_CompraBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerCUO_Compra", cnBD)
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
        Return dt.Rows(0)("numero").ToString

    End Function


End Class

