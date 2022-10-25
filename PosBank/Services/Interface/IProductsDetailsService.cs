using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Services.Interface
{
    public interface IProductsDetailsService
    {
        IEnumerable<ProductDetailsViewModel> DetailsJoinProduct();
        void Create(ProductDetailsViewModel productVm);
        void CreateRang(IEnumerable<ProductDetailsViewModel> productsVm);

    }
}
