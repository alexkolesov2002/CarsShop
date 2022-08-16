

using System.Collections.Generic;

namespace CarsShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Desk { get; set; }

        public List<Car> Cars { get; set; }
    }
}
