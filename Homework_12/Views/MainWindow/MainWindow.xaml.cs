using Homework_12.ViewModels.MainWindowVm;
using System.Windows;

namespace Homework_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Closing += (sender, args) =>
            {
                if (!(DataContext is MainWindowViewModel mainVm)) return;
                mainVm.OnExit();
            };
        }
    }
}