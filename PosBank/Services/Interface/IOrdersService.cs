using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Services.Interface
{
    public interface IOrdersService
    {
        OrderViewModel GetById(int id);
        IEnumerable<OrderViewModel> GetAll();
        void Create(OrderViewModel orderVm);
        void Delete(OrderViewModel orderVm);
        void Update(int id, OrderViewModel orderVm);
    }
}
