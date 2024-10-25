

using Domain.DTOs;

namespace Domain.UseCases.GetOrders;

public interface IGetOrderStorage
{
    Task<IEnumerable<OrderDto>> GetOrders(CancellationToken cancellationToken);
}