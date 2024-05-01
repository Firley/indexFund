using AutoMapper;
using IndexFund.Domain.Models.FundModels;

namespace IndexFund.Common.WebApi.Profiles
{
    public class FundProfile : Profile
    {
        public FundProfile()
        {
            CreateMap<FundForCreationDTO, Entities.Fund>();
            CreateMap<Entities.Fund, FundDTO>();
            CreateMap<FundForUpdateDTO, Entities.Fund>();
        }
    }
}
