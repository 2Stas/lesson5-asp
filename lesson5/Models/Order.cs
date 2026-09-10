
namespace lesson5.Models
{
    public class Order 
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string? CustomName { get; set; }

        public string? Status { get; set; }
    }
}
