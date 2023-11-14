using GloboTicket.TicketManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace IndexFund.Domain.Entities
{
    public class Fund : AuditableEntity
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string Name { get; set; } = null!;

        [MaxLength(64)]
        public string ShortName { get; set; } = null!;

        public string Benchmark { get; set; } = null!;

        [Range(1, 5)]
        public int RiskLevel { get; set; }

        [Range(100, 5000)]
        [Precision(7, 3)]
        public decimal FirstMinimalPayment { get; set; }

        [Precision(7, 3)]
        public decimal MinimalPayment { get; set; }

        [Precision(7, 3)]
        public decimal ManagementFee { get; set; }

        [Precision(7, 3)]
        public decimal HandlingFee { get; set; }

        [Precision(7, 3)]
        public decimal UnitPrice { get; set; }

        public bool IsActive { get; set; } = false;

        public string InternalCurrency { get; set; } = null!;

        public string ExternalCurrency { get; set; } = null!;

        public string PayoutCurrency { get; set; } = null!;

        public DateTime FundStartDate { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
