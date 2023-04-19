using IndexFund.Common.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Models
{
    public class FundDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string Benchmark { get; set; } = null!;
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
        public Category? Category { get; set; }
    }
}
