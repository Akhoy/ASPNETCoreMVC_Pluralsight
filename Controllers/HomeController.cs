using Microsoft.AspNetCore.Mvc;
using MVCAppModels;
using MVCAppViewModels;

namespace MVCAppControllers;
public class HomeController:Controller
{
    // bring in the db repository
    private readonly IPieRepository _pieRepository;
    public HomeController(IPieRepository pieRepository)
    {
        _pieRepository = pieRepository;
    }

    public IActionResult Index()
    {
        IEnumerable<Pie> piesOfTheWeek = _pieRepository.PiesOfTheWeek;
        HomeViewModel hvm = new HomeViewModel(piesOfTheWeek);
        return View(hvm);
    }
}