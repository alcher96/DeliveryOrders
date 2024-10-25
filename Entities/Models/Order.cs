﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {

        [Column("OrderId")]
        public Guid OrderId { get; set; }
        
        
        
        public string CustomerIpAddress { get; set; }

        
        public int OrderWeight { get; set; }


        
        public string CityDistrict { get; set; }

        public DateTime OrderTime { get; set; }

        public DateTime DeliveryTime { get; set; }

        [ForeignKey(nameof(FilteredOrder))]
        public Guid RequestId { get; set; }

        public FilteredOrder FilteredOrder { get; set; }
    }
}