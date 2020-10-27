Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class dProductos
    Inherits Conexion

    Public Function crearProductos(producto As ProductosEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearProducto"
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
                .Parameters.Add("@imagen", SqlDbType.VarChar).Value = producto.imagen
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = producto.id_usuario
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
    Public Function crearProductosBD(producto As ProductosEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearProducto"
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
                .Parameters.Add("@imagen", SqlDbType.VarChar).Value = producto.imagen
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = producto.id_usuario
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

    Public Function crearProductosPorLocal(prodLocal As ProductosLocalEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearProductoLocal"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = prodLocal.id_producto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = prodLocal.id_local
                .Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = prodLocal.ubicacion
                .Parameters.Add("@stock", SqlDbType.Int).Value = prodLocal.stock
                .Parameters.Add("@pCompra", SqlDbType.Decimal).Value = prodLocal.p_compra
                .Parameters.Add("@pVenta", SqlDbType.Decimal).Value = prodLocal.p_venta
                .Parameters.Add("@pMayor", SqlDbType.Decimal).Value = prodLocal.p_mayor
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
    Public Function crearProductosPorLocalBD(prodLocal As ProductosLocalEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearProductoLocal"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = prodLocal.id_producto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = prodLocal.id_local
                .Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = prodLocal.ubicacion
                .Parameters.Add("@stock", SqlDbType.Int).Value = prodLocal.stock
                .Parameters.Add("@pCompra", SqlDbType.Decimal).Value = prodLocal.p_compra
                .Parameters.Add("@pVenta", SqlDbType.Decimal).Value = prodLocal.p_venta
                .Parameters.Add("@pMayor", SqlDbType.Decimal).Value = prodLocal.p_mayor
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

    Public Function actualizarProductos(producto As ProductosEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarProducto"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = producto.id
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
                .Parameters.Add("@imagen", SqlDbType.VarChar).Value = producto.imagen
                .Parameters.Add("@web", SqlDbType.Char).Value = producto.web
                .Parameters.Add("@estado", SqlDbType.Char).Value = producto.estado
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
    Public Function actualizarProductosBD(producto As ProductosEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarProducto"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = producto.id
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
                .Parameters.Add("@imagen", SqlDbType.VarChar).Value = producto.imagen
                .Parameters.Add("@web", SqlDbType.Char).Value = producto.web
                .Parameters.Add("@estado", SqlDbType.Char).Value = producto.estado
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

    Public Function actualizarProductosPorLocal(prodLocal As ProductosLocalEntity) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarProductoLocal"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = prodLocal.id_producto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = prodLocal.id_local
                .Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = prodLocal.ubicacion
                .Parameters.Add("@stock", SqlDbType.Int).Value = prodLocal.stock
                .Parameters.Add("@pCompra", SqlDbType.Decimal).Value = prodLocal.p_compra
                .Parameters.Add("@pVenta", SqlDbType.Decimal).Value = prodLocal.p_venta
                .Parameters.Add("@pMayor", SqlDbType.Decimal).Value = prodLocal.p_mayor
                .Parameters.Add("@estado", SqlDbType.Char).Value = prodLocal.estado
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
    Public Function actualizarProductosPorLocalBD(prodLocal As ProductosLocalEntity, cadena As String) As String
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim miTran As SqlTransaction = cnBD.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cnBD
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_actualizarProductoLocal"
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = prodLocal.id_producto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = prodLocal.id_local
                .Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = prodLocal.ubicacion
                .Parameters.Add("@stock", SqlDbType.Int).Value = prodLocal.stock
                .Parameters.Add("@pCompra", SqlDbType.Decimal).Value = prodLocal.p_compra
                .Parameters.Add("@pVenta", SqlDbType.Decimal).Value = prodLocal.p_venta
                .Parameters.Add("@pMayor", SqlDbType.Decimal).Value = prodLocal.p_mayor
                .Parameters.Add("@estado", SqlDbType.Char).Value = prodLocal.estado
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

    Public Function obtenerProductoPreCreado(producto As ProductosEntity) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerProductoPreCreado", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function obtenerProductoPreCreadoBD(producto As ProductosEntity, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_obtenerProductoPreCreado", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idCategoria", SqlDbType.Int).Value = producto.id_categoria
                .Parameters.Add("@idMarca", SqlDbType.Int).Value = producto.id_marca
                .Parameters.Add("@idModelo", SqlDbType.Int).Value = producto.id_modelo
                .Parameters.Add("@idMaterial", SqlDbType.Int).Value = producto.id_material
                .Parameters.Add("@idTemporada", SqlDbType.Int).Value = producto.id_temporada
                .Parameters.Add("@idGenero", SqlDbType.Int).Value = producto.id_genero
                .Parameters.Add("@idUnidad", SqlDbType.Int).Value = producto.id_unidad
                .Parameters.Add("@idColor", SqlDbType.Int).Value = producto.id_color
                .Parameters.Add("@numSerie", SqlDbType.VarChar).Value = producto.num_serie
                .Parameters.Add("@codBarra", SqlDbType.VarChar).Value = producto.cod_barra
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function datosProductoLocalPorLocal(idProducto As Integer, idLocal As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosProductoLocalPorProducto", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = idProducto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function datosProductoLocalPorLocalBD(idProducto As Integer, idLocal As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosProductoLocalPorProducto", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idProducto", SqlDbType.Int).Value = idProducto
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function datosProductoGrilla(idLocal As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosProductoGrilla", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function datosProductoGrillaBD(idLocal As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_datosProductoGrilla", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.Int).Value = idLocal
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function buscarProductosPorTexto(dato As String, idLocal As Integer, numReg As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_buscarProductosPorTexto", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.VarChar).Value = idLocal
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
                .Parameters.Add("@numReg", SqlDbType.VarChar).Value = numReg
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function buscarProductosPorTexto(dato As String, idLocal As Integer, numReg As Integer, cadena As String) As DataTable
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_buscarProductosPorTexto", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.VarChar).Value = idLocal
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
                .Parameters.Add("@numReg", SqlDbType.VarChar).Value = numReg
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectarBD()
        End Try
        Return dt
    End Function

    Public Function totalProductosRelacionadosPorTexto(dato As String, idLocal As Integer) As Integer
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_totalProductosRelacionadosPorTexto", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.VarChar).Value = idLocal
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return 0
        Finally
            desconectar()
        End Try
        Return dt.Rows(0)(0).ToString
    End Function
    Public Function totalProductosRelacionadosPorTextoBD(dato As String, idLocal As Integer, cadena As String) As Integer
        If cnBD.State = ConnectionState.Closed Then conectarBD(cadena)
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_totalProductosRelacionadosPorTexto", cnBD)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idLocal", SqlDbType.VarChar).Value = idLocal
                .Parameters.Add("@dato", SqlDbType.VarChar).Value = dato
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return 0
        Finally
            desconectarBD()
        End Try
        Return dt.Rows(0)(0).ToString
    End Function
End Class

