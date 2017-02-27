using MusicStoreEF.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MusicStoreEF.Repositories
{
    public class ReleaseRepository : IReleaseRepository
    {
        private const int LatestReleasesCount = 10;

        private readonly IDbContext _context;

        public ReleaseRepository(IDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Release> GetLatestReleases()
        {
            return _context.Releases
                .Include(r => r.Artists)
                .Include(r => r.Genre)
                .OrderByDescending(r => r.ReleaseDate)
                .Take(LatestReleasesCount)
                .ToList();
        }

        public Release GetById(int id)
        {
            return _context.Releases
                .Include(r => r.Artists)
                .Include(r => r.Tracks.Select(t => t.Genre))
                .Include(r => r.Label)
                .Include(r => r.Genre)
                .Single(r => r.Id == id);
        }

        public IEnumerable<Release> GetByGenre(byte genreId)
        {
            return _context.Releases
                .Include(r => r.Artists)
                .Where(r => r.GenreId == genreId)
                .ToList();
        }

        public void Add(IEnumerable<Release> releases)
        {
            _context.Releases.AddRange(releases);
        }

        public void RemoveAll()
        {
            _context.Releases.RemoveRange(_context.Releases);
        }
    }
}