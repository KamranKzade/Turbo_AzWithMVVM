using System.Linq;
using System.Collections.Generic;
using Turbo_AzWithMVVM.Domain.Entities;
using Turbo_AzWithMVVM.Domain.Abstractions;


namespace Turbo_AzWithMVVM.DataAccess.EFrameworkServer
{
    public class EFCarRepository : ICarRepository
    {
        public ICollection<Car> GetAll()
        {
            List<Car> cars = new List<Car>();
            using (var context = new CarContext())
            {
                cars = context.Cars.ToList();

            }
            return cars;
        }
    }
}
