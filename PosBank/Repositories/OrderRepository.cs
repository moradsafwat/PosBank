using PosBank.Models;
using PosBank.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(PosbankDbContext _db) : base(_db)
        {
        }

    }
}
