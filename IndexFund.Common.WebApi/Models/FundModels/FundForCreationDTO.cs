namespace IndexFund.Common.WebApi.Models
{
    public class FundForCreationDTO
    {

        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string Benchmark { get; set; } = string.Empty;
        public int RiskLevel { get; set; }
        public decimal FirstMinimalPayment { get; set; }
        public decimal MinimalPayment { get; set; }
        public decimal ManagementFee { get; set; }
        public decimal HandlingFee { get; set; }
        public decimal UnitPrice { get; set; }
        public string InternalCurrency { get; set; } = "PLN";
        public string ExternalCurrency { get; set; } = "PLN";
        public string PayoutCurrency { get; set; } = "PLN";
        public DateTime FundStartDate { get; set; }
        public int CategoryId { get; set; } = 1;
    }
}
