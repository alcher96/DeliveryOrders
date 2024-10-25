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


        public OrderController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



       



        [HttpGet] 
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _repository.Order.GetAllOrdersAsync();
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

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderForCreationDto order)
        {
            var orderEntity = _mapper.Map<Order>(order);

            _repository.Order.CreateOrder(orderEntity);
            await _repository.SaveAsync();

            var orderToReturn = _mapper.Map<OrderDto>(orderEntity);



            return Ok(orderToReturn);
        }


      



    }


}
