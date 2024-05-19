using IndexFund.Domain.Models.CategoryModels;

using MediatR;

namespace IndexFund.Application.Features.Categories.Queries;

public class GetCategoriesListQuery : IRequest<List<CategoryDTO>>
{
}
