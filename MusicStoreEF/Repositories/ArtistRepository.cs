using MusicStoreEF.Models;
using System.Data.Entity;
using System.Linq;

namespace MusicStoreEF.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly IDbContext _context;

        public ArtistRepository(IDbContext context)
        {
            _context = context;
        }

        public Artist GetArtistWithReleases(int id)
        {
            return _context.Artists
                .Include(a => a.Releases.Select(r => r.Genre))
                .SingleOrDefault(a => a.Id == id);
        }
    }
}