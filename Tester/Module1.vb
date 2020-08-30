Imports SandBox.BL
Imports SandBox.Entities

Module Module1

    Sub Main()
        'GetAllBirds()
        'AddBird()
        'AddAria()
        'AddSpot()
        'GetUserSpots()
        Register()
        Console.WriteLine("What is your name?")

        Dim name = Console.ReadLine()
        Console.WriteLine("My name is: " + name)




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

    Sub Register()
        Dim user As New BirdUser With {
            .email = "my@email.com",
            .first_name = "yonatan",
            .last_name = "academka",
            .password = "1234",
            .phone = "012345679"}
        Using manager As New UserManager

            Dim n = manager.Register(user)

        End Using



    End Sub


    Function GetOrderByUserId(id As Integer) As List(Of Order)
        Dim manager = New OrderManager()
        Return manager.GetUserOrders(id)

    End Function


End Module
