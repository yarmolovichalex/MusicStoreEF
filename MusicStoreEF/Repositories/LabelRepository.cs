using MusicStoreEF.Models;
using System.Data.Entity;
using System.Linq;

namespace MusicStoreEF.Repositories
{
    public class LabelRepository : ILabelRepository
    {
        private readonly IDbContext _context;

        public LabelRepository(IDbContext context)
        {
            _context = context;
        }

        public Label GetById(int labelId)
        {
            return _context.Labels
                .Include(l => l.Releases.Select(r => r.Artists))
                .Include(l => l.Releases.Select(r => r.Genre))
                .SingleOrDefault(l => l.Id == labelId);
        }

        public void RemoveAll()
        {
            _context.Labels.RemoveRange(_context.Labels);
        }
    }
}