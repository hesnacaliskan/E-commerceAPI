using AutoMapper;
using SimpraFinalProject.Application.Features.Queries.Categories.GetAllCategory;
using SimpraFinalProject.Application.Features.Queries.Products.GetAllProduct;
using SimpraFinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, GetAllCategoryQueryResponse>().ReverseMap();
            CreateMap<Product, GetAllProductQueryResponse>().ReverseMap();
                
                

        }
    }
}
