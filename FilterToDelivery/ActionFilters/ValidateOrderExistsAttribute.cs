using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterToDelivery.ActionFilters;

public class ValidateOrderExistsAttribute : IAsyncActionFilter
{
    private readonly IRepositoryManager _repositoryManager;


    public ValidateOrderExistsAttribute(IRepositoryManager repository)
    {
        _repositoryManager = repository;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
            
    }
}