using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile() {
            CreateMap<Product,        ProductDto>().ReverseMap();
            CreateMap<Category,       CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<Product,        ProductUpdateDto>().ReverseMap();
            CreateMap<Product,        ProductWithCategoryDto>().ReverseMap();
            CreateMap<Category,       CategoryWithProductsDto>().ReverseMap();
            CreateMap<Product,        ProductCreateDto>().ReverseMap();
        }
    }
}
