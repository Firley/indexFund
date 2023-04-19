using AutoMapper;


namespace IndexFund.Common.WebApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Models.FundUserForRegistrationDTO, Entities.User>();
        }

    }
}
