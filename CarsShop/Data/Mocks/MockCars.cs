using CarsShop.Data.Interfaces;
using CarsShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarsShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Id = 1,
                        Name = "Lada Priora",
                        ShortDesk ="Топ",
                        LongDesk = "Тоооооп",
                        Image = "https://www.rabstol.net/uploads/gallery/main/575/rabstol_net_lada_priora_01.jpg",
                        Price= 1200000 ,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last() },

                    new Car { Id = 2,
                        Name = "Schoda Rapid ЭЛ",
                        ShortDesk ="Топчик",
                        LongDesk = "Супер топ машина",
                        Image = "https://s.auto.drom.ru/i24240/c/photos/fullsize/skoda/rapid/skoda_rapid_930759.jpg",
                        Price= 1100000 ,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.First() }
                };
            }


            set
            {
                
            }

        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
