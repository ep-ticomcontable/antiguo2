Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dAsientoLibroDiario
    Inherits Conexion


    Public Function registrarComodinBD(entiAA As ComodinEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarComodin"
                .Parameters.Add("@id_tipo_operacion", SqlDbType.VarChar).Value = entiAA.id_tipo_operacion
                .Parameters.Add("@id_tipo_documento", SqlDbType.VarChar).Value = entiAA.id_tipo_documento
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiAA.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@operacion", SqlDbType.VarChar).Value = entiAA.operacion
                .Parameters.Add("@id_banco", SqlDbType.VarChar).Value = entiAA.id_banco
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@diferencia", SqlDbType.Decimal).Value = entiAA.diferencia
                .Parameters.Add("@fec_reg", SqlDbType.DateTime).Value = entiAA.fec_reg
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
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

    Public Function actualizarComodinBD(entiAA As ComodinEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarComodin"
                .Parameters.Add("@id", SqlDbType.Int).Value = entiAA.id
                .Parameters.Add("@id_tipo_operacion", SqlDbType.VarChar).Value = entiAA.id_tipo_operacion
                .Parameters.Add("@id_tipo_documento", SqlDbType.VarChar).Value = entiAA.id_tipo_documento
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiAA.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@operacion", SqlDbType.VarChar).Value = entiAA.operacion
                .Parameters.Add("@id_banco", SqlDbType.VarChar).Value = entiAA.id_banco
                .Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@diferencia", SqlDbType.Decimal).Value = entiAA.diferencia
                .Parameters.Add("@fec_reg", SqlDbType.DateTime).Value = entiAA.fec_reg
                .Parameters.Add("@tipo", SqlDbType.VarChar).Value = entiAA.tipo
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


    Public Function registrarAsientoLibroDiario(entiAA As ALDiarioEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoLibroDiario"
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                .Parameters.Add("@cuo", SqlDbType.VarChar).Value = entiAA.cuo
                .Parameters.Add("@fecha_operacion", SqlDbType.Date).Value = entiAA.fecha_operacion
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@cod_libro", SqlDbType.VarChar).Value = entiAA.cod_libro
                .Parameters.Add("@numero_correlativo", SqlDbType.VarChar).Value = entiAA.numero_correlativo
                .Parameters.Add("@numero_documento", SqlDbType.VarChar).Value = entiAA.numero_documento
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@denominacion", SqlDbType.VarChar).Value = entiAA.denominacion
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
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
    Public Function registrarAsientoLibroDiarioBD(entiAA As ALDiarioEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoLibroDiario"
                .Parameters.Add("@id_comprobante", SqlDbType.VarChar).Value = entiAA.id_comprobante
                .Parameters.Add("@cuo", SqlDbType.VarChar).Value = entiAA.cuo
                .Parameters.Add("@fecha_operacion", SqlDbType.Date).Value = entiAA.fecha_operacion
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@cod_libro", SqlDbType.VarChar).Value = entiAA.cod_libro
                .Parameters.Add("@numero_correlativo", SqlDbType.VarChar).Value = entiAA.numero_correlativo
                .Parameters.Add("@numero_documento", SqlDbType.VarChar).Value = entiAA.numero_documento
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@denominacion", SqlDbType.VarChar).Value = entiAA.denominacion
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
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

    Public Function listaAsientoLibroDiario() As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAsientoLibroDiario", cn)
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
    Public Function listaAsientoLibroDiarioBD(cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaAsientoLibroDiario", cnBD)
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

End Class
