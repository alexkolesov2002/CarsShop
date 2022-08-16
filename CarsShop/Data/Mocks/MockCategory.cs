using CarsShop.Data.Interfaces;
using CarsShop.Data.Models;
using System.Collections.Generic;

namespace CarsShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            { 
                return new List<Category>
                {
                    new Category{ CategoryName = "Электроавтомобили " , Desk= "Новое слово техники" },
                    new Category{ CategoryName = "Автомобили с ДВС " , Desk= "Проверенное и хорошее" },

                };
            }
        }

    }
}
