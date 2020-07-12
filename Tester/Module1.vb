﻿Imports SandBox.BL
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
            Console.WriteLine(user.ID.ToString() + "|" + user.Name)
        Next
        Dim userid = 0
        Dim id = Console.ReadLine()
        If Integer.TryParse(id, userid) Then

            Dim orders = GetOrderByUserId(userid)


            For Each order In orders
                Console.WriteLine(order)

            Next
        End If

    End Sub


    Function GetAllUsers() As List(Of User)
        Dim manager = New UserManager()
        Return manager.GetAll()

    End Function


    Function GetOrderByUserId(id As Integer) As List(Of Order)
        Dim manager = New OrderManager()
        Return manager.GetUserOrders(id)

    End Function


End Module
