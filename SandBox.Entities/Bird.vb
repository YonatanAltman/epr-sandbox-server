Public Class BirdsEntity

End Class

Public Class BirdUser
    Public Property id As Integer
    Public Property first_name As String
    Public Property last_name As String
    Public Property email As String
    Public Property phone As String
    Public Property password As String
End Class

Public MustInherit Class BirdBaseEntity
    Public Property id As Integer
    Public Property name As String
    Public Property img As String
End Class


Public Class Bird
    Inherits BirdBaseEntity

End Class
Public Class Area
    Inherits BirdBaseEntity

End Class
Public Class BirdSpot
    Public Property id As Integer
    Public Property bird_id As String
    Public Property area_id As String
    Public Property email As String
    Public Property spot_date As DateTime

End Class
Public Class BirdSpotVm
    Public Property bird As String
    Public Property bird_img As String
    Public Property area As String
    Public Property area_img As String
    Public Property spot_date As DateTime

End Class

'id Integer Not null,
'	first_name text NULL,
'	last_name text NULL,
'	email text NULL,
'	phone text NULL,
'	"password" text NULL,