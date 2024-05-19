using AutoMapper;

using IndexFund.Application.Contracts.Persistence;
using IndexFund.Application.Features.Categories.Queries;
using IndexFund.Domain.Models.CategoryModels;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDTO>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var list = (await _categoryRepository.ListAllAsync()).OrderBy(x => x.Name).ToList();
            
            return _mapper.Map<List<CategoryDTO>>(list);
        }
    }
}
