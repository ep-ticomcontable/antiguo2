Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dCentroCostos
    Inherits Conexion

    Public Function registrarCentroCosto(idLocal As Integer, descripcion As String, idEmpleado As Integer, subCentro As Integer, estado As Integer) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCentroCosto"
                .Parameters.Add("@id_local", SqlDbType.Int).Value = idLocal
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("@id_empleado", SqlDbType.Int).Value = idEmpleado
                .Parameters.Add("@sub_centro", SqlDbType.Int).Value = subCentro
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
    Public Function registrarCentroCostoBD(idLocal As Integer, descripcion As String, idEmpleado As Integer, subCentro As Integer, estado As Integer, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarCentroCosto"
                .Parameters.Add("@id_local", SqlDbType.Int).Value = idLocal
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("@id_empleado", SqlDbType.Int).Value = idEmpleado
                .Parameters.Add("@sub_centro", SqlDbType.Int).Value = subCentro
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

    Public Function registrarParametroCentroCosto(idCentro As Integer, descripcion As String, porcentaje As Decimal, cuenta As String, debe As String, haber As String, estado As Integer) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarParametroCentroCosto"
                .Parameters.Add("@id_centro", SqlDbType.Int).Value = idCentro
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = porcentaje
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = cuenta
                .Parameters.Add("@debe", SqlDbType.VarChar).Value = debe
                .Parameters.Add("@haber", SqlDbType.VarChar).Value = haber
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
    Public Function registrarParametroCentroCostoBD(idCentro As Integer, descripcion As String, porcentaje As Decimal, cuenta As String, debe As String, haber As String, estado As Integer, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_registrarParametroCentroCosto"
                .Parameters.Add("@id_centro", SqlDbType.Int).Value = idCentro
                .Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = porcentaje
                .Parameters.Add("@cuenta", SqlDbType.VarChar).Value = cuenta
                .Parameters.Add("@debe", SqlDbType.VarChar).Value = debe
                .Parameters.Add("@haber", SqlDbType.VarChar).Value = haber
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

End Class
