using AutoMapper;
using ProductService.Dto;
using ProductService.Entities;

namespace ProductService.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
