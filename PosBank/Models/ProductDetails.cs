using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
