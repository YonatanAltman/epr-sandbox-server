
Imports System.Net
Imports System.Web.Http
Imports Sandbox.Entities
Imports Sandbox.BL
Imports System.Web.Http.Cors
Imports Sandbox.Entities.User

Namespace Controllers

    <EnableCors("*", "*", "*")>
    Public Class UserController
        Inherits ApiController

        ' GET: api/User
        Public Function GetValues() As List(Of BirdUser)

            ' get all users
            Dim users As List(Of BirdUser)

            Using manager As New UserManager
                Dim m As Integer
                users = manager.GetAll()


            End Using






            Return users
        End Function

        ' GET: api/User/5
        Public Function GetValue(ByVal id As Integer, ByVal password As Integer) As BirdUser
            Dim user As BirdUser

            Using manager As New UserManager
                user = manager.GetAll().Find(Function(u) u.id = id)


            End Using

            Return user
        End Function

        ' POST: api/User
        Public Function PostValue(<FromBody()> ByVal req As LoginRequest) As BirdUser
            ' get username & password
            Dim user As BirdUser

            Using manager As New UserManager
                Dim m As Integer
                user = manager.GetAll().Find(Function(u) u.email = req.username)


            End Using

            Return user



        End Function

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace