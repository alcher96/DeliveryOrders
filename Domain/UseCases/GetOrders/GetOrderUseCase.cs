using Domain.DTOs;


namespace Domain.UseCases.GetOrders;

public class GetOrderUseCase(IGetOrderStorage storage) : IGetOrderUseCase
{
    public Task<IEnumerable<OrderDto>> Execute(CancellationToken cancellationToken)
    {
        return storage.GetOrders(cancellationToken);
    }
}