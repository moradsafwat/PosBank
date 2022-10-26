using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<ProductDetails> ProductsDetails { get; set; }

        public List<OrderItem_ProductDetails> OrderItem_ProductDetails { get; set; }

    }
}
