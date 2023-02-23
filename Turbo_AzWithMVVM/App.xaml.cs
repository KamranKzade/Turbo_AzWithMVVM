using System.Windows;
using Turbo_AzWithMVVM.Domain.Abstractions;
using Turbo_AzWithMVVM.DataAccess.EFrameworkServer;



namespace Turbo_AzWithMVVM
{
    public partial class App : Application
    {
        public static IUnitOfWork DB;

        public App()
        {
            DB = new EFUnitOfWork();
        }
    }
}
