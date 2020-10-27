Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class nCrud
    Dim obj As New dCrud

    Public Function nCambiarBD(nomBd As String) As String
        Return obj.dCambiarBD(nombd)
    End Function

    Public Function nCrudInsertar(delimitador As String, tabla As String, aCampos As String, aValores As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)

        Dim sql As String
        sql = "insert " & tabla & " ("
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & ","
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & ") values ("
            End If
        Next
        For j As Integer = 0 To valores.Count
            If j < (valores.Count - 1) Then
                sql += "'" & valores(j) & "',"
            End If
            If j = (valores.Count - 1) Then
                sql += "'" & valores(j) & "');"
            End If
        Next
        Return obj.dEjecutarQuery(sql)
    End Function
    Public Function nCrudInsertarBD(delimitador As String, tabla As String, aCampos As String, aValores As String, cadena As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)

        Dim sql As String
        sql = "insert " & tabla & " ("
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & ","
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & ") values ("
            End If
        Next
        For j As Integer = 0 To valores.Count
            If j < (valores.Count - 1) Then
                sql += "'" & valores(j) & "',"
            End If
            If j = (valores.Count - 1) Then
                sql += "'" & valores(j) & "');"
            End If
        Next
        Return obj.dEjecutarQueryBD(sql, cadena)
    End Function

    Public Function nCrudActualizar(delimitador As String, tabla As String, aCampos As String, aValores As String, condicion As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)

        Dim sql As String
        sql = "update " & tabla & " set "
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "', "
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "' where "
            End If
        Next
        sql += condicion & ";"
        Return obj.dEjecutarQuery(sql)
    End Function
    Public Function nCrudActualizarBD(delimitador As String, tabla As String, aCampos As String, aValores As String, condicion As String, cadena As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)

        Dim sql As String
        sql = "update " & tabla & " set "
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "', "
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "' where "
            End If
        Next
        sql += condicion & ";"
        Return obj.dEjecutarQueryBD(sql, cadena)
    End Function

    Public Function nCrudListar(query As String) As DataTable
        Return obj.dEjecutarQueryLista(query)
    End Function
    Public Function nCrudListarBD(query As String, cadena As String) As DataTable
        Return obj.dEjecutarQueryListaBD(query, cadena)
    End Function

    Public Function nEjecutarQuery(query As String) As String
        Return obj.dEjecutarQuery(query)
    End Function
    Public Function nEjecutarQueryBD(query As String, cadena As String) As String
        Return obj.dEjecutarQueryBD(query, cadena)
    End Function
    Public Function nEjecutarConsultaOtrosEnBD(sql As String, cadena As String)
        Return obj.dEjecutarConsultaOtrosEnBD(sql, cadena)
    End Function
    Public Function nCargarBD(nombre As String, ruta As String) As String
        Return obj.dCargarBD(nombre, ruta)
    End Function


    Public Function nEjecutarConsultaEnBD(sql As String, nombreBD As String)
        Return obj.dEjecutarConsultaEnBD(sql, nombreBD)
    End Function

    Public Function registrarDetalleCajaBD(entiCaja As CajaEntity, cadena As String) As String
        Return obj.registrarDetalleCajaBD(entiCaja, cadena)
    End Function

    Public Function registrarDetraccionVenta(entiCaja As CajaEntity) As String
        Return obj.registrarDetraccionVenta(entiCaja)
    End Function

    Public Function registrarAsientosCajaBD(entiCaja As CajaEntity, cadena As String) As String
        Return obj.registrarAsientosCajaBD(entiCaja, cadena)
    End Function

    Public Function registrarAsientosCajaLDBD(entiCaja As CajaEntity, cadena As String) As String
        Return obj.registrarAsientosCajaLDBD(entiCaja, cadena)
    End Function
End Class
