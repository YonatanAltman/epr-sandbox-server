Imports SandBox.Entities

Public Class OrderManager

    Shared Function GerOrderList() As List(Of Order)
        Dim list As New List(Of Order) From {
            New Order(1001, "Yonatan"),
            New Order(1002, "Maayan"),
            New Order(1003, "Shirit"),
            New Order(1004, "Uri")
        }

        Return list
    End Function

    Public Function GetUserOrders(userId As Integer)

    End Function




End Class
