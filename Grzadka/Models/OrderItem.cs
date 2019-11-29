using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grzadka.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int PlantId { get; set; } //klucz obcy
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Plant Plant { get; set; }
        public virtual Order Order { get; set; }
    }
}