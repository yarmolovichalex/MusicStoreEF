using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Persistence
{
    public class DbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static DbContext Create()
        {
            return new DbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Releases)
                .WithMany(e => e.Artists)
                .Map(m =>
                {
                    m.MapLeftKey("ArtistId");
                    m.MapRightKey("ReleaseId");
                });

            modelBuilder.Entity<Artist>()
                .Property(e => e.Name).IsRequired().HasMaxLength(500);

            modelBuilder.Entity<Artist>()
                .Property(e => e.PhotoUrl).HasMaxLength(2000);

            modelBuilder.Entity<Artist>()
                .Property(e => e.Description).HasMaxLength(2000);

            modelBuilder.Entity<Release>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Release>()
                .Property(e => e.GenreId).IsRequired();

            modelBuilder.Entity<Label>()
                .HasMany(e => e.Releases)
                .WithRequired(e => e.Label);

            modelBuilder.Entity<Label>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Track>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Track>()
                .Property(e => e.GenreId).IsRequired();

            modelBuilder.Entity<Track>()
                .Property(t => t.AudioUrl).HasMaxLength(2000);

            modelBuilder.Entity<Genre>()
                .Property(g => g.Name).IsRequired();

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Tracks)
                .WithRequired(t => t.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Releases)
                .WithRequired(t => t.Genre)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}