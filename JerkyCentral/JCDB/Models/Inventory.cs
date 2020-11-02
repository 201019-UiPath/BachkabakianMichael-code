using System.Collections.Generic;

namespace JCDB.Models
{
    public class Inventory
    {
        //public int LocationId { get; set; }
        //public int ProductId { get; set; }
        public int InventoryId { get; set; }
        public List<Location> Location { get; set; }
        public List<Product> Product { get; set; }
        public int QuantityOnHand { get; set; }
    }
}