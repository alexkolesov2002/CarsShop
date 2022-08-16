namespace CarsShop.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ShortDesk { get; set; }
        public string LongDesk { get; set; }
        public string Image { get; set; }

        public decimal Price { get; set; }

        public bool IsFavourite { get; set; }

        public bool Available { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
     
        
    }
}
