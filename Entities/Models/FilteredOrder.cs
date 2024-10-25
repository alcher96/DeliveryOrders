namespace Entities.Models;

public class FilteredOrder
{
    public Guid RequestId { get; set; }

    public string CustomerIp { get; set; }

    public int RequestsCount { get; set; }

    public string CityDistrict { get; set; }

    public ICollection<Order> Orders { get; set; }
}