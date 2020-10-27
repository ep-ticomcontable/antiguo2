Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dCrud
    Inherits Conexion

    Public Function dEjecutarConsulta(ByVal sql As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        cmd = New SqlCommand

        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_ejecutarQuery"
                .Parameters.Add("@query", SqlDbType.Text).Value = sql
                .ExecuteNonQuery()
            End With

            Return "1"
        Catch ex As Exception
            Return "2"
        Finally
            desconectar()
        End Try
    End Function
    Public Function dEjecutarConsultaBD(ByVal sql As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_ejecutarQuery"
                .Parameters.Add("@query", SqlDbType.Text).Value = sql
                .ExecuteNonQuery()
            End With

            Return "1"
        Catch ex As Exception
            Return "2"
        Finally
            desconectar()
        End Try
    End Function
    Public Function dCargarBD(nombre As String, ruta As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        'cn.ChangeDatabase("master")
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "exec usp_attachBD '" & nombre & "','" & ruta & "'"
                .ExecuteNonQuery()
            End With
            Return "ok"
        Catch ex As Exception
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
    End Function

    Public Function dEjecutarConsultaOtrosEnBD(ByVal sql As String, ByVal nombreBD As String) As String
        If cn.State = ConnectionState.Closed Then conectarBD(nombreBD)
        'cn.ChangeDatabase(nombreBD)
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            Return "ok"
        Catch ex As Exception
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectarBD()
        End Try
        'cn.ChangeDatabase("TICOM-CONTABLE")
    End Function

    Public Function dEjecutarConsultaEnBD(ByVal sql As String, ByVal nombreBD As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        cn.ChangeDatabase(nombreBD)

        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = sql
                .ExecuteNonQuery()
            End With

            Return "ok"
        Catch ex As Exception
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
        cn.ChangeDatabase("bdTicomContable")
    End Function


    Public Function dCambiarBD(nomBd As String)
        Try
            cn.ChangeDatabase(nomBd)
            Return "ok"
        Catch ex As Exception
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
    End Function

    Public Function dEjecutarQuery(query As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_ejecutarQuerys"
                .Parameters.Add("@query", SqlDbType.VarChar).Value = query
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectar()
        End Try
    End Function
    Public Function dEjecutarQueryBD(query As String, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_ejecutarQuerys"
                .Parameters.Add("@query", SqlDbType.VarChar).Value = query
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "ok"
        Catch ex As Exception
            miTran.Rollback()
            Return "Error en la Transacción: " & ex.Message
        Finally
            desconectarBD()
        End Try
    End Function

    Public Function dEjecutarQueryListaBD(query As String, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_ejecutarQuerys", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@query", SqlDbType.VarChar).Value = query
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function
    Public Function dEjecutarQueryLista(query As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_ejecutarQuerys", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@query", SqlDbType.VarChar).Value = query
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function registrarDetraccionVenta(entiCaja As CajaEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetraccionVentas"
                .Parameters.Add("@cajaS", SqlDbType.VarChar).Value = entiCaja.id_tipo_caja
                .Parameters.Add("@cajaE", SqlDbType.VarChar).Value = entiCaja.id_tipo_salida
                .Parameters.Add("@numOperacion", SqlDbType.VarChar).Value = entiCaja.cliente
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCaja.monto
                .Parameters.Add("@idComprobante", SqlDbType.VarChar).Value = entiCaja.id_documento
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCaja.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCaja.numero
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCaja.glosa
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
    Public Function registrarDetalleCajaBD(entiCaja As CajaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarDetalleCaja"
                .Parameters.Add("@id_tipo_caja", SqlDbType.VarChar).Value = entiCaja.id_tipo_caja
                .Parameters.Add("@id_tipo_salida", SqlDbType.VarChar).Value = entiCaja.id_tipo_salida
                .Parameters.Add("@id_documento", SqlDbType.VarChar).Value = entiCaja.id_documento
                .Parameters.Add("@serie", SqlDbType.VarChar).Value = entiCaja.serie
                .Parameters.Add("@numero", SqlDbType.VarChar).Value = entiCaja.numero
                .Parameters.Add("@dni_ruc", SqlDbType.VarChar).Value = entiCaja.dni_ruc
                .Parameters.Add("@cliente", SqlDbType.VarChar).Value = entiCaja.cliente
                .Parameters.Add("@monto", SqlDbType.Decimal).Value = entiCaja.monto
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCaja.glosa
                .Parameters.Add("@estado", SqlDbType.Char).Value = "1"
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

    Public Function registrarAsientosCajaBD(entiCaja As CajaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientosCaja"
                .Parameters.Add("@estado", SqlDbType.Char).Value = entiCaja.estado
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entiCaja.id_caja
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCaja.glosa
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiCaja.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiCaja.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiCaja.haber
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
    Public Function registrarAsientosCajaLDBD(entiCaja As CajaEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarAsientosCajaLD"
                .Parameters.Add("@id_caja", SqlDbType.VarChar).Value = entiCaja.id_caja
                .Parameters.Add("@glosa", SqlDbType.VarChar).Value = entiCaja.glosa
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = entiCaja.cuenta
                .Parameters.Add("@debe", SqlDbType.Decimal).Value = entiCaja.debe
                .Parameters.Add("@haber", SqlDbType.Decimal).Value = entiCaja.haber
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
