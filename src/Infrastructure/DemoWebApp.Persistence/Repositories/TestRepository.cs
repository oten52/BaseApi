using DemoWebApp.Application.Interfaces.Repositories;
using DemoWebApp.Domain.Entities;
using DemoWebApp.Persistence.Context;

namespace DemoWebApp.Persistence.Repositories
{
    public class TestRepository : GenericRepository<t_AlertEvents, Guid>, ITestRepository
    {
        public TestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
