using System.Collections.Generic;

namespace JCDB.Models
{
    public class OrderLine
    {
        // public int OrderId { get; set; }
        // public int ProductId { get; set; }
        public List <Order> Order { get; set; }
        public List <Product> Product { get; set; }
    }
}