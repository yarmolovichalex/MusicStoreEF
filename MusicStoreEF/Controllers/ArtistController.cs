using MusicStoreEF.Repositories;
using MusicStoreEF.ViewModels;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArtistController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(int id)
        {
            var artist = _unitOfWork.Artists.GetById(id);

            if (artist == null)
                return HttpNotFound();

            var viewModel = new ArtistDetailsVm
            {
                Id = artist.Id,
                Name = artist.Name,
                PhotoUrl = artist.PhotoUrl,
                Description = artist.Description,
                Releases = artist.Releases.ToReleaseVms()
            };

            return View(viewModel);
        }
    }
}