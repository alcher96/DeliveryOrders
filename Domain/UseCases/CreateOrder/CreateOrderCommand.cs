namespace Domain.UseCases.CreateOrder;

public record CreateOrderCommand(Guid orderId, string customerIp);