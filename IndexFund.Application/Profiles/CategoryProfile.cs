using AutoMapper;
using IndexFund.Common.WebApi.Entities;
using IndexFund.Domain.Models.CategoryModels;

namespace IndexFund.Common.WebApi.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryForCreationDTO,Category>();
            CreateMap<CategoryForUpdateDTO, Category>();
        }
    }
}