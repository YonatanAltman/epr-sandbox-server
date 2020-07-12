Imports SandBox.Entities

Public Class OrderManager

    Shared Function GetOrderList() As List(Of Order)
        Dim list As New List(Of Order) From {
            New Order(1001, "Small boxes", 20000, 1001),
            New Order(1002, "Large boxes", 13030, 1001),
            New Order(1003, "aaaaaaaaaaa", 500, 1001),
            New Order(1004, "bbbbbbbbbbb", 503100, 1001),
            New Order(1005, "ccccccccccc", 66031, 1001),
            New Order(1006, "ddddddddddd", 20022, 1001),
            New Order(1007, "fffffffffff", 5003, 1001),
            New Order(1008, "ggggggggggg", 12000, 1001),
            New Order(1001, "Small boxes", 20000, 1002),
            New Order(1002, "Large boxes", 13030, 1003),
            New Order(1003, "aaaaaaaaaaa", 500, 1002),
            New Order(1004, "bbbbbbbbbbb", 503100, 1003),
            New Order(1005, "ccccccccccc", 66031, 1002),
            New Order(1006, "ddddddddddd", 20022, 1003),
            New Order(1007, "fffffffffff", 5003, 1004),
            New Order(1008, "ggggggggggg", 12000, 1002)
        }

        Return list
    End Function

    Public Function GetUserOrders(userId As Integer)
        Dim orders = GetOrderList.FindAll(Function(o) o.UserID = userId)
        Return orders

    End Function




End Class
