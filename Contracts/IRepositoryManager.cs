namespace Contracts;

public interface IRepositoryManager
{
    IOrderRepository Order { get; }

    Task SaveAsync();
}