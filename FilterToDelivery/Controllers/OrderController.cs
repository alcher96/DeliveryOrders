using System.Net;
using System.Text.RegularExpressions;
using AutoMapper;
using Contracts;
using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterToDelivery.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;


        public OrderController(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }



       



        [HttpGet] 
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _repository.Order.GetAllOrdersAsync();
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            
            return Ok(ordersDto);


        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderForCreationDto order)
        {
            var orderEntity = _mapper.Map<Order>(order);

            _repository.Order.CreateOrder(orderEntity);
            await _repository.SaveAsync();

            var orderToReturn = _mapper.Map<OrderDto>(orderEntity);



            return Ok(orderToReturn);
        }

        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteOrder(Guid orderId)
        {
            var order =await _repository.Order.GetOrderAsync(orderId, false);
            
            _repository.Order.DeleteOrder(order);
            await _repository.SaveAsync();
            return NoContent();
        }




    }


}
