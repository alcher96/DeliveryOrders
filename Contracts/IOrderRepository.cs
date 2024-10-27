using System.Runtime.InteropServices.JavaScript;
using Entities.Models;

namespace Contracts;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();

    Task<Order> GetOrderAsync(Guid orderId, bool trackChanges);
    
    
    Task<IEnumerable<Order>> GetOrdersFilteredAsync(DateTime firstDeliveryDateTime,
        string cityDistrict, bool trackChanges);

    void CreateOrder(Order order);

    void DeleteOrder(Order order);


    Task WriteDataList(string filename, IEnumerable<Order> dataList);

   

}