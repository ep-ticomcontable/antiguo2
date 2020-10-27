Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nUsuarios

    Dim obj As New dUsuarios

    Public Function verificarSesionUsuario(user As UsuariosE) As DataTable
        Return obj.verificarSesionUsuario(user)
    End Function
    Public Function verificarSesionUsuarioBD(user As UsuariosE, cadena As String) As DataTable
        Return obj.verificarSesionUsuarioBD(user, cadena)
    End Function

    Public Function nListaUsuariosPorTipoDeUsuario(tipo As String, idUsuario As Integer) As DataTable
        Return obj.listaUsuariosPorTipoDeUsuario(tipo, idUsuario)
    End Function
    Public Function nListaUsuariosPorTipoDeUsuarioBD(tipo As String, idUsuario As Integer, cadena As String) As DataTable
        Return obj.listaUsuariosPorTipoDeUsuarioBD(tipo, idUsuario, cadena)
    End Function

    Public Function nRegistrarUsuario(entiUsu As UsuariosE) As String
        Return obj.registrarUsuario(entiUsu)
    End Function
    Public Function nRegistrarUsuarioBD(entiUsu As UsuariosE, cadena As String) As String
        Return obj.registrarUsuarioBD(entiUsu, cadena)
    End Function
End Class
