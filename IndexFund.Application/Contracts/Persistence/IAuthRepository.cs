using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Models;

namespace IndexFund.Application.Contracts.Persistence
{
    public interface IAuthRepository
    {
        bool RegisterUser(User userToCreate);
        string ValidateUserCreditensials(FundUserCreditensialsDTO userCreditensialsDTO);
    }
}