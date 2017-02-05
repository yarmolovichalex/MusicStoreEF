﻿using MusicStoreEF.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class TrackController : Controller
    {
        private readonly MusicStoreDbContext _context;

        public TrackController()
        {
            _context = new MusicStoreDbContext();
        }

        public ActionResult Index()
        {
            var tracks = _context.Tracks
                .Include(t => t.Release.Artists)
                .Include(t => t.Release.Label)
                .Include(t => t.Genre)
                .ToList();

            return View(tracks);
        }
    }
}