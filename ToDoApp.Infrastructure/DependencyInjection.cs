using ToDoApp.Application.Abstractions;
using ToDoApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace ToDoApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Register infrastructure services here
            // e.g., services.AddDbContext<ToDoDbContext>(...);
            services.AddScoped<ITodoRepository, ToDoRepository>();
            return services;
        }
    }
}
