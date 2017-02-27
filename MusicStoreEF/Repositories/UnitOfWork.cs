using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _context;

        public IArtistRepository Artists { get; }
        public IReleaseRepository Releases { get; }
        public IGenreRepository Genres { get; }
        public ILabelRepository Labels { get; }
        public ITrackRepository Tracks { get; }

        public UnitOfWork(
            IDbContext context,
            IArtistRepository artists,
            IReleaseRepository releases,
            IGenreRepository genres,
            ILabelRepository labels,
            ITrackRepository tracks)
        {
            _context = context;
            Artists = artists;
            Releases = releases;
            Genres = genres;
            Labels = labels;
            Tracks = tracks;
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}