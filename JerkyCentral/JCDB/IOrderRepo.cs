using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface IOrderRepo
    {
        void AddOrder(Order order);
        List<Order> GetAllOrders();
    }
}