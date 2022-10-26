using AutoMapper;
using PosBank.Models;
using PosBank.Repositories.Interface;
using PosBank.Services.Interface;
using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrdersService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<OrderViewModel>>(_orderRepository.List());
        }

        public OrderViewModel GetById(int id)
        {
            return _mapper.Map<OrderViewModel>(_orderRepository.Find(id));
        }

        public void Create(OrderViewModel orderVm)
        {
            _orderRepository.Add(_mapper.Map<Order>(orderVm));
        }

        public void Delete(OrderViewModel orderVm)
        {
            _orderRepository.Remove(_mapper.Map<Order>(orderVm));
        }

        public void Update(int id, OrderViewModel orderVm)
        {
            throw new NotImplementedException();
        }
    }
}
