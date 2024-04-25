using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application
{
    public  static class ServicesRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {

            var assembely=Assembly.GetExecutingAssembly();  
            services.AddAutoMapper(assembely);
            services.AddMediatR(assembely);
        }
    }
}
