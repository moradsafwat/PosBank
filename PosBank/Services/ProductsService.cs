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
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductsService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productRepository.List());
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.Find(id));
        }

        public void Create(ProductViewModel productVm)
        {
            _productRepository.Add(_mapper.Map<Product>(productVm));
        }

        public void Delete(ProductViewModel productVm)
        {
            _productRepository.Remove(_mapper.Map<Product>(productVm));
        }

        public void Update(int id, ProductViewModel productVm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewModel> AllProductDetails()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productRepository.GetProductsWithDetails());
        }
    }
}
