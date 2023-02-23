using System.Collections.Generic;


namespace Turbo_AzWithMVVM.Domain.Abstractions
{
    public interface IRepository<T>
    {
        ICollection<T> GetAll();
    }
}
