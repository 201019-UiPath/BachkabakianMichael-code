namespace JCDB.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ListPrice { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}