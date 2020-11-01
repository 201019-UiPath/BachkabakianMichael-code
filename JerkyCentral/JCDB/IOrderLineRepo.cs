using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for orderlines
    /// </summary>
    public interface IOrderLineRepo
    {
        void AddOrderLineAsync(OrderLine orderline);
        List<OrderLine> GetAllOrderLines();
    }
}