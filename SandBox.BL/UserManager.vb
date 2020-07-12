Imports SandBox.Entities

Public Class UserManager
    Implements IDisposable

    Shared Function GerUserList() As List(Of User)
        Dim list As New List(Of User)

        list.Add(New User(1001, "Yonatan"))
        list.Add(New User(1002, "Maayan"))
        list.Add(New User(1003, "Shirit"))
        list.Add(New User(1004, "Uri"))

        Return list
    End Function

    Public Function GetAll() As List(Of User)
        Return GerUserList()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        ' clear all resources
    End Sub


End Class
