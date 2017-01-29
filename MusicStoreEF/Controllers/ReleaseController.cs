using MusicStoreEF.Models;
using MusicStoreEF.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class ReleaseController : Controller
    {
        private readonly MusicStoreDbContext _context;

        public ReleaseController()
        {
            _context = new MusicStoreDbContext();
        }

        public ActionResult Index()
        {
            var latestReleases = _context.Releases
                .Include(r => r.Artists)
                .Include(r => r.Genre)
                .OrderByDescending(r => r.ReleaseDate)
                .Take(10)
                .ToList();

            var viewModel = latestReleases.Select(r => new ReleaseViewModel
            {
                Id = r.Id,
                Name = r.Name,
                Artists = string.Join(", ", r.Artists.Select(a => a.Name).OrderBy(a => a)),
                ReleaseDate = r.ReleaseDate,
                Genre = r.Genre.Name,
                CoverUrl = r.CoverUrl
            });

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var release = _context.Releases
                .Include(r => r.Artists)
                .Include(r => r.Tracks.Select(t => t.Genre))
                .Include(r => r.Label)
                .Include(r => r.Genre)
                .Single(r => r.Id == id);

            var viewModel = new ReleaseDetailsViewModel
            {
                Name = release.Name,
                Artists = string.Join(", ", release.Artists.Select(a => a.Name).OrderBy(a => a)),
                CoverUrl = release.CoverUrl,
                Label = release.Label.Name,
                ReleaseDate = release.ReleaseDate,
                Tracks = release.Tracks.Select(t => new TrackViewModel
                {
                    Number = t.Number,
                    Name = t.Name,
                    Genre = t.Genre.Name,
                    BPM = t.BPM,
                    Key = t.Key,
                    Length = t.Length
                })
            };

            return View(viewModel);
        }
    }
}