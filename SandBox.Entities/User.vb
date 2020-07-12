Public Class User
    Property ID As Integer
    Property Name As String
    Property Password As String

    Public Sub New(id As Integer, Optional name As String = Nothing)
        Me.ID = id
        Me.Name = name
        Me.Password = "1111"
    End Sub
    Public Sub New()

    End Sub


End Class
