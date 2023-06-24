using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpraFinalProject.Application.Abstractions.Services;
using SimpraFinalProject.Application.Abstractions.Services.Authentications;
using SimpraFinalProject.Application.Repositories.Categories;
using SimpraFinalProject.Application.Repositories.Products;
using SimpraFinalProject.Domain.Entities.Identity;
using SimpraFinalProject.Persistence.Contexts;
using SimpraFinalProject.Persistence.Repositories.Categories;
using SimpraFinalProject.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {            
            services.AddDbContext<SimpraFinalProjectDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Scoped);
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SimpraFinalProjectDbContext>();            
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();           
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();



            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            
        }
    }
}
