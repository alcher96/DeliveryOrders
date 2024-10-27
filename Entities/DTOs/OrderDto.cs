namespace Entities.DTOs;

public class OrderDto
{
    public Guid orderId { get; set; }

    public int OrderWeight { get; set; }

    public string CityDistrict { get; set; }
    

    public DateTime DeliveryTime { get; set; }
}