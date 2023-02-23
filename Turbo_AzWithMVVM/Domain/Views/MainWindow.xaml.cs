using System.Windows;
using Turbo_AzWithMVVM.Domain.ViewModels;



namespace Turbo_AzWithMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel vm = new MainViewModel();
            this.DataContext = vm;
        }
    }
}
