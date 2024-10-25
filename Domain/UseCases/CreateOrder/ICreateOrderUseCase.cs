using Domain.DTOs;

namespace Domain.UseCases.CreateOrder;

public interface ICreateOrderUseCase
{
    Task<OrderDto> Execute(CreateOrderCommand command, CancellationToken cancellationToken);
}