using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace FilterToDelivery;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrderDto>()
            .ForMember(x=>x.DeliveryTime,
                opt=>
                    opt.MapFrom(c=>c.OrderTime.AddMinutes(30)));

        CreateMap<OrderForCreationDto, Order>();
    }
}