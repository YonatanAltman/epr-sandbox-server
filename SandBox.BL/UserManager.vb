Imports System.Data.SqlClient
Imports Dal
Imports Npgsql
Imports SandBox.Entities

Public Class UserManager
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

    Public Function Login(email As String, password As String) As BirdUser

        Dim user As BirdUser

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from login(@email,@password)"


                '2) add parameters to function
                Dim sqlparams As New List(Of SqlParameter)

                sqlparams.Add(New SqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "email",
                              .Value = email})
                sqlparams.Add(New SqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "password",
                              .Value = password})
                '3) open connection
                dal.Open()

                '4) read the result from db

                Dim result = dal.ExecuteReader(strx,)
                If result IsNot Nothing Then
                    If result.HasRows Then
                        While result.Read()
                            Dim _email = result("email")
                            Dim _first_name = result("first_name")
                            Dim _last_name = result("last_name")
                            Dim _phone = result("phone")
                            user = New BirdUser With {.email = _email,
                                                             .first_name = _first_name,
                                                             .last_name = _last_name,
                                                             .phone = _phone}

                        End While

                    End If
                End If



            End Using

        Catch ex As Exception
            Dim msg = ex.Message

        End Try
        Return user

    End Function

    Public Function Register(user As BirdUser) As Integer

        Dim id = 0

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from public.new_user(@first_name, @last_name, @email, @phone , @password )"


                '2) add parameters to function
                Dim sqlparams As New List(Of NpgsqlParameter)

                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "first_name",
                              .Value = user.first_name})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "last_name",
                              .Value = user.last_name})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "email",
                              .Value = user.email})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "phone",
                              .Value = user.phone})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "password",
                              .Value = user.password})

                '3) open connection
                dal.Open()

                '4) read the result from db
                Dim result = dal.ExecuteReader(strx, sqlparams)
                If result IsNot Nothing Then
                    If result.HasRows Then
                        While result.Read()
                            id = result(0)


                        End While

                    End If
                End If



            End Using

        Catch ex As Exception
            Dim msg = ex.Message

        End Try
        Return id

    End Function


    Public Sub Dispose() Implements IDisposable.Dispose
        ' clear all resources
    End Sub


End Class
