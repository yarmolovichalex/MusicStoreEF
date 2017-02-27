using MusicStoreEF.Repositories;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistController(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public ActionResult Index(int id)
        {
            var artist = _artistRepository.GetArtistWithReleases(id);

            if (artist == null)
                return HttpNotFound();
            
            return View(artist);
        }
    }
}