using CarsShop.Data.Models;
using System.Collections.Generic;

namespace CarsShop.VIewModels
{
    public class CarsCollectionViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CurrCategory { get; set;}
    }
}
