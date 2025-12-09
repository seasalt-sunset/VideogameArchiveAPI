using Microsoft.EntityFrameworkCore;
using VideogameArchiveAPI.Models;
using VideogameArchiveAPI.Models.CompanyModels;
using VideogameArchiveAPI.Models.VideogameModels;
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
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<VideogameUser> VideogameUsers { get; set; }
        public DbSet<GamingConsole> Consoles { get; set; }
        public DbSet<CustomFolder> CustomFolders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().UseTpcMappingStrategy();

            //correggi tutto qui sotto

            //modelBuilder.Entity<Videogame>(entity =>
            //{
            //    entity.HasKey(e => e.GameId);
                
            //    entity.HasMany(e => e.GamingConsoles)
            //    .WithMany(e => e.VideogameList)
            //    .UsingEntity(j => j.ToTable("VideogamesConsoles"));
            //    entity.HasMany(e => e.Developers)
            //    .WithMany(d => d.GameList)
            //    .UsingEntity(j => j.ToTable("VideogamesDevelopers"));

            //    entity.HasMany(e => e.Publishers)
            //    .WithMany(p => p.GameList)
            //    .UsingEntity(j => j.ToTable("VideogamesPublishers"));

            //    entity.HasMany(e => e.Genres)
            //    .WithMany(g => g.VideogameList)
            //    .UsingEntity(j => j.ToTable("VideogamesGenres"));

            //    entity.HasMany(e => e.GameModes)
            //    .WithMany(m => m.VideogameList)
            //    .UsingEntity(j => j.ToTable("VideogamesGameModes"));
            //});

            //modelBuilder.Entity<GamingConsole>(entity =>
            //{
            //    entity.HasKey(e => e.ConsoleId);
            //    entity.HasOne(e => e.Publisher)
            //    .WithMany(p => p.GamingConsolesList);
            //});
        }
    }
}
