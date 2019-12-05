using Microsoft.Extensions.DependencyInjection;
using Pacco.Web.Areas.Identity;
using Pacco.Web.Shared;

namespace Pacco.Web.Areas
{
    public static class Extensions
    {
        public static IServiceCollection RegisterIdentityArea(this IServiceCollection services)
        {
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddScoped<IdentityComponent>();
            services.AddScoped<MenuComponent>();

            return services;
        }
    }
}