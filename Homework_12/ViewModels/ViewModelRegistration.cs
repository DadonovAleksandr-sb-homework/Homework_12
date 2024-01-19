using Homework_12.ViewModels.MainWindowVm;
using Microsoft.Extensions.DependencyInjection;

namespace Homework_12.ViewModels
{
    public static class ViewModelRegistration
    {
        public static IServiceCollection RegisterViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
            ;

    }
}