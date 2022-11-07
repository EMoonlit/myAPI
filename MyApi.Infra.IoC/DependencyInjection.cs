using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApi.Application.Mappings;
using MyApi.Application.Services;
using MyApi.Application.Services.Interfaces;
using MyApi.Domain.Repositories;
using MyApi.Infra.Context;
using MyApi.Infra.Data.Repositories;

namespace MyApi.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionStringTest = configuration.GetConnectionString("DefaultConnection");
        
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IPersonRepository, PersonRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(DomainToDtoMapping));
        services.AddScoped<IPersonService, PersonService>();
        return services;
    }
}