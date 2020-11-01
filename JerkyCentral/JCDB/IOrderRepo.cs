using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral orders
    /// </summary>
    public interface IOrderRepo
    {
        void AddOrder(Order order);
        List<Order> GetAllOrders();
    }
}