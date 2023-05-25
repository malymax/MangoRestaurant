using Microsoft.EntityFrameworkCore;

//TOD: move to Mango.Product.Data or it's own project Mango.Product.Data.RA
namespace Mango.Product.API.RA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Data.Models.Product> Products { get; set; }
    }
}
