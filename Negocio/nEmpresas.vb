Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nEmpresas
    Inherits Conexion

    Dim obj As New dEmpresas
    Dim objCrud As New dCrud

    Public Function nListaEmpresasActivasPorUsuario(idUsuario As Integer) As DataTable
        Return obj.listaEmpresasActivasPorUsuario(idUsuario)
    End Function
    Public Function nListaEmpresasActivasPorUsuarioBD(idUsuario As Integer, cadena As String) As DataTable
        Return obj.listaEmpresasActivasPorUsuarioBD(idUsuario, cadena)
    End Function

    Public Function nDatosEmpresaPorId(idEmpresa As Integer) As DataTable
        Return obj.datosEmpresaPorId(idEmpresa)
    End Function
    Public Function nDatosEmpresaPorIdBD(idEmpresa As Integer, cadena As String) As DataTable
        Return obj.datosEmpresaPorIdBD(idEmpresa, cadena)
    End Function

    Public Function nDatosEmpresaPorAliasBD(nomAlias As String, cadena As String) As DataTable
        Return obj.datosEmpresaPorAliasBD(nomAlias, cadena)
    End Function

    Public Function nListaEmpresasTodas() As DataTable
        Return obj.listaEmpresasTodas()
    End Function
    Public Function nListaEmpresasTodasBD(cadena As String) As DataTable
        Return obj.listaEmpresasTodasBD(cadena)
    End Function

    Public Function nListaEmpresasPorTipoDeUsuario(tipo As String, idUsuario As Integer) As DataTable
        Return obj.listaEmpresasPorTipoDeUsuario(tipo, idUsuario)
    End Function
    Public Function nListaEmpresasPorTipoDeUsuarioBD(tipo As String, idUsuario As Integer, cadena As String) As DataTable
        Return obj.listaEmpresasPorTipoDeUsuarioBD(tipo, idUsuario, cadena)
    End Function

    Public Function nRegNuevaEmpresa(nomEmpresa As String, ByVal sqlBD As String, _
                                      ByVal sqlTables As String, _
                                      ByVal stores() As String) As String
        Try
            Dim rpta As String = ""
            rpta = obj.dRegNuevaEmpresa(nomEmpresa)
            If rpta = "1" Then

                rpta = objCrud.dEjecutarConsulta(sqlBD)
                If rpta = "1" Then
                    rpta = objCrud.dEjecutarConsulta(sqlTables)

                    If rpta = "1" Then
                        For Each strSQL As String In stores

                            If strSQL <> Nothing Then
                                rpta = objCrud.dEjecutarConsultaEnBD(nomEmpresa, strSQL)

                                If rpta <> "1" Then
                                    rpta = ("ERROR EN: " & rpta)
                                    Exit For
                                End If
                            End If
                        Next

                    End If

                End If
            End If

            Return rpta
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function nRegNuevaEmpresaBD(nomEmpresa As String, ByVal sqlBD As String, _
                                          ByVal sqlTables As String, _
                                          ByVal stores() As String, cadena As String) As String
        Try
            Dim rpta As String = ""
            rpta = obj.dRegNuevaEmpresaBD(nomEmpresa, cadena)
            If rpta = "1" Then

                rpta = objCrud.dEjecutarConsultaBD(sqlBD, cadena)
                If rpta = "1" Then
                    rpta = objCrud.dEjecutarConsultaBD(sqlTables, cadena)

                    If rpta = "1" Then
                        For Each strSQL As String In stores

                            If strSQL <> Nothing Then
                                rpta = objCrud.dEjecutarConsultaEnBD(nomEmpresa, strSQL)

                                If rpta <> "1" Then
                                    rpta = ("ERROR EN: " & rpta)
                                    Exit For
                                End If
                            End If
                        Next

                    End If

                End If
            End If

            Return rpta
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
