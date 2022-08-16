using CarsShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace CarsShop.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars IAllCars, ICarsCategory ICarsCat)
        {
            _allCars = IAllCars;
            _allCategories = ICarsCat;
        }

        public ViewResult CarsCollectionView()
        {
            ViewBag.Category = "Some new";
            var cars = _allCars.Cars;
            return View(cars);  
        }



    }
}
