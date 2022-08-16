using CarsShop.Data.Interfaces;
using CarsShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarsShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { Id = 1, Name = "Lada", ShortDesk ="", LongDesk = "", Image = "", Price= 1200000 , IsFavourite = true, Available = true, Category = _categoryCars.AllCategories.First() }
                };
            }


            set { }

        }
        public IEnumerable<Car> GetFavCars { get; set ; }

        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
