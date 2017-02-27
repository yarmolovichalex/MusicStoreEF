using MusicStoreEF.Repositories;
using MusicStoreEF.ViewModels;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class GenreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PartialViewResult GetGenres()
        {
            var model = _unitOfWork.Genres.GetAll();
            return PartialView("_Genres", model);
        }

        public ActionResult Index(byte genreId)
        {
            var genre = _unitOfWork.Genres.GetById(genreId);
            var releases = _unitOfWork.Releases.GetByGenre(genreId);

            var model = new GenreVm
            {
                Genre = genre.Name,
                Releases = releases.ToReleaseVms()
            };

            return View(model);
        }
    }
}