using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Picture { get; set; }
        public decimal FixedPrice { get; set; }

        public List<ProductDetails> ProductsDetails { get; set; }
    }
}
