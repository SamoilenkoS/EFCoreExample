using EFCoreExample.BAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.BAL
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}