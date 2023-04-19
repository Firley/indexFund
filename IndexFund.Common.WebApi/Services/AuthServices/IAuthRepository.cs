using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Models;

namespace IndexFund.Common.WebApi.Services
{
    public interface IAuthRepository
    {
        bool RegisterUser(User userToCreate);
        string ValidateUserCreditensials(FundUserCreditensialsDTO userCreditensialsDTO);
    }
}