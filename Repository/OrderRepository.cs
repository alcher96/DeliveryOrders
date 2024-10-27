using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Repository;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    //бизнес логика
    public async Task<IEnumerable<Order>> GetAllOrdersAsync() =>
        await FindAll().OrderBy(o => o.CityDistrict).ToListAsync();

    public async Task<Order> GetOrderAsync(Guid orderId, bool trackChanges) =>
        await FindByCondition(o => o.OrderId.Equals(orderId), trackChanges).SingleOrDefaultAsync();

    public async Task<IEnumerable<Order>> GetOrdersFilteredAsync(DateTime firstDeliveryDateTime,
        string cityDistrict, bool trackChanges) =>
        await FindByCondition(o => o.DeliveryTime < firstDeliveryDateTime.AddMinutes(30)
                                   && o.CityDistrict == cityDistrict, trackChanges: false).ToListAsync();
    
        
    public Task WriteDataList(string filename, IEnumerable<Order> dataList)
    {
        var filestream = File.OpenWrite(filename);
        var writer = new Utf8JsonWriter(filestream,
            new JsonWriterOptions
            {
                Indented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
        writer.WriteStartArray();
        foreach (var dataItem in dataList) {
            writer.WriteStartObject();
            writer.WriteString("Район:", dataItem.CityDistrict);
            writer.WriteString("Время доставки", dataItem.DeliveryTime.ToString("yyyy:MM:dd:HH:mm:ss"));
            writer.WriteNumber("Вес:",dataItem.OrderWeight);
            writer.WriteEndObject();
        }
        writer.WriteEndArray();
        
        writer.Dispose();
        filestream.Close();
        return Task.CompletedTask;
        
    }

    
    
    public void CreateOrder(Order order) => Create(order);


    public void DeleteOrder(Order order) => Delete(order);



}