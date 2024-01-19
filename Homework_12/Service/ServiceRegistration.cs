using Homework_12.Service.UserDialogService;
using Microsoft.Extensions.DependencyInjection;

namespace Homework_12.Service
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services) => services
            .AddTransient<IUserDialogService, WindowsUserDialogService>()
            ;

    }
}