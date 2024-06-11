using DemoWebApp.Domain.Entities;

namespace DemoWebApp.Application.Interfaces.Repositories
{
    public interface ITestRepository : IGenericRepositoryAsync<t_AlertEvents, Guid>
    {
    }
}
