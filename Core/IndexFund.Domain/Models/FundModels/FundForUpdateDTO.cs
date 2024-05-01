namespace IndexFund.Domain.Models.FundModels;

public class FundForUpdateDTO
{
    public string Name { get; set; }

    public string ShortName { get; set; }

    public string Benchmark { get; set; }

    public int RiskLevel { get; set; }

    public decimal FirstMinimalPayment { get; set; }

    public decimal MinimalPayment { get; set; }

    public decimal ManagementFee { get; set; }

    public decimal HandlingFee { get; set; }

    public decimal UnitPrice { get; set; }

    public string InternalCurrency { get; set; } = null!;

    public string ExternalCurrency { get; set; } = null!;
    public string PayoutCurrency { get; set; } = null!;

    public DateTime FundStartDate { get; set; }

    public int CategoryId { get; set; } = 1;
}
