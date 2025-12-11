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
        public DbSet<GamingPlatform> GamingPlatforms { get; set; }
        public DbSet<CustomFolder> CustomFolders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().UseTpcMappingStrategy();

            //correggi tutto qui sotto

            modelBuilder.Entity<Videogame>(entity =>
            {
                entity.HasKey(e => e.GameId);

                entity.HasMany(e => e.GamingPlatforms)
                .WithMany(e => e.VideogameList)
                .UsingEntity(j => j.ToTable("VideogamesConsoles"));
                entity.HasMany(e => e.Developers)
                .WithMany(d => d.GameList)
                .UsingEntity(j => j.ToTable("VideogamesDevelopers"));

                entity.HasMany(e => e.Publishers)
                .WithMany(p => p.GameList)
                .UsingEntity(j => j.ToTable("VideogamesPublishers"));

                entity.HasMany(e => e.Genres)
                .WithMany(g => g.VideogameList)
                .UsingEntity(j => j.ToTable("VideogamesGenres"));

                entity.HasMany(e => e.Tags)
                .WithMany(t => t.VideogameList)
                .UsingEntity(j => j.ToTable("VideogamesTags"));

                entity.HasMany(e => e.GameModes)
                .WithMany(m => m.VideogameList)
                .UsingEntity(j => j.ToTable("VideogamesGameModes"));
            });

            modelBuilder.Entity<VideogameUser>(entity =>
            {
                entity.HasKey(e => e.VideogameUserId);

                entity.HasOne(e => e.Videogame)
                .WithMany(v => v.VideogameUsers)
                .HasForeignKey(f => f.VideogameId);

                entity.HasOne(e => e.User)
                .WithMany(u => u.VideogamesUser)
                .HasForeignKey(f => f.UserId);

                entity.HasOne(e => e.FromVideogameCollection)
                .WithMany()
                .HasForeignKey(f => f.FromVideogameCollectionId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.CustomFolders)
                .WithMany(c => c.VideogamesUser)
                .UsingEntity(j => j.ToTable("CustomFolderVideogameUser"));
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.ReviewId);

                entity.HasOne(e => e.VideogameUser)
                .WithOne(vu => vu.Review)
                .HasForeignKey<Review>(f => f.VideogameUserId);
            });

            //AGGIUNGERE TUTTE LE CLASSI CON HASKEY E ISREQUIRED
            modelBuilder.Entity<GamingPlatform>(entity =>
            {
                entity.HasKey(e => e.ConsoleId);
                entity.HasOne(e => e.Publisher)
                .WithMany(p => p.GamingConsolesList);
            });
        }
    }
}
