Imports SandBox.BL
Imports SandBox.Entities

Public Class BirdTester

    Public Function GetAllBirds() As List(Of Bird)
        Dim birds As List(Of Bird)
        Using manager As New BirdManager
            birds = manager.GetAll()

            Console.WriteLine("--------------")
            Console.WriteLine(birds.Count)
            Console.WriteLine("--------------")



        End Using

        Return birds

    End Function

    Public Function AddBird() As Integer
        Dim bird As New Bird With {.name = "דרור", .id = 11, .img = "https://cms.birds.org.il/Data/Portal%20Images/Passeriformes/%D7%93%D7%A8%D7%95%D7%A8%D7%94%D7%91%D7%99%D7%AA-%D7%90%D7%91%D7%99%D7%9E%D7%90%D7%99%D7%A8-1_1820676843.jpg"}
        Dim id As Integer
        Using manager As New BirdManager
            id = manager.AddBird(bird)

            Console.WriteLine("--------------")
            Console.WriteLine(id)
            Console.WriteLine("--------------")



        End Using

        Return id

    End Function

    Public Function AddAria() As Integer
        Dim aria As New Area With {.name = "גבעת הרא""ה", .id = 0, .img = "https://binyamin.org.il/uploads/n/1581587404.9042.jpg"}
        Dim id As Integer
        Using manager As New BirdManager
            id = manager.AddAria(aria)

            Console.WriteLine("--------------")
            Console.WriteLine(id)
            Console.WriteLine("--------------")



        End Using

        Return id

    End Function
    Public Function AddSpot() As Integer
        Dim spot As New BirdSpot With {.area_id = 1000, .bird_id = 10, .email = "yonatan@academka.tech", .spot_date = New Date(2019, 7, 5)}
        Dim id As Integer
        Using manager As New BirdManager
            id = manager.AddSpot(spot)

            Console.WriteLine("--------------")
            Console.WriteLine(id)
            Console.WriteLine("--------------")



        End Using

        Return id

    End Function


    Public Function GetUserSpots() As List(Of BirdSpotVm)
        Dim email = "yonatan@academka.tech"
        Dim list As List(Of BirdSpotVm)
        Using manager As New BirdManager
            list = manager.GetUserSpot(email)

            Console.WriteLine("--------------")
            Console.WriteLine(list.Count)
            Console.WriteLine("--------------")



        End Using

        Return list

    End Function


End Class
