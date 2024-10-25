using AutoMapper;
using Contracts;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FilterToDelivery.Controllers
{
    [Route("api/filteredOrders")]
    [ApiController]
    public class FilteredOrdersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public FilteredOrdersController(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }


        [HttpGet]
        public async Task<IActionResult> GetFilteredOrders(DateTime starDateTime, DateTime endDateTime)
        {
            var orders = await _repository.Order.GetFilteredOrdersAsync(starDateTime, endDateTime);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            //var ordersDto = orders.Select(o => new OrderDto
            //{
            //    orderId = o.OrderId,
            //    CityDistrict = o.CityDistrict,
            //    CustomerIpAddress = o.CustomerIpAddress,
            //    DeliveryTime = o.DeliveryTime,
            //    OrderTime = o.OrderTime,
            //    OrderWeight = o.OrderWeight
            //}).ToList();

            return Ok(ordersDto);
        }

    }
}
