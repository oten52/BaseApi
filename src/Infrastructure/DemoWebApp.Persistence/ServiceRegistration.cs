using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoWebApp.Application.Interfaces.Repositories;
using DemoWebApp.Persistence.Context;
using DemoWebApp.Persistence.Repositories;

namespace DemoWebApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection serviceCollection, string? constr)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(constr));
            serviceCollection.AddTransient<ITestRepository, TestRepository>();
        }
    }
}
