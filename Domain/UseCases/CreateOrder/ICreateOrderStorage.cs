using Domain.DTOs;

namespace Domain.UseCases.CreateOrder;

public interface ICreateOrderStorage
{
    Task<bool> OrderExist(Guid  orderId, CancellationToken cancellationToken);
    Task<OrderDto> CreateOrder(Guid orderId, string customerIp, CancellationToken cancellationToken);
}