Imports System.Configuration
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.SqlClient
Imports Npgsql


Public Class BirdsDal
    Implements IDisposable
    Private npgsqlConnection As NpgsqlConnection
    Public Sub Open()
        Dim str = ConfigurationManager.ConnectionStrings("academka-birds")
        Dim con = str.ConnectionString
        npgsqlConnection = New NpgsqlConnection(con)
        npgsqlConnection.Open()

    End Sub
    Public Sub Close()
        npgsqlConnection.Close()


    End Sub
    Public Function ExecuteReader(strx As String, Optional sqlparams As List(Of NpgsqlParameter) = Nothing) As NpgsqlDataReader

        Dim Command As NpgsqlCommand
        'כבר פתוח
        'connection = New SqlConnection(cnctstring)

        Command = New NpgsqlCommand(strx, npgsqlConnection)
        If sqlparams IsNot Nothing Then
            For Each parameter In sqlparams
                Command.Parameters().Add(parameter)
            Next

        End If
        Try

            Return Command.ExecuteReader()
        Catch ex As Exception
            Dim message = ex.Message
            Throw ex
        End Try
        'Return getrs
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        If npgsqlConnection.State = ConnectionState.Open Then

            npgsqlConnection.Close()
        End If

        '_contextusr.Dispose()



    End Sub

End Class