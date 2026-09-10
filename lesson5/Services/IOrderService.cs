using lesson5.Models;

namespace lesson5.Services
{
    public interface IOrderService 
    {
        List<Order> GetAll();

        Order GetById(int id);

        Order Create(Order order);

        Order Delete(int id);

        Order UpdateStatus(int id, string status);
    }
}
