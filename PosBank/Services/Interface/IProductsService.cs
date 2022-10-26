using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Services.Interface
{
    public interface IProductsService
    {
        ProductViewModel GetById(int id);
        ProductViewModel GetProductWithDetailsById(int id);
        IEnumerable<ProductViewModel> GetAll();
        void Create(ProductViewModel productVm);
        void Delete(ProductViewModel productVm);
        void Update(int id, ProductViewModel productVm);
        IEnumerable<ProductViewModel> AllProductDetails();

    }
}
