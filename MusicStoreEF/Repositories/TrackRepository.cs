using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        private readonly IDbContext _context;

        public TrackRepository(IDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Track> GetAll()
        {
            return _context.Tracks
                .Include(t => t.Release.Artists)
                .Include(t => t.Release.Label)
                .Include(t => t.Genre)
                .ToList();
        }
    }
}