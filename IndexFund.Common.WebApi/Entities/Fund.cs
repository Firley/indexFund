using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Entities
{
    public class Fund
    {
        public int Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        [MaxLength(64)]
        public string ShortName { get; set; }
        public string Benchmark { get; set; }
        [Range(1, 5)]
        public int RiskLevel { get; set; }
        [Range(100, 5000)]
        [Precision(5, 2)]
        public decimal FirstMinimalPayment { get; set; }
        [Precision(5, 2)]
        public decimal MinimalPayment { get; set; }
        [Precision(5, 2)]
        public decimal ManagementFee { get; set; }
        [Precision(5, 2)]
        public decimal HandlingFee { get; set; }
        [Precision(5, 2)]
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; } = false;
        public string InternalCurrency { get; set; } = "PLN";
        public string ExternalCurrency { get; set; } = "PLN";
        public string PayoutCurrency { get; set; } = "PLN";
        public DateTime FundStartDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
