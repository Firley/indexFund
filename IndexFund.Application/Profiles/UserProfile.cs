using AutoMapper;
using IndexFund.Domain.Models.UserModels;

namespace IndexFund.Common.WebApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<FundUserForRegistrationDTO, Entities.User>();
        }
    }
}