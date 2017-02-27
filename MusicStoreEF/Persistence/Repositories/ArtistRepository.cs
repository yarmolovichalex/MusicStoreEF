using System.Data.Entity;
using System.Linq;
using MusicStoreEF.Core.Models;
using MusicStoreEF.Core.Repositories;

namespace MusicStoreEF.Persistence.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly IDbContext _context;

        public ArtistRepository(IDbContext context)
        {
            _context = context;
        }

        public Artist GetById(int id)
        {
            return _context.Artists
                .Include(a => Enumerable.Select<Release, Genre>(a.Releases, r => r.Genre))
                .SingleOrDefault(a => a.Id == id);
        }

        public void RemoveAll()
        {
            _context.Artists.RemoveRange(_context.Artists);
        }
    }
}