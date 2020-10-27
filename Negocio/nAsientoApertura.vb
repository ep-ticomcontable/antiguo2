Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAsientoApertura
    Inherits Conexion

    Dim obj As New dAsientoApertura

    Public Function nRegistrarAsientoApertura(entiAA As AAperturaEntity) As String
        Return obj.registrarAsientoApertura(entiAA)
    End Function
    Public Function nRegistrarAsientoAperturaBD(entiAA As AAperturaEntity, cadena As String) As String
        Return obj.registrarAsientoAperturaBD(entiAA, cadena)
    End Function

    Public Function nActualizarAsientoAperturaBD(entiAA As AAperturaEntity, cadena As String) As String
        Return obj.actualizarAsientoAperturaBD(entiAA, cadena)
    End Function

    Public Function nRegistrarDetalleAsientoApertura(entiDAA As DetalleAAperturaEntity) As String
        Return obj.registrarDetalleAsientoApertura(entiDAA)
    End Function
    Public Function nRegistrarDetalleAsientoAperturaBD(entiDAA As DetalleAAperturaEntity, cadena As String) As String
        Return obj.registrarDetalleAsientoAperturaBD(entiDAA, cadena)
    End Function

    Public Function nListaAsienteoApertura() As DataTable
        Return obj.listaAsienteoApertura()
    End Function
    Public Function nListaAsienteoAperturaBD(cadena As String) As DataTable
        Return obj.listaAsienteoAperturaBD(cadena)
    End Function

    Public Function nListaDetalleAsientoAperturaPorIdAsiento(idAsiento As Integer) As DataTable
        Return obj.listaDetalleAsientoAperturaPorIdAsiento(idAsiento)
    End Function
    Public Function nListaDetalleAsientoAperturaPorIdAsientoBD(idAsiento As Integer,cadena As String) As DataTable
        Return obj.listaDetalleAsientoAperturaPorIdAsientoBD(idAsiento, cadena)
    End Function

    Public Function nObtenerNumeroDeAsientoApertura() As String
        Return obj.obtenerNumeroDeAsientoApertura()
    End Function
    Public Function nObtenerNumeroDeAsientoAperturaBD(cadena As String) As String
        Return obj.obtenerNumeroDeAsientoAperturaBD(cadena)
    End Function

    Public Function nObtenerIdAsientoApertura() As String
        Return obj.obtenerIdAsientoApertura()
    End Function
    Public Function nObtenerIdAsientoAperturaBD(cadena As String) As String
        Return obj.obtenerIdAsientoAperturaBD(cadena)
    End Function
End Class
