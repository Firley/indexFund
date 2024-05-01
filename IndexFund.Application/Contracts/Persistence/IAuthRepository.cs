using IndexFund.Domain.Entities;
using IndexFund.Domain.Models.UserModels;

namespace IndexFund.Application.Contracts.Persistence
{
    public interface IAuthRepository
    {
        bool RegisterUser(User userToCreate);

        string ValidateUserCreditensials(FundUserCreditensialsDTO userCreditensialsDTO);
    }
}