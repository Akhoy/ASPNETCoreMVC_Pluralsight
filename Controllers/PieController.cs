using MVCAppModels;
using Microsoft.AspNetCore.Mvc;

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
            ViewBag.CurrentCategory="Cheese Cake";
            return View(_pieRepository.AllPies);
        }

    }
}
