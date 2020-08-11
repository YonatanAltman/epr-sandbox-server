Public Class BirdsEntity

End Class

Partial Public Class app_user
    Public Property id As Integer
    Public Property first_name As String
    Public Property last_name As String
    Public Property email As String
    Public Property phone As String
    Public Property password As String
End Class


Partial Public Class bird
    Public Property id As Integer
    Public Property name As String
    Public Property area As String
    Public Property img As String

End Class
Partial Public Class bird_spot
    Public Property id As Integer
    Public Property bird_id As String
    Public Property area_id As String
    Public Property user_id As String

End Class

'id Integer Not null,
'	first_name text NULL,
'	last_name text NULL,
'	email text NULL,
'	phone text NULL,
'	"password" text NULL,