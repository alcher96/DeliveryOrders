using Contracts;
using Entities;
using Entities.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Repository;

namespace FilterToDelivery.Tests;

public class OrderServiceTests
{

    private readonly OrderRepository _sut; 
    private readonly DbContextOptions<RepositoryContext> _dbContextOptions;
    private readonly RepositoryContext _dbContext;

    public OrderServiceTests()
    {
        //используем entityFrameworkInMemory в качестве базы данных для теста
        _dbContextOptions = new DbContextOptionsBuilder<RepositoryContext>().UseInMemoryDatabase("testDB").Options;
        _dbContext = new RepositoryContext(_dbContextOptions);

        _sut = new OrderRepository(_dbContext);
    }
    
    [Fact]
    public async Task GetOrdersFilteredAsync_WhenCalled_NotReturnsFilteredOrders()
    {
         // Arrange
         //невалидные данные
         await _dbContext.Orders.AddAsync(new Order()
         {
             OrderId = new Guid(),
             CityDistrict = "Западный",
             DeliveryTime = new DateTime(2022, 10, 22,17,28,12),
             OrderWeight = 15
         });
         await _dbContext.SaveChangesAsync();
          var cityDistrict = "Западный";
          DateTime firstDeliveryDate = new DateTime(2021, 10, 22,17,28,12);
         // Act
         var result = await _sut.GetOrdersFilteredAsync(firstDeliveryDate, cityDistrict, false);

         // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public async Task GetOrdersFilteredAsync_WhenCalled_ReturnsFilteredOrders()
    {
        // Arrange
        //валидные данные
        
        await _dbContext.Orders.AddRangeAsync(new Order()
        {
            OrderId = new Guid(),
            CityDistrict = "Западный",
            DeliveryTime = new DateTime(2022, 10, 22,17,28,12),
            OrderWeight = 15
        },
            new Order()
            {
                OrderId = new Guid(),
                CityDistrict = "Западный",
                DeliveryTime = new DateTime(2022, 10, 22,17,32,12),
                OrderWeight = 16
            });
        await _dbContext.SaveChangesAsync();
        var cityDistrict = "Западный";
        DateTime firstDeliveryDate = new DateTime(2024, 10, 22,17,28,12);
        // Act
        var result = await _sut.GetOrdersFilteredAsync(firstDeliveryDate, cityDistrict, false);

        // Assert
        Assert.NotEmpty(result);
    }
}