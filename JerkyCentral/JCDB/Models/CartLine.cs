namespace JCDB.Models
{
    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product User { get; set; }
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
    }
}