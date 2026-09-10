

namespace lesson5.DTO
{
    public class CreateOrderDto
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? CustomName { get; set; }
    }
}
