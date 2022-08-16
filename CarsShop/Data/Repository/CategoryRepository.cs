using CarsShop.Data.Interfaces;
using CarsShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace CarsShop.Data.Repository

{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent _DBcontent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this._DBcontent = appDBContent;
        }

       

        public IEnumerable<Category> AllCategories
        {
            get
            {
              return  _DBcontent.Categories;
            } 
        }
    }
}

