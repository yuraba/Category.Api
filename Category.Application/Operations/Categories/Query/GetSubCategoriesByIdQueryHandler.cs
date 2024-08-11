using Category.Application.Operations.Categories.Dto;
using Category.Domain.Interfaces.Repositories;
using MapsterMapper;
using MediatR;

namespace Category.Application.Operations.Categories.Query
{
    public record GetSubCategoriesByIdQuery(int parentId) : IRequest<List<CategoryDto>>;
    public class GetSubCategoriesByIdQueryHandler : IRequestHandler<GetSubCategoriesByIdQuery, List<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetSubCategoriesByIdQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public Task<List<CategoryDto>> Handle(GetSubCategoriesByIdQuery request, CancellationToken cancellationToken)
        {
            var categories = _categoryRepository.GetSub(request.parentId);
            return Task.FromResult(_mapper.Map<List<CategoryDto>>(categories));
        }
    }
}
