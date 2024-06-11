using DemoWebApp.Application.Wrappers;

namespace DemoWebApp.Persistence.Repositories
{
    internal interface IGenericRepositoryAsync<T>
    {
        Task<BaseResponse<List<T>>> GetAllAsync();
    }
}