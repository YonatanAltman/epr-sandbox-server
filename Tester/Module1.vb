Imports SandBox.BL
Imports SandBox.Entities

Module Module1

    Sub Main()
        'GetAllBirds()
        'AddBird()
        'AddAria()
        'AddSpot()
        'GetUserSpots()


    End Sub

    Sub GetAllBirds()
        Dim tester As New BirdTester

        Dim birds = tester.GetAllBirds()


    End Sub
    Sub AddBird()
        Dim tester As New BirdTester

        Dim birds = tester.AddBird()


    End Sub
    Sub AddAria()
        Dim tester As New BirdTester

        Dim birds = tester.AddAria()


    End Sub
    Sub AddSpot()
        Dim tester As New BirdTester

        Dim birds = tester.AddSpot()


    End Sub
    Sub GetUserSpots()
        Dim tester As New BirdTester

        Dim birds = tester.GetUserSpots()


    End Sub


    Function GetAllUsers() As List(Of BirdUser)
        Dim users As List(Of BirdUser)
        Using manager As New UserManager

            users = manager.GetAll()
            manager.Dispose()

        End Using

        Return users

    End Function


    Function GetOrderByUserId(id As Integer) As List(Of Order)
        Dim manager = New OrderManager()
        Return manager.GetUserOrders(id)

    End Function


End Module
