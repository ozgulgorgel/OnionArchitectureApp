using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Persistence.Context;
using OnionArchitectureApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));

            services.AddTransient<IProductRepository, ProductRepository>();
        }
        //public static IServiceCollection AddInfrastructure(
        //this IServiceCollection services)
        //{
        //    services.AddDbContext<ApplicationDbContext>(cfr => cfr.UseInMemoryDatabase("memorydb"));
        //    services.AddTransient<IProductRepository, ProductRepository>();
        //    return services;
        //}
      
    }
}
