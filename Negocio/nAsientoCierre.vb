Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nAsientoCierre
    Inherits Conexion

    Dim obj As New dAsientoCierre

    Public Function registrarAjusteAsientoCierre(entiAA As AsientoCierreEntity) As String
        Return obj.registrarAjusteAsientoCierre(entiAA)
    End Function
    Public Function registrarAjusteAsientoCierreBD(entiAA As AsientoCierreEntity, cadena As String) As String
        Return obj.registrarAjusteAsientoCierreBD(entiAA, cadena)
    End Function

    Public Function registrarCierreMensual(anio As String, mes As String, proceso As String, cuenta As String, glosa As String, debe As Decimal, haber As Decimal, cadena As String) As String
        Return obj.registrarCierreMensual(anio, mes, proceso, cuenta, glosa, debe, haber, cadena)
    End Function
End Class
