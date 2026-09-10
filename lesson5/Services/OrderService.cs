using lesson5.DTO;
using lesson5.Models;

namespace lesson5.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> ListOfOrders = new List<Order>
        {
            new Order { Id = 1, Name = "Product A", Price = 10.0m, Quantity = 2, CustomName = "Custom A", Status = "Pending" },
            new Order { Id = 2, Name = "Product B", Price = 20.0m, Quantity = 1, CustomName = "Custom B", Status = "Shipped" },
            new Order { Id = 3, Name = "Product C", Price = 15.0m, Quantity = 3, CustomName = "Custom C", Status = "Delivered" }
        };

        public List<Order> GetAll()
        {
            return ListOfOrders;
        }

        public Order GetById(int id)
        {
            return ListOfOrders.FirstOrDefault(o => o.Id == id);
        }

        public Order Create(CreateOrderDto order)
        {
            Order finalOrder = new Order
            {
                Id = ListOfOrders.Max(o => o.Id) + 1,
                Name = order.Name,
                Price = order.Price,
                Quantity = order.Quantity,
                CustomName = order.CustomName,
                Status = "Pending"
            };

            ListOfOrders.Add(finalOrder);
            return finalOrder;
        }
        
        public Order Delete(int id)
        {
            var order = ListOfOrders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                ListOfOrders.Remove(order);
            }
            return order;
        }

        public Order UpdateStatus(int id, string status)
        {
            var order = ListOfOrders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                order.Status = status;
            }
            return order;
        }
    }
}
