//ViewModel should contain the list of pies and the string category

using MVCAppModels;

namespace MVCAppViewModels;
public class PieListViewModel
{
    private readonly IEnumerable<Pie> _pies;
    private readonly string _currentCategory;

    //create list of pies property
    public IEnumerable<Pie> Pies => _pies;
    public string CurrentCategory => _currentCategory;
    public PieListViewModel(IEnumerable<Pie> pies, string currentCategory)
    {
        _pies = pies;
        _currentCategory = currentCategory;
    }
}