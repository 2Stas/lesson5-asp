using lesson5.Models;
using lesson5.DTO;

namespace lesson5.Services
{
    public interface IOrderService 
    {
        List<Order> GetAll();

        Order GetById(int id);

        void Create(CreateOrderDto order);

        Order Delete(int id);

        Order UpdateStatus(int id, string status);
    }
}
