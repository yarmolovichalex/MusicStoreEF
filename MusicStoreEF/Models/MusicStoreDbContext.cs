using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MusicStoreEF.Models
{
    public class MusicStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Label> Labels { get; set; }

        public MusicStoreDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MusicStoreDbContext Create()
        {
            return new MusicStoreDbContext();
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
                .Property(e => e.Genre).IsRequired();

            modelBuilder.Entity<Label>()
                .HasMany(e => e.Releases)
                .WithRequired(e => e.Label);

            modelBuilder.Entity<Label>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Track>()
                .Property(e => e.Name).IsRequired();

            modelBuilder.Entity<Track>()
                .Property(e => e.Genre).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}