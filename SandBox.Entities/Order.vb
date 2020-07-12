Public Class Order
    Property ID As Integer
    Property Desc As String
    Property Price As Double
    Property UserID As Integer

    Public Sub New(id As Integer, Optional name As String = Nothing)
        Me.ID = id
    End Sub
    Public Sub New()

    End Sub


End Class
