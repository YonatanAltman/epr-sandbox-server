Imports SandBox.BL
Imports SandBox.Entities

Module Module1

    Sub Main()
        Console.WriteLine("Let's start with your name:")
        Dim msg = "Thank you :"
        Dim name = Console.ReadLine()
        msg &= name

        Console.WriteLine(msg)

        Dim list = GetAllUsers()

        For Each user In list
            Console.WriteLine(user.Name)
        Next
    End Sub


    Function GetAllUsers() As List(Of User)
        Dim manager = New UserManager()
        Return manager.GetAll()

    End Function


End Module
