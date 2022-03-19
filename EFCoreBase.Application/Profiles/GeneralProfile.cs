using AutoMapper;
using EFCoreBase.Application.Dto.Category;
using EFCoreBase.Application.Dto.Feature;
using EFCoreBase.Application.Dto.Product;
using EFCoreBase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Application.Mapping
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
        }

    }
}
