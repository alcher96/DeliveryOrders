using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs;

public class OrderForCreationDto
{

    [Required(ErrorMessage = "ip address is a required field")]
    [RegularExpression("^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9‌​]{2}|2[0-4][0-9]|25[0-5])$", ErrorMessage = "ip address is not correct")]
    public string CustomerIpAddress { get; set; }


    [Required(ErrorMessage = "Order weight is a required field")]
    [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Weight ")]
    public int orderWeight { get; set; }


    [Required(ErrorMessage = "District is a required field")]
    public string CityDistrict { get; set; }

    public DateTime OrderTime { get; set; }
    

}