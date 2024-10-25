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
        var trackChanges = context.HttpContext.Request.Method.Equals("POST");
        var id = (Guid)context.ActionArguments["orderId"];
        var order = await _repositoryManager.Order.GetOrderAsync(id,trackChanges);
        
        if (order.CustomerIpAddress == "1.1.1.1")
        {
            context.Result = new NotFoundResult();
        }

        else
        {
            context.HttpContext.Items.Add("order",order);
            await next();
        }
    }
}