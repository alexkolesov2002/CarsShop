using CarsShop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace CarsShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }

        IEnumerable<Car> GetFavCars { get; }

        Car GetObjectCar(int carId);
    }
}
