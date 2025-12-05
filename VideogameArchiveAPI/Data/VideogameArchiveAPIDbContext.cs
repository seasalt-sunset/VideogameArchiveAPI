using Microsoft.EntityFrameworkCore;
using VideogameArchiveAPI.Models;
namespace VideogameArchiveAPI.Data
{
    public class VideogameArchiveAPIDbContext : DbContext
    {
        public VideogameArchiveAPIDbContext(DbContextOptions<VideogameArchiveAPIDbContext> options) : base(options)
        {

        }

        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().UseTpcMappingStrategy();

            modelBuilder.Entity<Developer>(entity =>
            {
                entity.HasKey("Id");
            });
        }
    }
}
