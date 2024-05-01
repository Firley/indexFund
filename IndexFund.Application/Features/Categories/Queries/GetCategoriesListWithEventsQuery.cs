using IndexFund.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<Category>>
    {
        public bool IncludeHistory { get; set; }
    }
}
