using GloboTicket.TicketManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace IndexFund.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}