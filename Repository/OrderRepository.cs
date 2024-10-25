using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    //простой вывод всех заказов, отсортированых по какому то полю, в данном случае по району
    public async Task<IEnumerable<Order>> GetAllOrdersAsync() =>
        await FindAll().OrderBy(o => o.CityDistrict).ToListAsync();

    public async Task<Order> GetOrderAsync(Guid orderId, bool trackChanges) =>
        await FindByCondition(o => o.OrderId.Equals(orderId), trackChanges).SingleOrDefaultAsync();

    public void CreateOrder(Order order) => Create(order);


    public void DeleteOrder(Order order) => Delete(order);


    public async Task<IEnumerable<Order>> GetFilteredOrdersAsync(DateTime intervalStart, DateTime intervalEnd)
    {
        return await FindByCondition(e => 
                e.OrderTime.Date > intervalStart &&
                e.OrderTime.Date < intervalEnd, trackChanges:false)
            .OrderBy(e=>e.CityDistrict)
            .ToListAsync();

       
    }
}