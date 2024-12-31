using MVCAppModels;

namespace MVCAppViewModels;
public class HomeViewModel
{
    public IEnumerable<Pie> PiesOfTheWeek;
    public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
    {
        PiesOfTheWeek = piesOfTheWeek;
    }
}