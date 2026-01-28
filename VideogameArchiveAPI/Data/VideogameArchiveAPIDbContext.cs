using Microsoft.EntityFrameworkCore;
using VideogameArchiveAPI.Models;
using VideogameArchiveAPI.Models.CompanyModels;
using VideogameArchiveAPI.Models.VideogameModels;
using Microsoft.Extensions.Configuration;
namespace VideogameArchiveAPI.Data
{
    public class VideogameArchiveAPIDbContext : DbContext
    {
        public VideogameArchiveAPIDbContext(DbContextOptions<VideogameArchiveAPIDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<GameMode> GameModes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<VideogameUser> VideogameUsers { get; set; }
        public DbSet<VideogameCopy> VideogameCopies { get; set; }
        public DbSet<CustomFolder> CustomFolders { get; set; }
        public DbSet<GamingPlatform> GamingPlatforms { get; set; }
        public DbSet<RealOwner> RealOwners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SubscriptionService> SubscriptionServices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.UseTpcMappingStrategy();

                entity.Ignore(e => e.GameList);
            });

            modelBuilder.Entity<Videogame>(entity =>
            {
                entity.HasKey(e => e.GameId);
                
                entity.HasIndex(e => e.GameName);

                entity.Property(e => e.GameName).IsRequired().HasMaxLength(500);

                entity.Property(e => e.MinPlayers).IsRequired();

                entity.Property(e => e.MaxPlayers).IsRequired();

                entity.Property(e => e.ReleaseDate).IsRequired();

                entity.HasMany(e => e.DLCs)
                .WithOne(d => d.DLCOfWhatGame)
                .HasForeignKey(d => d.DLCOfWhatGameId)
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(e => e.CollectionOfWhatGames)
                .WithOne(g => g.FromVideogameCollection)
                .HasForeignKey(g => g.FromVideogameCollectionId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.GamingPlatforms)
                .WithMany(e => e.VideogameList)
                .UsingEntity(j => j.ToTable("Videogames_GamingPlatforms"));

                entity.HasMany(e => e.SubscriptionServices)
                .WithMany(s => s.Videogames)
                .UsingEntity(j => j.ToTable("SubscriptionServices_Videogames"));
                
                entity.HasMany(e => e.Developers)
                .WithMany(d => d.GameList)
                .UsingEntity(j => j.ToTable("Videogames_Developers"));

                entity.HasMany(e => e.Publishers)
                .WithMany(p => p.GameList)
                .UsingEntity(j => j.ToTable("Videogames_Publishers"));

                entity.HasMany(e => e.Genres)
                .WithMany(g => g.VideogameList)
                .UsingEntity(j => j.ToTable("Videogames_Genres"));

                entity.HasMany(e => e.Tags)
                .WithMany(t => t.VideogameList)
                .UsingEntity(j => j.ToTable("Videogames_Tags"));

                entity.HasMany(e => e.GameModes)
                .WithMany(m => m.VideogameList)
                .UsingEntity(j => j.ToTable("Videogames_GameModes"));

            });

            modelBuilder.Entity<VideogameUser>(entity =>
            {
                entity.HasKey(e => e.VideogameUserId);

                entity.HasIndex(e => new { e.UserId, e.VideogameId }).IsUnique();

                entity.HasOne(e => e.Videogame)
                .WithMany(v => v.VideogameUsers)
                .HasForeignKey(e => e.VideogameId)
                .IsRequired();

                entity.HasOne(e => e.User)
                .WithMany(u => u.VideogamesUser)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

                entity.HasOne(e => e.Review)
                .WithOne(e => e.VideogameUser)
                .HasForeignKey<Review>(r => r.VideogameUserId)
                .IsRequired();

                entity.HasMany(e => e.VideogameCopies)
                .WithOne()
                .HasForeignKey(e => e.VideogameUserId)
                .IsRequired();
            });

            modelBuilder.Entity<VideogameCopy>(entity =>
            {
                entity.HasKey(e => e.VideogameCopyId);

                entity.Property(e => e.GameOwnership).IsRequired();
                entity.Property(e => e.GameStatus).IsRequired();
                entity.Property(e => e.GameFormat).IsRequired();

                entity.HasOne(e => e.FromVideogameCollection)
                .WithMany()
                .HasForeignKey(f => f.FromVideogameCollectionId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.RealOwners)
                .WithMany(o => o.VideogameCopies)
                .UsingEntity(j => j.ToTable("VideogameCopy_RealOwner"));

                entity.HasOne(e => e.SubscriptionService)
                .WithMany();
            });

            modelBuilder.Entity<CustomFolder>(entity =>
            {
                entity.HasKey(e => e.FolderId);

                entity.HasIndex(e => e.FolderName);

                entity.Property(e => e.FolderName).IsRequired();

                entity.HasMany(e => e.VideogamesUser)
                .WithMany(vu => vu.CustomFolders)
                .UsingEntity(j => j.ToTable("CustomFolders_VideogameUsers"));

                entity.HasMany(e => e.VideogameCopies)
                .WithMany(vc => vc.CustomFolders)
                .UsingEntity(j => j.ToTable("CustomFolders_VideogameCopies"));
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
                
                entity.Property(e => e.UserId).ValueGeneratedNever();
                
                entity.Property(e => e.UserName).IsRequired();

                entity.HasMany(e => e.RealOwners)
                .WithOne()
                .HasForeignKey(o => o.UserId);
            });
            
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.ReviewId);
            });

            //AGGIUNGERE TUTTE LE CLASSI CON HASKEY E ISREQUIRED
            modelBuilder.Entity<GamingPlatform>(entity =>
            {
                entity.HasKey(e => e.ConsoleId);

                entity.HasOne(e => e.Publisher)
                .WithMany(p => p.GamingConsolesList)
                .HasForeignKey(e => e.PublisherId);
            });

            modelBuilder.Entity<CustomFolder>(entity =>
            {
                entity.HasKey(e => e.FolderId);
                entity.Property(e => e.FolderName).IsRequired();
            });

            modelBuilder.Entity<GameMode>(entity =>
            {
                entity.HasKey(e => e.GameModeId);
                entity.Property(e => e.GameModeName).IsRequired();
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreId);
                entity.Property(e => e.GenreName).IsRequired();
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.TagId);
                entity.Property(e => e.TagName).IsRequired();
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.CompanyId);
                entity.Property(e => e.CompanyName).IsRequired();
            });

            modelBuilder.Entity<Developer>(entity =>
            {
                entity.HasKey(e => e.CompanyId);
                entity.Property(e => e.CompanyName).IsRequired();
            });

            modelBuilder.Entity<SubscriptionService>(entity =>
            {
                entity.HasKey(e => e.SubscriptionServiceId);
                entity.Property(e => e.SubscriptionServiceName).IsRequired();
            });

            modelBuilder.Entity<RealOwner>(entity =>
            {
                entity.HasKey(e => e.RealOwnerId);
                entity.Property(e => e.RealOwnerName).IsRequired();
            });
        }
    }
}
