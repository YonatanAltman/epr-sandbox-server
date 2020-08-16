Imports System.Net
Imports System.Web.Http
Imports Sandbox.Entities
Imports Sandbox.BL
Imports System.Web.Http.Cors

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
        Public Function PostValue(<FromBody()> ByVal newUser As BirdUser) As Integer

            Dim id As Integer

            Using manager As New UserManager

                id = manager.Register(newUser)


            End Using

            Return id



        End Function

        ' PUT: api/Register/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Register/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace