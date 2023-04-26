using AutoMapper;

namespace IndexFund.Common.WebApi.Profiles
{
    public class FundProfile : Profile
    {
        public FundProfile()
        {
            CreateMap<Models.FundForCreationDTO, Entities.Fund>();
            CreateMap<Entities.Fund, Models.FundDTO>();
            CreateMap<Models.FundForUpdateDTO, Entities.Fund>();
        }
    }
}
