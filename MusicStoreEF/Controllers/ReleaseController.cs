using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStoreEF.Models;

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
                .Include(x => x.Artists)
                .OrderByDescending(x => x.ReleaseDate)
                .Take(10)
                .ToList();

            return View(latestReleases);
        }

        public ActionResult Details(int id)
        {
            var release = _context.Releases
                .Include(x => x.Artists)
                .Include(x => x.Tracks)
                .Include(x => x.Label)
                .Single(x => x.Id == id);

            return View(release);
        }
    }
}