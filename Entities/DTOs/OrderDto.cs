namespace Entities.DTOs;

public class OrderDto
{
    public Guid orderId { get; set; }

    public string CustomerIpAddress { get; set; }

    public int OrderWeight { get; set; }

    public string CityDistrict { get; set; }

    public DateTime OrderTime { get; set; }

    public DateTime DeliveryTime { get; set; }
}