

namespace Turbo_AzWithMVVM.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
    }
}
