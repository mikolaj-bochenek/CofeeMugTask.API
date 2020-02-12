using AutoMapper;
using CoffeeMugTask.API.DTOs;
using CoffeeMugTask.API.Models;

namespace CoffeeMugTask.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<what you map, map to what>();

            CreateMap<ProductForCreateDTO, ProductModel>();
            CreateMap<ProductFroUpdateDTO, ProductModel>();
        }
    }
}