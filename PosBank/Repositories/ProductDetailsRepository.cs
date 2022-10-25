using Microsoft.EntityFrameworkCore;
using PosBank.Models;
using PosBank.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories
{
    public class ProductDetailsRepository : Repository<ProductDetails>, IProductDetailsRepository
    {
        public ProductDetailsRepository(PosbankDbContext _db) : base(_db)
        {

        }

        public IEnumerable<ProductDetails> DetailsJoinProduct()
        {
            return _db.ProductsDetails.Include(P => P.Product)
                            .ToList().OrderBy(o => o.Product.ProductName);
        }
    }
}
