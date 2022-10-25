using Microsoft.AspNetCore.Http;
using PosBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public IFormFile PictureUrl { get; set; }
        public string PictureVM { get; set; }
        public decimal FixedPrice { get; set; }


        public int  productId { get; set; }
        public IList<ProductDetailsViewModel> ProductsDetails { get; set; }
    }
}
