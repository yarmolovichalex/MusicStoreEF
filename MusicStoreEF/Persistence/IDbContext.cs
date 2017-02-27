using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Persistence
{
    public interface IDbContext
    {
        DbSet<Artist> Artists { get; set; }
        DbSet<Release> Releases { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<Label> Labels { get; set; }
        DbSet<Genre> Genres { get; set; }
        IDbSet<ApplicationUser> Users { get; set; }
        IDbSet<IdentityRole> Roles { get; set; }
        int SaveChanges();
    }
}