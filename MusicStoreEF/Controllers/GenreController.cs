using MusicStoreEF.Models;
using MusicStoreEF.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class GenreController : Controller
    {
        private readonly IDbContext _context;

        public GenreController(IDbContext context)
        {
            _context = context;
        }

        public PartialViewResult GetGenres()
        {
            var model = _context.Genres.ToList();
            return PartialView("_Genres", model);
        }

        public ActionResult Index(byte genreId)
        {
            var genre = _context.Genres.Single(g => g.Id == genreId);
            var releases = _context.Releases
                .Include(r => r.Artists)
                .Where(r => r.GenreId == genreId)
                .ToList();

            var model = new GenreViewModel
            {
                Genre = genre.Name,
                Releases = releases
            };

            return View(model);
        }
    }
}