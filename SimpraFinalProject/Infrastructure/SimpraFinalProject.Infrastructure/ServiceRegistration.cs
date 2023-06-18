using Microsoft.Extensions.DependencyInjection;
using SimpraFinalProject.Application.Abstractions.Token;
using SimpraFinalProject.Infrastructure.Services.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
        
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();

        }
    }
}
