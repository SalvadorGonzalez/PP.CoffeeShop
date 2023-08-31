using Microsoft.EntityFrameworkCore;

namespace PP.CoffeeShop.Presentation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Drink> Drinks { get; set; }
    }
}
