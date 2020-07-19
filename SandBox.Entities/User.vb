Public Class User
    Property id As Integer
    Property firstname As String
    Property password As String
    Property email As String

    Public Sub New(id As Integer, email As String, Optional name As String = Nothing)
        Me.id = id
        Me.firstname = name
        Me.email = email
        Me.password = "1111"
    End Sub
    Public Sub New()

    End Sub


End Class
