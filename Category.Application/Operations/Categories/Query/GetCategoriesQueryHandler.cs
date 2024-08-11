using Category.Application.Operations.Categories.Dto;
using Category.Domain.Interfaces.Repositories;
using MapsterMapper;
using MediatR;

namespace Category.Application.Operations.Categories.Query
{
    public record GetCategoriesQuery() : IRequest<List<CategoryDto>>;
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<List<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories =  _categoryRepository.GetMain();
            return Task.FromResult(_mapper.Map<List<CategoryDto>>(categories));
        }
    }
}
