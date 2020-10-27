Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dTablaContenido
    Inherits Conexion

    Public Function listarTablaContenidoPorTabla(idTabla As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listarTablaContenidoPorTabla", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = idTabla
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function listarTablaContenidoPorTablaBD(idTabla As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listarTablaContenidoPorTabla", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = idTabla
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function verificarDatoTablaContenido(dato As String, idTabla As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarDatoTablaContenido", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = idTabla
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function verificarDatoTablaContenidoBD(dato As String, idTabla As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarDatoTablaContenido", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = idTabla
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function crearDatoTablaContenido(tabContEnti As TablaContenidoEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearDatoTablaContenido"
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = tabContEnti.idLocal
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = tabContEnti.idTabla
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = tabContEnti.descripcion
                .Parameters.Add("@abreviatura", SqlDbType.VarChar).Value = tabContEnti.abreviatura
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
    Public Function crearDatoTablaContenidoBD(tabContEnti As TablaContenidoEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearDatoTablaContenido"
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = tabContEnti.idLocal
                .Parameters.Add("@idTabla", SqlDbType.Int).Value = tabContEnti.idTabla
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = tabContEnti.descripcion
                .Parameters.Add("@abreviatura", SqlDbType.VarChar).Value = tabContEnti.abreviatura
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

End Class

