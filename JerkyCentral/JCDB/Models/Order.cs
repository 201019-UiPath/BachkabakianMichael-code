namespace JCDB.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }  
        public int UserId { get; set; }
        public int LocationId { get; set; }
    }
}