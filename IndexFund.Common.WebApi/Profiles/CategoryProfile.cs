using AutoMapper;

namespace IndexFund.Common.WebApi.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Entities.Category,Models.CategoryDTO>();
            CreateMap<Models.CategoryForCreationDTO, Entities.Category>();
            CreateMap<Models.CategoryForUpdateDTO, Entities.Category>();
        }
    }
}