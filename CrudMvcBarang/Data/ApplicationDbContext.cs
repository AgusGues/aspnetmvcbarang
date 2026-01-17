using Microsoft.EntityFrameworkCore;
using CrudMvcBarang.Models;

namespace CrudMvcBarang.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Barang> Barang { get; set; }
    }
}
