using CarsShop.Data.Interfaces;
using CarsShop.VIewModels;
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
            ViewBag.Title = "Список автомобилей";
            CarsCollectionViewModel obj = new CarsCollectionViewModel();
            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Автомобили";
            return View(obj);  
        }



    }
}
