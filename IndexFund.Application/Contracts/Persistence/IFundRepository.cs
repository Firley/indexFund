namespace IndexFund.Application.Contracts.Persistence
{
    public interface IFundRepository
    {
        Task AddFundAsync(Fund fundToAdd);
        Task<bool> CheckFundNamesUniquenessAsync(Fund fundToUpdate);
        Task<Fund?> GetFundAsync(int fundId);
        Task<PagedList<Fund?>> GetFundsAsync(FundResourceParameters fundResourceParameters);
        Task<bool> SaveAsync();
    }
}