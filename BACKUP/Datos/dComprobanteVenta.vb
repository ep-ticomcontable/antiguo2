Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dComprobanteVenta
    Inherits Conexion

    Public Function obtenerIdComprobanteVenta() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdComprobanteVenta", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function obtenerIdComprobanteVentaBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdComprobanteVenta", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function registrarComprobanteVenta(entiCV As ComprobanteVentaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarComprobanteVenta"
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@tipo_venta", SqlDbType.VarChar).Value = entiCV.tipo_venta
                .Parameters.Add("@numero_maquina", SqlDbType.VarChar).Value = entiCV.numero_maquina
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entiCV.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entiCV.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entiCV.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entiCV.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entiCV.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entiCV.valor_facturado
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiCV.base_imponible
                .Parameters.Add("@valor_exonerado", SqlDbType.Decimal).Value = entiCV.valor_exonerado
                .Parameters.Add("@valor_inafecto", SqlDbType.Decimal).Value = entiCV.valor_inafecto
                .Parameters.Add("@valor_isc", SqlDbType.Decimal).Value = entiCV.valor_isc
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@otros_base_imponible", SqlDbType.Decimal).Value = entiCV.otros_base_imponible
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total
                .Parameters.Add("@tipo_cambio", SqlDbType.VarChar).Value = entiCV.tipo_cambio
                .Parameters.Add("@fec_comp_origen", SqlDbType.Date).Value = entiCV.fec_comp_origen
                .Parameters.Add("@tip_comp_origen", SqlDbType.VarChar).Value = entiCV.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entiCV.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entiCV.numero_comp_origen
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCV.estado
                .Parameters.Add("@id_usuario", SqlDbType.Char).Value = entiCV.id_usuario
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
    Public Function registrarComprobanteVentaBD(entiCV As ComprobanteVentaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarComprobanteVenta"
                .Parameters.Add("@numero_cuo", SqlDbType.Int).Value = entiCV.numero_cuo
                .Parameters.Add("@tipo_venta", SqlDbType.VarChar).Value = entiCV.tipo_venta
                .Parameters.Add("@id_gravado", SqlDbType.Int).Value = entiCV.id_gravado
                .Parameters.Add("@marca", SqlDbType.VarChar).Value = entiCV.marca
                .Parameters.Add("@centro_costo", SqlDbType.Int).Value = entiCV.centro
                .Parameters.Add("@numero_maquina", SqlDbType.VarChar).Value = entiCV.numero_maquina
                .Parameters.Add("@id_tipo_comprobante", SqlDbType.VarChar).Value = entiCV.id_tipo_comprobante
                .Parameters.Add("@fec_emision", SqlDbType.Date).Value = entiCV.fec_emision
                .Parameters.Add("@fec_pago", SqlDbType.Date).Value = entiCV.fec_pago
                .Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = entiCV.serie_comprobante
                .Parameters.Add("@numero_comprobante", SqlDbType.VarChar).Value = entiCV.numero_comprobante
                .Parameters.Add("@cod_dni", SqlDbType.VarChar).Value = entiCV.cod_dni
                .Parameters.Add("@num_dni", SqlDbType.VarChar).Value = entiCV.num_dni
                .Parameters.Add("@razon_social", SqlDbType.VarChar).Value = entiCV.razon_social
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCV.glosa
                .Parameters.Add("@valor_facturado", SqlDbType.Decimal).Value = entiCV.valor_facturado
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiCV.base_imponible
                .Parameters.Add("@valor_exonerado", SqlDbType.Decimal).Value = entiCV.valor_exonerado
                .Parameters.Add("@valor_inafecto", SqlDbType.Decimal).Value = entiCV.valor_inafecto
                .Parameters.Add("@valor_isc", SqlDbType.Decimal).Value = entiCV.valor_isc
                .Parameters.Add("@valor_igv", SqlDbType.Decimal).Value = entiCV.valor_igv
                .Parameters.Add("@otros_base_imponible", SqlDbType.Decimal).Value = entiCV.otros_base_imponible
                .Parameters.Add("@valor_descuento", SqlDbType.Decimal).Value = entiCV.valor_descuento
                .Parameters.Add("@total", SqlDbType.Decimal).Value = entiCV.total              
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entiCV.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.VarChar).Value = entiCV.tipo_cambio
                .Parameters.Add("@fec_comp_origen", SqlDbType.Date).Value = entiCV.fec_comp_origen
                .Parameters.Add("@tip_comp_origen", SqlDbType.VarChar).Value = entiCV.tip_comp_origen
                .Parameters.Add("@serie_comp_origen", SqlDbType.VarChar).Value = entiCV.serie_comp_origen
                .Parameters.Add("@numero_comp_origen", SqlDbType.VarChar).Value = entiCV.numero_comp_origen
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCV.estado
                .Parameters.Add("@id_usuario", SqlDbType.Char).Value = entiCV.id_usuario
                .Parameters.Add("@estadoComprobante", SqlDbType.Char).Value = entiCV.estado_comprobante
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

    Public Function registrarCajaChica(entiAA As CajaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCajaChica"
                '.Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                '.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = entiAA.comentarios
                '.Parameters.Add("@num_cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                '.Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                '.Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                '.Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                '.Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                '.Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                '.Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
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
    Public Function registrarCajaChicaBD(entiAA As CajaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCajaChica"
                '.Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                '.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = entiAA.comentarios
                '.Parameters.Add("@num_cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                '.Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                '.Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                '.Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                '.Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                '.Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                '.Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
                '.ExecuteNonQuery()
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

    Public Function registrarCajaBancos(entiAA As CajaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCajaBancos"
                '.Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                '.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = entiAA.comentarios
                '.Parameters.Add("@num_cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                '.Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                '.Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                '.Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                '.Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                '.Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                '.Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
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
    Public Function registrarCajaBancosBD(entiAA As CajaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCajaBancos"
                '.Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                '.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = entiAA.comentarios
                '.Parameters.Add("@num_cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                '.Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                '.Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                '.Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                '.Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                '.Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                '.Parameters.Add("@estado", SqlDbType.Char).Value = entiAA.estado
                '.Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
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

    Public Function listaAsienteoApertura() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAsienteoApertura", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaAsienteoAperturaBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAsienteoApertura", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function listaDetalleAsientoAperturaPorIdAsiento(idAsiento As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaDetalleAsientoAperturaPorIdAsiento", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaDetalleAsientoAperturaPorIdAsientoBD(idAsiento As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaDetalleAsientoAperturaPorIdAsiento", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idAsiento", SqlDbType.Int).Value = idAsiento
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function obtenerNumeroDeAsientoApertura() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerNumeroDeAsientoApertura", cn)
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
        Return Integer.Parse(dt.Rows(0)("numero").ToString) + 1
    End Function
    Public Function obtenerNumeroDeAsientoAperturaBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerNumeroDeAsientoApertura", cnBD)
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
        Return Integer.Parse(dt.Rows(0)("numero").ToString) + 1
    End Function

    Public Function obtenerIdAsientoApertura() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdAsientoApertura", cn)
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
        Return Integer.Parse(dt.Rows(0)("id").ToString) + 1
    End Function
    Public Function obtenerIdAsientoAperturaBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerIdAsientoApertura", cnBD)
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
        Return Integer.Parse(dt.Rows(0)("id").ToString) + 1
    End Function

    Public Function registrarDetalleAsientoVenta(entiAA As ComprobanteVentaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetalleAsientoVenta"
                .Parameters.Add("@id_asiento_venta", SqlDbType.Int).Value = entiAA.id_asiento_venta
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc_cont", SqlDbType.VarChar).Value = entiAA.id_tipo_comprobante
                .Parameters.Add("@num_doc", SqlDbType.VarChar).Value = entiAA.numero_comprobante
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

    Public Function registrarDetalleAsientoVentaBD(entiAA As ComprobanteVentaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetalleAsientoVenta"
                .Parameters.Add("@id_asiento_venta", SqlDbType.Int).Value = entiAA.id_asiento_venta
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entiAA.tipo_tasa_detraccion
                .Parameters.Add("@tasa_detraccion", SqlDbType.Decimal).Value = entiAA.tasa_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entiAA.fecha_detraccion
                .Parameters.Add("@numero_detraccion", SqlDbType.VarChar).Value = entiAA.numero_detraccion
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entiAA.valor_detraccion
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc_cont", SqlDbType.VarChar).Value = entiAA.id_tipo_comprobante
                .Parameters.Add("@num_doc", SqlDbType.VarChar).Value = entiAA.numero_comprobante
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

    Public Function dataComprobanteVentaPorId(codVenta As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_dataComprobanteVentaPorId", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codVenta", SqlDbType.VarChar).Value = codVenta
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
