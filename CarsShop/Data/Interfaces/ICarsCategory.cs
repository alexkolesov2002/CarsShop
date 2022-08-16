using CarsShop.Data.Models;
using System.Collections.Generic;

namespace CarsShop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
