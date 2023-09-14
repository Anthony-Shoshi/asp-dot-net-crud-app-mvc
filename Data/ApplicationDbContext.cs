using Microsoft.EntityFrameworkCore;
using MyCRUDApp.Models;

namespace MyCRUDApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
