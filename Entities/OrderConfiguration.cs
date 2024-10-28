using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    //data seed
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
     

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData
                (
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de704"),
                        CityDistrict = "Центральный",
                        DeliveryTime = new DateTime(2024, 10, 22, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de111"),
                        CityDistrict = "Северный",
                        DeliveryTime = new DateTime(2024, 11, 22, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de112"),
                        CityDistrict = "Восточный",
                        DeliveryTime = new DateTime(2024, 11, 23, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de113"),
                        CityDistrict = "Центральный",
                        DeliveryTime = new DateTime(2024, 11, 24, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de114"),
                        CityDistrict = "Центральный",
                        DeliveryTime = new DateTime(2024, 11, 25, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("cfa59f16-d6f9-4d8a-b97a-9aeec74de115"),
                        CityDistrict = "Центральный",
                        DeliveryTime = new DateTime(2024, 11, 26, 17, 38, 12),
                        OrderWeight = 12
                    },
                    new Order
                    {
                        OrderId = new Guid("78e03122-7e4e-44f0-ad11-5fe56a2669dd"),
                        CityDistrict = "Западный",
                        DeliveryTime = new DateTime(2024, 10, 22, 17, 38, 12),
                        OrderWeight = 15
                    },
                    new Order
                    {
                        OrderId = new Guid("4978799c-f114-46a0-bf6e-21d14e5c5bff"),
                        CityDistrict = "Западный",
                        DeliveryTime = new DateTime(2024, 10, 26, 17, 28, 12),
                        OrderWeight = 16
                    }


                    );

           
            


        }
    }
}
