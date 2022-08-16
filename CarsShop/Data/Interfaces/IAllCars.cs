using CarsShop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace CarsShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }

        IEnumerable<Car> GetFavCars { get; set; }

        Car GetObjectCar(int carId);
    }
}
