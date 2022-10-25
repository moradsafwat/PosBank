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
    public class ProductsDetailsService : IProductsDetailsService
    {
        private readonly IProductDetailsRepository _productDetailsRepository;
        private readonly IMapper _mapper;
        public ProductsDetailsService(IMapper mapper, IProductDetailsRepository productDetailsRepository)
        {
            _mapper = mapper;
            _productDetailsRepository = productDetailsRepository;
        }

        public void Create(ProductDetailsViewModel productVm)
        {
            _productDetailsRepository.Add(_mapper.Map<ProductDetails>(productVm));
        }

        public void CreateRang(IEnumerable<ProductDetailsViewModel> productsVm)
        {
            _productDetailsRepository.AddRange(_mapper.Map<IEnumerable<ProductDetails>>(productsVm));
        }
    }
}
