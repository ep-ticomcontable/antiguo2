Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nProductos
    Inherits Conexion

    Dim obj As New dProductos

    Public Function nCrearProductos(prodEntity As ProductosEntity) As String
        Return obj.crearProductos(prodEntity)
    End Function

    Public Function nCrearProductosPorLocal(prodLocalEntity As ProductosLocalEntity) As String
        Return obj.crearProductosPorLocal(prodLocalEntity)
    End Function

    Public Function nActualizarProductos(prodEntity As ProductosEntity) As String
        Return obj.actualizarProductos(prodEntity)
    End Function

    Public Function nActualizarProductosLocal(prodLocalEntity As ProductosLocalEntity) As String
        Return obj.actualizarProductosPorLocal(prodLocalEntity)
    End Function

    Public Function nObtenerProductoPreCreado(prodEntity As ProductosEntity) As DataTable
        Return obj.obtenerProductoPreCreado(prodEntity)
    End Function

    Public Function nDatosProductoLocalPorLocal(idProducto As Integer, idLocal As Integer) As DataTable
        Return obj.datosProductoLocalPorLocal(idProducto, idLocal)
    End Function

    Public Function nDatosProductoGrilla(idLocal As Integer) As DataTable
        Return obj.datosProductoGrilla(idLocal)
    End Function

    Public Function nBuscarProductosPorTexto(dato As String, idLocal As Integer, numReg As Integer) As DataTable
        Return obj.buscarProductosPorTexto(dato, idLocal, numReg)
    End Function

    Public Function nTotalProductosRelacionadosPorTexto(dato As String, idLocal As Integer) As Integer
        Return obj.totalProductosRelacionadosPorTexto(dato, idLocal)
    End Function
End Class
