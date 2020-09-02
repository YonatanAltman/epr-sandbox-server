Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Sandbox.Entities
Imports Sandbox.BL

Namespace Controllers
    <EnableCors("*", "*", "*")>
    Public Class RegisterController
        Inherits ApiController

        ' GET: api/Register
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Register/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Register
        Public Function PostValue(<FromBody()> ByVal newUser As BirdUser) As RegisterResponse
            Dim response As New RegisterResponse
            Try
                Using manager As New UserManager
                    Dim val = manager.Register(newUser)
                    If val < 1 Then
                        response.rc = 3
                        response.desc = "something went wrong in db register"
                    End If


                End Using
            Catch ex As Exception
                response.rc = 99
                response.desc = ex.Message
                response.title = "אוי לא! 🤦‍♂️"
                response.body = "סליחה, זה קורה לפעמים... תתקשרו ליונתן"
                ' write to db log
            End Try




            Return response
        End Function

        ' PUT: api/Register/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Register/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace