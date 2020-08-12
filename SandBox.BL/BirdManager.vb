Imports Dal
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


    Public Sub Dispose() Implements IDisposable.Dispose
        ' clear all resources
    End Sub


End Class
