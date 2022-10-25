using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }
}
