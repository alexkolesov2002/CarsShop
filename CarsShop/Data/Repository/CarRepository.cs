using CarsShop.Data.Interfaces;
using CarsShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarsShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _DBcontent;

        public CarRepository(AppDBContent appDBContent)
        {
            this._DBcontent = appDBContent;
        }



        public IEnumerable<Car> Cars => _DBcontent.Cars.Include(c =>  c.Category);
        public IEnumerable<Car> GetFavCars { get => _DBcontent.Cars.Where(x=>x.IsFavourite).Include(c=> c.Category); }

        public Car GetObjectCar(int carId)
        {
          return  _DBcontent.Cars.FirstOrDefault(x => x.Id == carId);
        }
    }
}
