Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nTablaContenido
    Inherits Conexion

    Dim obj As New dTablaContenido

    Public Function listarTablaContenidoPorTabla(idTabla As Integer) As DataTable
        Return obj.listarTablaContenidoPorTabla(idTabla)
    End Function
    Public Function listarTablaContenidoPorTablaBD(idTabla As Integer, cadena As String) As DataTable
        Return obj.listarTablaContenidoPorTablaBD(idTabla, cadena)
    End Function

    Public Function modificarCliente(dato As String, idTabla As Integer) As DataTable
        Return obj.verificarDatoTablaContenido(dato, idTabla)
    End Function
    Public Function modificarClienteBD(dato As String, idTabla As Integer, cadena As String) As DataTable
        Return obj.verificarDatoTablaContenidoBD(dato, idTabla, cadena)
    End Function

    Public Function crearDatoTablaContenido(tabContEnti As TablaContenidoEntity) As String
        Return obj.crearDatoTablaContenido(tabContEnti)
    End Function
    Public Function crearDatoTablaContenidoBD(tabContEnti As TablaContenidoEntity, cadena As String) As String
        Return obj.crearDatoTablaContenidoBD(tabContEnti, cadena)
    End Function

End Class
