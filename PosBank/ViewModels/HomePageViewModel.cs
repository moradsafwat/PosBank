using PosBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<ProductViewModel> ProductsVM { get; set; }
        public ProductViewModel Product { get; set; }

    }
}
