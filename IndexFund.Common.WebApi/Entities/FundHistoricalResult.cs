using System.ComponentModel.DataAnnotations.Schema;

namespace IndexFund.Common.WebApi.Entities
{
    public class FundHistoricalResult
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Result { get; set; }

        public double UnitPrice { get; set; }

        public int FundId { get; set; }

        public Fund? Fund { get; set; }
    }
}