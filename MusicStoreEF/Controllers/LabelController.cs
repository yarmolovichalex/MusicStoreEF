using MusicStoreEF.Repositories;
using MusicStoreEF.ViewModels;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class LabelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LabelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(int id)
        {
            var label = _unitOfWork.Labels.GetById(id);
            if (label == null)
                return HttpNotFound();

            var viewModel = new LabelDetailsVm
            {
                Id = label.Id,
                Name = label.Name,
                CoverUrl = label.CoverUrl,
                Releases = label.Releases.ToReleaseVms()
            };

            return View(viewModel);
        }
    }
}