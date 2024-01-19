using Homework_12.ViewModels.MainWindowVm;
using Microsoft.Extensions.DependencyInjection;

namespace Homework_12.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();
    }
}