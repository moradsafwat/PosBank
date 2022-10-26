using PosBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsWithDetails();
        Product GetProductsWithDetails(int id);
    }
}
