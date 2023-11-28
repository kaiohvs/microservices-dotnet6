using AutoMapper;
using GeekShopping.ProductAPI.Data.Dto.Request;
using GeekShopping.ProductAPI.Data.Dto.Response;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<Product, ProductRequest>().ReverseMap();            
        }


    }

}
