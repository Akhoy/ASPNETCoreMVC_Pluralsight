using MVCAppModels;
using Microsoft.AspNetCore.Mvc;
using MVCAppViewModels;

namespace MVCAppControllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        // GET: PieController
        public ActionResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes");
            return View(pieListViewModel);
        }

    }
}
