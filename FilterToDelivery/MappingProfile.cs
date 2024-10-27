using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace FilterToDelivery;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrderDto>();

        CreateMap<OrderForCreationDto, Order>();
    }
}