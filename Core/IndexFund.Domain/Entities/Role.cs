using GloboTicket.TicketManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace IndexFund.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}