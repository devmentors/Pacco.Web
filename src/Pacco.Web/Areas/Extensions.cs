using Microsoft.Extensions.DependencyInjection;
using Pacco.Web.Areas.Identity;

namespace Pacco.Web.Areas
{
    public static class Extensions
    {
        public static IServiceCollection RegisterIdentityArea(this IServiceCollection services)
        {
            services.AddTransient<IIdentityService, IdentityService>();
            services.AddSingleton<IdentityComponent>();
//            services.AddSingleton<MenuComponent>;

            return services;
        }
    }
}