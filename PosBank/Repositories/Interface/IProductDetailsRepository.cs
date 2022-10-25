using PosBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories.Interface
{
    public interface IProductDetailsRepository : IRepository<ProductDetails>
    {
        IEnumerable<ProductDetails> DetailsJoinProduct();
    }
}
