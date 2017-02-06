using MusicStoreEF.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class ArtistController : Controller
    {
        private readonly MusicStoreDbContext _context;

        public ArtistController()
        {
            _context = new MusicStoreDbContext();
        }

        public ActionResult Index(int id)
        {
            var artist = _context.Artists
                .Include(a => a.Releases.Select(r => r.Genre))
                .SingleOrDefault(a => a.Id == id);

            if (artist == null)
                return HttpNotFound();
            
            return View(artist);
        }
    }
}