Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class nCuentaImpuestos
    Inherits Conexion

    Public Function registrarAsientoApertura(entiAA As AAperturaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoApertura"
                .Parameters.Add("@id", SqlDbType.Int).Value = entiAA.id
                .Parameters.Add("@id_asiento", SqlDbType.Int).Value = entiAA.id_asiento
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@total_debe_s", SqlDbType.Decimal).Value = entiAA.total_debe_s
                .Parameters.Add("@total_haber_s", SqlDbType.Decimal).Value = entiAA.total_haber_s
                .Parameters.Add("@diferencia_s", SqlDbType.Decimal).Value = entiAA.diferencia_s
                .Parameters.Add("@total_debe_d", SqlDbType.Decimal).Value = entiAA.total_debe_d
                .Parameters.Add("@total_haber_d", SqlDbType.Decimal).Value = entiAA.total_haber_d
                .Parameters.Add("@diferencia_d", SqlDbType.Decimal).Value = entiAA.diferencia_d
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = entiAA.periodo
                .Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                .Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
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
    Public Function registrarAsientoAperturaBD(entiAA As AAperturaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientoApertura"
                .Parameters.Add("@id", SqlDbType.Int).Value = entiAA.id
                .Parameters.Add("@id_asiento", SqlDbType.Int).Value = entiAA.id_asiento
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiAA.numero
                .Parameters.Add("@total_debe_s", SqlDbType.Decimal).Value = entiAA.total_debe_s
                .Parameters.Add("@total_haber_s", SqlDbType.Decimal).Value = entiAA.total_haber_s
                .Parameters.Add("@diferencia_s", SqlDbType.Decimal).Value = entiAA.diferencia_s
                .Parameters.Add("@total_debe_d", SqlDbType.Decimal).Value = entiAA.total_debe_d
                .Parameters.Add("@total_haber_d", SqlDbType.Decimal).Value = entiAA.total_haber_d
                .Parameters.Add("@diferencia_d", SqlDbType.Decimal).Value = entiAA.diferencia_d
                .Parameters.Add("@periodo", SqlDbType.VarChar).Value = entiAA.periodo
                .Parameters.Add("@fecha", SqlDbType.Date).Value = entiAA.fecha
                .Parameters.Add("@id_usuario", SqlDbType.Int).Value = entiAA.id_usuario
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

    Public Function registrarDetalleAsientoApertura(entiAA As DetalleAAperturaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetalleAsientoApertura"
                .Parameters.Add("@id_asiento_apertura", SqlDbType.Int).Value = entiAA.id_asiento_apertura
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@id_moneda", SqlDbType.Int).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc_cont", SqlDbType.Int).Value = entiAA.id_doc_cont
                .Parameters.Add("@num_doc", SqlDbType.Char).Value = entiAA.num_doc
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
    Public Function registrarDetalleAsientoAperturaBD(entiAA As DetalleAAperturaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetalleAsientoApertura"
                .Parameters.Add("@id_asiento_apertura", SqlDbType.Int).Value = entiAA.id_asiento_apertura
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiAA.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiAA.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiAA.haber
                .Parameters.Add("@id_moneda", SqlDbType.Int).Value = entiAA.id_moneda
                .Parameters.Add("@tipo_cambio", SqlDbType.Decimal).Value = entiAA.tipo_cambio
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiAA.glosa
                .Parameters.Add("@id_doc_cont", SqlDbType.Int).Value = entiAA.id_doc_cont
                .Parameters.Add("@num_doc", SqlDbType.Char).Value = entiAA.num_doc
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
End Class
