using Contracts;
using Entities;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IOrderRepository> _orderRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(repositoryContext));
    }

    public IOrderRepository Order => _orderRepository.Value;
    public  Task SaveAsync()
    {
       return _repositoryContext.SaveChangesAsync();
    }
}