using DemoWebApp.Application.Wrappers;
using DemoWebApp.Domain.Common;

namespace DemoWebApp.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T, PKey> where T : BaseEntity<PKey>
    {
        Task<BaseResponse<List<T>>> GetAllAsync();
    }
}
