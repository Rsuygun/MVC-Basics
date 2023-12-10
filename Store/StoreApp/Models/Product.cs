namespace StoreApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String? PrudctName { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}