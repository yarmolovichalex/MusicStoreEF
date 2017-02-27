using MusicStoreEF.Repositories;
using MusicStoreEF.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class TrackController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrackController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var tracks = _unitOfWork.Tracks.GetAll();

            var viewModel = tracks.Select(t => new TrackDetailsVm
            {
                Name = t.Name,
                ReleaseId = t.ReleaseId,
                ReleaseDate = t.Release.ReleaseDate,
                ReleaseCoverUrl = t.Release.CoverUrl,
                Artists = t.Release.Artists.ToArtistVms().ToList(),
                Label = new LabelVm
                {
                    Id = t.Release.Label.Id,
                    Name = t.Release.Label.Name
                },
                Genre = t.Genre.Name,
                Key = t.Key,
                Price = t.Price
            });

            return View(viewModel);
        }
    }
}