using Domain.DTOs;

namespace Domain.UseCases.GetOrders;

public interface IGetOrderUseCase
{
    Task<IEnumerable<OrderDto>> Execute(CancellationToken cancellationToken);
}