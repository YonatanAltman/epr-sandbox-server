Imports Dal
Imports SandBox.Entities

Public Class BirdManager
    Implements IDisposable

    Public Function GetAll() As List(Of BirdUser)

        Dim birdUsers As New List(Of BirdUser)

        Try
            Using dal As New BirdsDal
                Dim strx = "select * from app_user"

                dal.Open()
                Dim result = dal.ExecuteReader(strx)
                If result IsNot Nothing Then
                    If result.HasRows Then
                        While result.Read()
                            Dim email = result("email")
                            Dim first_name = result("first_name")
                            Dim last_name = result("last_name")
                            Dim phone = result("phone")
                            birdUsers.Add(New BirdUser With {.email = email,
                                                             .first_name = first_name,
                                                             .last_name = last_name,
                                                             .phone = phone})

                        End While

                    End If
                End If



            End Using

        Catch ex As Exception
            Dim msg = ex.Message

        End Try
        Return birdUsers

    End Function

    Public Function GetUser(email As String, password As String) As BirdUser

        Dim user As BirdUser

        Try

            Using contex As New BirdsContext
                Dim users = contex.users.FirstOrDefault(Function(u) u.email = email And u.password = password)

                user = ConverDbUserToVM(users)


            End Using

        Catch ex As Exception

        End Try
        Return user

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        ' clear all resources
    End Sub

    Private Function ConverDbUserListToVM(users As List(Of app_user)) As List(Of BirdUser)
        Dim list As New List(Of BirdUser)
        For Each u In users
            list.Add(ConverDbUserToVM(u))
        Next
        Return list
    End Function

    Private Function ConverDbUserToVM(dbUSer As app_user) As BirdUser

        Dim user As New BirdUser With {
                 .email = dbUSer.email,
        .first_name = dbUSer.first_name,
        .last_name = dbUSer.last_name,
        .phone = dbUSer.phone}

        Return user
    End Function
End Class
