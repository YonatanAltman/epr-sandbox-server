﻿Imports System.Net
Imports System.Web.Http
Imports Sandbox.Entities
Imports Sandbox.BL

Namespace Controllers
    Public Class BirdController
        Inherits ApiController

        ' GET: api/Bird
        Public Function GetValues() As IEnumerable(Of Bird)

            Dim users As List(Of Bird)
            Using manager As New BirdManager
                users = manager.GetAll()


            End Using
            Return users

        End Function

        ' GET: api/Bird/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Bird
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Bird/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Bird/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace