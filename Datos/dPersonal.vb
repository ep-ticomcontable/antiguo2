Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dPersonal
    Inherits Conexion

    Public Function registrarPersonal(entidad As PersonalEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarPersonal"
                .Parameters.Add("@cod_dni", SqlDbType.Int).Value = entidad.cod_dni
                .Parameters.Add("@cuspp", SqlDbType.VarChar).Value = entidad.cuspp
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = entidad.nombres
                .Parameters.Add("@ape_pat", SqlDbType.VarChar).Value = entidad.ape_pat
                .Parameters.Add("@ape_mat", SqlDbType.VarChar).Value = entidad.ape_mat
                .Parameters.Add("@fec_ingreso", SqlDbType.Date).Value = entidad.fec_ingreso
                .Parameters.Add("@id_cargo", SqlDbType.Int).Value = entidad.id_cargo
                .Parameters.Add("@id_moneda", SqlDbType.Int).Value = entidad.id_moneda
                .Parameters.Add("@sueldo_basico", SqlDbType.Decimal).Value = entidad.sueldo_basico
                .Parameters.Add("@asignacion", SqlDbType.VarChar).Value = entidad.asignacion
                .Parameters.Add("@valor_asignacion", SqlDbType.Decimal).Value = entidad.valor_asignacion
                .Parameters.Add("@num_hijos", SqlDbType.Int).Value = entidad.num_hijos
                .Parameters.Add("@id_pension", SqlDbType.Int).Value = entidad.id_pension
                .Parameters.Add("@porc_pension", SqlDbType.Decimal).Value = entidad.porc_pension
                .Parameters.Add("@descuentos", SqlDbType.Decimal).Value = entidad.descuentos
                .Parameters.Add("@total_remuneracion", SqlDbType.Decimal).Value = entidad.total_remuneracion
                .Parameters.Add("@fec_registro", SqlDbType.Date).Value = entidad.fec_registro
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
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

    Public Function actualizarPersonal(entidad As PersonalEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarPersonal"
                .Parameters.Add("@id", SqlDbType.Int).Value = entidad.id
                .Parameters.Add("@cod_dni", SqlDbType.Int).Value = entidad.cod_dni
                .Parameters.Add("@cuspp", SqlDbType.VarChar).Value = entidad.cuspp
                .Parameters.Add("@nombres", SqlDbType.VarChar).Value = entidad.nombres
                .Parameters.Add("@ape_pat", SqlDbType.VarChar).Value = entidad.ape_pat
                .Parameters.Add("@ape_mat", SqlDbType.VarChar).Value = entidad.ape_mat
                .Parameters.Add("@fec_ingreso", SqlDbType.Date).Value = entidad.fec_ingreso
                .Parameters.Add("@id_cargo", SqlDbType.Int).Value = entidad.id_cargo
                .Parameters.Add("@id_moneda", SqlDbType.Int).Value = entidad.id_moneda
                .Parameters.Add("@sueldo_basico", SqlDbType.Decimal).Value = entidad.sueldo_basico
                .Parameters.Add("@asignacion", SqlDbType.VarChar).Value = entidad.asignacion
                .Parameters.Add("@valor_asignacion", SqlDbType.Decimal).Value = entidad.valor_asignacion
                .Parameters.Add("@num_hijos", SqlDbType.Int).Value = entidad.num_hijos
                .Parameters.Add("@id_pension", SqlDbType.Int).Value = entidad.id_pension
                .Parameters.Add("@porc_pension", SqlDbType.Decimal).Value = entidad.porc_pension
                .Parameters.Add("@descuentos", SqlDbType.Decimal).Value = entidad.descuentos
                .Parameters.Add("@total_remuneracion", SqlDbType.Decimal).Value = entidad.total_remuneracion
                .Parameters.Add("@fec_registro", SqlDbType.Date).Value = entidad.fec_registro
                .Parameters.Add("@estado", SqlDbType.Char).Value = entidad.estado
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

End Class
