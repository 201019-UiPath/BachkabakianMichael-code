using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface IOrderLineRepo
    {
        void AddOrderLine(OrderLine orderline);
        List<OrderLine> GetAllOrderLines();
    }
}