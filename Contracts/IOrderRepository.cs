using System.Runtime.InteropServices.JavaScript;
using Entities.Models;

namespace Contracts;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();

    Task<Order> GetOrderAsync(Guid orderId, bool trackChanges);

    Task<IEnumerable<Order>> GetFilteredOrdersAsync(DateTime intervalStart, DateTime intervalEnd);

    void CreateOrder(Order order);

    void DeleteOrder(Order order);
}