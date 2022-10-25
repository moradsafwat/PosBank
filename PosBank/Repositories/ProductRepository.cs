using Microsoft.EntityFrameworkCore;
using PosBank.Models;
using PosBank.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(PosbankDbContext _db) : base(_db)
        {
        }
        public IEnumerable<Product> GetProductsWithDetails()
        {
            return _db.Products.Include(d => d.ProductsDetails)
                .ToList();
        }
    }
}
