using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PP.CoffeeShop.Presentation.Data
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public DrinkCategory? Category { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
    }

    
}
