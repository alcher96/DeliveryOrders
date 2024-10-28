using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs;

public class OrderForCreationDto
{
    
    [Required(ErrorMessage = "Order weight is a required field")]
    [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Weight ")]
    public int orderWeight { get; set; }


    [Required(ErrorMessage = "District is a required field")]
    public string CityDistrict { get; set; }

    [Required(ErrorMessage = "The Date field is required.")]
    public DateTime DeliveryTime { get; set; }
    

}