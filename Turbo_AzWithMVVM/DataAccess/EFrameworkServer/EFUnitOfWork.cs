using Turbo_AzWithMVVM.Domain.Abstractions;



namespace Turbo_AzWithMVVM.DataAccess.EFrameworkServer
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public ICarRepository CarRepository => new EFCarRepository();
    }
}
