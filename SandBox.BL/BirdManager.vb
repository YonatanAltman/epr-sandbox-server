Imports System.Data.SqlClient
Imports Dal
Imports Npgsql
Imports SandBox.Entities

Public Class BirdManager
    Implements IDisposable

    Public Function GetAll() As List(Of Bird)

        Dim birds As New List(Of Bird)

        Try
            Using dal As New BirdsDal
                Dim strx = "select * from bird"

                dal.Open()
                Dim result = dal.ExecuteReader(strx)
                If result IsNot Nothing Then
                    If result.HasRows Then
                        While result.Read()
                            Dim id = result("id")
                            Dim name = result("name")
                            Dim img = result("img")
                            birds.Add(New Bird With {.id = id,
                                                             .name = name,
                                                             .img = img
                                                             })

                        End While

                    End If
                End If



            End Using

        Catch ex As Exception
            Dim msg = ex.Message

        End Try
        Return birds

    End Function

    ' 
    'add a new bird or edit one. if has `id` it will update the bird
    '
    Public Function AddBird(bird As Bird) As Integer

        Dim id = 0

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from public.add_bird(@name, @img, @id )"


                '2) add parameters to function
                Dim sqlparams As New List(Of NpgsqlParameter)

                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.Int32,
                              .IsNullable = True,
                              .ParameterName = "id",
                              .Value = bird.id})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "name",
                              .Value = bird.name})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "img",
                              .Value = bird.img})
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

    Public Function AddAria(area As Area) As Integer

        Dim id = 0

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from public.add_area(@name, @img, @id )"


                '2) add parameters to function
                Dim sqlparams As New List(Of NpgsqlParameter)

                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.Int32,
                              .IsNullable = True,
                              .ParameterName = "id",
                              .Value = area.id})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "name",
                              .Value = area.name})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "img",
                              .Value = area.img})
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


    Public Function AddSpot(spot As BirdSpot) As Integer

        Dim id = 0

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from public.add_spot(@bird_id, @aria_id, @email, @spot_date )"


                '2) add parameters to function
                Dim sqlparams As New List(Of NpgsqlParameter)

                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.Int32,
                              .IsNullable = True,
                              .ParameterName = "bird_id",
                              .Value = spot.bird_id})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.Int32,
                              .ParameterName = "aria_id",
                              .Value = spot.area_id})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "email",
                              .Value = spot.email})
                sqlparams.Add(New NpgsqlParameter With {
                              .DbType = DbType.DateTime,
                              .ParameterName = "spot_date",
                              .Value = spot.spot_date})
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
    Public Function GetUserSpot(email As String) As List(Of BirdSpotVm)

        Dim list As New List(Of BirdSpotVm)

        Try
            Using dal As New BirdsDal
                '1) the function in db
                Dim strx = "select * from public.get_user_spots(@email)"


                '2) add parameters to function
                Dim sqlparams As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter With {
                              .DbType = DbType.String,
                              .ParameterName = "email",
                              .Value = email}
                }

                '3) open connection
                dal.Open()

                '4) read the result from db
                Dim result = dal.ExecuteReader(strx, sqlparams)
                If result IsNot Nothing Then
                    If result.HasRows Then
                        While result.Read()
                            Dim bird = result("bird")
                            Dim bird_img = result("bird_img")
                            Dim area = result("area")
                            Dim area_img = result("area_img")
                            Dim spot_date = result("spot_date")

                            list.Add(New BirdSpotVm With {
                                     .area = area,
                                     .area_img = area_img,
                                     .bird = bird,
                                     .bird_img = bird_img,
                                     .spot_date = DateTime.Parse(spot_date)
                                     })

                        End While

                    End If
                End If



            End Using

        Catch ex As Exception
            Dim msg = ex.Message

        End Try
        Return list

    End Function


    Public Sub Dispose() Implements IDisposable.Dispose
        ' clear all resources
    End Sub


End Class
