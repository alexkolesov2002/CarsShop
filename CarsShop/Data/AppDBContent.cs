
using CarsShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
