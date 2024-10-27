
using System.Xml;
using AutoMapper;
using Contracts;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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
        public async Task<IActionResult> GetFilteredOrders(DateTime firstDeliveryDateTime, string CityDistrict)
        {
            var orders = await _repository.Order.GetOrdersFilteredAsync(firstDeliveryDateTime, CityDistrict,trackChanges:false);
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            await _repository.Order.WriteDataList("data.txt", orders);
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
