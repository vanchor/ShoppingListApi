using Microsoft.EntityFrameworkCore;

namespace ShoppingListApi.Models
{
    public class ShoppingListContext : DbContext
    {
        public DbSet<Grocery> Grocery { get; set; }

        public ShoppingListContext(DbContextOptions<ShoppingListContext> options) : base(options)
        {

        }
    }
}
