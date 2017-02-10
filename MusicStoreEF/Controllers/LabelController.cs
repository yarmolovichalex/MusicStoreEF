using MusicStoreEF.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class LabelController : Controller
    {
        private readonly MusicStoreDbContext _context;

        public LabelController()
        {
            _context = new MusicStoreDbContext();
        }

        public ActionResult Index(int id)
        {
            var label = _context.Labels
                .Include(l => l.Releases.Select(r => r.Artists))
                .Include(l => l.Releases.Select(r => r.Genre))
                .SingleOrDefault(l => l.Id == id);
            if (label == null)
                return HttpNotFound();

            return View(label);
        }
    }
}