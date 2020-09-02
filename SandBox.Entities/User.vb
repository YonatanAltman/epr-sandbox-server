Public Class User
    Property id As Integer
    Property firstname As String
    Property password As String
    Property email As String
    Property role As String

    Public Sub New(id As Integer, email As String, Optional name As String = Nothing, Optional role As String = Nothing)
        Me.id = id
        Me.firstname = name
        Me.email = email
        Me.role = role
        Me.password = "1111"
    End Sub
    Public Sub New()

    End Sub

    Public Class LoginRequest
        Property username As String
        Property password As String


    End Class


End Class

Public Class RegisterResponse
    Inherits EprResponse
    Property user As BirdUser
End Class