using MusicStoreEF.Repositories;
using MusicStoreEF.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class ReleaseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReleaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var latestReleases = _unitOfWork.Releases.GetLatestReleases();

            var viewModel = latestReleases.Select(r => r.ToReleaseVm());

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var release = _unitOfWork.Releases.GetById(id);

            var viewModel = new ReleaseDetailsVm
            {
                Name = release.Name,
                Artists = release.Artists.ToArtistVms().ToList(),
                CoverUrl = release.CoverUrl,
                Label = release.Label,
                ReleaseDate = release.ReleaseDate,
                Tracks = release.Tracks.ToTrackVms()
            };

            return View(viewModel);
        }
    }
}