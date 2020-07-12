Public Class Order
    Property ID As Integer
    Property Desc As String
    Property Price As Double
    Property UserID As Integer

    Public Sub New(id As Integer, desc As String, price As Double, userID As Integer)
        Me.ID = id
        Me.Desc = desc
        Me.Price = price
        Me.UserID = userID
    End Sub
    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Dim str = ""
        str = String.Format("{0} | {1} |{2} | {3}", ID, Price, Desc, UserID)

        Return str
    End Function
End Class
