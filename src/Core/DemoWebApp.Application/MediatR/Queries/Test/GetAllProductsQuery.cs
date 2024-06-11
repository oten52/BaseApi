using DemoWebApp.Application.Interfaces.Repositories;
using DemoWebApp.Application.Wrappers;
using DemoWebApp.Domain.Entities;
using MediatR;

namespace DemoWebApp.Application.MediatR.Queries.Test
{
    public class GetAllProductsQuery : IRequest<BaseResponse<List<t_AlertEvents>>>
    {
        
        
    }

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, BaseResponse<List<t_AlertEvents>>>
    {
        private readonly ITestRepository _testRepository;
        public GetAllProductsQueryHandler(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<BaseResponse<List<t_AlertEvents>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _testRepository.GetAllAsync();
        }
    }
}
