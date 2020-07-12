Public Class User
    Property ID As Integer
    Property Name As String

    Public Sub New(id As Integer, Optional name As String = Nothing)
        Me.ID = id
        Me.Name = name
    End Sub
    Public Sub New()

    End Sub


End Class
