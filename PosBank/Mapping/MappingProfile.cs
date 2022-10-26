using AutoMapper;
using PosBank.Models;
using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(d => d.PictureVM, s => s.MapFrom(s => s.Picture));
            CreateMap<ProductViewModel, Product>()
                .ForMember(d => d.Picture, s => s.MapFrom(s => s.PictureVM));
            
            CreateMap<HomePageViewModel, ProductViewModel>();
            
            CreateMap<ProductDetails, ProductDetailsViewModel>()
                .ForMember(d => d.Product_Name, s => s.MapFrom(s => s.Product.ProductName))
                .ForMember(d => d.Photo, s => s.MapFrom(s => s.Product.Picture))
                ;
            CreateMap<ProductDetailsViewModel, ProductDetails>();

            CreateMap<Order, OrderViewModel>(); 
            CreateMap<OrderViewModel, Order>();

        }
    }
}
