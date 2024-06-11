using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DemoWebApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection serviceCollection)
        {
            var assm = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(assm);
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assm));
        }
    }
}
