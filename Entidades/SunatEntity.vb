Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing
Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text.RegularExpressions
Imports System.Collections.Specialized

Public Class SunatEntity
    Public Enum Resul
        Ok = 0
        NoResul = 1
        ErrorCapcha = 2
        [Error] = 3
    End Enum
    Private state As Resul
    Private _Ruc As String
    Private _Nombres As String
    Private _ApePaterno As String
    Private _ApeMaterno As String
    Private _Estado As String
    Private _Telefono As String
    Private myCookie As CookieContainer
    Public ReadOnly Property GetCapcha As Image
        Get
            Return ReadCapcha()
        End Get
    End Property
    Public ReadOnly Property Nombres As String
        Get
            Return _Nombres
        End Get

    End Property
    Public ReadOnly Property Ruc As String
        Get
            Return _Ruc
        End Get
    End Property

    Public ReadOnly Property ApePaterno As String
        Get
            Return _ApePaterno
        End Get

    End Property
    Public ReadOnly Property ApeMaterno As String
        Get
            Return _ApeMaterno
        End Get

    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _Estado
        End Get

    End Property
    Public ReadOnly Property Telefono As String
        Get
            Return _Telefono
        End Get

    End Property
    Public ReadOnly Property GetResul As Resul
        Get
            Return state
        End Get
    End Property
    Public Sub New()
        Try
            myCookie = Nothing
            myCookie = New CookieContainer()
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
            ReadCapcha()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function ValidarCertificado(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As [Boolean]
        Return True
    End Function
    Private Function ReadCapcha() As Image
        Try
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image&magic=2"), HttpWebRequest)
            myWebRequest.CookieContainer = myCookie
            myWebRequest.Proxy = Nothing
            myWebRequest.Credentials = CredentialCache.DefaultCredentials
            Dim myWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
            Dim myImgStream As Stream = myWebResponse.GetResponseStream()
            Return Image.FromStream(myImgStream)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub GetInfo(ByVal numDni As String, ByVal ImgCapcha As String)
        Dim xRuc As String = ""
        Dim xRazSoc As String = ""
        Dim xEst As String = ""
        Dim xCon As String = ""
        Dim xDir As String = ""
        Dim xAg As String = ""
        Dim xTel As String = ""
        Try

            Dim myUrl As String = ""
            myUrl = [String].Format("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={0}&codigo={1}", numDni, ImgCapcha)
            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0"
            myWebRequest.CookieContainer = myCookie
            myWebRequest.Credentials = CredentialCache.DefaultCredentials
            myWebRequest.Proxy = Nothing
            Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
            Dim myStream As Stream = myHttpWebResponse.GetResponseStream()
            Dim myStreamReader As New StreamReader(myStream)

            Dim xDat As String = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd())

            Dim _split As String() = xDat.Split(New Char() {"<"c, ">"c, ControlChars.Lf, ControlChars.Cr})
            Dim _resul As New List(Of String)()
            For i As Integer = 0 To _split.Length - 1
                If Not String.IsNullOrEmpty(_split(i).Trim()) Then
                    _resul.Add(_split(i).Trim())
                End If
            Next
            Select Case _resul.Count
                Case 77
                    state = Resul.ErrorCapcha
                    Exit Select
                Case Is >= 635
                    state = Resul.Ok
                    Exit Select
                Case 147
                    state = Resul.NoResul
                    Exit Select
                Case Else
                    state = Resul.[Error]
                    Exit Select
            End Select
            If state = Resul.Ok Then
                Dim tabla() As String
                xDat = Replace(xDat, "     ", " ")
                xDat = Replace(xDat, "    ", " ")
                xDat = Replace(xDat, "   ", " ")
                xDat = Replace(xDat, "  ", " ")
                xDat = Replace(xDat, "( ", "(")
                xDat = Replace(xDat, " )", ")")

                tabla = Regex.Split(xDat, "<td class")
                If numDni.StartsWith("1") Then

                    tabla(1) = tabla(1).Replace("=""bg"" colspan=3>" & numDni & " - ", "")
                    tabla(1) = tabla(1).Replace("</td>" & vbCrLf & " </tr>" & vbCrLf & " <tr>" & vbCrLf & "", "")

                    tabla(12) = tabla(12).Replace("=""bg"" colspan=1>", "")
                    tabla(12) = tabla(12).Replace("</td>", "")

                    tabla(17) = tabla(17).Replace("=""bg"" colspan=3>", "")
                    tabla(17) = tabla(17).Replace("</td>" & vbCrLf & " </tr>" & vbCrLf & "<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->" & vbCrLf & "<!-- <tr> -->" & vbCrLf & "<!-- ", "")

                    tabla(19) = tabla(19).Replace("=""bg"" colspan=1>", "")
                    tabla(19) = tabla(19).Replace("</td> -->" & vbCrLf & "<!-- ", "")
                    xRuc = numDni
                    xRazSoc = Trim(CStr(tabla(1)))
                    xEst = Trim(CStr(tabla(12)))
                    xDir = "" & HttpUtility.HtmlEncode(tabla(17).ToString)
                    xTel = Trim(CStr(tabla(19)))
                ElseIf numDni.StartsWith("2") Then
                    'búsqueda de empresa ...
                    tabla(1) = tabla(1).Replace("=""bg"" colspan=3>" & numDni & " - ", "")
                    tabla(1) = tabla(1).Replace("</td>" & vbCrLf & " </tr>" & vbCrLf & " <tr>" & vbCrLf & "", "")
                    tabla(10) = tabla(10).Replace("=""bg"" colspan=1>", "")
                    tabla(10) = tabla(10).Replace("</td>", "")
                    tabla(15) = tabla(15).Replace("=""bg"" colspan=3>", "")
                    tabla(15) = tabla(15).Replace("</td>" & vbCrLf & " </tr>" & vbCrLf & "<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->" & vbCrLf & "<!-- <tr> -->" & vbCrLf & "<!-- ", "")
                    tabla(17) = tabla(17).Replace("=""bg"" colspan=1>", "")
                    tabla(17) = tabla(17).Replace("</td> -->" & vbCrLf & "<!-- ", "")
                    xRuc = numDni
                    xRazSoc = Trim(CStr(tabla(1)))
                    xEst = Trim(CStr(tabla(10)))
                    xDir = CStr(tabla(15))
                    xTel = Trim(CStr(tabla(17)))
                End If
                _Ruc = xRuc
                _Nombres = xRazSoc
                _ApeMaterno = xDir
                _Estado = xEst
                _Telefono = xTel
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GetInfo_Dni(ByVal numDni As String, ByVal ImgCapcha As String)
        Dim xRuc As String = ""
        Dim xRazSoc As String = ""
        Dim xEst As String = ""
        Dim xCon As String = ""
        Dim xDir As String = ""
        Dim xAg As String = ""
        Dim xTel As String = ""
        Dim Dts_Return As New DataSet
        Try

            'link para pasar los datos , RUC y valor del captcha
            Dim myUrl As String = ""
            myUrl = [String].Format("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorTipdoc&nrodoc={0}&codigo={1}&tipdoc=1", numDni, ImgCapcha)

            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0"
            myWebRequest.CookieContainer = myCookie
            myWebRequest.Credentials = CredentialCache.DefaultCredentials
            myWebRequest.Proxy = Nothing
            Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
            Dim myStream As Stream = myHttpWebResponse.GetResponseStream()
            Dim myStreamReader As New StreamReader(myStream)
            'se lee los datos
            Dim xDat As String = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd())
            Dim _split As String() = xDat.Split(New Char() {"<"c, ">"c, ControlChars.Lf, ControlChars.Cr})
            Dim _resul As New List(Of String)()
            For i As Integer = 0 To _split.Length - 1
                If Not String.IsNullOrEmpty(_split(i).Trim()) Then
                    _resul.Add(_split(i).Trim())
                End If
            Next
            Select Case _resul.Count
                Case 77
                    state = Resul.ErrorCapcha
                    Exit Select
                Case Is >= 215
                    state = Resul.Ok
                    Exit Select
                Case 147
                    state = Resul.NoResul
                    Exit Select
                Case Else
                    state = Resul.[Error]
                    Exit Select
            End Select
            If state = Resul.Ok Then
                Dim tabla() As String
                xDat = Replace(xDat, "     ", " ")
                xDat = Replace(xDat, "    ", " ")
                xDat = Replace(xDat, "   ", " ")
                xDat = Replace(xDat, "  ", " ")
                xDat = Replace(xDat, "( ", "(")
                xDat = Replace(xDat, " )", ")")
                tabla = Regex.Split(Trim(xDat), "class=""bg""")
                Dim Dts As New DataSet
                Dts.Tables.Add("Tabla")
                Dim Dc_1 As New DataColumn("Ruc", GetType(System.String))
                Dim Dc_2 As New DataColumn("Razon_Social", GetType(System.String))
                Dim Dc_3 As New DataColumn("Ubicacion", GetType(System.String))
                Dim Dc_4 As New DataColumn("Estado", GetType(System.String))
                Dts.Tables(0).Columns.Add(Dc_1)
                Dts.Tables(0).Columns.Add(Dc_2)
                Dts.Tables(0).Columns.Add(Dc_3)
                Dts.Tables(0).Columns.Add(Dc_4)

                Dim NroRuc As Integer = 1
                Dim RazSoc As Integer = 1
                Dim Dir As Integer = 1
                Dim Est As Integer = 1

                Dim Nro As Integer = 1
                Nro = tabla.Count - 1
                For F As Integer = 1 To tabla.Count - 1
                    If F = 1 Then
                        tabla(F) = tabla(F).Replace(">", "")
                        tabla(F) = tabla(F).Replace("<a href=""javascript:sendNroRuc(", "")
                        tabla(F) = tabla(F).Replace("</td>", "")
                        tabla(F) = tabla(F).Replace(" <td ", "")
                        tabla(F) = tabla(F).Trim
                        tabla(F) = Microsoft.VisualBasic.Left(tabla(F).Replace(" </td>", ""), 11) 'Nro RUC
                        tabla(F) = tabla(F).Trim

                        tabla(F + 1) = tabla(F + 1).Replace(" align=""left""> ", "")
                        tabla(F + 1) = tabla(F + 1).Replace(" </td>", "")
                        tabla(F + 1) = tabla(F + 1).Replace(" <td ", "")
                        tabla(F + 1) = tabla(F + 1).Trim

                        tabla(F + 2) = tabla(F + 2).Replace("align=""left""> ", "")
                        tabla(F + 2) = tabla(F + 2).Replace(" </td>", "")
                        tabla(F + 2) = tabla(F + 2).Replace("</tr>", "")
                        tabla(F + 2) = tabla(F + 2).Replace(" <td ", "")
                        tabla(F + 2) = tabla(F + 2).Trim

                        tabla(F + 3) = tabla(F + 3).Replace(" align=""left""> ", "")
                        tabla(F + 3) = tabla(F + 3).Replace("</td>", "")
                        tabla(F + 3) = tabla(F + 3).Replace("</tr>", "")
                        tabla(F + 3) = tabla(F + 3).Replace("<tr>", "")
                        tabla(F + 3) = tabla(F + 3).Replace(" <td align=""center""", "")
                        tabla(F + 3) = Microsoft.VisualBasic.Left(tabla(F + 3), 21)
                        tabla(F + 3) = tabla(F + 3).Replace("</table>", "")
                        tabla(F + 3) = tabla(F + 3).Trim

                        xRuc = Trim(CStr(tabla(F)))
                        xRazSoc = Trim(CStr(tabla(F + 1)))
                        xDir = CStr(tabla(F + 2))
                        xEst = Trim(CStr(tabla(F + 3)))

                        _Ruc = xRuc
                        _Nombres = xRazSoc
                        _ApeMaterno = xDir
                        _Estado = xEst
                        _Telefono = xTel

                        Dts.Tables(0).Rows.Add(_Ruc, _Nombres, _ApeMaterno, _Estado)
                    Else
                        NroRuc = NroRuc + 4
                        RazSoc = NroRuc + 1
                        Dir = RazSoc + 1
                        Est = Dir + 1
                        If Microsoft.VisualBasic.Left(tabla(NroRuc), 20) <> ">Para sugerencias y " Then
                            tabla(NroRuc) = tabla(NroRuc).Replace(">", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace("<a href=""javascript:sendNroRuc(", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace("</td>", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace(" <td ", "")
                            tabla(NroRuc) = tabla(NroRuc).Trim
                            tabla(NroRuc) = Microsoft.VisualBasic.Left(tabla(NroRuc).Replace(" </td>", ""), 11) 'Nro RUC
                            tabla(NroRuc) = tabla(NroRuc).Trim

                            tabla(RazSoc) = tabla(RazSoc).Replace(" align=""left""> ", "")
                            tabla(RazSoc) = tabla(RazSoc).Replace(" </td>", "")
                            tabla(RazSoc) = tabla(RazSoc).Replace(" <td ", "")
                            tabla(RazSoc) = tabla(RazSoc).Trim

                            tabla(Dir) = tabla(Dir).Replace("align=""left""> ", "")
                            tabla(Dir) = tabla(Dir).Replace(" </td>", "")
                            tabla(Dir) = tabla(Dir).Replace("</tr>", "")
                            tabla(Dir) = tabla(Dir).Replace(" <td ", "")
                            tabla(Dir) = tabla(Dir).Trim

                            tabla(Est) = tabla(Est).Replace(" align=""left""> ", "")
                            tabla(Est) = tabla(Est).Replace("</td>", "")
                            tabla(Est) = tabla(Est).Replace("</tr>", "")
                            tabla(Est) = tabla(Est).Replace("<tr>", "")
                            tabla(Est) = tabla(Est).Replace(" <td align=""center""", "")
                            tabla(Est) = Microsoft.VisualBasic.Left(tabla(Est), 21)
                            tabla(Est) = tabla(Est).Replace("</table>", "")

                            tabla(Est) = tabla(Est).Trim

                            xRuc = Trim(CStr(tabla(NroRuc)))
                            xRazSoc = Trim(CStr(tabla(RazSoc)))
                            xDir = CStr(tabla(Dir))
                            xEst = Trim(CStr(tabla(Est)))

                            _Ruc = xRuc
                            _Nombres = xRazSoc
                            _ApeMaterno = xDir
                            _Estado = xEst
                            _Telefono = xTel

                            Dts.Tables(0).Rows.Add(_Ruc, _Nombres, _ApeMaterno, _Estado)
                        Else
                            Exit For
                        End If
                    End If
                Next
                'GetInfo(_Ruc, ImgCapcha)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetInfo_RazonSocial(ByVal numDni As String, ByVal ImgCapcha As String) As DataSet
        Dim xRuc As String = ""
        Dim xRazSoc As String = ""
        Dim xEst As String = ""
        Dim xCon As String = ""
        Dim xDir As String = ""
        Dim xAg As String = ""
        Dim xTel As String = ""
        Dim Dts_Return As New DataSet
        Try


            Dim myUrl As String = ""
            myUrl = [String].Format("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRazonSoc&razSoc={0}&codigo={1}", numDni, ImgCapcha)

            Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0"
            myWebRequest.CookieContainer = myCookie
            myWebRequest.Credentials = CredentialCache.DefaultCredentials
            myWebRequest.Proxy = Nothing
            Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
            Dim myStream As Stream = myHttpWebResponse.GetResponseStream()
            Dim myStreamReader As New StreamReader(myStream)

            Dim xDat As String = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd())
            Dim _split As String() = xDat.Split(New Char() {"<"c, ">"c, ControlChars.Lf, ControlChars.Cr})
            Dim _resul As New List(Of String)()
            For i As Integer = 0 To _split.Length - 1
                If Not String.IsNullOrEmpty(_split(i).Trim()) Then
                    _resul.Add(_split(i).Trim())
                End If
            Next
            Select Case _resul.Count
                Case 77
                    state = Resul.ErrorCapcha
                    Exit Select
                Case Is >= 215
                    state = Resul.Ok
                    Exit Select
                Case 147
                    state = Resul.NoResul
                    Exit Select
                Case Else
                    state = Resul.[Error]
                    Exit Select
            End Select
            If state = Resul.Ok Then
                Dim tabla() As String
                xDat = Replace(xDat, "     ", " ")
                xDat = Replace(xDat, "    ", " ")
                xDat = Replace(xDat, "   ", " ")
                xDat = Replace(xDat, "  ", " ")
                xDat = Replace(xDat, "( ", "(")
                xDat = Replace(xDat, " )", ")")
                tabla = Regex.Split(Trim(xDat), "class=""bg""")
                Dim Dts As New DataSet
                Dts.Tables.Add("Tabla")
                Dim Dc_1 As New DataColumn("Ruc", GetType(System.String))
                Dim Dc_2 As New DataColumn("Razon_Social", GetType(System.String))
                Dim Dc_3 As New DataColumn("Ubicacion", GetType(System.String))
                Dim Dc_4 As New DataColumn("Estado", GetType(System.String))
                Dts.Tables(0).Columns.Add(Dc_1)
                Dts.Tables(0).Columns.Add(Dc_2)
                Dts.Tables(0).Columns.Add(Dc_3)
                Dts.Tables(0).Columns.Add(Dc_4)

                Dim NroRuc As Integer = 1
                Dim RazSoc As Integer = 1
                Dim Dir As Integer = 1
                Dim Est As Integer = 1

                Dim Nro As Integer = 1
                Nro = tabla.Count - 1
                For F As Integer = 1 To tabla.Count - 1
                    If F = 1 Then
                        tabla(F) = tabla(F).Replace(">", "")
                        tabla(F) = tabla(F).Replace("<a href=""javascript:sendNroRuc(", "")
                        tabla(F) = tabla(F).Replace("</td>", "")
                        tabla(F) = tabla(F).Replace(" <td ", "")
                        tabla(F) = tabla(F).Trim
                        tabla(F) = Microsoft.VisualBasic.Left(tabla(F).Replace(" </td>", ""), 11) 'Nro RUC
                        tabla(F) = tabla(F).Trim

                        tabla(F + 1) = tabla(F + 1).Replace(" align=""left""> ", "")
                        tabla(F + 1) = tabla(F + 1).Replace(" </td>", "")
                        tabla(F + 1) = tabla(F + 1).Replace(" <td ", "")
                        tabla(F + 1) = tabla(F + 1).Trim

                        tabla(F + 2) = tabla(F + 2).Replace("align=""left""> ", "")
                        tabla(F + 2) = tabla(F + 2).Replace(" </td>", "")
                        tabla(F + 2) = tabla(F + 2).Replace("</tr>", "")
                        tabla(F + 2) = tabla(F + 2).Replace(" <td ", "")
                        tabla(F + 2) = tabla(F + 2).Trim

                        tabla(F + 3) = tabla(F + 3).Replace(" align=""left""> ", "")
                        tabla(F + 3) = tabla(F + 3).Replace("</td>", "")
                        tabla(F + 3) = tabla(F + 3).Replace("</tr>", "")
                        tabla(F + 3) = tabla(F + 3).Replace("<tr>", "")
                        tabla(F + 3) = tabla(F + 3).Replace(" <td align=""center""", "")
                        tabla(F + 3) = tabla(F + 3).Trim

                        xRuc = Trim(CStr(tabla(F)))
                        xRazSoc = Trim(CStr(tabla(F + 1)))
                        xDir = CStr(tabla(F + 2))
                        xEst = Trim(CStr(tabla(F + 3)))

                        _Ruc = xRuc
                        _Nombres = xRazSoc
                        _ApeMaterno = xDir
                        _Estado = xEst
                        _Telefono = xTel

                        Dts.Tables(0).Rows.Add(_Ruc, _Nombres, _ApeMaterno, _Estado)
                    Else
                        NroRuc = NroRuc + 4
                        RazSoc = NroRuc + 1
                        Dir = RazSoc + 1
                        Est = Dir + 1
                        If Microsoft.VisualBasic.Left(tabla(NroRuc), 20) <> ">Para sugerencias y " Then
                            tabla(NroRuc) = tabla(NroRuc).Replace(">", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace("<a href=""javascript:sendNroRuc(", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace("</td>", "")
                            tabla(NroRuc) = tabla(NroRuc).Replace(" <td ", "")
                            tabla(NroRuc) = tabla(NroRuc).Trim
                            tabla(NroRuc) = Microsoft.VisualBasic.Left(tabla(NroRuc).Replace(" </td>", ""), 11) 'Nro RUC
                            tabla(NroRuc) = tabla(NroRuc).Trim

                            tabla(RazSoc) = tabla(RazSoc).Replace(" align=""left""> ", "")
                            tabla(RazSoc) = tabla(RazSoc).Replace(" </td>", "")
                            tabla(RazSoc) = tabla(RazSoc).Replace(" <td ", "")
                            tabla(RazSoc) = tabla(RazSoc).Trim

                            tabla(Dir) = tabla(Dir).Replace("align=""left""> ", "")
                            tabla(Dir) = tabla(Dir).Replace(" </td>", "")
                            tabla(Dir) = tabla(Dir).Replace("</tr>", "")
                            tabla(Dir) = tabla(Dir).Replace(" <td ", "")
                            tabla(Dir) = tabla(Dir).Trim

                            tabla(Est) = tabla(Est).Replace(" align=""left""> ", "")
                            tabla(Est) = tabla(Est).Replace("</td>", "")
                            tabla(Est) = tabla(Est).Replace("</tr>", "")
                            tabla(Est) = tabla(Est).Replace("<tr>", "")
                            tabla(Est) = tabla(Est).Replace(" <td align=""center""", "")
                            tabla(Est) = Microsoft.VisualBasic.Left(tabla(Est), 21)
                            tabla(Est) = tabla(Est).Replace("</table>", "")

                            tabla(Est) = tabla(Est).Trim

                            xRuc = Trim(CStr(tabla(NroRuc)))
                            xRazSoc = Trim(CStr(tabla(RazSoc)))
                            xDir = CStr(tabla(Dir))
                            xEst = Trim(CStr(tabla(Est)))

                            _Ruc = xRuc
                            _Nombres = xRazSoc
                            _ApeMaterno = xDir
                            _Estado = xEst
                            _Telefono = xTel

                            Dts.Tables(0).Rows.Add(_Ruc, _Nombres, _ApeMaterno, _Estado)
                        Else
                            Exit For
                        End If
                    End If
                Next
                Dts_Return = Dts
            End If
            Return Dts_Return
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
