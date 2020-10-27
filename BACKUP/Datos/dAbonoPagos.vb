Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dAbonoPagos
    Inherits Conexion

    Public Function registrarAbonoCompras(entiAA As AbonoComprasEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoCompras"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_venta", SqlDbType.VarChar).Value = entiAA.id_compra
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
            desconectar()
        End Try
    End Function
    Public Function registrarAbonoComprasBD(entiAA As AbonoComprasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoCompras"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_compra", SqlDbType.VarChar).Value = entiAA.id_compra
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
    Public Function registrarAsientoAbonoCompras(entiAA As AbonoComprasEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoAbonoCompras"
                .Parameters.Add("@id_abono_compra", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_cliente", SqlDbType.VarChar).Value = entiAA.id_cliente
                .Parameters.Add("@id_compra", SqlDbType.VarChar).Value = entiAA.monto
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiAA.base_imponible
                .Parameters.Add("@nro_detraccion", SqlDbType.VarChar).Value = entiAA.nro_detraccion
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entiAA.tipo_tasa_detraccion
                .Parameters.Add("@valor_tasa", SqlDbType.Decimal).Value = entiAA.valor_tasa
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entiAA.valor_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entiAA.fecha_detraccion
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
            desconectar()
        End Try
    End Function
    Public Function registrarAsientoAbonoComprasBD(entiAA As AbonoComprasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoAbonoCompras"
                .Parameters.Add("@id_abono_compra", SqlDbType.VarChar).Value = entiAA.id
                .Parameters.Add("@id_cliente", SqlDbType.VarChar).Value = entiAA.id_cliente
                .Parameters.Add("@id_compra", SqlDbType.VarChar).Value = entiAA.id_compra
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiAA.base_imponible
                .Parameters.Add("@nro_detraccion", SqlDbType.VarChar).Value = entiAA.nro_detraccion
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entiAA.tipo_tasa_detraccion
                .Parameters.Add("@valor_tasa", SqlDbType.Decimal).Value = entiAA.valor_tasa
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entiAA.valor_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entiAA.fecha_detraccion
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

    Public Function registrarAsientoAbonoVentas(entiAA As AbonoComprasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoAbonoVentas"
                .Parameters.Add("@id_abono_venta", SqlDbType.VarChar).Value = entiAA.id
                .Parameters.Add("@id_cliente", SqlDbType.VarChar).Value = entiAA.id_cliente
                .Parameters.Add("@id_venta", SqlDbType.VarChar).Value = entiAA.id_compra
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@base_imponible", SqlDbType.Decimal).Value = entiAA.base_imponible
                .Parameters.Add("@nro_detraccion", SqlDbType.VarChar).Value = entiAA.nro_detraccion
                .Parameters.Add("@tipo_tasa_detraccion", SqlDbType.VarChar).Value = entiAA.tipo_tasa_detraccion
                .Parameters.Add("@valor_tasa", SqlDbType.Decimal).Value = entiAA.valor_tasa
                .Parameters.Add("@valor_detraccion", SqlDbType.Decimal).Value = entiAA.valor_detraccion
                .Parameters.Add("@fecha_detraccion", SqlDbType.Date).Value = entiAA.fecha_detraccion
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

    Public Function obtenerUltimoAbonoCompra() As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerUltimoAbonoCompra", cn)
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
        If dt.Rows(0)("numero").ToString.Length >= 0 Then
            Return Integer.Parse(dt.Rows(0)("numero").ToString) + 1
        Else
            Return 1
        End If
    End Function

    Public Function obtenerUltimoAbonoCompraBD(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerUltimoAbonoCompra", cnBD)
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

    Public Function obtenerUltimoAbonoVenta(cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerUltimoAbonoVenta", cnBD)
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

    Public Function listaAbonosPagoCompras(idCompra As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAbonosPagoCompras", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCompra", SqlDbType.VarChar).Value = idCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listaAbonosPagoComprasBD(idCompra As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAbonosPagoCompras", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCompra", SqlDbType.VarChar).Value = idCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function sumaAbonoPagoCompras(idCompra As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_sumaAbonoPagoCompras", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCompra", SqlDbType.VarChar).Value = idCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function sumaAbonoPagoComprasBD(idCompra As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_sumaAbonoPagoCompras", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCompra", SqlDbType.VarChar).Value = idCompra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function registrarAbonoVentas(entiAA As AbonoVentasEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoVentas"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_venta", SqlDbType.VarChar).Value = entiAA.id_venta
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@id_banco", SqlDbType.VarChar).Value = entiAA.id_banco
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
            desconectar()
        End Try
    End Function
    Public Function registrarAbonoVentasBD(entiAA As AbonoVentasEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAbonoVentas"
                .Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = entiAA.tipo_comprobante
                .Parameters.Add("@id_venta", SqlDbType.VarChar).Value = entiAA.id_venta
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entiAA.id_caja
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiAA.monto
                .Parameters.Add("@id_banco", SqlDbType.VarChar).Value = entiAA.id_banco
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

End Class
